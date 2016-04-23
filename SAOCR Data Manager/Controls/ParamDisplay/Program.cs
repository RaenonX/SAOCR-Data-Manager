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
using SAOCR_Data_Manager.Resources.Controls;

namespace SAOCR_Data_Manager
{
    public partial class ParamDisplay : UserControl
    {
        private void ChooseCharacterStatus(object sender, EventArgs e)
        {
            try
            {
                Button_SE_ Btn = (Button_SE_)sender;

                ST_ALv1.ButtonColor = Color.White;
                ST_ALvM.ButtonColor = Color.White;
                ST_ULv1.ButtonColor = Color.White;
                ST_ULvM.ButtonColor = Color.White;
                Btn.ButtonColor = Color.Red;

                switch (Btn.Name)
                {
                    case "ST_ALv1":
                        PLv = EParamLv.Lv1;
                        PAk = EParamAwaked.Awaked;
                        break;
                    case "ST_ALvM":
                        PLv = EParamLv.LvMAX;
                        PAk = EParamAwaked.Awaked;
                        break;
                    case "ST_ULv1":
                        PLv = EParamLv.Lv1;
                        PAk = EParamAwaked.Unawaked;
                        break;
                    case "ST_ULvM":
                        PLv = EParamLv.LvMAX;
                        PAk = EParamAwaked.Unawaked;
                        break;
                    default:
                        PLv = EParamLv.Null;
                        PAk = EParamAwaked.Null;
                        break;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000A014, ex);
                throw;
            }
        }

        private void ReFreshData(CharaData PInfo)
        {
            try
            {
                SetCharacterParams(PInfo, PAk, PLv);
                SetGrowRate(PInfo, PAk);
                SetMainParam(PInfo);
                SetParamDeploy(PInfo);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A018, e);
                throw;
            }
        }

        private void ReArrange(object sender, EventArgs e)
        {
            try
            {
                int[] PTA = { Param1st, Param2nd, Param3rd, Param4th };
                Label[] LPTA = { TP_1st, TP_2nd, TP_3rd, TP_4th };

                for (int i = 0; i < PTA.Length; i++)
                {
                    switch ((EParamType)PTA[i])
                    {
                        case EParamType.Mebius:
                            LPTA[i].Text = RParamI.Layout_TypeAverage;
                            break;
                        case EParamType.Force:
                            LPTA[i].Text = RParamI.Layout_TypeAttack;
                            break;
                        case EParamType.Aegis:
                            LPTA[i].Text = RParamI.Layout_TypeDefense;
                            break;
                        case EParamType.Magius:
                            LPTA[i].Text = RParamI.Layout_TypeMagius;
                            break;
                        default:
                            SystemAPI.Error(RError.E_0x0000A016);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000A015, ex);
                throw;
            }
        }

        private void SetCharacterParams(CharaData Param, EParamAwaked EPA, EParamLv EPL)
        {
            try
            {
                Label[] P1stL = { PR_1stHP, PR_1stSTR, PR_1stVIT, PR_1stINT, PR_1stMEN };
                Label[] P2ndL = { PR_2ndHP, PR_2ndSTR, PR_2ndVIT, PR_2ndINT, PR_2ndMEN };
                Label[] P3rdL = { PR_3rdHP, PR_3rdSTR, PR_3rdVIT, PR_3rdINT, PR_3rdMEN };
                Label[] P4thL = { PR_4thHP, PR_4thSTR, PR_4thVIT, PR_4thINT, PR_4thMEN };
                Label[][] Params = { P1stL, P2ndL, P3rdL, P4thL };
                int[] PTA = { Param1st, Param2nd, Param3rd, Param4th };

                for (int i = 0; i < PTA.Length; i++)
                {
                    int[] PArray = new int[10];

                    switch (EPA)
                    {
                        case EParamAwaked.Unawaked:
                            PArray = Param.Parameters.Basic.Unawaked.GetArray((EParamType)PTA[i]);
                            break;
                        case EParamAwaked.Awaked:
                            PArray = Param.Parameters.Basic.Awaked.GetArray((EParamType)PTA[i]);
                            break;
                        default:
                            SystemAPI.Error(RError.E_0x0000A017);
                            break;
                    }

                    for (int j = (int)EPL; j < PArray.Length; j += 2)
                    {
                        Params[i][j / 2].Text = PArray[j].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A013, e);
                throw;
            }
        }

        private void SetGrowRate(CharaData Param, EParamAwaked EPA)
        {
            try
            {
                Label[] GrowRate = { GR_HP, GR_Param };
                double[] Data = Param.Parameters.Extra.GrowRate.GetArray(EPA);

                for (int i = 0; i < GrowRate.Length; i++)
                {
                    GrowRate[i].Text = Data[i].ToString("0.00");
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A019, e);
                throw;
            }
        }

        private void SetMainParam(CharaData Param)
        {
            try
            {
                PR_Main.Text = EnumTranslator.EParamCategoryT(Param.Parameters.Extra.MainParam);
                switch (Param.Parameters.Extra.MainParam)
                {
                    case EParamCategory.STR:
                        PR_Main.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                        break;
                    case EParamCategory.VIT:
                        PR_Main.BackColor = Color.FromArgb((int)EBackColorAlpha.LightBlue);
                        break;
                    case EParamCategory.INT:
                        PR_Main.BackColor = Color.FromArgb((int)EBackColorAlpha.Green);
                        break;
                    case EParamCategory.MEN:
                        PR_Main.BackColor = Color.FromArgb((int)EBackColorAlpha.Purple);
                        break;
                    default:
                        SystemAPI.Warning(RWarning.W_0xC000A006);
                        break;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A01A, e);
                throw;
            }
        }

        private void SetParamDeploy(CharaData Param)
        {
            try
            {
                Label[] Deploys = { DS_STR, DS_VIT, DS_INT, DS_MEN };
                int[] DeployP = Param.Parameters.Extra.Deploy.GetArray();

                for (int i = 0; i < Deploys.Length; i++)
                {
                    Deploys[i].Text = DeployP[i].ToString();
                    if (DeployP[i] == DeployP.Max())
                    {
                        Deploys[i].BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                    }
                    else
                    {
                        Deploys[i].BackColor = Color.FromArgb((int)EBackColorAlpha.Grey70);
                    }
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A01B, e);
                throw;
            }
        }
    }
}
