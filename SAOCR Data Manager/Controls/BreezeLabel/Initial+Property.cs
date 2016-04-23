using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager.Controls
{
    public struct ColorConfig
    {
        public struct ColorDifference
        {
            public int R;
            public int G;
            public int B;
            public int A;
        }

        public Color Begin;
        public Color End;
        public bool To2ndColor;
        public ColorDifference Diff;
        public int CurColor;
        public int Changetime;
    }

    public struct ColorTimer
    {
        public struct TimerObject {
            public bool Enable;
            public int Interval;
        }

        public int Count;
        public bool Gate;
        public TimerObject A;
        public TimerObject R;
        public TimerObject G;
        public TimerObject B;
    }

    public partial class BreezeLabel : UserControl
    {
        ColorTimer CTimer = new ColorTimer();
        ColorConfig CConfig = new ColorConfig();

        public BreezeLabel()
        {
            try
            {
                InitializeComponent();
                SizeChanged += BreezeLabel_SizeChanged;
                
                CTimer.A.Interval = CTimer.R.Interval = CTimer.G.Interval = CTimer.B.Interval = 1000;

                FMain.BreezeLabel.Tick += new EventHandler(RefreshBackColor);
                FMain.BreezeLabel.Tick += ColorStatusRefresh;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001700E, e);
                throw;
            }
        }

        [Bindable(true), Category("顯示"), Description("標籤文字。")]
        public string LText
        {
            get
            {
                try
                {
                    return label.Text;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017001, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    label.Text = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017002, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("顯示"), Description("標籤字型。")]
        public Font LFont
        {
            get
            {
                try
                {
                    return label.Font;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017003, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    label.Font = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017004, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("顯示"), Description("標籤文字位置。")]
        public ContentAlignment LAlign
        {
            get
            {
                try
                {
                    return label.TextAlign;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017005, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    label.TextAlign = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017006, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("顯示"), Description("標籤文字顏色。")]
        public Color LForeColor
        {
            get
            {
                try
                {
                    return label.ForeColor;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017007, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    label.ForeColor = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017008, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("顯示"), Description("標籤框線樣式。")]
        public BorderStyle LBorderStyle
        {
            get
            {
                try
                {
                    return label.BorderStyle;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017009, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    label.BorderStyle = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0001700A, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("設定"), Description("標籤背景顏色。")]
        public Color LBackColor
        {
            get
            {
                try
                {
                    return label.BackColor;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017014, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    label.BackColor = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017015, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("設定"), Description("顏色變化週期(從第一顏色到第二顏色所需時間)，單位為毫秒(變化時實際上是以10ms為單位)。")]
        public int ChangeTime
        {
            get
            {
                try
                {
                    return CConfig.Changetime * FMain.BreezeLabel.Interval;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0001700B, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    CConfig.Changetime = value / FMain.BreezeLabel.Interval;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0001700C, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("設定"), Description("第一顏色。")]
        public Color ColorBegin
        {
            get
            {
                try
                {
                    return CConfig.Begin;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00017019, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    CConfig.Begin = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0001701A, e);
                    throw;
                }
            }
        }

        [Bindable(true), Category("設定"), Description("第二顏色。")]
        public Color ColorEnd
        {
            get
            {
                try
                {
                    return CConfig.End;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0001701B, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    CConfig.End = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0001701C, e);
                    throw;
                }
            }
        }
    }
}
