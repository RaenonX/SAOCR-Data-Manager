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
using SAOCR_Data_Manager.Resources;
using System.Drawing.Imaging;
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void MN_Button_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Text == RMain.Layout_CheckLog)
                {
                    StatusLog.Open();
                }
                else if (e.ClickedItem.Text == RMain.Layout_CheckProgramAnnouncements)
                {
                    Process.Start(Application.StartupPath + "/" + Const.Path.ANNOUNCEMENT);
                }
                else if (e.ClickedItem.Text == RMain.Layout_ViewCaptureFolder)
                {
                    Process.Start(Application.StartupPath + "/" + Const.Path.SCREENSHOT);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00020001 + e.ClickedItem.Text, ex);
                throw;
            }
        }

        private void MN_Capture_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap BMP = new Bitmap(Size.Width, Size.Height, PixelFormat.Format32bppArgb);
                Graphics Graphic = Graphics.FromImage(BMP);

                Point P = new Point(0, 0);
                Graphic.CopyFromScreen(Location, P, Size, CopyPixelOperation.SourceCopy);
                Status(RMain.Log_Captured);

                LastCaptureName = DateTime.Now.ToString(Const.FORMAT_DATETIME_NOW);
                BMP.Save(Const.Path.SCREENSHOT + Const.Path.SCREENSHOT_NAME + LastCaptureName + ".png", ImageFormat.Png);
                Status(RMain.Log_CaptureSaved + LastCaptureName);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00020002, ex);
                throw;
            }
        }
    }
}
