namespace SAOCR_Data_Manager.Forms
{
    partial class CharaDataDisplay
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
            this.Panel = new System.Windows.Forms.Panel();
            this.LS = new SAOCR_Data_Manager.LsDisplay();
            this.BasicInfo = new SAOCR_Data_Manager.Controls.Initialize_Properties.BasicInfo();
            this.Param = new SAOCR_Data_Manager.ParamDisplay();
            this.BA = new SAOCR_Data_Manager.BaDisplay();
            this.Border = new System.Windows.Forms.Panel();
            this.Favorite = new SAOCR_Data_Manager.Button_SE_();
            this.CharacterName = new SAOCR_Data_Manager.Controls.BreezeLabel();
            this.Panel.SuspendLayout();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Controls.Add(this.LS);
            this.Panel.Controls.Add(this.BasicInfo);
            this.Panel.Controls.Add(this.Param);
            this.Panel.Controls.Add(this.BA);
            this.Panel.Location = new System.Drawing.Point(1, 37);
            this.Panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(5);
            this.Panel.Size = new System.Drawing.Size(746, 564);
            this.Panel.TabIndex = 2;
            // 
            // LS
            // 
            this.LS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LS.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.LS.ForeColor = System.Drawing.Color.White;
            this.LS.Location = new System.Drawing.Point(160, 664);
            this.LS.Marquee = true;
            this.LS.Name = "LS";
            this.LS.Size = new System.Drawing.Size(411, 115);
            this.LS.TabIndex = 25;
            // 
            // BasicInfo
            // 
            this.BasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BasicInfo.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.BasicInfo.ForeColor = System.Drawing.Color.White;
            this.BasicInfo.Location = new System.Drawing.Point(8, 8);
            this.BasicInfo.Name = "BasicInfo";
            this.BasicInfo.Size = new System.Drawing.Size(713, 410);
            this.BasicInfo.TabIndex = 24;
            // 
            // Param
            // 
            this.Param.Awaked = EParamAwaked.Null;
            this.Param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Param.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Param.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Param.ForeColor = System.Drawing.Color.White;
            this.Param.Location = new System.Drawing.Point(78, 785);
            this.Param.Lv = EParamLv.Null;
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(574, 374);
            this.Param.TabIndex = 0;
            this.Param.TypeParamAt1st = EParamType.Mebius;
            this.Param.TypeParamAt2nd = EParamType.Force;
            this.Param.TypeParamAt3rd = EParamType.Aegis;
            this.Param.TypeParamAt4th = ((EParamType)((EParamType.Force | EParamType.Aegis)));
            // 
            // BA
            // 
            this.BA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BA.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.BA.ForeColor = System.Drawing.Color.White;
            this.BA.isTextTranslated = true;
            this.BA.Location = new System.Drawing.Point(86, 424);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(558, 234);
            this.BA.TabIndex = 1;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.Favorite);
            this.Border.Controls.Add(this.CharacterName);
            this.Border.Controls.Add(this.Panel);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(748, 601);
            this.Border.TabIndex = 27;
            // 
            // Favorite
            // 
            this.Favorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Favorite.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Favorite.ButtonBackgroundImage = global::SAOCR_Data_Manager.Properties.Resources.abc_ic_menu_paste_mtrl_am_alpha;
            this.Favorite.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Favorite.ButtonColor = System.Drawing.Color.White;
            this.Favorite.ButtonEnabled = false;
            this.Favorite.ButtonImage = null;
            this.Favorite.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Favorite.ButtonText = "";
            this.Favorite.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Favorite.Location = new System.Drawing.Point(711, 1);
            this.Favorite.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(36, 36);
            this.Favorite.TabIndex = 27;
            // 
            // CharacterName
            // 
            this.CharacterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CharacterName.ChangeTime = 2000;
            this.CharacterName.ColorBegin = System.Drawing.Color.Empty;
            this.CharacterName.ColorEnd = System.Drawing.Color.Empty;
            this.CharacterName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CharacterName.Font = new System.Drawing.Font("微軟正黑體", 17F);
            this.CharacterName.ForeColor = System.Drawing.Color.White;
            this.CharacterName.LAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharacterName.LBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CharacterName.LBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharacterName.LFont = new System.Drawing.Font("微軟正黑體", 17F);
            this.CharacterName.LForeColor = System.Drawing.Color.White;
            this.CharacterName.Location = new System.Drawing.Point(1, 1);
            this.CharacterName.LText = "";
            this.CharacterName.Margin = new System.Windows.Forms.Padding(3, 4, 0, 4);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(710, 36);
            this.CharacterName.TabIndex = 28;
            // 
            // CharaDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CharaDataDisplay";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(748, 602);
            this.Panel.ResumeLayout(false);
            this.Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal ParamDisplay Param;
        internal BaDisplay BA;
        internal System.Windows.Forms.Panel Panel;
        internal LsDisplay LS;
        internal Controls.Initialize_Properties.BasicInfo BasicInfo;
        internal Controls.BreezeLabel CharacterName;
        private System.Windows.Forms.Panel Border;
        private Button_SE_ Favorite;
    }
}
