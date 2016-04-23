using Microsoft.VisualBasic.Devices;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager.APIs
{
    public static class StatusLog
    {
        public static void InitializeLog()
        {
            try
            {
                Computer My = new Computer();
                if (!My.FileSystem.FileExists(FMain.LogPath))
                {
                    if (!My.FileSystem.DirectoryExists(My.FileSystem.GetParentPath(FMain.LogPath)))
                    {
                        Directory.CreateDirectory(My.FileSystem.GetParentPath(FMain.LogPath));
                    }
                    FileStream fileStream = new FileStream(FMain.LogPath, FileMode.Create);
                    fileStream.Close();   
                }

                string[] TextToWrite = 
                {
                    Const.Log.TITLE + DateTime.Now,
                    null,
                    Const.Log.PROGRAM_VERSION + Assembly.GetEntryAssembly().GetName().Version.ToString() + " " + Application.ProductVersion,
                    null,
                    Const.Log.NETWORK_AVAILABLE + Extent.HaveConnection().ToString(),
                    Const.Log.SEPARATOR
                };
                foreach (string Text in TextToWrite)
                {
                    My.FileSystem.WriteAllText(FMain.LogPath, Text + "\r\n", true);
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001D002, e);
                throw;
            }
        }

        public static void Log(string Message)
        {
            try
            {
                Log(Message, ELogCategory.Info);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001D003, e);
                throw;
            }
        }

        public static void Log(string Message, ELogCategory ELC)
        {
            try
            {
                Computer My = new Computer();

                My.FileSystem.WriteAllText(FMain.LogPath, "[" + EnumTranslator.LogCategoryT(ELC) + "] " + DateTime.Now + " - " + Message + "\r\n", true);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001D004, e);
                throw;
            }
        }

        public static void Clear()
        {
            try
            {
                Computer My = new Computer();

                My.FileSystem.WriteAllText(FMain.LogPath, "", false);
                InitializeLog();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001D005, e);
                throw;
            }
        }

        public static void Delete()
        {
            try
            {
                Computer My = new Computer();

                My.FileSystem.DeleteFile(FMain.LogPath);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001D006, e);
                throw;
            }
        }

        public static void Open()
        {
            try
            {
                Process.Start(FMain.LogPath);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001D007, e);
                throw;
            }
        }
    }
}
