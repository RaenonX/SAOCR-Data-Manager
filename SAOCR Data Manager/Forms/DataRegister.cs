using Microsoft.VisualBasic.Devices;
using SAOCR_Data_Manager.APIs;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager.Forms
{
    public partial class DataRegister : Form
    {
        WindowPosition WndPos = new WindowPosition();
        Computer My = new Computer();
        EDataRegCategory DRC;

        public DataRegister(EDataRegCategory ERC, string Path, string[] Data)
        {
            try
            {
                DRC = ERC;
                InitializeComponent();
                InitializeUIText(Data, Path);
                InitializeEventHandler();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C002, ex);
                throw;
            }
        }

        private void InitializeUIText(string[] DR, string FilePath)
        {
            try
            {
                Sys_Close.ButtonText = RMain.Layout_CloseProg;
                Sys_Min.ButtonText = RMain.Layout_Minimum;
                RegTargetText.Text = RDataReg.Layout_RegTarget;
                PathText.Text = RDataReg.Layout_FilePath;
                RegTarget.Text = EnumTranslator.DataRegT(DRC);
                Path.Text = FilePath;
                Box_BA.Text = RDataReg.Layout_BA;
                Box_LS.Text = RDataReg.Layout_LS;

                switch (DRC)
                {
                    case EDataRegCategory.BA:
                        Box_BA.Visible = true;

                        //BA Panel
                        BAForceByName.Text = RDataReg.Layout_ForceJPName;
                        BACHDesText.Text = RDataReg.Layout_BACHDescription;
                        BAJPDesText.Text = RDataReg.Layout_BAJPDescription;
                        BASeries1Text.Text = RDataReg.Layout_Series1;
                        BASeries2Text.Text = RDataReg.Layout_Series2;
                        BAScoreText.Text = RDataReg.Layout_Score;
                        BAJPNameText.Text = RDataReg.Layout_BAJPName;
                        BAJPName.Text = DR[(int)EBADataInfo.Name];
                        BAJPDes.Text = DR[(int)EBADataInfo.DesJP];
                        BARegister.ButtonText = RDataReg.Layout_Register;
                        break;
                    case EDataRegCategory.LS:
                        Box_LS.Visible = true;

                        //LS Panel
                        IDText.Text = RDataReg.Layout_ID;
                        EffectJPText.Text = RDataReg.Layout_Effect + RDataReg.Layout_JP;
                        TargetCHText.Text = RDataReg.Layout_Target + RDataReg.Layout_CH;
                        TargetJPText.Text = RDataReg.Layout_Target + RDataReg.Layout_JP;
                        TargetScoreText.Text = RDataReg.Layout_Score;
                        SpecScoreText.Text = RDataReg.Layout_Score;
                        SpecText.Text = RDataReg.Layout_Spec;
                        STRText.Text = RDataReg.Layout_STR;
                        VITText.Text = RDataReg.Layout_VIT;
                        INTText.Text = RDataReg.Layout_INT;
                        MENText.Text = RDataReg.Layout_MEN;
                        SSText.Text = RDataReg.Layout_SS;
                        HPText.Text = RDataReg.Layout_HP;
                        LSRegister.ButtonText = RDataReg.Layout_Register;
                        TargetJP.Text = DR[(int)ELSDictCode.TARGET_JP];
                        EffectJP.Text = DR[(int)ELSDictCode.EFFECT_JP];
                        ID.Text = DR[(int)ELSDictCode.ID];
                        break;
                    case EDataRegCategory.CharaInfo:
                        Box_Info.Visible = true;

                        //Info Panel
                        CharaIDText.Text = RDataReg.Layout_CharaID;
                        ReleaseDateText.Text = RDataReg.Layout_ReleaseDate;
                        GetMethod.Text = RDataReg.Layout_GetMethod;
                        FolkNameText.Text = RDataReg.Layout_FolkName;

                        InfoRegister.ButtonText = RDataReg.Layout_Register;
                        
                        CharaID.Text = DR[(int)ECharaDimCode.ID - 1];
                        ReleaseDate.Value = new DateTime(
                            Convert.ToInt32(DR[(int)ECharaDimCode.RELEASE_YEAR - 1]),
                            Convert.ToInt32(DR[(int)ECharaDimCode.RELEASE_MONTH - 1]),
                            Convert.ToInt32(DR[(int)ECharaDimCode.RELEASE_DATE - 1])
                            );
                        GetMethod.Text = DR[(int)ECharaDimCode.GET_METHOD - 1];
                        TextBox[] LBs = { FolkName1, FolkName2, FolkName3, FolkName4, FolkName5 };
                        for (int i = 0; i < LBs.Length; i++)
                        {
                            LBs[i].Text = DR[(int)ECharaDimCode.FOLKNAME + i - 1];
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C003, ex);
                throw;
            }
        }

        private void InitializeEventHandler()
        {
            try
            {
                Sys_Close.ButtonClick += new EventHandler((sender, e) => SystemAPI.CloseWindow(this));
                Sys_Min.ButtonClick += new EventHandler((sender, e) => SystemAPI.MinimizeProgram(this));
                Title.MouseMove += new MouseEventHandler(MoveWindow_MouseMove);
                Title.MouseDown += new MouseEventHandler(MoveWindow_MouseDown);
                BAScore.KeyPress += Extent.VerifyTextIsNum;

                Border.Paint += SystemAPI.DrawBorderCoral;

                BARegister.ButtonClick += Register_ButtonClick;
                LSRegister.ButtonClick += Register_ButtonClick;
                InfoRegister.ButtonClick += Register_ButtonClick;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C004, ex);
                throw;
            }
        }

        private void Register_ButtonClick(object sender, EventArgs e)
        {
            string str = "";
            string[] strArr = { "" }, strArr2 = { "" };

            switch (DRC)
            {
                case EDataRegCategory.BA:
                    strArr = new string[] { BAForceByName.Checked.ToString(), BAJPDes.Text, BACHDes.Text, BASeries1.Text, BASeries2.Text, BAScore.Text };
                    strArr2 = new string[] { BAForceByName.Text, BAJPDesText.Text, BACHDesText.Text, BASeries1Text.Text, BASeries2Text.Text, BAScoreText.Text };
                    break;
                case EDataRegCategory.LS:
                    strArr = new string[] { ID.Text, TargetJP.Text, TargetCH.Text, EffectJP.Text, Spec.Text, TargetScore.Text, STR.Text, VIT.Text, INT.Text, MEN.Text, HP.Text, SS.Text, SpecScore.Text };
                    strArr2 = new string[] { IDText.Text, TargetJPText.Text, TargetCHText.Text, EffectJPText.Text, SpecText.Text, TargetScoreText.Text, STRText.Text, VITText.Text, INTText.Text, MENText.Text, HPText.Text, SSText.Text, SpecScoreText.Text };
                    break;
                case EDataRegCategory.CharaInfo:
                    strArr = new string[] { CharaID.Text, GetMethod.Text, ReleaseDate.Value.Year.ToString(), ReleaseDate.Value.Month.ToString(), ReleaseDate.Value.Day.ToString(), FolkName1.Text, FolkName2.Text, FolkName3.Text, FolkName4.Text, FolkName5.Text };
                    strArr2 = new string[] { CharaIDText.Text, GetMethodText.Text, ReleaseDateText.Text, ReleaseDateText.Text, ReleaseDateText.Text, FolkNameText.Text, FolkNameText.Text, FolkNameText.Text, FolkNameText.Text, FolkNameText.Text };
                    break;
                default:
                    return;
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                str += "【";
                str += strArr2[i];
                str += " = ";
                if (Extent.isEmptyString(strArr[i]))
                {
                    str += "(None)";
                } else
                {
                    str += strArr[i];
                }
                if (i != strArr.Length - 1)
                {
                    str += "】";
                }
            }

            if (new MessageDialog(RDataReg.Message_DoubleCheck, str, MessageBoxButtonStyle.YesNo).ShowDialog() == DialogResult.Yes)
            {
                string ToWrite = "\r\n";

                switch (DRC)
                {
                    case EDataRegCategory.BA:
                        #region BA Section
                        if (BAForceByName.Checked)
                        {
                            strArr[0] = BAJPName.Text;
                        } else
                        {
                            strArr[0] = "";
                        }
                        
                        foreach (string var in strArr)
                        {
                            ToWrite += var;
                            ToWrite += "\t";
                        }
                        ToWrite += "\n";

                        My.FileSystem.WriteAllText(Path.Text, ToWrite, true);
                        break;
                        #endregion
                    case EDataRegCategory.LS:
                        #region LS Section
                        foreach (string var in strArr)
                        {
                            ToWrite += var;
                            ToWrite += "\t";
                        }
                        ToWrite += "\n";

                        My.FileSystem.WriteAllText(Path.Text, ToWrite, true);
                        break;
                    #endregion
                    case EDataRegCategory.CharaInfo:
                        #region Info Section
                        foreach (string var in strArr)
                        {
                            ToWrite += var;
                            ToWrite += "\t";
                        }
                        ToWrite += "\n";
                        
                        My.FileSystem.WriteAllText(Path.Text, ToWrite, true);
                        break;
                        #endregion
                }

                new MessageDialog(RDataReg.Message_RegisterCompleted + EnumTranslator.DataRegT(DRC)).ShowDialog();
                StatusLog.Log(RDataReg.Log_Log1 + EnumTranslator.DataRegT(DRC) + RDataReg.Log_Log2 + Path.Text + RDataReg.Log_Log3 + ToWrite);
            }
        }

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SystemAPI.MoveWindow_MouseDown(Left, Top, e.X, e.Y, ref WndPos);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C000, ex);
                throw;
            }
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                if (lbl.Capture == true)
                {
                    SystemAPI.MoveWindow_MouseMove(Left, Top, e.X, e.Y, ref WndPos, this);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C001, ex);
                throw;
            }
        }
    }
}
