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
using System.Diagnostics;

namespace SAOCR_Data_Manager.Controls
{
    public partial class BreezeLabel : UserControl
    {
        private void AT_Tick()
        {
            try
            {
                if ((CConfig.Diff.A < 0) ^ (label.BackColor.A < CConfig.Begin.A))
                {
                    label.BackColor = CConfig.Begin;
                    SetTSC();
                }
                else if ((CConfig.Diff.A < 0) ^ (label.BackColor.A > CConfig.End.A))
                {
                    label.BackColor = CConfig.End;
                    SetTSC();
                }

                if (CConfig.Diff.A < 0 ^ !CConfig.To2ndColor)
                {
                    CConfig.CurColor -= (int)ColorCategory.A;
                }
                else
                {
                    CConfig.CurColor += (int)ColorCategory.A;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001701D, ex);
                throw;
            }
        }

        private void RT_Tick()
        {
            try
            {
                if ((CConfig.Diff.R < 0) ^ (label.BackColor.R < CConfig.Begin.R))
                {
                    label.BackColor = CConfig.Begin;
                    SetTSC();
                }
                else if ((CConfig.Diff.R < 0) ^ (label.BackColor.R > CConfig.End.R))
                {
                    label.BackColor = CConfig.End;
                    SetTSC();
                }

                if (CConfig.Diff.R < 0 ^ !CConfig.To2ndColor)
                {
                    CConfig.CurColor -= (int)ColorCategory.R;
                }
                else
                {
                    CConfig.CurColor += (int)ColorCategory.R;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00017011, ex);
                throw;
            }
        }

        private void GT_Tick()
        {
            try
            {
                if ((CConfig.Diff.G < 0) ^ (label.BackColor.G < CConfig.Begin.G))
                {
                    label.BackColor = CConfig.Begin;
                    SetTSC();
                }
                else if ((CConfig.Diff.G < 0) ^ (label.BackColor.G > CConfig.End.G))
                {
                    label.BackColor = CConfig.End;
                    SetTSC();
                }

                if (CConfig.Diff.G < 0 ^ !CConfig.To2ndColor)
                {
                    CConfig.CurColor -= (int)ColorCategory.G;
                }
                else
                {
                    CConfig.CurColor += (int)ColorCategory.G;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00017012, ex);
                throw;
            }
        }

        private void BT_Tick()
        {
            try
            {
                if ((CConfig.Diff.B < 0) ^ (label.BackColor.B < CConfig.Begin.B))
                {
                    label.BackColor = CConfig.Begin;
                    SetTSC();
                }
                else if ((CConfig.Diff.B < 0) ^ (label.BackColor.B > CConfig.End.B))
                {
                    label.BackColor = CConfig.End;
                    SetTSC();
                }

                if (CConfig.Diff.B < 0 ^ !CConfig.To2ndColor)
                {
                    CConfig.CurColor -= (int)ColorCategory.B;
                }
                else
                {
                    CConfig.CurColor += (int)ColorCategory.B;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00017013, ex);
                throw;
            }
        }

        private void SetTSC()
        {
            try
            {
                if (label.BackColor == CConfig.End)
                {
                    CConfig.To2ndColor = false;
                }
                else if (label.BackColor == CConfig.Begin)
                {
                    CConfig.To2ndColor = true;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00017017, ex);
                throw;
            }
        }

        private void ColorStatusRefresh(object sender, EventArgs e)
        {
            try
            {
                if (CTimer.Gate)
                {
                    CTimer.Count++;
                    if (CTimer.A.Interval != 0)
                    {
                        if (CTimer.Count % CTimer.A.Interval == 0 && CTimer.A.Enable)
                        {
                            AT_Tick();
                        }
                    }

                    if (CTimer.R.Interval != 0)
                    {
                        if (CTimer.Count % CTimer.R.Interval == 0 && CTimer.R.Enable)
                        {
                            RT_Tick();
                        }
                    }

                    if (CTimer.G.Interval != 0)
                    {
                        if (CTimer.Count % CTimer.G.Interval == 0 && CTimer.G.Enable)
                        {
                            GT_Tick();
                        }
                    }

                    if (CTimer.B.Interval != 0)
                    {
                        if (CTimer.Count % CTimer.B.Interval == 0 && CTimer.B.Enable)
                        {
                            BT_Tick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001701F, ex);
                throw;
            }
        }

        private void RefreshBackColor(object sender, EventArgs e)
        {
            try
            {
                if (CTimer.Gate)
                {
                    label.BackColor = Color.FromArgb(CConfig.CurColor);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00017021, ex);
                throw;
            }
        }

        private void BreezeLabel_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                label.Size = Size;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001700D, ex);
                throw;
            }
        }

        private void InitializeParameters()
        {
            try
            {
                if (CConfig.Changetime == 0)
                {
                    CConfig.Changetime = Const.Default.FREEZE_CHANGE_TIME;
                }

                CConfig.Diff.A = CConfig.End.A - CConfig.Begin.A;
                CConfig.Diff.R = CConfig.End.R - CConfig.Begin.R;
                CConfig.Diff.G = CConfig.End.G - CConfig.Begin.G;
                CConfig.Diff.B = CConfig.End.B - CConfig.Begin.B;

                if (CConfig.Diff.A == 0)
                {
                    CTimer.A.Enable = false;
                }
                else
                {
                    CTimer.A.Enable = true;
                    CTimer.A.Interval = Math.Abs(CConfig.Changetime / CConfig.Diff.A);
                    if (CTimer.A.Interval == 0)
                    {
                        CTimer.A.Interval = 1;
                    }
                }

                if (CConfig.Diff.R == 0)
                {
                    CTimer.R.Enable = false;
                }
                else
                {
                    CTimer.R.Enable = true;
                    CTimer.R.Interval = Math.Abs(CConfig.Changetime / CConfig.Diff.R);
                    if (CTimer.R.Interval == 0)
                    {
                        CTimer.R.Interval = 1;
                    }
                }

                if (CConfig.Diff.G == 0)
                {
                    CTimer.G.Enable = false;
                }
                else
                {
                    CTimer.G.Enable = true;
                    CTimer.G.Interval = Math.Abs(CConfig.Changetime / CConfig.Diff.G);
                    if (CTimer.G.Interval == 0)
                    {
                        CTimer.G.Interval = 1;
                    }
                }

                if (CConfig.Diff.B == 0)
                {
                    CTimer.B.Enable = false;
                }
                else
                {
                    CTimer.B.Enable = true;
                    CTimer.B.Interval = Math.Abs(CConfig.Changetime / CConfig.Diff.B);
                    if (CTimer.B.Interval == 0)
                    {
                        CTimer.B.Interval = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00017020, ex);
                throw;
            }
        }
    }
}
