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
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void ST_FilePathSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Button_SE_ Sender = (Button_SE_)sender;

                switch (Sender.Name)
                {
                    case "ST_PathBeepBrowse":
                    case "ST_PathWarningBrowse":
                        EX_FileDialog.FilterIndex = 3;
                        break;
                    case "ST_PathBGMBrowse":
                        EX_FileDialog.FilterIndex = 4;
                        break;
                }

                if (EX_FileDialog.ShowDialog(this) != DialogResult.Cancel)
                {
                    string Extension = Path.GetExtension(EX_FileDialog.FileName);

                    switch (Sender.Name)
                    {
                        case "ST_PathBeepBrowse":
                            if (Extension != ".wav" && Extension != ".mp3")
                            {
                                Status(RStatus.Warning_SENotChanged + RStatus.Warning_WrongExtension + RStatus.Warning_ReCheckExtension);
                                return;
                            }
                            UC.SE_Beep = EX_FileDialog.FileName;
                            Status(RStatus.Result_SEChangedBeep + UC.SE_Beep);
                            break;
                        case "ST_PathWarningBrowse":
                            if (Extension != ".wav")
                            {
                                Status(RStatus.Warning_SENotChanged + RStatus.Warning_WrongExtension + RStatus.Warning_ReCheckExtension);
                                return;
                            }
                            UC.SE_Warning = EX_FileDialog.FileName;
                            Status(RStatus.Result_SEChangedWarning + UC.SE_Warning);
                            break;
                        case "ST_PathBGMBrowse":
                            if (Extension != ".wav" && Extension != ".mp3")
                            {
                                Status(RStatus.Warning_SENotChanged + RStatus.Warning_WrongExtension + RStatus.Warning_ReCheckExtension);
                                return;
                            }
                            UC.SE_BGM = EX_FileDialog.FileName;
                            Status(RStatus.Result_SEChangedWarning + UC.SE_BGM);
                            InitializeBGM();
                            break;
                    }
                }
                else
                {
                    Status(RStatus.Warning_SENotChanged);
                }

                switch (Sender.Name)
                {
                    case "ST_PathBeepBrowse":
                        ST_PathBeep.MarqueeText = UC.SE_Beep;
                        ST_PathBeep.Restart();
                        break;
                    case "ST_PathWarningBrowse":
                        ST_PathWarning.MarqueeText = UC.SE_Warning;
                        ST_PathWarning.Restart();
                        break;
                    case "ST_PathBGMBrowse":
                        ST_PathBGM.MarqueeText = UC.SE_BGM;
                        ST_PathBGM.Restart();
                        break;
                }
                UC.Save();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00027002, ex);
                throw;
            }
        }

        private void ST_DirectoryPathSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Button_SE_ Sender = (Button_SE_)sender;

                EX_DirectoryDialog.Description = RConfig.Message_ChoosePathToStoreFile1;
                switch (Sender.Name)
                {
                    case "ST_AUCsvBrowse":
                        EX_DirectoryDialog.Description += RConfig.Message_Csv;
                        break;
                }
                EX_DirectoryDialog.Description += RConfig.Message_ChoosePathToStoreFile2;
                StatusLog.Log(RConfig.Log_StartChooseDirectory + EX_DirectoryDialog.Description);

                if (EX_DirectoryDialog.ShowDialog(this) != DialogResult.Cancel)
                {
                    switch (Sender.Name)
                    {
                        case "ST_AUCsvBrowse":
                            UC.Path_Download = EX_DirectoryDialog.SelectedPath;
                            Status(RStatus.S_0xF0027000 + UC.Path_Download);
                            break;
                    }
                }
                else
                {
                    Status(RWarning.W_0xC0027000);
                }

                switch (Sender.Name)
                {
                    case "ST_AUCsvBrowse":
                        ST_AUCsvPath.MarqueeText = UC.Path_Download;
                        ST_AUCsvPath.Restart();
                        break;
                }

                UC.Save();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00027001, ex);
                throw;
            }
        }

        private void ST_ReLoad_Click(object sender, EventArgs e)
        {
            InitializeDataTitle();
            InitializeCharaDict();
            InitializeDataTables();
            Status(RStatus.S_0xF0027001);
        }

        private void ST_AutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            UC.State_AutoLoad = ST_AutoLoad.Checked;
            UC.Save();
        }

        private void ST_Developer_ArriveToBorder(object sender, EventArgs e)
        {
            ST_DevelopersCounter++;
            switch (ST_DevelopersCounter)
            {
                case 1:
                    ST_DevelopersText.Text = RConfig.Layout_DevelopersTextDev;
                    ST_Developer.MarqueeText = RConfig.Layout_DevelopersDev1;
                    break;
                case 2:
                    ST_DevelopersText.Text = RConfig.Layout_DevelopersTextTst;
                    ST_Developer.MarqueeText = RConfig.Layout_DevelopersTst1;
                    break;
                case 3:
                    ST_DevelopersText.Text = RConfig.Layout_DevelopersTextAst;
                    ST_Developer.MarqueeText = RConfig.Layout_DevelopersAst1;
                    break;
                case 4:
                    ST_DevelopersText.Text = RConfig.Layout_DevelopersTextAst;
                    ST_Developer.MarqueeText = RConfig.Layout_DevelopersAst2;
                    ST_DevelopersCounter = 0;
                    break;
            }
        }

        private void ST_MuteChanged(object sender, EventArgs e)
        {
            CheckBox[] MuteCheckBoxes = { ST_PathBeepMute, ST_PathBGMMute, ST_PathWarningMute, ST_PathMessageMute };
            Boolean[] MuteConfigs = { UC.SE_BeepMute, UC.SE_BGMMute, UC.SE_WarningMute, UC.SE_MessageMute };

            UC.Save();
            UC.SE_BeepMute = ST_PathBeepMute.Checked;
            UC.SE_BGMMute = ST_PathBGMMute.Checked;
            UC.SE_WarningMute = ST_PathWarningMute.Checked;
            UC.SE_MessageMute = ST_PathMessageMute.Checked;

            BGM.settings.mute = UC.SE_BGMMute;
            UC.Save();
        }

        private void ST_Data_DoubleClick(object sender, EventArgs e)
        {
            ListView LV = (ListView)sender;

            ListView.SelectedListViewItemCollection SelectedItem = LV.SelectedItems;
            
            foreach (ListViewItem item in SelectedItem)
            {
                CT_Step.Text = item.SubItems[2].Text;
            }
            PageSwitch(P_CsvTable);
            CT_StepGo_ButtonClick();
        }

        private void ST_AUCheckGoButtonClick(object sender, EventArgs e)
        {
            Button_SE_ Sender = (Button_SE_)sender;
            AU.isCheckAll = false;

            switch (Sender.Name)
            {
                case "ST_AUProgCheckGo":
                    AUProgram.CheckUpdate();
                    break;
                case "ST_AUCsvCheckGo":
                    AUCsv.CheckUpdate();
                    break;
            }
        }

        private void AUDataSave(object sender, EventArgs e)
        {
            UC.AU_ProgramChannel = ST_AUProgChannel.SelectedIndex;
            UC.AU_ProgramMode = ST_AUProgMode.SelectedIndex;
            UC.AU_CSVMode = ST_AUCsvMode.SelectedIndex;
            UC.AMMode = ST_AttachmentMode.SelectedIndex;
            UC.Save();
        }

        private void ST_ClearAllAttachments_ButtonClick(object sender, EventArgs e)
        {
            if (new MessageDialog(RWarning.W_0xC0027001.Replace("\\n", "\n"), MessageBoxButtonStyle.YesNo).ShowDialog() == DialogResult.Yes)
            {
                My.FileSystem.DeleteDirectory(Const.Path.ATTACHMENT_AREA + "/" + Const.Path.CHARA_PIC, DeleteDirectoryOption.DeleteAllContents);
                if (My.FileSystem.DirectoryExists(Const.Path.ATTACHMENT_AREA + "/" + Const.Path.CHARA_PIC))
                {
                    new MessageDialog(RWarning.W_0xC0027002.Replace("\\n", "\n")).ShowDialog();
                } else
                {
                    new MessageDialog(RStatus.S_0xF0027002.Replace("\\n", "\n")).ShowDialog();
                    Status(RStatus.S_0xF0027002);
                }
            }
        }
    }
}
