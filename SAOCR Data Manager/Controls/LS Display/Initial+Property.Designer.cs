namespace SAOCR_Data_Manager
{
    partial class LsDisplay
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
            this.GP_LS = new System.Windows.Forms.GroupBox();
            this.EffectScoreText = new System.Windows.Forms.Label();
            this.EffectScore = new System.Windows.Forms.Label();
            this.EffectText = new System.Windows.Forms.Label();
            this.TargetScoreText = new System.Windows.Forms.Label();
            this.TargetScore = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.Label();
            this.Effect = new SAOCR_Data_Manager.MarqueeableLabel();
            this.Target = new SAOCR_Data_Manager.MarqueeableLabel();
            this.GP_LS.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_LS
            // 
            this.GP_LS.Controls.Add(this.EffectScoreText);
            this.GP_LS.Controls.Add(this.EffectScore);
            this.GP_LS.Controls.Add(this.Effect);
            this.GP_LS.Controls.Add(this.EffectText);
            this.GP_LS.Controls.Add(this.TargetScoreText);
            this.GP_LS.Controls.Add(this.TargetScore);
            this.GP_LS.Controls.Add(this.Target);
            this.GP_LS.Controls.Add(this.TargetText);
            this.GP_LS.ForeColor = System.Drawing.Color.White;
            this.GP_LS.Location = new System.Drawing.Point(5, 5);
            this.GP_LS.Margin = new System.Windows.Forms.Padding(5);
            this.GP_LS.Name = "GP_LS";
            this.GP_LS.Size = new System.Drawing.Size(401, 105);
            this.GP_LS.TabIndex = 13;
            this.GP_LS.TabStop = false;
            // 
            // EffectScoreText
            // 
            this.EffectScoreText.Location = new System.Drawing.Point(378, 64);
            this.EffectScoreText.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.EffectScoreText.Name = "EffectScoreText";
            this.EffectScoreText.Size = new System.Drawing.Size(16, 32);
            this.EffectScoreText.TabIndex = 17;
            this.EffectScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EffectScore
            // 
            this.EffectScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EffectScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.EffectScore.Font = new System.Drawing.Font("Consolas", 10F);
            this.EffectScore.Location = new System.Drawing.Point(332, 64);
            this.EffectScore.Margin = new System.Windows.Forms.Padding(3);
            this.EffectScore.Name = "EffectScore";
            this.EffectScore.Size = new System.Drawing.Size(43, 32);
            this.EffectScore.TabIndex = 16;
            this.EffectScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EffectText
            // 
            this.EffectText.Location = new System.Drawing.Point(6, 64);
            this.EffectText.Margin = new System.Windows.Forms.Padding(3);
            this.EffectText.Name = "EffectText";
            this.EffectText.Size = new System.Drawing.Size(43, 32);
            this.EffectText.TabIndex = 14;
            this.EffectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetScoreText
            // 
            this.TargetScoreText.Location = new System.Drawing.Point(378, 22);
            this.TargetScoreText.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TargetScoreText.Name = "TargetScoreText";
            this.TargetScoreText.Size = new System.Drawing.Size(16, 32);
            this.TargetScoreText.TabIndex = 13;
            this.TargetScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetScore
            // 
            this.TargetScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.TargetScore.Font = new System.Drawing.Font("Consolas", 10F);
            this.TargetScore.Location = new System.Drawing.Point(332, 22);
            this.TargetScore.Margin = new System.Windows.Forms.Padding(3);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(43, 32);
            this.TargetScore.TabIndex = 12;
            this.TargetScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetText
            // 
            this.TargetText.Location = new System.Drawing.Point(6, 22);
            this.TargetText.Margin = new System.Windows.Forms.Padding(3);
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(43, 32);
            this.TargetText.TabIndex = 0;
            this.TargetText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Effect
            // 
            this.Effect.Direction = MarqueeDirection.Horizontal;
            this.Effect.EnableMarquee = true;
            this.Effect.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Effect.FreezeTime = 2000;
            this.Effect.LabelSize = new System.Drawing.Size(269, 32);
            this.Effect.LeftDistance = 5;
            this.Effect.Location = new System.Drawing.Point(56, 64);
            this.Effect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Effect.MarqueeText = "";
            this.Effect.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.Effect.MoveDifferenceEachTime = 1;
            this.Effect.MoveInterval = 15;
            this.Effect.Name = "Effect";
            this.Effect.OverBorderDistance = 100;
            this.Effect.Size = new System.Drawing.Size(269, 32);
            this.Effect.TabIndex = 15;
            // 
            // Target
            // 
            this.Target.Direction = MarqueeDirection.Horizontal;
            this.Target.EnableMarquee = true;
            this.Target.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Target.FreezeTime = 2000;
            this.Target.LabelSize = new System.Drawing.Size(269, 32);
            this.Target.LeftDistance = 5;
            this.Target.Location = new System.Drawing.Point(56, 22);
            this.Target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Target.MarqueeText = "";
            this.Target.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.Target.MoveDifferenceEachTime = 1;
            this.Target.MoveInterval = 15;
            this.Target.Name = "Target";
            this.Target.OverBorderDistance = 100;
            this.Target.Size = new System.Drawing.Size(269, 32);
            this.Target.TabIndex = 1;
            // 
            // LsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.GP_LS);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "LsDisplay";
            this.Size = new System.Drawing.Size(411, 115);
            this.GP_LS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GP_LS;
        private System.Windows.Forms.Label EffectScoreText;
        private System.Windows.Forms.Label EffectScore;
        private MarqueeableLabel Effect;
        private System.Windows.Forms.Label EffectText;
        private System.Windows.Forms.Label TargetScoreText;
        private System.Windows.Forms.Label TargetScore;
        private MarqueeableLabel Target;
        private System.Windows.Forms.Label TargetText;
    }
}
