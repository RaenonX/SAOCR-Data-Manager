namespace SAOCR_Data_Manager.Controls.BA_Display
{
    partial class DataRegister
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
            this.Title = new System.Windows.Forms.Label();
            this.Sys_Min = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Close = new SAOCR_Data_Manager.Button_SE_();
            this.Border = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Title.ForeColor = System.Drawing.Color.Coral;
            this.Title.Location = new System.Drawing.Point(1, 1);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(538, 24);
            this.Title.TabIndex = 9;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Sys_Min.Location = new System.Drawing.Point(539, 1);
            this.Sys_Min.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Min.Name = "Sys_Min";
            this.Sys_Min.Size = new System.Drawing.Size(50, 24);
            this.Sys_Min.TabIndex = 11;
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
            this.Sys_Close.Location = new System.Drawing.Point(589, 1);
            this.Sys_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Close.Name = "Sys_Close";
            this.Sys_Close.Size = new System.Drawing.Size(50, 24);
            this.Sys_Close.TabIndex = 10;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.label2);
            this.Border.Controls.Add(this.label1);
            this.Border.Controls.Add(this.Title);
            this.Border.Controls.Add(this.Sys_Close);
            this.Border.Controls.Add(this.Sys_Min);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(640, 400);
            this.Border.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "隊長技";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "更改對象";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataRegister";
            this.Text = "DataRegister";
            this.Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Title;
        public Button_SE_ Sys_Min;
        public Button_SE_ Sys_Close;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}