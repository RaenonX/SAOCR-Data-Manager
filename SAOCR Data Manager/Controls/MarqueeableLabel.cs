using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SAOCR_Data_Manager
{
    public struct TimerObject
    {
        public int Count;
        public int FreezeCount;
        public int Interval;
        public bool Gate;
        public bool Freezing;
    }

    public partial class MarqueeableLabel : UserControl
    {
        private int PosDiff = 1, OverborderDistance = 15, Leftdistance = 5;
        TimerObject TimerO = new TimerObject();

        private MarqueeDirection MQD = MarqueeDirection.Horizontal;
        private MarqueeMode MQM = MarqueeMode.ContinualAndSneeze;

        bool MarqueeEnabled = true;
        
        Point TextLabelOriginalPosition;
        Size ControlSize;

        public event EventHandler ArriveToBorder;

        public MarqueeableLabel()
        {
            InitializeComponent();
            SizeChanged += MarqueeableLabel_SizeChanged;
            TextLabel.SizeChanged += MarqueeableLabel_SizeChanged;
            Border.Paint += SystemAPI.DrawBorderWhite;
            FMain.MarqueeLabel.Tick += new EventHandler(TimerTicked);

            ControlSize = Size;
        }

        private void MarqueeableLabel_SizeChanged(object sender, EventArgs e)
        {
            TextLabel.Top = (Size.Height - TextLabel.Height) / 2;
            Border.Size = Size;
        }

        [Bindable(true), Category("Marquee Options"),
           Description("是否啟用跑馬燈功能。")]
        public bool EnableMarquee
        {
            get { return MarqueeEnabled; }

            set { MarqueeEnabled = value; }
        }

        [Bindable(true), Category("Layout Options"),
           Description("跑馬燈要顯示的文字。")]
        public string MarqueeText
        {
            get { return TextLabel.Text; }

            set {
                if (TextLabel.Text != value)
                {
                    TextLabel.Text = value;
                    TextLabel.Invalidate();
                }
            }
        }

        [Bindable(true), Category("Layout Options"),
            Description("跑馬燈整體的大小。如果文字超過外框，則外框會自動變成和文字一樣大。")]
        public Size LabelSize
        {
            get { return Size; }

            set
            {
                if (Size != value)
                {
                    Size = value;
                    Border.Size = value;
                    if (TextLabel.Size.Height > Size.Height)
                    {
                        Size NewSize = new Size(TextLabel.Height, Size.Width);
                        Size = NewSize;
                    }
                }
            }
        }

        [Bindable(true), Category("Marquee Options"),
            Description("跑馬燈在移動文字時，座標的變換頻率。單位是毫秒。計時器一個單位是10ms，所以使用時如果是15ms會自動被無條件捨去成1。")]
        public int MoveInterval
        {
            get
            {
                return TimerO.Interval;
            }
            set
            {
                TimerO.Interval = value;
            }
        }

        [Bindable(true), Category("Marquee Options"),
            Description("跑馬燈於最原始狀態凍結的時間長度。單位是毫秒。")]
        public int FreezeTime
        {
            get
            {
                return TimerO.FreezeCount * FMain.MarqueeLabel.Interval;
            }
            set
            {
                TimerO.FreezeCount = value / FMain.MarqueeLabel.Interval;
            }
        }

        [Bindable(true), Category("Marquee Options"),
            Description("跑馬燈在移動文字時的座標變化量。")]
        public int MoveDifferenceEachTime
        {
            get { return PosDiff; }
            set { PosDiff = value; }
        }

        [Bindable(true), Category("Layout Options"),
            Description("跑馬燈的文字顏色。")]
        public Color LForeColor
        {
            get { return TextLabel.ForeColor; }
            set { TextLabel.ForeColor = value; }
        }

        [Bindable(true), Category("Marquee Options"),
           Description("跑馬燈的文字移動方向。")]
        public MarqueeDirection Direction
        {
            get { return MQD; }
            set { MQD = value; }
        }

        [Bindable(true), Category("Marquee Options"),
           Description("跑馬燈的文字框，最靠近控制項的界線的最大距離。到達該距離後將會重置。")]
        public int OverBorderDistance
        {
            get { return OverborderDistance; }
            set { OverborderDistance = value; }
        }

        [Bindable(true), Category("Marquee Options"),
           Description("文字標籤與控制項左方邊界的距離。")]
        public int LeftDistance
        {
            get { return Leftdistance; }
            set
            {
                Leftdistance = value;
                Point TextLabelPosition = new Point(Leftdistance, TextLabel.Location.Y);
                TextLabel.Location = TextLabelPosition;
            }
        }

        [Bindable(true), Category("Marquee Options"),
           Description("跑馬燈文字的運行模式。")]
        public MarqueeMode Mode
        {
            get { return MQM; }
            set { MQM = value; }
        }

        /// <summary>
        /// 呼叫此方法將會啟用跑馬燈的跑馬功能。
        /// </summary>
        public void Marquee()
        {
            TextLabelOriginalPosition = TextLabel.Location;
            TextLabel.Top = (Size.Height - TextLabel.Height) / 2;
            TimerO.Gate = true;
            TimerO.Freezing = true;

            if (FreezeTime == 0)
            {
                FreezeTime = Const.Default.MARQUEE_FREEZE_TIME;
            }
            if (MoveInterval == 0)
            {
                MoveInterval = Const.Default.MARQUEE_MOVE_INTERVAL;
            }
        }

        public void Restart()
        {
            TextLabel.Location = TextLabelOriginalPosition;
            Marquee();
        }

        public void TimerTicked(object sender, EventArgs e)
        {
            if (TimerO.Gate)
            {
                TimerO.Count++;
            }

            if ((TimerO.Count % (TimerO.Interval / FMain.MarqueeLabel.Interval) == 0) && TimerO.Gate && !TimerO.Freezing)
            {
                #region
                Point Pos = TextLabel.Location;
                if (Direction == MarqueeDirection.Horizontal)
                {
                    Pos.X -= PosDiff;
                    TextLabel.Location = Pos;
                    if (-(TextLabel.Location.X + TextLabel.Size.Width) > OverBorderDistance
                        || TextLabel.Location.X == TextLabelOriginalPosition.X)
                    {
                        switch (MQM)
                        {
                            case MarqueeMode.Continual:
                                if (-(TextLabel.Location.X + TextLabel.Size.Width) > OverBorderDistance)
                                {
                                    ArriveToBorder?.Invoke(this, EventArgs.Empty);
                                    Continual();
                                }
                                break;
                            case MarqueeMode.ContinualAndSneeze:
                                if (-(TextLabel.Location.X + TextLabel.Size.Width) > OverBorderDistance)
                                {
                                    ArriveToBorder?.Invoke(this, EventArgs.Empty);
                                    Continual();
                                }
                                else if (TextLabel.Location.X == TextLabelOriginalPosition.X)
                                {
                                    ResetAtOriginal();
                                }
                                break;
                            case MarqueeMode.ResetAtOriginal:
                                ArriveToBorder?.Invoke(this, EventArgs.Empty);
                                ResetAtOriginal();
                                break;
                        }
                    }
                }
                else if (Direction == MarqueeDirection.Vertical)
                {
                    Pos.Y -= PosDiff;
                    TextLabel.Location = Pos;
                    if (-(TextLabel.Location.Y + TextLabel.Size.Height) > OverBorderDistance
                        || TextLabel.Location.Y == TextLabelOriginalPosition.Y)
                    {
                        switch (MQM)
                        {
                            case MarqueeMode.Continual:
                                if (-(TextLabel.Location.Y + TextLabel.Size.Height) > OverBorderDistance)
                                {
                                    ArriveToBorder?.Invoke(this, EventArgs.Empty);
                                    Continual();
                                }
                                break;
                            case MarqueeMode.ContinualAndSneeze:
                                if (-(TextLabel.Location.Y + TextLabel.Size.Height) > OverBorderDistance)
                                {
                                    ArriveToBorder?.Invoke(this, EventArgs.Empty);
                                    Continual();
                                }
                                else if (TextLabel.Location.Y == TextLabelOriginalPosition.Y)
                                {
                                    ResetAtOriginal();
                                }
                                break;
                            case MarqueeMode.ResetAtOriginal:
                                ArriveToBorder?.Invoke(this, EventArgs.Empty);
                                ResetAtOriginal();
                                break;
                        }
                    }
                }
                #endregion
            } else if (TimerO.Freezing)
            {
                if (((TimerO.Count % TimerO.FreezeCount == 0) && TimerO.Gate) || Extent.isEmptyString(MarqueeText))
                {
                    TimerO.Freezing = false;
                }
            }
        }

        public void ResetAtOriginal()
        {
            TextLabel.Location = TextLabelOriginalPosition;
            TextLabel.Top = (Size.Height - TextLabel.Height) / 2;
            TimerO.Freezing = true;
        }

        public void Continual()
        {
            Point NewLocation;
            if (Direction == MarqueeDirection.Horizontal)
            {
                NewLocation = new Point(TextLabelOriginalPosition.X + Size.Width,
                    TextLabelOriginalPosition.Y);
                TextLabel.Location = NewLocation;
            }
            else if (Direction == MarqueeDirection.Vertical)
            {
                NewLocation = new Point(TextLabelOriginalPosition.X,
                    TextLabelOriginalPosition.Y + Size.Height);
                TextLabel.Location = NewLocation;
            }
        }
    }
}
