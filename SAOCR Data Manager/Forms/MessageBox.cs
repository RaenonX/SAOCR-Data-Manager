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
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager
{
    public partial class MessageDialog : System.Windows.Forms.Form
    {
        Computer My = new Computer();
        WindowPosition WndPos = new WindowPosition();
        Downloader DL;
        bool restart;

        public MessageDialog(string msg, string caption, MessageBoxButtonStyle Button, float FontSize)
        {
            try
            {
                Initialize(msg, "", caption, Button, FontSize, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023001, e);
                throw;
            }
        }

        public MessageDialog(string msg, string exMsg, string caption, MessageBoxButtonStyle Button)
        {
            try
            {
                Initialize(msg, exMsg, caption, Button, 12.5f, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023002, e);
                throw;
            }
        }

        public MessageDialog(string msg, MessageBoxButtonStyle Button, Downloader DL, bool Restart)
        {
            try
            {
                restart = Restart;
                Initialize(msg, "", "SAOCR Data Manager", Button, 12.5f, DL);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023003, e);
                throw;
            }
        }

        public MessageDialog(string msg, MessageBoxButtonStyle Button)
        {
            try
            {
                Initialize(msg, "", "SAOCR Data Manager", Button, 12.5f, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023003, e);
                throw;
            }
        }

        public MessageDialog(string msg, string exMsg, MessageBoxButtonStyle Button)
        {
            try
            {
                Initialize(msg, exMsg, "SAOCR Data Manager", Button, 12.5f, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023004, e);
                throw;
            }
        }

        public MessageDialog(string msg, string exMsg, string caption)
        {
            try
            {
                Initialize(msg, exMsg, caption, MessageBoxButtonStyle.OK, 12.5f, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023005, e);
                throw;
            }
        }

        public MessageDialog(string msg, string caption, float FontSize)
        {
            try
            {
                Initialize(msg, "", caption, MessageBoxButtonStyle.OK, FontSize, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023006, e);
                throw;
            }
        }

        public MessageDialog(string msg, string caption)
        {
            try
            {
                Initialize(msg, "", caption, MessageBoxButtonStyle.OK, 12.5f, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023009, e);
                throw;
            }
        }

        public MessageDialog(string msg)
        {
            try
            {
                Initialize(msg, "", "SAOCR Data Manager", MessageBoxButtonStyle.OK, 12.5f, null);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023007, e);
                throw;
            }
        }

        public void Initialize(string msg, string exMsg, string caption, MessageBoxButtonStyle Button, float FontSize, Downloader DLer)
        {
            try
            {
                InitializeComponent();

                if (Button == MessageBoxButtonStyle.Downlaoder)
                {
                    SpeedText.Text = RMessageBox.Layout_Speed;
                    FileSizeText.Text = RMessageBox.Layout_Size;
                    DownloadUI.Visible = true;
                    DLMessage.Text = msg;
                    DL = DLer;
                }
                else if (!Extent.isEmptyString(exMsg))
                {
                    ExMessage.Visible = true;
                    ExMessage.Marquee();
                    ExMessage.MarqueeText = exMsg;
                    Message.Size = new Size(560, 103);
                }

                InitializeEventHandler();

                Message.Text = msg;
                Title.Text = caption;
                ButtonStyleSelector(Button);

                Sys_Min.ButtonText = RMain.Layout_Minimum;
                Sys_Close.ButtonText = RMain.Layout_CloseProg;

                Font F = new Font(Message.Font.FontFamily, FontSize);
                Message.Font = F;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00023008, e);
                throw;
            }
        }

        public void InitializeEventHandler()
        {
            try
            {
                Border.Paint += new PaintEventHandler(SystemAPI.DrawBorderCoral);

                Title.MouseMove += new MouseEventHandler(MoveWindow_MouseMove);
                Title.MouseDown += new MouseEventHandler(MoveWindow_MouseDown);

                if (DL != null)
                {
                    DL.DownloadBegin += DL_DownloadBegin;
                    DL.DownloadCompleted += DL_DownloadCompleted;
                    DL.InfoUpdated += DL_InfoUpdated;
                    timer.Tick += DL_RefreshInfo;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002300A, e);
                throw;
            }
        }

        private void DL_InfoUpdated(object sender, EventArgs e)
        {
            try
            {
                if (DL.Status == DLStatus.Downloading)
                {
                    ProgressSingle.Value = (int)Convert.ToDouble(DL.GetDLInfo(DLInfoCategory.ItemPercentage).Replace("%", ""));
                    ProgressAll.Value = (int)Convert.ToDouble(DL.GetDLInfo(DLInfoCategory.TotalPercentage).Replace("%", ""));
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023017, ex);
                throw;
            }
        }

        private void DL_RefreshInfo(object sender, EventArgs e)
        {
            try
            {
                Title.Text = DL.GetStatusString() + DL.GetDLInfo(DLInfoCategory.ItemPercentage) + " (" + DL.GetDLInfo(DLInfoCategory.CurrentCount) + "/" + DL.GetDLInfo(DLInfoCategory.TotalItems) + ")";
                DLMessage.Text = DL.GetStatusString();
                DLMessage.Text += "\n" + RMessageBox.Layout_DownloadItems1 + DL.GetDLInfo(DLInfoCategory.TotalItems) + RMessageBox.Layout_DownloadItems2 + DL.GetDLInfo(DLInfoCategory.CurrentCount) + "/" + DL.GetDLInfo(DLInfoCategory.TotalItems) + " (" + DL.GetDLInfo(DLInfoCategory.TotalPercentage) + ")";
                FileSize.Text = DL.GetDLInfo(DLInfoCategory.SizeReceived) + " / " + DL.GetDLInfo(DLInfoCategory.TotalSize) + " (" + DL.GetDLInfo(DLInfoCategory.ItemPercentage) + ")";
                Speed.Text = DL.GetDLInfo(DLInfoCategory.Speed);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023016, ex);
                throw;
            }
        }

        private void DL_DownloadCompleted(object sender, EventArgs e)
        {
            try
            {
                Button_Right.Enabled = true;
                Button_Left.Enabled = false;

                DL_InfoUpdated(sender, e);
                DL_RefreshInfo(sender, e);

                if (DL.GetDLInfo(DLInfoCategory.Description) == FMain.URLs[(int)EPathRowCode.PROGRAM_DESCRIPTION] && DL.Status == DLStatus.DownloadSucceed)
                {
                    Button_Right.ButtonText = RMessageBox.Cmd_Install;
                    Button_Right.ButtonClick -= new EventHandler(StartDownload);
                    Button_Right.ButtonClick += new EventHandler(StartProgress);
                }
                else if (restart && DL.Status == DLStatus.DownloadSucceed)
                {
                    Button_Right.ButtonText = RMessageBox.Cmd_Restart;
                    Button_Right.ButtonClick -= new EventHandler(StartDownload);
                    Button_Right.ButtonClick += new EventHandler(RestartProgram);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023015, ex);
                throw;
            }
        }

        private void DL_DownloadBegin(object sender, EventArgs e)
        {
            try
            {
                Button_Right.Enabled = false;
                Button_Left.Enabled = true;

                timer.Enabled = true;
                timer.Start();

                Title.Text = DL.GetStatusString() + DL.GetDLInfo(DLInfoCategory.ItemPercentage);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023014, ex);
                throw;
            }
        }

        public MessageBoxButtonStyle ButtonStyleSelector(MessageBoxButtonStyle Button)
        {
            try
            {
                switch (Button)
                {
                    case MessageBoxButtonStyle.OK:
                        Button_Left.Visible = false;
                        Button_Center.Visible = false;
                        Button_Right.Visible = true;

                        Button_Right.ButtonText = RMessageBox.Cmd_OK;
                        Button_Right.ButtonClick += new EventHandler(ResOK);
                        AcceptButton = Button_Right.Btn;
                        CancelButton = Sys_Close.Btn;

                        return MessageBoxButtonStyle.OK;

                    case MessageBoxButtonStyle.OKCancel:
                        Button_Left.Visible = true;
                        Button_Center.Visible = false;
                        Button_Right.Visible = true;

                        Button_Left.ButtonText = RMessageBox.Cmd_Cancel;
                        Button_Right.ButtonText = RMessageBox.Cmd_OK;

                        Button_Left.ButtonClick += new EventHandler(ResCancel);
                        Button_Right.ButtonClick += new EventHandler(ResOK);
                        AcceptButton = Button_Right.Btn;
                        CancelButton = Button_Left.Btn;

                        return MessageBoxButtonStyle.OKCancel;

                    case MessageBoxButtonStyle.YesNoCancel:
                        Button_Left.Visible = true;
                        Button_Center.Visible = true;
                        Button_Right.Visible = true;

                        Button_Left.ButtonText = RMessageBox.Cmd_Yes;
                        Button_Center.ButtonText = RMessageBox.Cmd_No;
                        Button_Right.ButtonText = RMessageBox.Cmd_Cancel;

                        Button_Left.ButtonClick += new EventHandler(ResYes);
                        Button_Center.ButtonClick += new EventHandler(ResNo);
                        Button_Right.ButtonClick += new EventHandler(ResOK);
                        AcceptButton = Button_Left.Btn;
                        CancelButton = Button_Right.Btn;

                        return MessageBoxButtonStyle.YesNoCancel;

                    case MessageBoxButtonStyle.RetryCancel:
                        Button_Left.Visible = true;
                        Button_Center.Visible = true;
                        Button_Right.Visible = false;

                        Button_Left.ButtonText = RMessageBox.Cmd_Retry;
                        Button_Center.ButtonText = RMessageBox.Cmd_Cancel;

                        Button_Left.ButtonClick += new EventHandler(ResRetry);
                        Button_Center.ButtonClick += new EventHandler(ResCancel);
                        AcceptButton = Button_Left.Btn;
                        CancelButton = Sys_Close.Btn;

                        return MessageBoxButtonStyle.RetryCancel;

                    case MessageBoxButtonStyle.YesNo:
                        Button_Left.Visible = true;
                        Button_Center.Visible = false;
                        Button_Right.Visible = true;

                        Button_Left.ButtonText = RMessageBox.Cmd_No;
                        Button_Right.ButtonText = RMessageBox.Cmd_Yes;

                        Button_Left.ButtonClick += new EventHandler(ResNo);
                        Button_Right.ButtonClick += new EventHandler(ResYes);
                        AcceptButton = Button_Right.Btn;
                        CancelButton = Button_Left.Btn;

                        return MessageBoxButtonStyle.RetryCancel;

                    case MessageBoxButtonStyle.Downlaoder:
                        Button_Left.Visible = true;
                        Button_Center.Visible = false;
                        Button_Right.Visible = true;

                        Button_Left.ButtonText = RMessageBox.Cmd_Cancel;
                        Button_Right.ButtonText = RMessageBox.Cmd_Download;

                        Button_Left.ButtonClick += new EventHandler(CancelDownload);
                        Button_Right.ButtonClick += new EventHandler(StartDownload);
                        AcceptButton = Button_Right.Btn;
                        CancelButton = Button_Left.Btn;

                        Button_Left.Enabled = false;
                        Button_Right.Enabled = true;

                        return MessageBoxButtonStyle.Downlaoder;

                    default:
                        SystemAPI.Error(RError.E_0x0002300C);
                        throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002300B, e);
                throw;
            }
        }
        
        private void ResOK(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002300D, ex);
                throw;
            }
        }

        private void ResYes(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002300E, ex);
                throw;
            }
        }

        private void ResNo(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.No;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002300F, ex);
                throw;
            }
        }

        private void ResRetry(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Retry;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023010, ex);
                throw;
            }
        }

        private void ResCancel(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023011, ex);
                throw;
            }
        }

        private void StartDownload(object sender, EventArgs e)
        {
            try
            {
                if (DL == null) {
                    SystemAPI.Warning(RWarning.W_0xC0023000);
                    return;
                }
                DL.DLStart();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023012, ex);
                throw;
            }
        }

        private void CancelDownload(object sender, EventArgs e)
        {
            try
            {
                DL.DLCancel();

                Button_Right.Enabled = true;
                Button_Left.Enabled = false;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00023013, ex);
                throw;
            }
        }
        
        private void RestartProgram(object sender, EventArgs e)
        {
            SystemAPI.RestartProgram(true);
        }

        private void StartProgress(object sender, EventArgs e)
        {
            Process.Start(DL.GetFileLocation(DataSource.Local));
            SystemAPI.CloseProgram(true);
        }

        private void Sys_Min_Click(object sender, EventArgs e)
        {
            SystemAPI.MinimizeProgram(this);
        }

        private void Sys_Close_Click(object sender, EventArgs e)
        {
            if (DL != null)
            {
                DL.DLCancel();
            }
            SystemAPI.CloseWindow(this);
        }

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            SystemAPI.MoveWindow_MouseDown(Left, Top, e.X, e.Y, ref WndPos);
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Capture == true)
            {
                SystemAPI.MoveWindow_MouseMove(Left, Top, e.X, e.Y, ref WndPos, this);
            }
        }
    }
}
