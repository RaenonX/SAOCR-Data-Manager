namespace SAOCR_Data_Manager.Forms
{
    partial class DataViewF
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
            this.Sys_Close = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Min = new SAOCR_Data_Manager.Button_SE_();
            this.Border = new System.Windows.Forms.Panel();
            this.KeywordResult = new System.Windows.Forms.ListView();
            this.KeywordText = new System.Windows.Forms.Label();
            this.Keyword = new System.Windows.Forms.TextBox();
            this.KeywordGo = new SAOCR_Data_Manager.Button_SE_();
            this.Data = new System.Windows.Forms.ListView();
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
            this.Title.TabIndex = 6;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sys_Close
            // 
            this.Sys_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Sys_Close.ButtonColor = System.Drawing.Color.Red;
            this.Sys_Close.ButtonEnabled = true;
            this.Sys_Close.ButtonText = "";
            this.Sys_Close.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Sys_Close.ForeColor = System.Drawing.Color.Red;
            this.Sys_Close.Location = new System.Drawing.Point(589, 1);
            this.Sys_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Close.Name = "Sys_Close";
            this.Sys_Close.Size = new System.Drawing.Size(50, 24);
            this.Sys_Close.TabIndex = 7;
            // 
            // Sys_Min
            // 
            this.Sys_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Sys_Min.ButtonColor = System.Drawing.Color.White;
            this.Sys_Min.ButtonEnabled = true;
            this.Sys_Min.ButtonText = "";
            this.Sys_Min.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Sys_Min.ForeColor = System.Drawing.Color.White;
            this.Sys_Min.Location = new System.Drawing.Point(539, 1);
            this.Sys_Min.Margin = new System.Windows.Forms.Padding(0);
            this.Sys_Min.Name = "Sys_Min";
            this.Sys_Min.Size = new System.Drawing.Size(50, 24);
            this.Sys_Min.TabIndex = 8;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.KeywordResult);
            this.Border.Controls.Add(this.KeywordText);
            this.Border.Controls.Add(this.Keyword);
            this.Border.Controls.Add(this.KeywordGo);
            this.Border.Controls.Add(this.Data);
            this.Border.Controls.Add(this.Title);
            this.Border.Controls.Add(this.Sys_Min);
            this.Border.Controls.Add(this.Sys_Close);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(640, 480);
            this.Border.TabIndex = 9;
            // 
            // KeywordResult
            // 
            this.KeywordResult.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.KeywordResult.AutoArrange = false;
            this.KeywordResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.KeywordResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeywordResult.ForeColor = System.Drawing.Color.White;
            this.KeywordResult.FullRowSelect = true;
            this.KeywordResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.KeywordResult.Location = new System.Drawing.Point(12, 123);
            this.KeywordResult.MultiSelect = false;
            this.KeywordResult.Name = "KeywordResult";
            this.KeywordResult.Size = new System.Drawing.Size(135, 345);
            this.KeywordResult.TabIndex = 35;
            this.KeywordResult.UseCompatibleStateImageBehavior = false;
            this.KeywordResult.View = System.Windows.Forms.View.Details;
            // 
            // KeywordText
            // 
            this.KeywordText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.KeywordText.Location = new System.Drawing.Point(12, 28);
            this.KeywordText.Margin = new System.Windows.Forms.Padding(3);
            this.KeywordText.Name = "KeywordText";
            this.KeywordText.Size = new System.Drawing.Size(54, 25);
            this.KeywordText.TabIndex = 34;
            this.KeywordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Keyword
            // 
            this.Keyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Keyword.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Keyword.ForeColor = System.Drawing.Color.White;
            this.Keyword.Location = new System.Drawing.Point(12, 59);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(135, 25);
            this.Keyword.TabIndex = 32;
            // 
            // KeywordGo
            // 
            this.KeywordGo.ButtonColor = System.Drawing.Color.White;
            this.KeywordGo.ButtonEnabled = true;
            this.KeywordGo.ButtonText = "";
            this.KeywordGo.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.KeywordGo.Location = new System.Drawing.Point(95, 91);
            this.KeywordGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeywordGo.Name = "KeywordGo";
            this.KeywordGo.Size = new System.Drawing.Size(52, 25);
            this.KeywordGo.TabIndex = 33;
            // 
            // Data
            // 
            this.Data.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.Data.AutoArrange = false;
            this.Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Data.ForeColor = System.Drawing.Color.White;
            this.Data.FullRowSelect = true;
            this.Data.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Data.Location = new System.Drawing.Point(153, 28);
            this.Data.MultiSelect = false;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(475, 440);
            this.Data.TabIndex = 31;
            this.Data.UseCompatibleStateImageBehavior = false;
            this.Data.View = System.Windows.Forms.View.Details;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataView";
            this.Text = "DataView";
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Title;
        public Button_SE_ Sys_Close;
        public Button_SE_ Sys_Min;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.ListView Data;
        private System.Windows.Forms.TextBox Keyword;
        private Button_SE_ KeywordGo;
        private System.Windows.Forms.Label KeywordText;
        private System.Windows.Forms.ListView KeywordResult;
    }
}