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
using System.Diagnostics;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager
{
    public partial class BaDisplay : UserControl
    {
        private void SetSeriesLabelColor(object sender, EventArgs e)
        {
            try
            {
                Label LB = (Label)sender;

                if (!Extent.isEmptyString(LB.Text))
                {
                    BASeriesType BASeries = EnumTranslator.BASeriesTextT(LB.Text);

                    switch (BASeries)
                    {
                        case BASeriesType.Attack:
                            LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                            break;
                        case BASeriesType.Support:
                            LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Orange);
                            break;
                        case BASeriesType.Heal:
                            LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Green);
                            break;
                        case BASeriesType.Abnormal:
                            LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Blue);
                            break;
                    }
                } else
                {
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Grey70);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000E002, ex);
                throw;
            }
        }

        private void HealRateCheck(object sender, EventArgs e)
        {
            try
            {
                Label[] LB1 = { HealText1, Heal1, HealRate1 };
                Label[] LB2 = { HealText2, Heal2, HealRate2 };
                Label[] LB3 = { HealText3, Heal3, HealRate3 };

                Label LB = (Label)sender;

                switch (LB.Name)
                {
                    case "Heal1":
                        foreach (Label L in LB1)
                        {
                            if (LB.Text == "0" || Extent.isEmptyString(LB.Text))
                            {
                                L.Visible = false;
                            }
                            else
                            {
                                L.Visible = true;
                            }
                        }
                        break;
                    case "Heal2":
                        foreach (Label L in LB2)
                        {
                            if (LB.Text == "0" || Extent.isEmptyString(LB.Text))
                            {
                                L.Visible = false;
                            }
                            else
                            {
                                L.Visible = true;
                            }
                        }
                        break;
                    case "Heal3":
                        foreach (Label L in LB3)
                        {
                            if (LB.Text == "0" || Extent.isEmptyString(LB.Text))
                            {
                                L.Visible = false;
                            }
                            else
                            {
                                L.Visible = true;
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000E00A, ex);
                throw;
            }
        }

        private void PowerCheck(object sender, EventArgs e)
        {
            try
            {
                Label[] LB1 = { Power1, PowerText1 };
                Label[] LB2 = { Power2, PowerText2 };
                Label[] LB3 = { Power3, PowerText3 };

                Label LB = (Label)sender;

                switch (LB.Name)
                {
                    case "Power1":
                        foreach (Label L in LB1)
                        {
                            if (LB.Text == "0" || Extent.isEmptyString(LB.Text))
                            {
                                L.Visible = false;
                            }
                            else
                            {
                                L.Visible = true;
                            }
                        }
                        break;
                    case "Power2":
                        foreach (Label L in LB2)
                        {
                            if (LB.Text == "0" || Extent.isEmptyString(LB.Text))
                            {
                                L.Visible = false;
                            }
                            else
                            {
                                L.Visible = true;
                            }
                        }
                        break;
                    case "Power3":
                        foreach (Label L in LB3)
                        {
                            if (LB.Text == "0" || Extent.isEmptyString(LB.Text))
                            {
                                L.Visible = false;
                            }
                            else
                            {
                                L.Visible = true;
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000E00B, ex);
                throw;
            }
        }
    }
}
