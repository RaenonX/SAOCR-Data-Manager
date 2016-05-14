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
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Forms;
using SAOCR_Data_Manager.APIs;
using System.IO;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void DL_BeginDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Extent.HaveConnection())
                {
                    PDI.AllowDL = DL_AbortDownload.ButtonEnabled = true;
                    DL_StartDownload.ButtonEnabled = false;

                    PDI.Percent = PDI.Downloading = PDI.Completed = 0;
                    PDI.Pending = PDI.Total;
                    PDI.FolderName = UC.Path_Download + "/" + Const.Path.CHARA_PIC_DOWNLOAD;
                    My.FileSystem.CreateDirectory(PDI.FolderName);
                    DLs.Clear();
                    RefreshCounts();

                    InitializeList(InitItem.DL_DownloadStatus);
                    DL_CompleteList.Clear();

                    for (int i = 0; i < DL_DownloadList.Items.Count; i++)
                    {
                        if (DLs.Count < Const.Count.MAX_DOWNLOAD_NUM)
                        {
                            BuildDownloader(i);
                        }
                        else
                        {
                            break;
                        }
                    }

                    Status(RDownload.Log_BeginDownload + PDI.Total);
                } else
                {
                    SystemAPI.Warning(RWarning.W_0xC0002007);
                    Status(RStatus.S_0xF000200D);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002008, ex);
                throw;
            }
        }

        private void DL_AbortDownload_Click(object sender, EventArgs e)
        {
            try
            {
                PDI.AllowDL = DL_AbortDownload.ButtonEnabled = false;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000200C, ex);
                throw;
            }
        }

        private void DownloadCompleted(object sender, EventArgs e)
        {
            try
            {
                Downloader DL = (Downloader)sender;

                if (PDI.AllowDL)
                {
                    InfoUpdated_WithDelay(DL, EventArgs.Empty);
                }
                RefreshCounts();

                string DLLog = "";
                DLLog += "角色ID: ";
                DLLog += DL.GetDLInfo(DLInfoCategory.Description);
                DLLog += ", 下載結果: ";
                DLLog += DL.GetDLInfo(DLInfoCategory.Status);
                DL_CompleteList.AppendText(DLLog + "\n");
                StatusLog.Log(DLLog);

                if (DL.GetDLInfo(DLInfoCategory.Status) == EnumTranslator.DLStatusT(DLStatus.DownloadFailed))
                {
                    PDI.Failed++;
                } else if (DL.GetDLInfo(DLInfoCategory.Status) == EnumTranslator.DLStatusT(DLStatus.DownloadSucceed))
                {
                    PDI.Completed++;
                }
                DLs.Remove(DL);

                int DL_Pos = PDI.Completed + PDI.Downloading + PDI.Failed;
                if (PDI.Completed + PDI.Failed == PDI.Total)
                {
                    DL_StartDownload.ButtonEnabled = true;
                    DL_AbortDownload.ButtonEnabled = false;

                    Status(RStatus.S_0xF000200C);
                    if (new MessageDialog(
                        RDownload.Log_DownloadComplete_1 + PDI.Total + RDownload.Log_DownloadComplete_2 + PDI.Completed + RDownload.Log_DownloadComplete_3 + PDI.Failed + RDownload.Log_DownloadComplete_4.Replace("\\n", "\n") + PDI.FolderName + "\n\n" + RDownload.Message_OpenFilePath
                        , RDownload.Message_FilePath + PDI.FolderName
                        , MessageBoxButtonStyle.YesNo).ShowDialog() == DialogResult.Yes)
                    {
                        Process.Start(PDI.FolderName);
                    }
                } else if (DL_Pos <= PDI.Total)
                {
                    BuildDownloader(DL_Pos - 1);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000200B, ex);
                throw;
            }
        }

        private void DownloadCancelled(object sender, EventArgs e)
        {
            try
            {
                Downloader DL = (Downloader)sender;

                RefreshCounts();

                #region Cancel Download Section
                if (PDI.Completed != PDI.Total && !PDI.AllowDL && PDI.Downloading == 0 && DL.Status == DLStatus.DownloadCancelled)
                {
                    DL_StartDownload.ButtonEnabled = true;
                    DL_AbortDownload.ButtonEnabled = false;

                    Status(RStatus.S_0xF000200B);
                    if (new MessageDialog(
                        RDownload.Log_DownloadCancelled_1 + PDI.Total + RDownload.Log_DownloadCancelled_2 + PDI.Completed + RDownload.Log_DownloadCancelled_3.Replace("\\n", "\n") + PDI.FolderName + "\n\n" + RDownload.Message_OpenFilePath
                        , RDownload.Message_FilePath + PDI.FolderName
                        , MessageBoxButtonStyle.YesNo).ShowDialog() == DialogResult.Yes)
                    {
                        Process.Start(PDI.FolderName);
                    }
                }
                #endregion
            }
            catch (FileNotFoundException)
            {
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000200F, ex);
                throw;
            }
        }

        private void InfoUpdated_WithDelay(object sender, EventArgs e)
        {
            try
            {
                Downloader DL = (Downloader)sender;
                
                if (!PDI.AllowDL)
                {
                    DL.DLCancel();
                }

                DL_DownloadStatus.Items[DL.GetDLInfo(DLInfoCategory.Description)].SubItems[(int)EPicDLStatusCode.FILE_SIZE].Text = DL.GetDLInfo(DLInfoCategory.TotalSize);
                DL_DownloadStatus.Items[DL.GetDLInfo(DLInfoCategory.Description)].SubItems[(int)EPicDLStatusCode.PROGRESS].Text = DL.GetDLInfo(DLInfoCategory.ItemPercentage);
                DL_DownloadStatus.Items[DL.GetDLInfo(DLInfoCategory.Description)].SubItems[(int)EPicDLStatusCode.STATUS].Text = DL.GetDLInfo(DLInfoCategory.Status);
                if (DL.GetDLInfo(DLInfoCategory.Status) == EnumTranslator.DLStatusT(DLStatus.DownloadSucceed))
                {
                    DL_DownloadStatus.Items[DL.GetDLInfo(DLInfoCategory.Description)].BackColor = Color.FromArgb((int)EBackColorAlpha.RG120B70);
                }
                else if (DL.GetDLInfo(DLInfoCategory.Status) == EnumTranslator.DLStatusT(DLStatus.DownloadFailed))
                {
                    DL_DownloadStatus.Items[DL.GetDLInfo(DLInfoCategory.Description)].BackColor = Color.FromArgb((int)EBackColorAlpha.R80GB30);
                }
                else if (DL.GetDLInfo(DLInfoCategory.Status) == EnumTranslator.DLStatusT(DLStatus.DownloadCancelled))
                {
                    DL_DownloadStatus.Items[DL.GetDLInfo(DLInfoCategory.Description)].BackColor = Color.FromArgb((int)EBackColorAlpha.R30G50B80);
                }
                LogChanged(DL_DownloadStatus, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000200D, ex);
                throw;
            }
        }

        private void BuildDownloader(int No)
        {
            try
            {
                if (!PDI.AllowDL)
                {
                    return;
                }
                string CharaID = DL_DownloadList.Items[No].SubItems[(int)ECharaDataInListCode.ID].Text;
                string CharaName = DL_DownloadList.Items[No].SubItems[(int)ECharaDataInListCode.NAME].Text;

                Uri OnNET = new Uri(Const.URL.PIC_AREA + Const.URL.CHARA_PIC + "/" + CharaID + Const.Path.PIC_EXTENSION);
                string AtLocal = PDI.FolderName + "/" + CharaID + " - " + CharaName + Const.Path.PIC_EXTENSION;

                Downloader DL = new Downloader(OnNET, AtLocal, SizeUnit.KB, CharaID);
                DL.DownloadCompleted += DownloadCompleted;
                DL.DownloadCancelled += DownloadCompleted;
                DL.DownloadCancelled += DownloadCancelled;
                DL.InfoUpdated += InfoUpdated_WithDelay;
                DL.DLStart();
                DLs.Add(DL);

                ListViewItem LVI = new ListViewItem();
                LVI.Name = CharaID;
                LVI.SubItems.Add(CharaID);
                LVI.SubItems.Add(DL.GetDLInfo(DLInfoCategory.TotalSize));
                LVI.SubItems.Add(DL.GetDLInfo(DLInfoCategory.ItemPercentage));
                LVI.SubItems.Add(DL.GetDLInfo(DLInfoCategory.Status));
                DL_DownloadStatus.Items.Add(LVI);

                PDI.Downloading++;
                PDI.Pending--;
                StatusLog.Log(RDownload.Log_BuildDownloader + CharaID);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000200E, ex);
                throw;
            }
        }

        private void RefreshCounts()
        {
            try
            {
                PDI.Downloading = DLs.Count;
                DL_DLing.Text = PDI.Downloading.ToString();

                PDI.Percent = (int)((double)(PDI.Completed + PDI.Failed) / PDI.Total * 100);
                DL_Progress.Value = PDI.Percent;

                PDI.Pending = PDI.Total - (PDI.Completed + PDI.Downloading + PDI.Failed);
                DL_Pending.Text = PDI.Pending.ToString();

                DL_Completed.Text = PDI.Completed.ToString();

                DL_Failed.Text = PDI.Failed.ToString();

                StatusLog.Log(RDownload.Log_RefreshStatus_1 + PDI.Percent + RDownload.Log_RefreshStatus_2 + PDI.Pending + RDownload.Log_RefreshStatus_3 + PDI.Downloading + RDownload.Log_RefreshStatus_4 + PDI.Completed + RDownload.Log_RefreshStatus_5 + PDI.Failed);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000200A, ex);
                throw;
            }
        }

        private void LogChanged(object sender, EventArgs e)
        {
            if (typeof(RichTextBox) == sender.GetType())
            {
                RichTextBox RTB = (RichTextBox)sender;
                RTB.SelectionStart = RTB.Text.Length;
                RTB.ScrollToCaret();
            } else if (typeof(ListView) == sender.GetType())
            {
                ListView LSV = (ListView)sender;
                LSV.EnsureVisible(LSV.Items.Count - 1);
            }
        }

        private void DL_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DL_SearchCharacter.Result.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem LSV in DL_SearchCharacter.Result.SelectedItems)
                    {
                        if (!DL_DownloadList.Items.ContainsKey(LSV.Name))
                        {
                            ListViewItem LVI = (ListViewItem)LSV.Clone();
                            LVI.Name = LVI.SubItems[(int)ECharaDataInListCode.ID].Text;
                            DL_DownloadList.Items.Add(LVI);
                        }
                    }
                    Status(RStatus.S_0xF0002002);
                }
                else
                {
                    SystemAPI.Warning(RWarning.W_0xC0002000);
                    Status(RStatus.S_0xF0002003);
                }
                DL_DownloadList_RefreshCount();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002000, ex);
                throw;
            }
        }

        private void DL_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DL_DownloadList.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem LSV in DL_DownloadList.SelectedItems)
                    {
                        DL_DownloadList.Items.Remove(LSV);
                    }
                    Status(RStatus.S_0xF0002004);
                }
                else
                {
                    SystemAPI.Warning(RWarning.W_0xC0002001);
                    Status(RStatus.S_0xF0002005);
                }
                DL_DownloadList_RefreshCount();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002001, ex);
                throw;
            }
        }

        private void DL_AddAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (DL_SearchCharacter.Result.Items.Count > 0)
                {
                    foreach (ListViewItem LSV in DL_SearchCharacter.Result.Items)
                    {
                        if (!DL_DownloadList.Items.ContainsKey(LSV.Name))
                        {
                            ListViewItem LVI = (ListViewItem)LSV.Clone();
                            LVI.Name = LVI.SubItems[(int)ECharaDataInListCode.ID].Text;
                            DL_DownloadList.Items.Add(LVI);
                        }
                    }
                    Status(RStatus.S_0xF0002006);
                }
                else
                {
                    SystemAPI.Warning(RWarning.W_0xC0002002);
                    Status(RStatus.S_0xF0002007);
                }
                DL_DownloadList_RefreshCount();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002002, ex);
                throw;
            }
        }

        private void DL_CharaIDAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] DR = DataAPI.Search(DL_CharaID.Text, DT.CharaDict, 0, Const.Count.MAX_NUM, (int)ECharaDictCodeByColName.ID, true);

                if (DR != null)
                {
                    foreach (ListViewItem LVI in DL_DownloadList.Items)
                    {
                        if (DL_DownloadList.Items.ContainsKey(DR[0][(int)ECharaDictCode.ID].ToString()))
                        {
                            SystemAPI.Warning(RWarning.W_0xC0002005);
                            return;
                        }
                    }
                    ListViewItem LSV = new ListViewItem();
                    LSV.Name = DR[0][(int)ECharaDictCode.ID].ToString();
                    LSV.SubItems.Add(DR[0][(int)ECharaDictCode.ID].ToString());
                    LSV.SubItems.Add(DR[0][(int)ECharaDictCode.HEAD].ToString() + DR[0][(int)ECharaDictCode.JP_NAME].ToString());
                    DL_DownloadList.Items.Add(LSV);
                    Status(RStatus.S_0xF0002008 + DL_CharaID.Text);
                } else
                {
                    SystemAPI.Warning(RWarning.W_0xC0002003);
                    Status(RStatus.S_0xF0002009);
                }
                DL_DownloadList_RefreshCount();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002003, ex);
                throw;
            }
        }

        private void DL_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DL_SearchCharacter.FindCharacter(ref DT.CharaMix, Status);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002004, ex);
                throw;
            }
        }

        private void DL_CharaSeriesForm_LinkClick(object sender, EventArgs e)
        {
            try
            {
                DL_SearchCharacter.OpenSeriesTable(ref DT.CharaSeries, Status);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002005, ex);
                throw;
            }
        }

        private void DL_ClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (new MessageDialog(RDownload.Message_EnsureClear, MessageBoxButtonStyle.YesNo).ShowDialog() == DialogResult.Yes)
                {
                    InitializeList(InitItem.DL_DownloadList);
                }
                DL_DownloadList_RefreshCount();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002006, ex);
                throw;
            }
        }

        private void DL_SearchResult_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DL_Add_Click(sender, e);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002007, ex);
                throw;
            }
        }

        private void DL_DownloadStatus_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListView LV = (ListView)sender;

                foreach (ListViewItem LSV in DL_DownloadStatus.SelectedItems)
                {
                    string CharaID = LSV.SubItems[(int)EPicDLStatusCode.ID].Text;
                    string CharaName = DL_DownloadList.Items[CharaID].SubItems[(int)ECharaDataInListCode.NAME].Text;
                    string FileName = PDI.FolderName + "/" + CharaID + " - " + CharaName + Const.Path.PIC_EXTENSION;
                    if (My.FileSystem.FileExists(FileName))
                    {
                        Process.Start(FileName);
                    } else
                    {
                        SystemAPI.Warning(RWarning.W_0xC0002006 + FileName);
                    }
                    
                    StatusLog.Log(RDownload.Log_OpenFile + FileName);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002007, ex);
                throw;
            }
        }

        private void DL_DownloadList_RefreshCount()
        {
            try
            {
                PDI.Total = DL_DownloadList.Items.Count;
                DL_PicCount.Text = PDI.Total.ToString();

                if (PDI.Total > 0)
                {
                    DL_StartDownload.ButtonEnabled = true;
                } else
                {
                    DL_StartDownload.ButtonEnabled = false;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002009, ex);
                throw;
            }
        }

        private void DL_SearchCharacter_ItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (DL_SearchCharacter.Result.Items.Count > 0)
                {
                    DL_AddAll.ButtonEnabled = DL_Add.ButtonEnabled = true;
                } else
                {
                    DL_AddAll.ButtonEnabled = DL_Add.ButtonEnabled = false;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00002010, ex);
                throw;
            }
        }
    }
}
