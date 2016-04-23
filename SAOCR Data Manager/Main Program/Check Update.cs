using SAOCR_Data_Manager.Properties;
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
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.IO;
using System.Reflection;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Module;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        public void InitializeUpdateChecker()
        {
            ReCreateProgramVersionData();

            AUProgram = new UpdateChecker
                (new Uri(URLs[(int)EPathRowCode.PROGRAM_VERSION_NET]), URLs[(int)EPathRowCode.PROGRAM_VERSION_LOCAL], "\t", URLs[(int)EPathRowCode.PROGRAM_DESCRIPTION]);
            AUCsv = new UpdateChecker(new Uri(URLs[(int)EPathRowCode.CSV_VERSION_NET]), URLs[(int)EPathRowCode.CSV_VERSION_LOCAL], "\t", URLs[(int)EPathRowCode.CSV_DESCRIPTION]);
            AUResource = new UpdateChecker(new Uri(URLs[(int)EPathRowCode.RESOURCES_VERSION_NET]), URLs[(int)EPathRowCode.RESOURCES_VERSION_LOCAL], "\t", URLs[(int)EPathRowCode.RESOURCES_DESCRIPTION]);
            
            AUProgram.CheckCompleted += new EventHandler(AUSystem_CheckCompleted);
            AUProgram.CheckSucceed += new EventHandler(AUData_CheckSucceed);
            AUProgram.CheckFailed += new EventHandler(AUData_CheckFailed);
            AUProgram.CheckBegin += new EventHandler(AUData_CheckBegin);
            AUCsv.CheckCompleted += new EventHandler(AUSystem_CheckCompleted);
            AUCsv.CheckSucceed += new EventHandler(AUData_CheckSucceed);
            AUCsv.CheckFailed += new EventHandler(AUData_CheckFailed);
            AUCsv.CheckBegin += new EventHandler(AUData_CheckBegin);
            AUResource.CheckCompleted += new EventHandler(AUSystem_CheckCompleted);
            AUResource.CheckSucceed += new EventHandler(AUData_CheckSucceed);
            AUResource.CheckFailed += new EventHandler(AUData_CheckFailed);
            AUResource.CheckBegin += new EventHandler(AUData_CheckBegin);
        }

        private void AUSystem_CheckCompleted(object sender, EventArgs e)
        {
            AU.Counter++;
            RefreshVersionText();

            if (AU.isCheckAll)
            {
                if (AU.Counter % 3 == 0)
                {
                    if (AUProgram.UpdateAvailable((AutoUpdateChannel)UC.AU_ProgramChannel))
                    {
                        ProgramHaveUpdate();
                    }
                    else if (AUCsv.UpdateAvailable())
                    {
                        CsvHaveUpdate();
                    }
                    else if (AUResource.UpdateAvailable())
                    {
                        DimensionHaveUpdate();
                    }
                   
                }
            } else
            {
                UpdateChecker UCHK = (UpdateChecker)sender;

                if (UCHK.Description == URLs[(int)EPathRowCode.PROGRAM_DESCRIPTION])
                {
                    ProgramHaveUpdate();
                }
                else if (UCHK.Description == URLs[(int)EPathRowCode.CSV_DESCRIPTION])
                {
                    CsvHaveUpdate();
                }
                else if (UCHK.Description == URLs[(int)EPathRowCode.RESOURCES_DESCRIPTION])
                {
                    DimensionHaveUpdate();
                }
            }
        }

        private void ProgramHaveUpdate()
        {
            string Message = "", ExMesssage = "";

            if (AUProgram.UpdateAvailable((AutoUpdateChannel)UC.AU_ProgramChannel))
            {
                Message = RConfig.Message_Program + RConfig.Message_UpdateAvailable;
                switch ((AutoUpdateMode)UC.AU_ProgramMode)
                {
                    case AutoUpdateMode.CheckAndDownload:
                        Message += RConfig.Message_DownloadOrNot;
                        ExMesssage = RConfig.Message_VersionCurrent + AUProgram.GetVersionString(DataSource.Local) + RConfig.Message_VersionNew + AUProgram.GetVersionString(DataSource.Network);
                        if (new MessageDialog(Message, ExMesssage, MessageBoxButtonStyle.YesNo).ShowDialog(this) == DialogResult.Yes)
                        {
                            Downloader DL = new Downloader(new Uri(URLs[(int)EPathRowCode.PROGRAM_DOWNLOAD_NET]), UC.Path_Download + Const.Path.PROGRAM, SizeUnit.KB, URLs[(int)EPathRowCode.PROGRAM_DESCRIPTION]);
                            new MessageDialog(Message, MessageBoxButtonStyle.Downlaoder, DL, true).ShowDialog(this);
                        };
                        break;
                    case AutoUpdateMode.CheckOnly:
                        new MessageDialog(Message).Show();
                        break;
                }
            }
        }

        private void CsvHaveUpdate()
        {
            string Message = "", ExMesssage = "";

            if (AUCsv.UpdateAvailable())
            {
                Message = RConfig.Message_Csv + RConfig.Message_UpdateAvailable;
                switch ((AutoUpdateMode)UC.AU_CSVMode)
                {
                    case AutoUpdateMode.CheckAndDownload:
                        Message += RConfig.Message_DownloadOrNot;
                        ExMesssage = RConfig.Message_VersionCurrent + AUCsv.GetVersionString(DataSource.Local) + RConfig.Message_VersionNew + AUCsv.GetVersionString(DataSource.Network);
                        if (new MessageDialog(Message, ExMesssage, MessageBoxButtonStyle.YesNo).ShowDialog(this) == DialogResult.Yes)
                        {
                            Downloader DL = new Downloader(new Uri(URLs[(int)EPathRowCode.CSV_DOWNLOAD_NET]), AC.Path_CSV, SizeUnit.KB, new Uri(URLs[(int)EPathRowCode.CSV_VERSION_NET]), URLs[(int)EPathRowCode.CSV_VERSION_LOCAL], URLs[(int)EPathRowCode.CSV_DESCRIPTION]);
                            new MessageDialog(Message, MessageBoxButtonStyle.Downlaoder, DL, true).ShowDialog(this);
                        };
                        break;
                    case AutoUpdateMode.CheckOnly:
                        new MessageDialog(Message).Show();
                        break;
                }
            }
        }

        private void DimensionHaveUpdate()
        {
            string Message = "";

            if (AUResource.UpdateAvailable())
            {
                Message = RConfig.Message_Resource + RConfig.Message_UpdateAvailable;
                switch ((AutoUpdateMode)UC.AU_CSVMode)
                {
                    case AutoUpdateMode.CheckAndDownload:
                        Message += RConfig.Message_DownloadOrNot;
                        if (new MessageDialog(Message, MessageBoxButtonStyle.YesNo).ShowDialog(this) == DialogResult.Yes)
                        {
                            List<Uri> ResourceURLs = new List<Uri>();
                            string[] FILEs = AUResource.GetUpdateAvailableList();
                            foreach (string item in FILEs)
                            {
                                ResourceURLs.Add(new Uri(Const.URL.NETWORK_FILE_AREA + Const.URL.FOLDER_DIMENSION + "/" + item));
                            }
                            Downloader DL = new Downloader(ResourceURLs.ToArray(), AUResource.GetUpdateAvailableList(), SizeUnit.KB, new Uri(URLs[(int)EPathRowCode.RESOURCES_VERSION_NET]), URLs[(int)EPathRowCode.RESOURCES_VERSION_LOCAL], URLs[(int)EPathRowCode.RESOURCES_DESCRIPTION]);

                            new MessageDialog(Message, MessageBoxButtonStyle.Downlaoder, DL, true).ShowDialog(this);
                        };
                        break;
                    case AutoUpdateMode.CheckOnly:
                        new MessageDialog(Message).Show();
                        break;
                }
            }
        }

        private void AUData_CheckSucceed(object sender, EventArgs e)
        {
            UpdateChecker UCHK = (UpdateChecker)sender;

            if (UCHK.Description == URLs[(int)EPathRowCode.PROGRAM_DESCRIPTION])
            {
                Status(UCHK.Description + RStatus.Result_CheckUpdateSucceed + UCHK.GetStatusString((AutoUpdateChannel)UC.AU_ProgramChannel));
            } else
            {
                Status(UCHK.Description + RStatus.Result_CheckUpdateSucceed + UCHK.GetStatusString());
            }
        }

        private void AUData_CheckFailed(object sender, EventArgs e)
        {
            UpdateChecker UC = (UpdateChecker)sender;

            SystemAPI.SEWarning();
            Status(UC.Description + RStatus.Result_CheckUpdateFailed + UC.GetStatusString());
        }

        private void AUData_CheckBegin(object sender, EventArgs e)
        {
            UpdateChecker UC = (UpdateChecker)sender;

            Status(UC.Description + RStatus.Action_CheckingUpdate);
        }

        public void RefreshVersionText()
        {
            ST_AUProgLatestVer.Text = AUProgram.GetVersionString(DataSource.Network, UC.AU_ProgramChannel);
        }

        public void ReCreateProgramVersionData()
        {
            string VersionFilePath = URLs[(int)EPathRowCode.PROGRAM_VERSION_LOCAL];
            TextFieldParser ProgramVersionParser = new TextFieldParser(VersionFilePath);
            ProgramVersionParser.SetDelimiters("\t");
            string CurrentProgramVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();

            List<string> VersionDataList = new List<string>();
            string[] VersionData;

            while (!ProgramVersionParser.EndOfData)
            {
                VersionDataList.AddRange(ProgramVersionParser.ReadFields());
            }
            VersionData = VersionDataList.ToArray();
            VersionData[3] = VersionData[1] = CurrentProgramVersion;

            My.FileSystem.WriteAllText(VersionFilePath, "", false);
            for (int i = 0; i < VersionData.Length; i++)
            {
                My.FileSystem.WriteAllText(VersionFilePath, VersionData[i], true);
                if (i % 2 == 1)
                {
                    My.FileSystem.WriteAllText(VersionFilePath, "\r\n", true);
                }
                else
                {
                    My.FileSystem.WriteAllText(VersionFilePath, "\t", true);
                }
            }
        }
    }
}
