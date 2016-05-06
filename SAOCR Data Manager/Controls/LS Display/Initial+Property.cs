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
using SAOCR_Data_Manager.Resources.Controls;

namespace SAOCR_Data_Manager
{
    public partial class LsDisplay : UserControl
    {
        bool marquee = true, LSDataImported;
        Size ControlSize;
        CharaData CDT;

        public LsDisplay()
        {
            InitializeComponent();
            InitializeUIText();
            InitializeControlAttribute();

            ControlSize = Size;
            SizeChanged += Display_SizeChanged;
            TargetText.Click += LSRegister;
            EffectText.Click += LSRegister;
        }
        
        private void Display_SizeChanged(object sender, EventArgs e)
        {
            Size = ControlSize;
        }

        public void InitializeUIText()
        {
            //Label in LS
            EffectText.Text = RLsDisplay.Layout_Effect;
            TargetText.Text = RLsDisplay.Layout_Target;
            EffectScoreText.Text = RLsDisplay.Layout_ScoreText;
            TargetScoreText.Text = RLsDisplay.Layout_ScoreText;

            GP_LS.Text = RLsDisplay.Layout_Title;
        }


        public void InitializeControlAttribute()
        {
            if (marquee)
            {
                Effect.Marquee();
                Target.Marquee();
            }
        }

        /// <summary>
        /// 是否啟用跑馬燈功能。
        /// </summary>
        [Bindable(true), Category("Options"),
         Description("是否啟用跑馬燈功能。")]
        public bool Marquee
        {
            get { return marquee; }
            set { marquee = value; }
        }
    }
}
