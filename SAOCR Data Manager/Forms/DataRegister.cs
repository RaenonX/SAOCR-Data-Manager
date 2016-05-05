using SAOCR_Data_Manager.Resources;
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

namespace SAOCR_Data_Manager.Controls.BA_Display
{
    public partial class DataRegister : Form
    {
        WindowPosition WndPos = new WindowPosition();

        public DataRegister()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C002, ex);
                throw;
            }
        }

        private void InitializeUIText()
        {
            try
            {
                Sys_Close.ButtonText = RMain.Layout_CloseProg;
                Sys_Min.ButtonText = RMain.Layout_Minimum;


            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C003, ex);
                throw;
            }
        }

        private void InitializeEventHandler()
        {
            try
            {
                Sys_Close.ButtonClick += new EventHandler((sender, e) => SystemAPI.CloseWindow(this));
                Sys_Min.ButtonClick += new EventHandler((sender, e) => SystemAPI.MinimizeProgram(this));
                Title.MouseMove += new MouseEventHandler(MoveWindow_MouseMove);
                Title.MouseDown += new MouseEventHandler(MoveWindow_MouseDown);

                Border.Paint += SystemAPI.DrawBorderCoral;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002C004, ex);
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
                SystemAPI.Error(RError.E_0x0002C000, ex);
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
                SystemAPI.Error(RError.E_0x0002C001, ex);
                throw;
            }
        }
    }
}
