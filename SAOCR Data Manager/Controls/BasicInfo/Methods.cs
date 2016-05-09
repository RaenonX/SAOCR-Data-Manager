using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Forms;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Resources.Controls;
using SAOCR_Data_Manager.Properties;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace SAOCR_Data_Manager.Controls.Initialize_Properties
{
    public partial class BasicInfo : UserControl
    {
        public void DisplayCharacterBasicInfo(CharaData Data)
        {
            try
            {
                UserConfig UC = new UserConfig();

                CDT = Data;
                CharaID.Text = Data.Data.CharaID;
                Rarity.Text = Data.Data.CharaID.Substring(6, 1);
                CharaName = Data.Info.Basic.GetBasicInfo(EBasicInfoCode.JP_NAME);

                Control[] BasicInfoL = { EN, CV, Intro };
                for (int i = 1; i <= BasicInfoL.Length; i++)
                {
                    BasicInfoL[i - 1].Text = Data.Info.Basic.GetBasicInfo((EBasicInfoCode)i);
                }

                Label[] BattleInfoL = { Weapon, Element, Scene, Sex };
                for (int i = 0; i < BattleInfoL.Length; i++)
                {
                    BattleInfoL[i].Text = Data.Info.BattleRelated.GetStringArray()[i];
                }

                GetMethod.Text = Data.Info.Extra.GetMethod;
                DateTime DTT = Data.Info.Extra.ReleaseDate;
                if (DTT.Year == Const.Default.RELEASE_DATE_UNKNOWN_YEAR)
                {
                    ReleaseDate.Text = RBasicInfo.Output_Unknown;
                }
                else
                {
                    ReleaseDate.Text = DTT.ToString("yyyy年MM月dd日 (" + EnumTranslator.WeekDayT(DTT.DayOfWeek) + ")");
                }

                FolkName.MarqueeText = Data.Info.Extra.FolkName;
                FolkName.Restart();

                Picture.ImageLocation = null;
                switch ((EAttachmentManageMode)UC.AMMode)
                {
                    case EAttachmentManageMode.AlwaysDL:
                        Picture.ImageLocation = Const.URL.PIC_AREA + Const.URL.CHARA_PIC + "/" + Data.CDT.Info[0][(int)ENameSecCol.ID_PIC].ToString() + Const.Path.PIC_EXTENSION;
                        break;
                    case EAttachmentManageMode.DelAfterClose:
                    case EAttachmentManageMode.DLonce:
                        Computer My = new Computer();
                        string PicName = Data.CDT.Info[0][(int)ENameSecCol.ID_PIC].ToString() + Const.Path.PIC_EXTENSION;
                        string PicAtLocal = Const.Path.ATTACHMENT_AREA + "/" + Const.Path.CHARA_PIC + "/" + PicName;
                        string PicOnNet = Const.URL.PIC_AREA + Const.URL.CHARA_PIC + "/" + PicName;

                        
                        if (!My.FileSystem.FileExists(PicAtLocal))
                        {
                            if (DL != null && DL.isDownloading())
                            {
                                DL.DLCancel();
                                DL = null;
                            }
                            DL = new Downloader(new Uri(PicOnNet), PicAtLocal, SizeUnit.KB, PicName);
                            DL.DownloadSucceed += (sender, e) => Picture_Download_Succeed(PicAtLocal);
                            DL.DownloadFailed += Picture_Download_Failed;
                            DL.DownloadBegin += Picture_Download_Begin;
                            DL.DLStart();
                        } else
                        {
                            Picture.ImageLocation = PicAtLocal;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00013005, e);
                throw;
            }
        }

        /// <returns>角色名稱+CV、屬性顏色、屬性、場景顏色、場景、武器、釋出日期、角色名稱、獲得方法、俗名</returns>
        public string[] OutputForHTML()
        {
            string[] A =
            {
                CharaName + " (CV:" + CV.Text + ")",
                SFColorTrans.ElementT(EnumTranslator.ElementT(Element.Text)),
                Element.Text,
                SFColorTrans.SceneT(EnumTranslator.SceneT(Scene.Text)),
                Scene.Text,
                Weapon.Text,
                ReleaseDate.Text,
                CharaName,
                GetMethod.Text,
                FolkName.MarqueeText
            };
            return A;
        }
    }
}
