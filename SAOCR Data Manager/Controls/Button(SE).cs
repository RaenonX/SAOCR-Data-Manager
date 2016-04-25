using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Properties;

namespace SAOCR_Data_Manager
{
    public partial class Button_SE_ : UserControl
    {
        UserConfig config = new UserConfig();
        
        public event EventHandler ButtonClick;

        public Button_SE_()
        {
            InitializeComponent();

            SizeChanged += Reset;
            Paint += Reset;

            Button.MouseClick += Button_Click;
        }

        private void Reset(object sender, EventArgs e)
        {
            Point NewLoc = new Point(- 1, - 1);
            Button.Location = NewLoc;
            Size NewSize = new Size(Size.Width + 2, Size.Height + 2);
            Button.Size = NewSize;
        }
        
        public void Button_Click(object sender, MouseEventArgs e)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
            SystemAPI.SEBeep();
        }

        [Bindable(true), Category("Special Options"),
           Description("按鈕上的文字。")]
        public string ButtonText
        {
            get { return Button.Text; }
            set { Button.Text = value; }
        }

        [Bindable(true), Category("Special Options"),
          Description("按鈕上的圖片。")]
        public Image ButtonBackgroundImage
        {
            get { return Button.BackgroundImage; }
            set { Button.BackgroundImage = value; }
        }

        [Bindable(true), Category("Special Options"),
          Description("按鈕上的圖片顯示方式。")]
        public ImageLayout ButtonBackgroundImageLayout
        {
            get { return Button.BackgroundImageLayout; }
            set { Button.BackgroundImageLayout = value; }
        }

        [Bindable(true), Category("Special Options"),
          Description("按鈕的背景顏色。")]
        public Color ButtonBackColor
        {
            get { return Button.BackColor; }
            set { Button.BackColor = value; }
        }

        [Bindable(true), Category("Special Options"),
          Description("按鈕上的圖片顯示方式。")]
        public ContentAlignment ButtonImageAlign
        {
            get { return Button.ImageAlign; }
            set { Button.ImageAlign = value; }
        }

        [Bindable(true), Category("Special Options"),
          Description("按鈕上的圖片顯示方式。")]
        public Image ButtonImage
        {
            get { return Button.Image; }
            set { Button.Image = value; }
        }

        [Bindable(true), Category("Special Options"),
           Description("按鈕上的文字的顏色。")]
        public Color ButtonColor
        {
            get { return Button.ForeColor; }
            set { Button.ForeColor = value; }
        }

        [Bindable(true), Category("Special Options"),
          Description("按鈕是否啟用。")]
        public bool ButtonEnabled
        {
            get { return Button.Enabled; }
            set { Button.Enabled = value; }
        }

        public Button Btn
        {
            get { return Button; }
        }
    }
}
