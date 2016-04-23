using Microsoft.VisualBasic.Devices;
using SAOCR_Data_Manager.APIs;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public class SystemAPI
    {
        /// <summary>
        /// 關閉程式。
        /// </summary>
        public static void CloseProgram(bool Normal)
        {
            if (Normal)
            {
                StatusLog.Delete();
            }
           
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }

        /// <summary>
        /// 關閉視窗。
        /// </summary>
        /// <param name="FM">要關閉的表單。</param>
        public static void CloseWindow(Form FM)
        {
            FM.Close();
        }

        /// <summary>
        /// 視窗最小化。
        /// </summary>
        public static void MinimizeProgram(Form FM)
        {
            FM.WindowState = FormWindowState.Minimized;
        }

        public static void RestartProgram(bool Normal)
        {
            if (Normal)
            {
                StatusLog.Delete();
            }
            Application.Restart();
        }

        public static void MoveWindow_MouseDown(int Left, int Top, int X, int Y, ref WindowPosition Pos)
        {
            Pos.LEFT = Left;
            Pos.TOP = Top;
            Pos.X = X;
            Pos.Y = Y;
        }

        public static void MoveWindow_MouseMove(int Left, int Top, int X, int Y, ref WindowPosition Pos, Form ActiveForm)
        {
            ActiveForm.Top = Y + Pos.TOP - Pos.Y;
            ActiveForm.Left = X + Pos.LEFT - Pos.X;
            Pos.LEFT = FMain.ActiveForm.Left;
            Pos.TOP = FMain.ActiveForm.Top;
        }

        /// <summary>
        /// 畫上橘色的邊框。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DrawBorderCoral(object sender, PaintEventArgs e)
        {
            Rectangle BorderRect = (sender as Control).ClientRectangle;
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle, Color.Coral, ButtonBorderStyle.Solid);
        }

        /// <summary>
        /// 畫上白色的邊框。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DrawBorderWhite(object sender, PaintEventArgs e)
        {
            Rectangle BorderRect = (sender as Control).ClientRectangle;
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        public static void SEWarning()
        {
            try
            {
                UserConfig config = new UserConfig();
                if (config.SE_WarningMute == false)
                {
                    FMain.WMPO.Warning.URL = config.SE_Warning;
                    FMain.WMPO.Warning.Ctlcontrols.play();
                }
            }
            catch (Exception e)
            {
                Error(RError.E_0x0000C001, e);
                throw;
            }
        }

        public static void SEBeep()
        {
            try
            {
                UserConfig config = new UserConfig();
                if (!config.SE_BeepMute)
                {
                    FMain.WMPO.Beep.URL = config.SE_Beep;
                    FMain.WMPO.Beep.Ctlcontrols.play();
                }
            }
            catch (Exception e)
            {
                Error(RError.E_0x0000C002, e);
                throw;
            }
        }

        public static void SEMessage()
        {
            try
            {
                UserConfig config = new UserConfig();
                if (!config.SE_MessageMute)
                {
                    FMain.WMPO.Message.URL = config.SE_Message;
                    FMain.WMPO.Message.Ctlcontrols.play();
                }
            }
            catch (Exception e)
            {
                Error(RError.E_0x0000C003, e);
                throw;
            }
        }

        public static void Error(string ErrorMessage, Exception e = null)
        {
            if (FMain.WMPO.isGateOpen)
            {
                UserConfig config = new UserConfig();

                StatusLog.Log(RMain.Log_Error + " " + e.GetType().ToString() + " " + ErrorMessage, ELogCategory.Error);
                SEWarning();

                ErrorMessage = ErrorMessage.Replace("\\r", "\r").Replace("\\n", "\n");
                ErrorMessage += "\n" + RError.Error_ProgramRestart;

                string ExMessage = e.Message.Replace("\r\n", " | "), Title;


                if (e == null)
                {
                    Title = RError.Error;
                }
                else
                {
                    Title = e.GetType().ToString();
                }

                FMain.WMPO.Timer.Enabled = true;
                FMain.WMPO.Timer.Start();
                FMain.WMPO.isGateOpen = false;
                switch (new MessageDialog(ErrorMessage, ExMessage, Title, MessageBoxButtonStyle.YesNo).ShowDialog())
                {
                    case DialogResult.Yes:
                        if (!config.DebugMode)
                        {
                            RestartProgram(false);
                        }
                        break;
                    case DialogResult.No:
                        if (!config.DebugMode)
                        {
                            CloseProgram(false);
                        }
                        break;
                }
                

                
               
            }
        }

        public static void Warning(string WarnMessage)
        {
            if (FMain.WMPO.isGateOpen)
            {
                StatusLog.Log(RMain.Log_Warning + " " + WarnMessage, ELogCategory.Warning);
                SEWarning();
                WarnMessage = WarnMessage.Replace("\\r", "\r").Replace("\\n", "\n");
                new MessageDialog(WarnMessage, RWarning.Warning).ShowDialog();
                FMain.WMPO.Timer.Enabled = true;
                FMain.WMPO.Timer.Start();
                FMain.WMPO.isGateOpen = false;
            }
        }
    }
}
