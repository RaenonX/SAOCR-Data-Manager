using SAOCR_Data_Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.IO;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Resources.Forms;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void Res_Select_Click(object sender, EventArgs e)
        {
            EX_FileDialog.FilterIndex = 1;
            EX_FileDialog.ShowDialog(this);
            if (Extent.isEmptyString(EX_FileDialog.FileName))
            {
                Status(RStatus.Warning_FileNotImported);
                return;
            }
            LastImportedFileExt = Path.GetExtension(EX_FileDialog.FileName);
            switch (LastImportedFileExt)
            {
                case ".csv":
                    AC.Path_CSV = EX_FileDialog.FileName;
                    UC.Save();
                    Status(RStatus.Result_ImportCsvComplete + AC.Path_CSV);
                    break;
                case ".assetbundle":
                    AC.Path_ASB = EX_FileDialog.FileName;
                    UC.Save();
                    Status(RStatus.Result_ImportAssetbundleComplete + AC.Path_ASB);
                    break;
                default:
                    Status(RStatus.Error_FileNotLegal + AC.Path_CSV);
                    return;
            }
        }

        private void Res_Load_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Status(RStatus.Acting_Loading);

            if (LoadCSVData())
            {
                foreach (Button_SE_ item in FunctionButtons)
                {
                    item.ButtonEnabled = true;
                }
            }

            ST_ReLoad_Click(sender, e);
        }

        private void ToCsvTable_Click(object sender, EventArgs e)
        {
            PageSwitch(P_CsvTable);
        }

        private void ToHomePage_Click(object sender, EventArgs e)
        {
            PageSwitch(P_HomePage);
        }

        private void ToSettings_Click(object sender, EventArgs e)
        {
            PageSwitch(P_Config);
        }

        private void ToCharacterData_Click(object sender, EventArgs e)
        {
            PageSwitch(P_CharacterData);
        }

        private void ToStatistics_Click(object sender, EventArgs e)
        {
            PageSwitch(P_Statistics);
        }

        private void ToDownload_Click(object sender, EventArgs e)
        {
            PageSwitch(P_Download);
        }

        private void ToEXPCalc_Click(object sender, EventArgs e)
        {
            PageSwitch(P_EXPCalc);
        }

        private void ToEquipmentData_Click(object sender, EventArgs e)
        {
            PageSwitch(P_Equip);
        }

        private void Announcement_ArriveToBorder(object sender, EventArgs e)
        {
            try
            {
                if (Announce.Strings.Count > 0)
                {
                    if (Announce.Strings[Announce.Counter].Length >= 5)
                    {
                        if (Announce.Strings[Announce.Counter].Substring(0, 5) == Const.AnnouncementKeyword.IMPORTANT)
                        {
                            HM_Announcement.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                            HM_Announcement.MarqueeText = Announce.Strings[Announce.Counter].Replace(Const.AnnouncementKeyword.IMPORTANT, "");
                        }
                        else if (Announce.Strings[Announce.Counter].Substring(0, 5) == Const.AnnouncementKeyword.WARNING)
                        {
                            HM_Announcement.BackColor = Color.FromArgb((int)EBackColorAlpha.Yellow);
                            HM_Announcement.MarqueeText = Announce.Strings[Announce.Counter].Replace(Const.AnnouncementKeyword.WARNING, "");
                        }
                        else if (Announce.Strings[Announce.Counter].Substring(0, 5) == Const.AnnouncementKeyword.INFO)
                        {
                            HM_Announcement.BackColor = Color.FromArgb((int)EBackColorAlpha.Blue);
                            HM_Announcement.MarqueeText = Announce.Strings[Announce.Counter].Replace(Const.AnnouncementKeyword.INFO, "");
                        }
                        else
                        {
                            HM_Announcement.BackColor = Color.FromArgb((int)EBackColorAlpha.Grey70);
                            HM_Announcement.MarqueeText = Announce.Strings[Announce.Counter];
                        }
                    }
                    else
                    {
                        HM_Announcement.MarqueeText = Announce.Strings[Announce.Counter];
                    }

                    Announce.Counter++;
                    if (Announce.Counter >= Announce.Max)
                    {
                        Announce.Counter = 0;
                    }
                } else
                {
                    HM_Announcement.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                    HM_Announcement.MarqueeText = RHome.Message_NoAnnouncement;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001F001, ex);
                throw;
            }
        }

        private void Announce_DownloadCompleted(object sender, EventArgs e)
        {
            try
            {
                DataAPI.LoadCSV(ref Announce.Strings, Announce.Local);
                HM_Announcement.Marquee();
                Announce.Max = Announce.Strings.Count;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001F002, ex);
                throw;
            }
        }
    }
}
