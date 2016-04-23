using System;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Controls;
using Microsoft.VisualBasic.Devices;

namespace SAOCR_Data_Manager
{
    public partial class BaDisplay : UserControl
    {
        bool TextTranslate = true;
        Size ControlSize;

        public BaDisplay()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();

                ControlSize = Size;
                SizeChanged += Display_SizeChanged;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000E004, e);
                throw;
            }
        }

        private void Display_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                Size = ControlSize;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000E005, ex);
                throw;
            }
        }

        public void InitializeUIText()
        {
            try
            {
                //GroupBox
                GP_BA.Text = RBaDisplay.Layout_Title;

                //Label in BA
                ScoreText1.Text = ScoreText2.Text = ScoreText3.Text = RBaDisplay.Layout_ScoreText;
                Title1.Text = RBaDisplay.Layout_BA1;
                Title2.Text = RBaDisplay.Layout_BA2;
                Title3.Text = RBaDisplay.Layout_BA3;
                Series1stText1.Text = Series1stText2.Text = Series1stText3.Text = RBaDisplay.Layout_Series + RBaDisplay.Layout_SeriesAnd;
                Series2ndText1.Text = Series2ndText2.Text = Series2ndText3.Text = RBaDisplay.Layout_Series;

                //Extra Info
                PowerText1.Text = PowerText2.Text = PowerText3.Text = RBaDisplay.Layout_Power;
                HealRate1.Text = HealRate2.Text = HealRate3.Text = RBaDisplay.Layout_Rate;
                HealText1.Text = HealText2.Text = HealText3.Text = RBaDisplay.Layout_HealRate;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000E006, ex);
                throw;
            }
        }

        public void InitializeEventHandler()
        {
            try
            {
                Series1st1.TextChanged += SetSeriesLabelColor;
                Series2nd1.TextChanged += SetSeriesLabelColor;
                Series1st2.TextChanged += SetSeriesLabelColor;
                Series2nd2.TextChanged += SetSeriesLabelColor;
                Series1st3.TextChanged += SetSeriesLabelColor;
                Series2nd3.TextChanged += SetSeriesLabelColor;
                Heal1.TextChanged += HealRateCheck;
                Heal2.TextChanged += HealRateCheck;
                Heal3.TextChanged += HealRateCheck;
                Power1.TextChanged += PowerCheck;
                Power2.TextChanged += PowerCheck;
                Power3.TextChanged += PowerCheck;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000E007, e);
                throw;
            }
        }

        /// <summary>
        /// 文字是否轉換成中文。
        /// </summary>
        [Bindable(true), Category("Options"),
         Description("BA或LS文字經由字典轉譯成中文。")]
        public bool isTextTranslated
        {
            get
            {
                try
                {
                    return TextTranslate;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000E008, e);
                    throw;
                }
            }
            set
            {
                try
                {
                    TextTranslate = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000E009, e);
                    throw;
                }
            }
        }
    }
}
