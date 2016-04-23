namespace SAOCR_Data_Manager
{
    partial class UI_WMPOnly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_WMPOnly));
            this.Warning = new AxWMPLib.AxWindowsMediaPlayer();
            this.Beep = new AxWMPLib.AxWindowsMediaPlayer();
            this.Message = new AxWMPLib.AxWindowsMediaPlayer();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Message)).BeginInit();
            this.SuspendLayout();
            // 
            // Warning
            // 
            this.Warning.Enabled = true;
            this.Warning.Location = new System.Drawing.Point(279, 123);
            this.Warning.Name = "Warning";
            this.Warning.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Warning.OcxState")));
            this.Warning.Size = new System.Drawing.Size(75, 23);
            this.Warning.TabIndex = 0;
            this.Warning.Visible = false;
            // 
            // Beep
            // 
            this.Beep.Enabled = true;
            this.Beep.Location = new System.Drawing.Point(12, 12);
            this.Beep.Name = "Beep";
            this.Beep.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Beep.OcxState")));
            this.Beep.Size = new System.Drawing.Size(75, 23);
            this.Beep.TabIndex = 1;
            this.Beep.Visible = false;
            // 
            // Message
            // 
            this.Message.Enabled = true;
            this.Message.Location = new System.Drawing.Point(13, 39);
            this.Message.Name = "Message";
            this.Message.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Message.OcxState")));
            this.Message.Size = new System.Drawing.Size(75, 23);
            this.Message.TabIndex = 2;
            this.Message.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // UI_WMPOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Beep);
            this.Controls.Add(this.Warning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_WMPOnly";
            this.Text = "UI_WMPOnly";
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Message)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal AxWMPLib.AxWindowsMediaPlayer Warning;
        internal AxWMPLib.AxWindowsMediaPlayer Message;
        internal AxWMPLib.AxWindowsMediaPlayer Beep;
        internal System.Windows.Forms.Timer Timer;
    }
}