using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using SAOCR_Data_Manager.APIs;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public class UpdateChecker
    {
        Computer My = new Computer();
        WebClient Web = new WebClient();

        AUSystemObjects AUSys = new AUSystemObjects();

        public event EventHandler CheckBegin, CheckCompleted, CheckSucceed, CheckFailed;
        public string Description;
        
        public UpdateChecker(Uri NetworkData, string LocalData, string Delimeters, string description)
        {
            if (!My.FileSystem.FileExists(LocalData))
            {
                throw new ArgumentException(RError.Error_FileNotFound);
            }
            Web.DownloadFileCompleted += (sender, e) => FileDownloadCompleted();
            Description = description;
            SetProperties(NetworkData, LocalData, Delimeters);
            AUSys.Status = AUCheckStatus.HaveNotChecked;
        }

        public void CheckUpdate()
        {
            StatusLog.Log(Description + RMain.Log_CheckingUpdate);
            if (CheckBegin != null)
            {
                CheckBegin(this, EventArgs.Empty);
            }
            DownLoadFileOnline();
        }
        
        public bool UpdateAvailable()
        {
            switch (AUSys.Status)
            {
                case AUCheckStatus.UpdateAvailable:
                    return true;
                default:
                    return false;
            }
        }

        public bool UpdateAvailable(AutoUpdateChannel AUC)
        {
            string[] List = GetUpdateAvailableList();
            foreach (string item in List)
            {
                if (item == EnumTranslator.AutoUpdateChannelT(AUC))
                {
                    return true;
                }
            }
            return false;
        }
        
        public string GetVersionString(DataSource VTS, int ColumnIndex = 0)
        {
            switch (AUSys.Status)
            {
                case AUCheckStatus.CheckFailed:
                    return RError.Error_AUCheckFailed;
                case AUCheckStatus.HaveNotChecked:
                    return RError.Warning_AUHaveNotChecked;
                case AUCheckStatus.NoConnection:
                    return RError.Warning_AUNoConnection;
                case AUCheckStatus.IsLatest:
                case AUCheckStatus.UpdateAvailable:
                    switch (VTS)
                    {
                        case DataSource.Local:
                            return AUSys.Version.Local[ColumnIndex];
                        case DataSource.Network:
                            return AUSys.Version.Network[ColumnIndex];
                        default:
                            throw new ArgumentException(RError.Error_SourceError);
                    }
                default:
                    throw new ArgumentException(RError.Error_FlagError);
            }
            
        }
    
        public string GetStatusString()
        {
            return EnumTranslator.AUCheckStatusT(AUSys.Status);
        }

        public string GetStatusString(AutoUpdateChannel AUC)
        {
            switch (AUSys.Status)
            {
                case AUCheckStatus.IsLatest:
                case AUCheckStatus.UpdateAvailable:
                    string[] List = GetUpdateAvailableList();
                    foreach (string item in List)
                    {
                        if (item == EnumTranslator.AutoUpdateChannelT(AUC))
                        {
                            return EnumTranslator.AUCheckStatusT(AUCheckStatus.UpdateAvailable);
                        }
                    }
                    return EnumTranslator.AUCheckStatusT(AUCheckStatus.IsLatest);
                default:
                    return EnumTranslator.AUCheckStatusT(AUSys.Status);
            }
        }

        public string[] GetUpdateAvailableList()
        {
            AUSys.Data.FileList.Clear();

            for (int i = 1; i < AUSys.Data.Local.Length; i += 2)
            {
                try
                {
                    if (Convert.ToInt32(AUSys.Data.Network[i]) > Convert.ToInt32(AUSys.Data.Local[i]))
                    {
                        AUSys.Data.FileList.Add(AUSys.Data.Network[i - 1]);
                    }
                }
                catch (FormatException) {
                    Version NetworkVer = new Version(AUSys.Data.Network[i]);
                    Version LocalVer = new Version(AUSys.Data.Local[i]);
                    if (NetworkVer > LocalVer)
                    {
                        AUSys.Data.FileList.Add(AUSys.Data.Network[i - 1]);
                    }
                }
                catch (Exception)
                {
                    
                }
            }

            return AUSys.Data.FileList.ToArray();
        }
        //-------------------------------------Inner Function
        private void SetProperties(Uri NetworkData, string LocalData, string Delimeters)
        {
            //初始化資料清單
            AUSys.Data.FileList = new List<string>();
            AUSys.Data.LocalList = new List<string>();
            AUSys.Data.NetworkList = new List<string>();
            AUSys.Version.LocalList = new List<string>();
            AUSys.Version.NetworkList = new List<string>();

            //設定字元分隔子
            AUSys.Delimeters = Delimeters;

            //設定檔案在網路上的URL
            AUSys.Location.Network = NetworkData;

            //設定本地比對檔案的位址。
            AUSys.Location.Local = LocalData;

            //設定從網路上下載版本號碼檔案的時候的存放路徑。
            AUSys.Location.NetworkDL = My.FileSystem.GetTempFileName();

            //初始化表格解析介面。
            AUSys.Parser.Local = new TextFieldParser(AUSys.Location.Local);
            AUSys.Parser.Local.SetDelimiters(AUSys.Delimeters);
            AUSys.Parser.Network = new TextFieldParser(AUSys.Location.NetworkDL);
            AUSys.Parser.Network.SetDelimiters(AUSys.Delimeters);
        }
        
        private void DownLoadFileOnline()
        {
            if (Extent.HaveConnection())
            {
                try
                {
                    Web.DownloadFileAsync(AUSys.Location.Network, AUSys.Location.NetworkDL);
                }
                catch (Exception)
                {
                    AUSys.Status = AUCheckStatus.CheckFailed;
                }
            } else
            {
                AUSys.Status = AUCheckStatus.NoConnection;
                FileDownloadCompleted();
            }
        }

        private void FileDownloadCompleted()
        {
            try
            {
                SetDataToArray(AUSetDataTarget.Local);
                SetDataToArray(AUSetDataTarget.Network);
                if (CheckSucceed != null)
                {
                    CheckSucceed(this, EventArgs.Empty);
                }
            }
            catch (Exception)
            {
                AUSys.Status = AUCheckStatus.CheckFailed;
                if (CheckFailed != null)
                {
                    CheckFailed(this, EventArgs.Empty); ;
                }
            }
            SetStatusAndVersionToData(Extent.HaveConnection());

            StatusLog.Log(Description + RMain.Log_CheckComplete + GetStatusString());
            if (CheckCompleted != null)
            {
                CheckCompleted(this, EventArgs.Empty); ;
            }
        }

        private void SetDataToArray(AUSetDataTarget AUST)
        {
            switch (AUST)
            {
                case AUSetDataTarget.Local:
                    AUSys.Data.LocalList.Clear();

                    AUSys.Parser.Local = new TextFieldParser(AUSys.Location.Local);
                    AUSys.Parser.Local.SetDelimiters(AUSys.Delimeters);

                    while (!AUSys.Parser.Local.EndOfData)
                    {
                        AUSys.Data.LocalList.AddRange(AUSys.Parser.Local.ReadFields());
                    }
                    AUSys.Data.Local = AUSys.Data.LocalList.ToArray();
                    break;
                case AUSetDataTarget.Network:
                    AUSys.Data.NetworkList.Clear();

                    AUSys.Parser.Network = new TextFieldParser(AUSys.Location.NetworkDL);
                    AUSys.Parser.Network.SetDelimiters(AUSys.Delimeters);

                    while (!AUSys.Parser.Network.EndOfData)
                    {
                        AUSys.Data.NetworkList.AddRange(AUSys.Parser.Network.ReadFields());
                    }
                    AUSys.Data.Network = AUSys.Data.NetworkList.ToArray();
                    break;
            }
        }

        private void SetStatusAndVersionToData(bool HaveConnection)
        {
            AUSys.Version.NetworkList.Clear();
            AUSys.Version.LocalList.Clear();

            for (int i = 1; i <= AUSys.Data.Local.Length; i += 2)
            {
                try
                {
                    AUSys.Version.NetworkList.Add(AUSys.Data.Network[i]);
                }
                catch (Exception)
                {
                    AUSys.Version.NetworkList.Add(AUSys.Data.Local[i]);
                    continue;
                }
                
                AUSys.Version.LocalList.Add(AUSys.Data.Local[i]);

                int NetWorkVersionIsLarger;
                if (HaveConnection)
                {
                    try
                    {
                        NetWorkVersionIsLarger = Convert.ToInt32(Convert.ToInt64(AUSys.Data.Network[i]) > Convert.ToInt64(AUSys.Data.Local[i])) + 1;
                    }
                    catch (FormatException)
                    {
                        Version NetVer = new Version(AUSys.Data.Network[i]);
                        Version LocalVer = new Version(AUSys.Data.Local[i]);
                        NetWorkVersionIsLarger = Convert.ToInt32(NetVer > LocalVer) + 1;
                    }
                    catch (Exception)
                    {
                        NetWorkVersionIsLarger = -1;
                    }
                } else
                {
                    NetWorkVersionIsLarger = -2;
                }

                if (AUSys.Status != AUCheckStatus.UpdateAvailable)
                {
                    AUSys.Status = (AUCheckStatus)NetWorkVersionIsLarger;
                } else
                {
                    continue;
                }
            }

            AUSys.Version.Network = AUSys.Version.NetworkList.ToArray();
            AUSys.Version.Local = AUSys.Version.LocalList.ToArray();
        }
    }
}
