using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using SAOCR_Data_Manager.APIs;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Resources.Module;
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
    public class Downloader
    {
        Computer My = new Computer();
        WebClient Web = new WebClient();
        DLSystemObjects DLData = new DLSystemObjects();
        Timer timer = new Timer();

        public bool CreateSucceed;

        public event EventHandler PropertySetComplete, DownloadBegin, DownloadSucceed, DownloadFailed, DownloadCancelled, DownloadCompleted, InfoUpdated, InfoUpdatedWithDelay;

        #region Init Section
        public Downloader(Uri NetworkLocation, string LocalLocation, SizeUnit DLSizeUnit, string Description)
        {
            Uri[] URL = { NetworkLocation };
            string[] Local = { LocalLocation };
            CommonInitialize(URL, Local, DLSizeUnit, null, null, Description);
        }

        public Downloader(Uri[] NetworkLocation, string[] LocalLocation, SizeUnit DLSizeUnit, string Description)
        {
            CommonInitialize(NetworkLocation, LocalLocation, DLSizeUnit, null, null, Description);
        }

        public Downloader(Uri NetworkLocation, string LocalLocation, SizeUnit DLSizeUnit, Uri NetVer, string LocalVer, string Description)
        {
            Uri[] URL = { NetworkLocation };
            string[] Local = { LocalLocation };
            CommonInitialize(URL, Local, DLSizeUnit, NetVer, LocalVer, Description);
        }

        public Downloader(Uri[] NetworkLocation, string[] LocalLocation, SizeUnit DLSizeUnit, Uri NetVer, string LocalVer, string Description)
        {
            CommonInitialize(NetworkLocation, LocalLocation, DLSizeUnit, NetVer, LocalVer, Description);
        }

        public void CommonInitialize(Uri[] NetworkLocation, string[] LocalLocation, SizeUnit DLSizeUnit, Uri NetVer, string LocalVer, string Description)
        {
            try
            {
                foreach (string item in LocalLocation)
                {
                    if (My.FileSystem.FileExists(item))
                    {
                        FileAttributes attr = File.GetAttributes(item);
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            SystemAPI.Warning(RWarning.W_0xC0025000 + item);
                            CreateSucceed = false;
                            return;
                        }
                    }
                }
                DLData.Location.NetworkVer = NetVer;
                DLData.Location.LocalVer = LocalVer;

                DLData.Info.Description = Description;

                DLData.Location.NetworkList = new List<Uri>();
                DLData.Location.LocalList = new List<string>();

                timer.Tick += new EventHandler(UpdateSpeed);
                timer.Interval = 500;

                DLData.Info.DLSizeUnit = DLSizeUnit;
                DLData.Location.NetworkList.AddRange(NetworkLocation);
                DLData.Location.LocalList.AddRange(LocalLocation);

                DLData.Location.Network = DLData.Location.NetworkList.ToArray();
                DLData.Location.Local = DLData.Location.LocalList.ToArray();

                DLData.Count.Items = DLData.Location.Local.Length;

                DLData.Location.NetworkDLing = DLData.Location.Network[DLData.Count.Current];
                DLData.Location.LocalDLing = DLData.Location.Local[DLData.Count.Current];

                DLData.Status = DLStatus.Ready;
                Web.DownloadFileCompleted += DLCompleted;
                Web.DownloadProgressChanged += DLProgressChanged;

                DLData.TempForSpeed = new List<long>();

                PropertySetComplete?.Invoke(this, EventArgs.Empty);

                CreateSucceed = true;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00025000, e);
                throw;
            }
        }
        #endregion

        public void DLStart()
        {
            try
            {
                if (Extent.HaveConnection())
                {
                    DownloadBegin?.Invoke(this, EventArgs.Empty);

                    timer.Enabled = true;
                    timer.Start();
                    DLData.Status = DLStatus.Downloading;
                    DLData.Count.Current = 0;
                    DLData.Location.NetworkDLing = DLData.Location.Network[DLData.Count.Current];
                    DLData.Location.LocalDLing = DLData.Location.Local[DLData.Count.Current];

                    try
                    {
                        if (!My.FileSystem.DirectoryExists(Path.GetDirectoryName(DLData.Location.LocalDLing)))
                        {
                            My.FileSystem.CreateDirectory(Path.GetDirectoryName(DLData.Location.LocalDLing));
                        }
                        Web.DownloadFileAsync(DLData.Location.NetworkDLing, DLData.Location.LocalDLing);
                    }
                    catch (Exception)
                    {
                        StatusLog.Log(RDownloader.Log_DownloadFailed);
                        DLData.Status = DLStatus.DownloadFailed;
                        DownloadFailed?.Invoke(this, EventArgs.Empty);
                        DownloadCompleted?.Invoke(this, EventArgs.Empty);
                    }
                }
                else
                {
                    DLData.Status = DLStatus.NoConnection;
                    DownloadFailed?.Invoke(this, EventArgs.Empty);
                    DownloadCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00025002, e);
                throw;
            }
        }
        
        public void DLCancel()
        {
            try
            {
                Web.DownloadFileCompleted -= DLCompleted;
                Web.DownloadFileCompleted += DLCompleted_Cancel;
                Web.CancelAsync();
                DLData.Status = DLStatus.DownloadCancelled;
                StatusLog.Log(RDownloader.Log_DownloadCancelled);

                if (My.FileSystem.FileExists(DLData.Location.LocalDLing))
                {
                    My.FileSystem.DeleteFile(DLData.Location.LocalDLing);
                }
            }
            catch (IOException)
            {
                if (My.FileSystem.FileExists(DLData.Location.LocalDLing))
                {
                    My.FileSystem.DeleteFile(DLData.Location.LocalDLing);
                }
                StatusLog.Log(RDownloader.Log_RetryToDelete + DLData.Location.LocalDLing);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00025003, e);
                throw;
            }
        }

        private void DLCompleted_Cancel(object sender, EventArgs e)
        {
            try
            {
                DownloadCancelled?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00025004, ex);
                throw;
            }
        }
        
        public string GetDLInfo(DLInfoCategory DLIC)
        {
            try
            {
                switch (DLIC)
                {
                    case DLInfoCategory.ItemPercentage:
                        return DLData.Info.Percent.ToString("0.00") + "%";
                    case DLInfoCategory.SizeReceived:
                        return (DLData.Info.BytesReceived / (int)DLData.Info.DLSizeUnit).ToString() + " " + EnumTranslator.SizeUnitT(DLData.Info.DLSizeUnit, false);
                    case DLInfoCategory.TotalSize:
                        return (DLData.Info.TotalBytes / (int)DLData.Info.DLSizeUnit).ToString() + " " + EnumTranslator.SizeUnitT(DLData.Info.DLSizeUnit, false);
                    case DLInfoCategory.Speed:
                        return DLData.Info.Speed.ToString("0.00") + " " + EnumTranslator.SizeUnitT(DLData.Info.DLSizeUnit, false) + "/s";
                    case DLInfoCategory.CurrentCount:
                        return DLData.Count.Current.ToString();
                    case DLInfoCategory.TotalItems:
                        return DLData.Count.Items.ToString();
                    case DLInfoCategory.TotalPercentage:
                        return ((double)DLData.Count.Current / DLData.Count.Items * 100).ToString("0.00") + "%";
                    case DLInfoCategory.Description:
                        return DLData.Info.Description;
                    case DLInfoCategory.Status:
                        return GetStatusString();
                    default:
                        throw new ArgumentException(RError.E_0x00025006);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00025005 + DLIC.ToString(), ex);
                throw;
            }
        }
        
        public bool isDownloading()
        {
            if (DLData.Status == DLStatus.Downloading)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string GetStatusString()
        {
            return EnumTranslator.DLStatusT(DLData.Status);
        }

        public DLStatus Status
        {
            get { return DLData.Status; }
        }
        
        public string GetFileLocation(DataSource DS)
        {
            switch (DS)
            {
                case DataSource.Local:
                    return DLData.Location.LocalDLing;
                case DataSource.Network:
                    return DLData.Location.NetworkDLing.ToString();
                default:
                    SystemAPI.Warning(RWarning.W_0xC0025001);
                    return null;
            }
        }
        
        private void DLProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DLData.Status = DLStatus.Downloading;
            DLData.Info.BytesReceived = e.BytesReceived;
            DLData.Info.TotalBytes = e.TotalBytesToReceive;
            DLData.Info.Percent = Math.Round((double)DLData.Info.BytesReceived / DLData.Info.TotalBytes * 100, 2);
            InfoUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void DLCompleted(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;

            DLData.Count.Current++;

            if (DLData.Count.Current < DLData.Count.Items)
            {
                DLData.Location.NetworkDLing = DLData.Location.Network[DLData.Count.Current];
                DLData.Location.LocalDLing = DLData.Location.Local[DLData.Count.Current];
                timer.Enabled = true;
                timer.Start();
                StatusLog.Log(RDownloader.Log_ASyncDownload1 + DLData.Location.NetworkDLing + RDownloader.Log_ASyncDownload2 + DLData.Location.NetworkDLing);
                Web.DownloadFileAsync(DLData.Location.NetworkDLing, DLData.Location.LocalDLing);
            }
            else
            {
                foreach (string file in DLData.Location.Local)
                {
                    if (!My.FileSystem.FileExists(file))
                    {
                        DLData.Status = DLStatus.DownloadInCompleted;
                        break;
                    } 
                }
                if (DLData.Status != DLStatus.DownloadInCompleted)
                {
                    Web.DownloadFileCompleted -= DLCompleted;
                    if (DLData.Location.NetworkVer != null && DLData.Location.LocalVer != null)
                    {
                        using (WebClient WC = new WebClient())
                        {
                            WC.DownloadFileAsync(DLData.Location.NetworkVer, DLData.Location.LocalVer);
                        } 
                    }
                    DLData.Status = DLStatus.DownloadSucceed;
                    DownloadSucceed?.Invoke(this, EventArgs.Empty);
                }
                DownloadCompleted?.Invoke(this, EventArgs.Empty);
                StatusLog.Log(RDownloader.Log_DownloadSucceed1 + DLData.Count.Items + RDownloader.Log_DownloadSucceed2 + DLData.Info.Speed);
            }
        }

        private void UpdateSpeed(object sender, EventArgs e)
        {
            DLData.TempForSpeed.Add(DLData.Info.BytesReceived);
            if (DLData.TempForSpeed.Count > Const.SPEED_BUFFER)
            {
                DLData.TempForSpeed.RemoveAt(0);
            }

            DLData.Info.Speed = (double)(DLData.TempForSpeed.Max() - DLData.TempForSpeed.Min()) / (Const.SPEED_BUFFER * timer.Interval);

            InfoUpdatedWithDelay?.Invoke(this, EventArgs.Empty);
        }
    }
}
