namespace SAOCR_Data_Manager.Forms
{
    partial class PictureB
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Border = new System.Windows.Forms.Panel();
            this.Sys_Close = new SAOCR_Data_Manager.Button_SE_();
            this.Save = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Min = new SAOCR_Data_Manager.Button_SE_();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.ErrorImage = global::SAOCR_Data_Manager.Properties.Resources.Error;
            this.PictureBox.ImageLocation = "";
            this.PictureBox.InitialImage = global::SAOCR_Data_Manager.Properties.Resources.Loading;
            this.PictureBox.Location = new System.Drawing.Point(10, 29);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(700, 700);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Title.ForeColor = System.Drawing.Color.Coral;
            this.Title.Location = new System.Drawing.Point(1, 1);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(618, 24);
            this.Title.TabIndex = 3;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "jpg";
            this.SaveFileDialog.Filter = "JPG 檔案|*.jpg|所有檔案|*.*";
            // 
            // Border
            // 
            this.Border.Controls.Add(this.Sys_Close);
            this.Border.Controls.Add(this.Save);
            this.Border.Controls.Add(this.Sys_Min);
            this.Border.Controls.Add(this.Title);
            this.Border.Controls.Add(this.PictureBox);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(720, 740);
            this.Border.TabIndex = 7;
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
            this.Sys_Close.Location = new System.Drawing.Point(669, 1);
            this.Sys_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Close.Name = "Sys_Close";
            this.Sys_Close.Size = new System.Drawing.Size(50, 24);
            this.Sys_Close.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Save.ButtonBackgroundImage = null;
            this.Save.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.ButtonColor = System.Drawing.Color.White;
            this.Save.ButtonEnabled = true;
            this.Save.ButtonImage = null;
            this.Save.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.ButtonText = "";
            this.Save.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(515, 1);
            this.Save.Margin = new System.Windows.Forms.Padding(0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 24);
            this.Save.TabIndex = 6;
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
            this.Sys_Min.Location = new System.Drawing.Point(619, 1);
            this.Sys_Min.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Min.Name = "Sys_Min";
            this.Sys_Min.Size = new System.Drawing.Size(50, 24);
            this.Sys_Min.TabIndex = 5;
            // 
            // PictureB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(720, 740);
            this.Controls.Add(this.Border);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PictureB";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Picture";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Button_SE_ Sys_Close;
        public Button_SE_ Sys_Min;
        internal System.Windows.Forms.PictureBox PictureBox;
        internal System.Windows.Forms.Label Title;
        public Button_SE_ Save;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Panel Border;
    }
}