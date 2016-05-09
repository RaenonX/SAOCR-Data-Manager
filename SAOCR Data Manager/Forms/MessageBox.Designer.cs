namespace SAOCR_Data_Manager
{
    partial class MessageDialog
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.Button_Left = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Close = new SAOCR_Data_Manager.Button_SE_();
            this.Button_Right = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Min = new SAOCR_Data_Manager.Button_SE_();
            this.Button_Center = new SAOCR_Data_Manager.Button_SE_();
            this.Message = new System.Windows.Forms.Label();
            this.ExMessage = new SAOCR_Data_Manager.MarqueeableLabel();
            this.DownloadUI = new System.Windows.Forms.Panel();
            this.DLMessage = new System.Windows.Forms.Label();
            this.SpeedText = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.ProgressSingle = new System.Windows.Forms.ProgressBar();
            this.FileSizeText = new System.Windows.Forms.Label();
            this.FileSize = new System.Windows.Forms.Label();
            this.ProgressAll = new System.Windows.Forms.ProgressBar();
            this.ReturnText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Border.SuspendLayout();
            this.DownloadUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Title.ForeColor = System.Drawing.Color.Coral;
            this.Title.Location = new System.Drawing.Point(1, 1);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(498, 24);
            this.Title.TabIndex = 0;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.Title);
            this.Border.Controls.Add(this.Button_Left);
            this.Border.Controls.Add(this.Sys_Close);
            this.Border.Controls.Add(this.Button_Right);
            this.Border.Controls.Add(this.Sys_Min);
            this.Border.Controls.Add(this.Button_Center);
            this.Border.Controls.Add(this.Message);
            this.Border.Controls.Add(this.ExMessage);
            this.Border.Controls.Add(this.DownloadUI);
            this.Border.Controls.Add(this.ReturnText);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(600, 250);
            this.Border.TabIndex = 7;
            // 
            // Button_Left
            // 
            this.Button_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Left.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Left.ButtonBackgroundImage = null;
            this.Button_Left.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Left.ButtonColor = System.Drawing.Color.White;
            this.Button_Left.ButtonEnabled = true;
            this.Button_Left.ButtonImage = null;
            this.Button_Left.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Left.ButtonText = "";
            this.Button_Left.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Button_Left.ForeColor = System.Drawing.Color.White;
            this.Button_Left.Location = new System.Drawing.Point(20, 205);
            this.Button_Left.Margin = new System.Windows.Forms.Padding(1, 10, 1, 1);
            this.Button_Left.Name = "Button_Left";
            this.Button_Left.Size = new System.Drawing.Size(130, 32);
            this.Button_Left.TabIndex = 4;
            // 
            // Sys_Close
            // 
            this.Sys_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Sys_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sys_Close.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Sys_Close.ButtonBackgroundImage = null;
            this.Sys_Close.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sys_Close.ButtonColor = System.Drawing.Color.Red;
            this.Sys_Close.ButtonEnabled = true;
            this.Sys_Close.ButtonImage = null;
            this.Sys_Close.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sys_Close.ButtonText = "";
            this.Sys_Close.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Sys_Close.ForeColor = System.Drawing.Color.Red;
            this.Sys_Close.Location = new System.Drawing.Point(548, 1);
            this.Sys_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Close.Name = "Sys_Close";
            this.Sys_Close.Size = new System.Drawing.Size(50, 24);
            this.Sys_Close.TabIndex = 1;
            this.Sys_Close.ButtonClick += new System.EventHandler(this.Sys_Close_Click);
            // 
            // Button_Right
            // 
            this.Button_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Right.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Right.ButtonBackgroundImage = null;
            this.Button_Right.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Right.ButtonColor = System.Drawing.Color.White;
            this.Button_Right.ButtonEnabled = true;
            this.Button_Right.ButtonImage = null;
            this.Button_Right.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Right.ButtonText = "";
            this.Button_Right.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Button_Right.ForeColor = System.Drawing.Color.White;
            this.Button_Right.Location = new System.Drawing.Point(450, 205);
            this.Button_Right.Margin = new System.Windows.Forms.Padding(1, 10, 1, 1);
            this.Button_Right.Name = "Button_Right";
            this.Button_Right.Size = new System.Drawing.Size(130, 32);
            this.Button_Right.TabIndex = 6;
            // 
            // Sys_Min
            // 
            this.Sys_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Sys_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sys_Min.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Sys_Min.ButtonBackgroundImage = null;
            this.Sys_Min.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sys_Min.ButtonColor = System.Drawing.Color.White;
            this.Sys_Min.ButtonEnabled = true;
            this.Sys_Min.ButtonImage = null;
            this.Sys_Min.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sys_Min.ButtonText = "";
            this.Sys_Min.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Sys_Min.ForeColor = System.Drawing.Color.White;
            this.Sys_Min.Location = new System.Drawing.Point(498, 1);
            this.Sys_Min.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Min.Name = "Sys_Min";
            this.Sys_Min.Size = new System.Drawing.Size(50, 24);
            this.Sys_Min.TabIndex = 2;
            this.Sys_Min.ButtonClick += new System.EventHandler(this.Sys_Min_Click);
            // 
            // Button_Center
            // 
            this.Button_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Center.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Center.ButtonBackgroundImage = null;
            this.Button_Center.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Center.ButtonColor = System.Drawing.Color.White;
            this.Button_Center.ButtonEnabled = true;
            this.Button_Center.ButtonImage = null;
            this.Button_Center.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Center.ButtonText = "";
            this.Button_Center.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Button_Center.ForeColor = System.Drawing.Color.White;
            this.Button_Center.Location = new System.Drawing.Point(235, 205);
            this.Button_Center.Margin = new System.Windows.Forms.Padding(1, 10, 1, 1);
            this.Button_Center.Name = "Button_Center";
            this.Button_Center.Size = new System.Drawing.Size(130, 32);
            this.Button_Center.TabIndex = 5;
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(20, 45);
            this.Message.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(560, 147);
            this.Message.TabIndex = 3;
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExMessage
            // 
            this.ExMessage.Direction = MarqueeDirection.Horizontal;
            this.ExMessage.EnableMarquee = true;
            this.ExMessage.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ExMessage.FreezeTime = 3000;
            this.ExMessage.LabelSize = new System.Drawing.Size(560, 32);
            this.ExMessage.LeftDistance = 5;
            this.ExMessage.LForeColor = System.Drawing.Color.White;
            this.ExMessage.Location = new System.Drawing.Point(20, 160);
            this.ExMessage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.ExMessage.MarqueeText = "";
            this.ExMessage.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ExMessage.MoveDifferenceEachTime = 1;
            this.ExMessage.MoveInterval = 15;
            this.ExMessage.Name = "ExMessage";
            this.ExMessage.OverBorderDistance = 20;
            this.ExMessage.Size = new System.Drawing.Size(560, 32);
            this.ExMessage.TabIndex = 7;
            this.ExMessage.Visible = false;
            // 
            // DownloadUI
            // 
            this.DownloadUI.Controls.Add(this.DLMessage);
            this.DownloadUI.Controls.Add(this.SpeedText);
            this.DownloadUI.Controls.Add(this.Speed);
            this.DownloadUI.Controls.Add(this.ProgressSingle);
            this.DownloadUI.Controls.Add(this.FileSizeText);
            this.DownloadUI.Controls.Add(this.FileSize);
            this.DownloadUI.Controls.Add(this.ProgressAll);
            this.DownloadUI.Location = new System.Drawing.Point(20, 47);
            this.DownloadUI.Name = "DownloadUI";
            this.DownloadUI.Size = new System.Drawing.Size(560, 145);
            this.DownloadUI.TabIndex = 9;
            this.DownloadUI.Visible = false;
            // 
            // DLMessage
            // 
            this.DLMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DLMessage.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.DLMessage.ForeColor = System.Drawing.Color.White;
            this.DLMessage.Location = new System.Drawing.Point(0, 0);
            this.DLMessage.Margin = new System.Windows.Forms.Padding(3);
            this.DLMessage.Name = "DLMessage";
            this.DLMessage.Size = new System.Drawing.Size(560, 61);
            this.DLMessage.TabIndex = 13;
            this.DLMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedText
            // 
            this.SpeedText.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.SpeedText.ForeColor = System.Drawing.Color.White;
            this.SpeedText.Location = new System.Drawing.Point(329, 67);
            this.SpeedText.Margin = new System.Windows.Forms.Padding(3);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(72, 33);
            this.SpeedText.TabIndex = 12;
            this.SpeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Speed
            // 
            this.Speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Speed.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Speed.ForeColor = System.Drawing.Color.White;
            this.Speed.Location = new System.Drawing.Point(407, 67);
            this.Speed.Margin = new System.Windows.Forms.Padding(3);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(153, 32);
            this.Speed.TabIndex = 11;
            this.Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressSingle
            // 
            this.ProgressSingle.ForeColor = System.Drawing.Color.White;
            this.ProgressSingle.Location = new System.Drawing.Point(0, 129);
            this.ProgressSingle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ProgressSingle.MarqueeAnimationSpeed = 10;
            this.ProgressSingle.Name = "ProgressSingle";
            this.ProgressSingle.Size = new System.Drawing.Size(560, 16);
            this.ProgressSingle.Step = 1;
            this.ProgressSingle.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressSingle.TabIndex = 10;
            // 
            // FileSizeText
            // 
            this.FileSizeText.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.FileSizeText.ForeColor = System.Drawing.Color.White;
            this.FileSizeText.Location = new System.Drawing.Point(0, 67);
            this.FileSizeText.Margin = new System.Windows.Forms.Padding(3);
            this.FileSizeText.Name = "FileSizeText";
            this.FileSizeText.Size = new System.Drawing.Size(75, 34);
            this.FileSizeText.TabIndex = 9;
            this.FileSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileSize
            // 
            this.FileSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSize.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.FileSize.ForeColor = System.Drawing.Color.White;
            this.FileSize.Location = new System.Drawing.Point(81, 67);
            this.FileSize.Margin = new System.Windows.Forms.Padding(3);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(242, 33);
            this.FileSize.TabIndex = 8;
            this.FileSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressAll
            // 
            this.ProgressAll.ForeColor = System.Drawing.Color.White;
            this.ProgressAll.Location = new System.Drawing.Point(0, 108);
            this.ProgressAll.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ProgressAll.MarqueeAnimationSpeed = 10;
            this.ProgressAll.Name = "ProgressAll";
            this.ProgressAll.Size = new System.Drawing.Size(560, 16);
            this.ProgressAll.Step = 1;
            this.ProgressAll.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressAll.TabIndex = 8;
            // 
            // ReturnText
            // 
            this.ReturnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReturnText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReturnText.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.ReturnText.ForeColor = System.Drawing.Color.White;
            this.ReturnText.Location = new System.Drawing.Point(20, 205);
            this.ReturnText.Name = "ReturnText";
            this.ReturnText.Size = new System.Drawing.Size(345, 32);
            this.ReturnText.TabIndex = 10;
            this.ReturnText.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageDialog";
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.DownloadUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Title;
        public SAOCR_Data_Manager.Button_SE_ Sys_Close;
        public SAOCR_Data_Manager.Button_SE_ Sys_Min;
        public SAOCR_Data_Manager.Button_SE_ Button_Left;
        public SAOCR_Data_Manager.Button_SE_ Button_Center;
        public SAOCR_Data_Manager.Button_SE_ Button_Right;
        private System.Windows.Forms.Panel Border;
        private MarqueeableLabel ExMessage;
        public System.Windows.Forms.Label Message;
        private System.Windows.Forms.ProgressBar ProgressAll;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel DownloadUI;
        public System.Windows.Forms.Label FileSizeText;
        public System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.ProgressBar ProgressSingle;
        public System.Windows.Forms.Label DLMessage;
        public System.Windows.Forms.Label SpeedText;
        public System.Windows.Forms.Label Speed;
        private System.Windows.Forms.TextBox ReturnText;
    }
}

