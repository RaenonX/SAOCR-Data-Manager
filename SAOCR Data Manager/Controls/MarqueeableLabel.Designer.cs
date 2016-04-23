namespace SAOCR_Data_Manager
{
    partial class MarqueeableLabel
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextLabel = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextLabel.Location = new System.Drawing.Point(5, 10);
            this.TextLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(310, 16);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "RaenonX JELLYCAT is a human-cat who was a jellyfish.";
            // 
            // Border
            // 
            this.Border.Controls.Add(this.TextLabel);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(233, 36);
            this.Border.TabIndex = 0;
            // 
            // MarqueeableLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MarqueeableLabel";
            this.Size = new System.Drawing.Size(233, 36);
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Border;
        internal System.Windows.Forms.Label TextLabel;
    }
}
