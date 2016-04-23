using Microsoft.VisualBasic.Devices;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager.Forms
{
    public partial class PictureB : Form
    {
        WindowPosition WndPos = new WindowPosition();
        UserConfig config = new UserConfig();
        Computer My = new Computer();

        public PictureB()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00015001, e);
                throw;
            }
        }

        public void InitializeUIText()
        {
            try
            {
                Sys_Close.ButtonText = RMain.Layout_CloseProg;
                Sys_Min.ButtonText = RMain.Layout_Minimum;

                Title.Text = RPicture.Layout_Title;
                Save.ButtonText = RPicture.Layout_Save;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00015002, e);
                throw;
            }
        }

        public void InitializeEventHandler()
        {
            try
            {
                Sys_Close.ButtonClick += new EventHandler((sender, e) => SystemAPI.CloseWindow(this));
                Sys_Min.ButtonClick += new EventHandler((sender, e) => SystemAPI.MinimizeProgram(this));

                Border.Paint += new PaintEventHandler(SystemAPI.DrawBorderCoral);

                PictureBox.LoadCompleted += new AsyncCompletedEventHandler(PictureBox_LoadCompleted);

                Title.MouseMove += new MouseEventHandler(MoveWindow_MouseMove);
                Title.MouseDown += new MouseEventHandler(MoveWindow_MouseDown);

                Save.ButtonClick += new EventHandler(Save_ButtonClick);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00015003, e);
                throw;
            }
        }

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SystemAPI.MoveWindow_MouseDown(Left, Top, e.X, e.Y, ref WndPos);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00015004, ex);
                throw;
            }
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                if (lbl.Capture == true)
                {
                    SystemAPI.MoveWindow_MouseMove(Left, Top, e.X, e.Y, ref WndPos, this);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00015005, ex);
                throw;
            }
        }

        private void Save_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog.InitialDirectory = config.Path_Download;
                SaveFileDialog.FileName = Title.Text;
                SaveFileDialog.ShowDialog(this);

                if (!Extent.isEmptyString(SaveFileDialog.FileName))
                {
                    FileStream FS = (FileStream)SaveFileDialog.OpenFile();
                    PictureBox.Image.Save(FS, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    SystemAPI.Warning(RWarning.W_0xC0015001);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00015006, ex);
                throw;
            }
        }

        private void PictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Save.ButtonEnabled = true;
        }
    }
}
