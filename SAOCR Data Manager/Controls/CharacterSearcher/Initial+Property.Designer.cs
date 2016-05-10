namespace SAOCR_Data_Manager.Controls
{
    partial class CharacterSearcher
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.SeriesTable = new System.Windows.Forms.LinkLabel();
            this.Series = new System.Windows.Forms.TextBox();
            this.SeriesText = new System.Windows.Forms.Label();
            this.Rarity = new System.Windows.Forms.TextBox();
            this.RarityText = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.ListView();
            this.KeywordText = new System.Windows.Forms.Label();
            this.Keyword = new System.Windows.Forms.TextBox();
            this.Search = new SAOCR_Data_Manager.Button_SE_();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.SeriesTable);
            this.GroupBox.Controls.Add(this.Series);
            this.GroupBox.Controls.Add(this.SeriesText);
            this.GroupBox.Controls.Add(this.Rarity);
            this.GroupBox.Controls.Add(this.RarityText);
            this.GroupBox.Controls.Add(this.Result);
            this.GroupBox.Controls.Add(this.KeywordText);
            this.GroupBox.Controls.Add(this.Keyword);
            this.GroupBox.Controls.Add(this.Search);
            this.GroupBox.ForeColor = System.Drawing.Color.White;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(294, 335);
            this.GroupBox.TabIndex = 29;
            this.GroupBox.TabStop = false;
            // 
            // SeriesTable
            // 
            this.SeriesTable.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.SeriesTable.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SeriesTable.Location = new System.Drawing.Point(114, 53);
            this.SeriesTable.Name = "SeriesTable";
            this.SeriesTable.Size = new System.Drawing.Size(116, 24);
            this.SeriesTable.TabIndex = 35;
            this.SeriesTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Series
            // 
            this.Series.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Series.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Series.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Series.ForeColor = System.Drawing.Color.White;
            this.Series.Location = new System.Drawing.Point(66, 53);
            this.Series.MaxLength = 3;
            this.Series.Name = "Series";
            this.Series.Size = new System.Drawing.Size(42, 25);
            this.Series.TabIndex = 34;
            // 
            // SeriesText
            // 
            this.SeriesText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.SeriesText.Location = new System.Drawing.Point(6, 53);
            this.SeriesText.Margin = new System.Windows.Forms.Padding(3);
            this.SeriesText.Name = "SeriesText";
            this.SeriesText.Size = new System.Drawing.Size(54, 25);
            this.SeriesText.TabIndex = 33;
            this.SeriesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rarity
            // 
            this.Rarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rarity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rarity.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Rarity.ForeColor = System.Drawing.Color.White;
            this.Rarity.Location = new System.Drawing.Point(242, 22);
            this.Rarity.MaxLength = 1;
            this.Rarity.Name = "Rarity";
            this.Rarity.Size = new System.Drawing.Size(46, 25);
            this.Rarity.TabIndex = 32;
            // 
            // RarityText
            // 
            this.RarityText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.RarityText.Location = new System.Drawing.Point(199, 22);
            this.RarityText.Margin = new System.Windows.Forms.Padding(3);
            this.RarityText.Name = "RarityText";
            this.RarityText.Size = new System.Drawing.Size(37, 25);
            this.RarityText.TabIndex = 31;
            this.RarityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.Result.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.Result.AutoArrange = false;
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.FullRowSelect = true;
            this.Result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Result.Location = new System.Drawing.Point(6, 85);
            this.Result.MultiSelect = false;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(282, 244);
            this.Result.TabIndex = 30;
            this.Result.UseCompatibleStateImageBehavior = false;
            this.Result.View = System.Windows.Forms.View.Details;
            // 
            // KeywordText
            // 
            this.KeywordText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.KeywordText.Location = new System.Drawing.Point(6, 22);
            this.KeywordText.Margin = new System.Windows.Forms.Padding(3);
            this.KeywordText.Name = "KeywordText";
            this.KeywordText.Size = new System.Drawing.Size(54, 25);
            this.KeywordText.TabIndex = 29;
            this.KeywordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Keyword
            // 
            this.Keyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Keyword.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Keyword.ForeColor = System.Drawing.Color.White;
            this.Keyword.Location = new System.Drawing.Point(66, 22);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(127, 25);
            this.Keyword.TabIndex = 26;
            // 
            // Search
            // 
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Search.ButtonBackgroundImage = null;
            this.Search.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search.ButtonColor = System.Drawing.Color.White;
            this.Search.ButtonEnabled = true;
            this.Search.ButtonImage = null;
            this.Search.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search.ButtonText = "";
            this.Search.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Search.Location = new System.Drawing.Point(236, 53);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(52, 25);
            this.Search.TabIndex = 27;
            // 
            // CharacterSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.GroupBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CharacterSearcher";
            this.Size = new System.Drawing.Size(294, 335);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.LinkLabel SeriesTable;
        private System.Windows.Forms.TextBox Series;
        private System.Windows.Forms.Label SeriesText;
        private System.Windows.Forms.TextBox Rarity;
        private System.Windows.Forms.Label RarityText;
        private System.Windows.Forms.Label KeywordText;
        private System.Windows.Forms.TextBox Keyword;
        private Button_SE_ Search;
        internal System.Windows.Forms.ListView Result;
    }
}
