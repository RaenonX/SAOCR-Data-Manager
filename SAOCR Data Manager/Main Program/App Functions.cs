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
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        public bool LoadCSVData()
        {
            #region Check Last Imported File Extension
            if (LastImportedFileExt == ".assetbundle")
            {
                Disunity();
            }
            #endregion

            #region Check is Valid or not
            if (!My.FileSystem.FileExists(AC.Path_CSV) || Extent.isEmptyString(AC.Path_CSV))
            {
                Status(RStatus.Error_FileNotFoundCSV);
                if (My.FileSystem.FileExists(AC.Path_ASB) || My.FileSystem.FileExists(Const.Path.DEFAULT_CSV))
                {
                   Disunity();
                } else
                {
                    SystemAPI.SEWarning();
                    return false;
                }
            }
            #endregion

            Status(RStatus.Acting_Loading);
            InitializeDataTable(ref DT.Source, "SAOCR Main Data");
            DataAPI.LoadCSV(ref DT.Source, AC.Path_CSV);

            CT_CsvView.DataSource = DT.Source;
            CT_CsvView.Columns[0].Width = 50;

            InitializeDataTitle();
            InitializeCharaDict();

            Status(RStatus.Result_LoadingComplete);
            
            return true;
        }

        public bool LoadBADictionary()
        {
            #region Check is Valid or not
            if (Extent.isEmptyString(Const.Path.BA_DICT))
            {
                Status(RStatus.Error_NeedToInputBADict);
                SystemAPI.SEWarning();
                return false;
            }
            if (!My.FileSystem.FileExists(Const.Path.BA_DICT))
            {
                Status(RStatus.Error_FileNotFoundBADict);
                SystemAPI.SEWarning();
                return false;
            }
            #endregion

            InitializeDataTable(ref DT.BADict, 10, "BA Dictionary");
            DataAPI.LoadCSV(ref DT.BADict, Const.Path.BA_DICT, "\t");
            return true;
        }

        public void Disunity()
        {
            try
            {
                using (Process p = new Process())
                {
                    string SavePath = Directory.GetParent(AC.Path_ASB).FullName;
                    string DecompressedFolderName = Application.StartupPath + @"\csv";
                    string command = @"/c disunity bundle-extract csv.assetbundle";

                    My.FileSystem.CopyFile(AC.Path_ASB, Application.StartupPath + "/csv.assetbundle", true);
                    if (My.FileSystem.DirectoryExists(DecompressedFolderName))
                    {
                        My.FileSystem.DeleteDirectory(DecompressedFolderName, DeleteDirectoryOption.DeleteAllContents);
                    }

                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.Arguments = command;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    p.WaitForExit();

                    string[] FileList = Directory.GetFileSystemEntries(DecompressedFolderName);
                    string FileName = Path.GetFileName(FileList[0]);
                    string newName = FileName + ".csv";

                    My.FileSystem.RenameFile(FileList[0], newName);
                    My.FileSystem.MoveFile(DecompressedFolderName + "/" + newName, SavePath + "/" + newName, true);
                    My.FileSystem.DeleteDirectory(DecompressedFolderName, DeleteDirectoryOption.DeleteAllContents);
                    My.FileSystem.DeleteFile("csv.assetbundle");

                    AC.Path_CSV = SavePath + "/" + newName;
                    UC.Save();

                    Status(RStatus.Result_DisunityComplete);
                }
            }
            catch (Exception e)
            {
                Status(
                    RStatus.Error_Exception1 + e.Message + RStatus.Error_Exception2 + e.GetType() + RStatus.Error_Exception3);
            }
        }

        public void PageSwitch(Panel PanelToShow)
        {
            P_HomePage.Visible = false;
            P_CsvTable.Visible = false;
            P_Config.Visible = false;
            P_CharacterData.Visible = false;
            P_Statistics.Visible = false;
            P_Download.Visible = false;
            P_EXPCalc.Visible = false;
            
            PanelToShow.Visible = true;
            string LogText = RMain.Log_GoToPage;

            MN_Title.Text = RMain.AtPage_ProgramName + " - ";
              
            switch (PanelToShow.Name)
            {
                case "P_HomePage":
                    LogText += MN_Title.Text += RMain.AtPage_HomePage;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_HomePage);
                    break;
                case "P_CsvTable":
                    LogText += MN_Title.Text += RMain.AtPage_CsvTable;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_CsvTable);
                    break;
                case "P_Config":
                    LogText += MN_Title.Text += RMain.AtPage_Settings;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_Settings);
                    break;
                case "P_CharacterData":
                    LogText += MN_Title.Text += RMain.AtPage_CharacterData;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_CharacterData);
                    break;
                case "P_Statistics":
                    LogText += MN_Title.Text += RMain.AtPage_Statistics;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_Statistics);
                    break;
                case "P_Download":
                    LogText += MN_Title.Text += RMain.AtPage_Download;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_Download);
                    break;
                case "P_EXPCalc":
                    LogText += MN_Title.Text += RMain.AtPage_EXPCalc;
                    Status(RStatus.S_0xF0000000 + RMain.AtPage_EXPCalc);
                    break;
            }
            StatusLog.Log(LogText);
        }

        public void SettingsSave(object sender, PropertyChangedEventArgs e)
        {
            Status(RStatus.Result_SettingsSaved);
        }

        private void TextBoxEnter(object sender, KeyPressEventArgs e)
        {
            TextBox senderTextBox = (TextBox)sender;

            if (e.KeyChar == (Char)Keys.Enter)
            {
                switch (senderTextBox.Name)
                {
                    case "CT_Step":
                        CT_StepGo_ButtonClick(this, EventArgs.Empty);
                        break;
                    case "CT_Search":
                        CT_SearchGo_ButtonClick(this, EventArgs.Empty);
                        break;
                    case "CD_CharacterID":
                        CD_CharacterIDGo_ButtonClick(this, EventArgs.Empty);
                        break;
                    case "DL_CharaID":
                        DL_CharaIDAdd_Click(this, EventArgs.Empty);
                        break;
                }
            }
        }

        public void Status(string Message)
        {
            Status(Message, false);
        }

        public void Status(string Message, bool Append)
        {
            Message = Message.Replace("\\n", " ");
            SystemAPI.SEMessage();
            StatusLog.Log(Message, ELogCategory.Status);
            if (Append)
            {
                MN_Status.Text += Message;
            }
            else
            {
                MN_Status.Text = Message;
            }
        }
    }
}
