namespace SAOCR_Data_Manager.Forms
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
            this.Border = new System.Windows.Forms.Panel();
            this.Box_Info = new System.Windows.Forms.GroupBox();
            this.ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.GetMethod = new System.Windows.Forms.TextBox();
            this.GetMethodText = new System.Windows.Forms.Label();
            this.ReleaseDateText = new System.Windows.Forms.Label();
            this.FolkName5 = new System.Windows.Forms.TextBox();
            this.FolkName4 = new System.Windows.Forms.TextBox();
            this.FolkName3 = new System.Windows.Forms.TextBox();
            this.FolkName2 = new System.Windows.Forms.TextBox();
            this.CharaIDText = new System.Windows.Forms.Label();
            this.CharaID = new System.Windows.Forms.Label();
            this.FolkName1 = new System.Windows.Forms.TextBox();
            this.FolkNameText = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.Label();
            this.RegTargetText = new System.Windows.Forms.Label();
            this.RegTarget = new System.Windows.Forms.Label();
            this.Box_BA = new System.Windows.Forms.GroupBox();
            this.BAJPNameText = new System.Windows.Forms.Label();
            this.BAJPName = new System.Windows.Forms.Label();
            this.BAScore = new System.Windows.Forms.TextBox();
            this.BAScoreText = new System.Windows.Forms.Label();
            this.BASeries2 = new System.Windows.Forms.TextBox();
            this.BASeries2Text = new System.Windows.Forms.Label();
            this.BASeries1 = new System.Windows.Forms.TextBox();
            this.BASeries1Text = new System.Windows.Forms.Label();
            this.BACHDes = new System.Windows.Forms.TextBox();
            this.BACHDesText = new System.Windows.Forms.Label();
            this.BAJPDesText = new System.Windows.Forms.Label();
            this.BAJPDes = new System.Windows.Forms.Label();
            this.BAForceByName = new System.Windows.Forms.CheckBox();
            this.Box_LS = new System.Windows.Forms.GroupBox();
            this.SS = new System.Windows.Forms.TextBox();
            this.SSText = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.TextBox();
            this.HPText = new System.Windows.Forms.Label();
            this.MEN = new System.Windows.Forms.TextBox();
            this.MENText = new System.Windows.Forms.Label();
            this.INT = new System.Windows.Forms.TextBox();
            this.INTText = new System.Windows.Forms.Label();
            this.VIT = new System.Windows.Forms.TextBox();
            this.VITText = new System.Windows.Forms.Label();
            this.SpecScore = new System.Windows.Forms.TextBox();
            this.SpecScoreText = new System.Windows.Forms.Label();
            this.STR = new System.Windows.Forms.TextBox();
            this.STRText = new System.Windows.Forms.Label();
            this.Spec = new System.Windows.Forms.TextBox();
            this.SpecText = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.EffectJPText = new System.Windows.Forms.Label();
            this.EffectJP = new System.Windows.Forms.Label();
            this.TargetScore = new System.Windows.Forms.TextBox();
            this.TargetScoreText = new System.Windows.Forms.Label();
            this.TargetCH = new System.Windows.Forms.TextBox();
            this.TargetCHText = new System.Windows.Forms.Label();
            this.TargetJPText = new System.Windows.Forms.Label();
            this.TargetJP = new System.Windows.Forms.Label();
            this.InfoRegister = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Close = new SAOCR_Data_Manager.Button_SE_();
            this.Sys_Min = new SAOCR_Data_Manager.Button_SE_();
            this.BARegister = new SAOCR_Data_Manager.Button_SE_();
            this.LSRegister = new SAOCR_Data_Manager.Button_SE_();
            this.Border.SuspendLayout();
            this.Box_Info.SuspendLayout();
            this.Box_BA.SuspendLayout();
            this.Box_LS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Title.ForeColor = System.Drawing.Color.Coral;
            this.Title.Location = new System.Drawing.Point(1, 1);
            this.Title.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(538, 24);
            this.Title.TabIndex = 9;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.PathText);
            this.Border.Controls.Add(this.Path);
            this.Border.Controls.Add(this.RegTargetText);
            this.Border.Controls.Add(this.RegTarget);
            this.Border.Controls.Add(this.Title);
            this.Border.Controls.Add(this.Sys_Close);
            this.Border.Controls.Add(this.Sys_Min);
            this.Border.Controls.Add(this.Box_LS);
            this.Border.Controls.Add(this.Box_Info);
            this.Border.Controls.Add(this.Box_BA);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(640, 400);
            this.Border.TabIndex = 12;
            // 
            // Box_Info
            // 
            this.Box_Info.Controls.Add(this.ReleaseDate);
            this.Box_Info.Controls.Add(this.GetMethod);
            this.Box_Info.Controls.Add(this.GetMethodText);
            this.Box_Info.Controls.Add(this.ReleaseDateText);
            this.Box_Info.Controls.Add(this.FolkName5);
            this.Box_Info.Controls.Add(this.FolkName4);
            this.Box_Info.Controls.Add(this.FolkName3);
            this.Box_Info.Controls.Add(this.FolkName2);
            this.Box_Info.Controls.Add(this.CharaIDText);
            this.Box_Info.Controls.Add(this.CharaID);
            this.Box_Info.Controls.Add(this.InfoRegister);
            this.Box_Info.Controls.Add(this.FolkName1);
            this.Box_Info.Controls.Add(this.FolkNameText);
            this.Box_Info.ForeColor = System.Drawing.Color.White;
            this.Box_Info.Location = new System.Drawing.Point(12, 63);
            this.Box_Info.Name = "Box_Info";
            this.Box_Info.Size = new System.Drawing.Size(616, 322);
            this.Box_Info.TabIndex = 29;
            this.Box_Info.TabStop = false;
            this.Box_Info.Visible = false;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.CalendarFont = new System.Drawing.Font("微軟正黑體", 9F);
            this.ReleaseDate.CalendarForeColor = System.Drawing.Color.White;
            this.ReleaseDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ReleaseDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ReleaseDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.ReleaseDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ReleaseDate.CustomFormat = "yyyy年MM月dd日 (五)";
            this.ReleaseDate.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.ReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReleaseDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ReleaseDate.Location = new System.Drawing.Point(144, 86);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(176, 26);
            this.ReleaseDate.TabIndex = 38;
            // 
            // GetMethod
            // 
            this.GetMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.GetMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GetMethod.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.GetMethod.ForeColor = System.Drawing.Color.White;
            this.GetMethod.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GetMethod.Location = new System.Drawing.Point(406, 86);
            this.GetMethod.Name = "GetMethod";
            this.GetMethod.Size = new System.Drawing.Size(105, 26);
            this.GetMethod.TabIndex = 36;
            // 
            // GetMethodText
            // 
            this.GetMethodText.Location = new System.Drawing.Point(326, 86);
            this.GetMethodText.Margin = new System.Windows.Forms.Padding(3);
            this.GetMethodText.Name = "GetMethodText";
            this.GetMethodText.Size = new System.Drawing.Size(74, 26);
            this.GetMethodText.TabIndex = 35;
            this.GetMethodText.Text = "獲得方法";
            this.GetMethodText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReleaseDateText
            // 
            this.ReleaseDateText.Location = new System.Drawing.Point(64, 86);
            this.ReleaseDateText.Margin = new System.Windows.Forms.Padding(3);
            this.ReleaseDateText.Name = "ReleaseDateText";
            this.ReleaseDateText.Size = new System.Drawing.Size(74, 26);
            this.ReleaseDateText.TabIndex = 33;
            this.ReleaseDateText.Text = "釋出日期";
            this.ReleaseDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolkName5
            // 
            this.FolkName5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FolkName5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolkName5.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.FolkName5.ForeColor = System.Drawing.Color.White;
            this.FolkName5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FolkName5.Location = new System.Drawing.Point(506, 54);
            this.FolkName5.Name = "FolkName5";
            this.FolkName5.Size = new System.Drawing.Size(104, 26);
            this.FolkName5.TabIndex = 32;
            // 
            // FolkName4
            // 
            this.FolkName4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FolkName4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolkName4.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.FolkName4.ForeColor = System.Drawing.Color.White;
            this.FolkName4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FolkName4.Location = new System.Drawing.Point(396, 54);
            this.FolkName4.Name = "FolkName4";
            this.FolkName4.Size = new System.Drawing.Size(104, 26);
            this.FolkName4.TabIndex = 31;
            // 
            // FolkName3
            // 
            this.FolkName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FolkName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolkName3.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.FolkName3.ForeColor = System.Drawing.Color.White;
            this.FolkName3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FolkName3.Location = new System.Drawing.Point(286, 54);
            this.FolkName3.Name = "FolkName3";
            this.FolkName3.Size = new System.Drawing.Size(104, 26);
            this.FolkName3.TabIndex = 30;
            // 
            // FolkName2
            // 
            this.FolkName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FolkName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolkName2.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.FolkName2.ForeColor = System.Drawing.Color.White;
            this.FolkName2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FolkName2.Location = new System.Drawing.Point(176, 54);
            this.FolkName2.Name = "FolkName2";
            this.FolkName2.Size = new System.Drawing.Size(104, 26);
            this.FolkName2.TabIndex = 29;
            // 
            // CharaIDText
            // 
            this.CharaIDText.Location = new System.Drawing.Point(204, 22);
            this.CharaIDText.Margin = new System.Windows.Forms.Padding(3);
            this.CharaIDText.Name = "CharaIDText";
            this.CharaIDText.Size = new System.Drawing.Size(74, 26);
            this.CharaIDText.TabIndex = 28;
            this.CharaIDText.Text = "角色ID";
            this.CharaIDText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharaID
            // 
            this.CharaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharaID.Font = new System.Drawing.Font("Consolas", 15F);
            this.CharaID.Location = new System.Drawing.Point(284, 22);
            this.CharaID.Margin = new System.Windows.Forms.Padding(3);
            this.CharaID.Name = "CharaID";
            this.CharaID.Size = new System.Drawing.Size(128, 26);
            this.CharaID.TabIndex = 27;
            this.CharaID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolkName1
            // 
            this.FolkName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FolkName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolkName1.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.FolkName1.ForeColor = System.Drawing.Color.White;
            this.FolkName1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FolkName1.Location = new System.Drawing.Point(66, 54);
            this.FolkName1.Name = "FolkName1";
            this.FolkName1.Size = new System.Drawing.Size(104, 26);
            this.FolkName1.TabIndex = 19;
            // 
            // FolkNameText
            // 
            this.FolkNameText.Location = new System.Drawing.Point(6, 54);
            this.FolkNameText.Margin = new System.Windows.Forms.Padding(3);
            this.FolkNameText.Name = "FolkNameText";
            this.FolkNameText.Size = new System.Drawing.Size(54, 26);
            this.FolkNameText.TabIndex = 16;
            this.FolkNameText.Text = "俗名";
            this.FolkNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(158, 31);
            this.PathText.Margin = new System.Windows.Forms.Padding(3);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(65, 26);
            this.PathText.TabIndex = 16;
            this.PathText.Text = "檔案路徑";
            this.PathText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Path
            // 
            this.Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Path.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.Path.Location = new System.Drawing.Point(229, 31);
            this.Path.Margin = new System.Windows.Forms.Padding(3);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(399, 26);
            this.Path.TabIndex = 15;
            this.Path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegTargetText
            // 
            this.RegTargetText.Location = new System.Drawing.Point(12, 31);
            this.RegTargetText.Margin = new System.Windows.Forms.Padding(3);
            this.RegTargetText.Name = "RegTargetText";
            this.RegTargetText.Size = new System.Drawing.Size(65, 26);
            this.RegTargetText.TabIndex = 13;
            this.RegTargetText.Text = "更改模式";
            this.RegTargetText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegTarget
            // 
            this.RegTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegTarget.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.RegTarget.Location = new System.Drawing.Point(83, 31);
            this.RegTarget.Margin = new System.Windows.Forms.Padding(3);
            this.RegTarget.Name = "RegTarget";
            this.RegTarget.Size = new System.Drawing.Size(69, 26);
            this.RegTarget.TabIndex = 12;
            this.RegTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Box_BA
            // 
            this.Box_BA.Controls.Add(this.BAJPNameText);
            this.Box_BA.Controls.Add(this.BAJPName);
            this.Box_BA.Controls.Add(this.BARegister);
            this.Box_BA.Controls.Add(this.BAScore);
            this.Box_BA.Controls.Add(this.BAScoreText);
            this.Box_BA.Controls.Add(this.BASeries2);
            this.Box_BA.Controls.Add(this.BASeries2Text);
            this.Box_BA.Controls.Add(this.BASeries1);
            this.Box_BA.Controls.Add(this.BASeries1Text);
            this.Box_BA.Controls.Add(this.BACHDes);
            this.Box_BA.Controls.Add(this.BACHDesText);
            this.Box_BA.Controls.Add(this.BAJPDesText);
            this.Box_BA.Controls.Add(this.BAJPDes);
            this.Box_BA.Controls.Add(this.BAForceByName);
            this.Box_BA.ForeColor = System.Drawing.Color.White;
            this.Box_BA.Location = new System.Drawing.Point(12, 63);
            this.Box_BA.Name = "Box_BA";
            this.Box_BA.Size = new System.Drawing.Size(616, 322);
            this.Box_BA.TabIndex = 14;
            this.Box_BA.TabStop = false;
            this.Box_BA.Visible = false;
            // 
            // BAJPNameText
            // 
            this.BAJPNameText.Location = new System.Drawing.Point(120, 22);
            this.BAJPNameText.Margin = new System.Windows.Forms.Padding(3);
            this.BAJPNameText.Name = "BAJPNameText";
            this.BAJPNameText.Size = new System.Drawing.Size(81, 26);
            this.BAJPNameText.TabIndex = 28;
            this.BAJPNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAJPName
            // 
            this.BAJPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BAJPName.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.BAJPName.Location = new System.Drawing.Point(207, 22);
            this.BAJPName.Margin = new System.Windows.Forms.Padding(3);
            this.BAJPName.Name = "BAJPName";
            this.BAJPName.Size = new System.Drawing.Size(402, 26);
            this.BAJPName.TabIndex = 27;
            this.BAJPName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BAScore
            // 
            this.BAScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BAScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BAScore.Font = new System.Drawing.Font("Consolas", 12F);
            this.BAScore.ForeColor = System.Drawing.Color.White;
            this.BAScore.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BAScore.Location = new System.Drawing.Point(540, 119);
            this.BAScore.Name = "BAScore";
            this.BAScore.Size = new System.Drawing.Size(69, 26);
            this.BAScore.TabIndex = 25;
            this.BAScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BAScoreText
            // 
            this.BAScoreText.Location = new System.Drawing.Point(493, 119);
            this.BAScoreText.Margin = new System.Windows.Forms.Padding(3);
            this.BAScoreText.Name = "BAScoreText";
            this.BAScoreText.Size = new System.Drawing.Size(41, 26);
            this.BAScoreText.TabIndex = 24;
            this.BAScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BASeries2
            // 
            this.BASeries2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BASeries2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BASeries2.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.BASeries2.ForeColor = System.Drawing.Color.White;
            this.BASeries2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BASeries2.Location = new System.Drawing.Point(209, 119);
            this.BASeries2.Name = "BASeries2";
            this.BASeries2.Size = new System.Drawing.Size(69, 26);
            this.BASeries2.TabIndex = 23;
            // 
            // BASeries2Text
            // 
            this.BASeries2Text.Location = new System.Drawing.Point(145, 119);
            this.BASeries2Text.Margin = new System.Windows.Forms.Padding(3);
            this.BASeries2Text.Name = "BASeries2Text";
            this.BASeries2Text.Size = new System.Drawing.Size(58, 26);
            this.BASeries2Text.TabIndex = 22;
            this.BASeries2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BASeries1
            // 
            this.BASeries1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BASeries1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BASeries1.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.BASeries1.ForeColor = System.Drawing.Color.White;
            this.BASeries1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BASeries1.Location = new System.Drawing.Point(70, 119);
            this.BASeries1.Name = "BASeries1";
            this.BASeries1.Size = new System.Drawing.Size(69, 26);
            this.BASeries1.TabIndex = 21;
            // 
            // BASeries1Text
            // 
            this.BASeries1Text.Location = new System.Drawing.Point(6, 119);
            this.BASeries1Text.Margin = new System.Windows.Forms.Padding(3);
            this.BASeries1Text.Name = "BASeries1Text";
            this.BASeries1Text.Size = new System.Drawing.Size(58, 26);
            this.BASeries1Text.TabIndex = 20;
            this.BASeries1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BACHDes
            // 
            this.BACHDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BACHDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BACHDes.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.BACHDes.ForeColor = System.Drawing.Color.White;
            this.BACHDes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BACHDes.Location = new System.Drawing.Point(207, 87);
            this.BACHDes.Name = "BACHDes";
            this.BACHDes.Size = new System.Drawing.Size(402, 26);
            this.BACHDes.TabIndex = 19;
            // 
            // BACHDesText
            // 
            this.BACHDesText.Location = new System.Drawing.Point(120, 86);
            this.BACHDesText.Margin = new System.Windows.Forms.Padding(3);
            this.BACHDesText.Name = "BACHDesText";
            this.BACHDesText.Size = new System.Drawing.Size(81, 26);
            this.BACHDesText.TabIndex = 18;
            this.BACHDesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAJPDesText
            // 
            this.BAJPDesText.Location = new System.Drawing.Point(120, 54);
            this.BAJPDesText.Margin = new System.Windows.Forms.Padding(3);
            this.BAJPDesText.Name = "BAJPDesText";
            this.BAJPDesText.Size = new System.Drawing.Size(81, 26);
            this.BAJPDesText.TabIndex = 16;
            this.BAJPDesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAJPDes
            // 
            this.BAJPDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BAJPDes.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.BAJPDes.Location = new System.Drawing.Point(207, 54);
            this.BAJPDes.Margin = new System.Windows.Forms.Padding(3);
            this.BAJPDes.Name = "BAJPDes";
            this.BAJPDes.Size = new System.Drawing.Size(402, 26);
            this.BAJPDes.TabIndex = 15;
            this.BAJPDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BAForceByName
            // 
            this.BAForceByName.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.BAForceByName.Location = new System.Drawing.Point(6, 19);
            this.BAForceByName.Name = "BAForceByName";
            this.BAForceByName.Size = new System.Drawing.Size(108, 26);
            this.BAForceByName.TabIndex = 0;
            this.BAForceByName.UseVisualStyleBackColor = true;
            // 
            // Box_LS
            // 
            this.Box_LS.Controls.Add(this.SS);
            this.Box_LS.Controls.Add(this.SSText);
            this.Box_LS.Controls.Add(this.HP);
            this.Box_LS.Controls.Add(this.HPText);
            this.Box_LS.Controls.Add(this.MEN);
            this.Box_LS.Controls.Add(this.MENText);
            this.Box_LS.Controls.Add(this.INT);
            this.Box_LS.Controls.Add(this.INTText);
            this.Box_LS.Controls.Add(this.VIT);
            this.Box_LS.Controls.Add(this.VITText);
            this.Box_LS.Controls.Add(this.SpecScore);
            this.Box_LS.Controls.Add(this.SpecScoreText);
            this.Box_LS.Controls.Add(this.STR);
            this.Box_LS.Controls.Add(this.STRText);
            this.Box_LS.Controls.Add(this.Spec);
            this.Box_LS.Controls.Add(this.SpecText);
            this.Box_LS.Controls.Add(this.IDText);
            this.Box_LS.Controls.Add(this.ID);
            this.Box_LS.Controls.Add(this.EffectJPText);
            this.Box_LS.Controls.Add(this.EffectJP);
            this.Box_LS.Controls.Add(this.LSRegister);
            this.Box_LS.Controls.Add(this.TargetScore);
            this.Box_LS.Controls.Add(this.TargetScoreText);
            this.Box_LS.Controls.Add(this.TargetCH);
            this.Box_LS.Controls.Add(this.TargetCHText);
            this.Box_LS.Controls.Add(this.TargetJPText);
            this.Box_LS.Controls.Add(this.TargetJP);
            this.Box_LS.ForeColor = System.Drawing.Color.White;
            this.Box_LS.Location = new System.Drawing.Point(12, 63);
            this.Box_LS.Name = "Box_LS";
            this.Box_LS.Size = new System.Drawing.Size(616, 322);
            this.Box_LS.TabIndex = 29;
            this.Box_LS.TabStop = false;
            this.Box_LS.Visible = false;
            // 
            // SS
            // 
            this.SS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS.Font = new System.Drawing.Font("Consolas", 12F);
            this.SS.ForeColor = System.Drawing.Color.White;
            this.SS.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SS.Location = new System.Drawing.Point(566, 183);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(44, 26);
            this.SS.TabIndex = 46;
            this.SS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SSText
            // 
            this.SSText.Location = new System.Drawing.Point(519, 183);
            this.SSText.Margin = new System.Windows.Forms.Padding(3);
            this.SSText.Name = "SSText";
            this.SSText.Size = new System.Drawing.Size(41, 26);
            this.SSText.TabIndex = 45;
            this.SSText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HP
            // 
            this.HP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HP.Font = new System.Drawing.Font("Consolas", 12F);
            this.HP.ForeColor = System.Drawing.Color.White;
            this.HP.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.HP.Location = new System.Drawing.Point(469, 183);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(44, 26);
            this.HP.TabIndex = 44;
            this.HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HPText
            // 
            this.HPText.Location = new System.Drawing.Point(422, 183);
            this.HPText.Margin = new System.Windows.Forms.Padding(3);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(41, 26);
            this.HPText.TabIndex = 43;
            this.HPText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MEN
            // 
            this.MEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MEN.Font = new System.Drawing.Font("Consolas", 12F);
            this.MEN.ForeColor = System.Drawing.Color.White;
            this.MEN.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MEN.Location = new System.Drawing.Point(566, 151);
            this.MEN.Name = "MEN";
            this.MEN.Size = new System.Drawing.Size(44, 26);
            this.MEN.TabIndex = 42;
            this.MEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MENText
            // 
            this.MENText.Location = new System.Drawing.Point(519, 151);
            this.MENText.Margin = new System.Windows.Forms.Padding(3);
            this.MENText.Name = "MENText";
            this.MENText.Size = new System.Drawing.Size(41, 26);
            this.MENText.TabIndex = 41;
            this.MENText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INT
            // 
            this.INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.INT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.INT.Font = new System.Drawing.Font("Consolas", 12F);
            this.INT.ForeColor = System.Drawing.Color.White;
            this.INT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.INT.Location = new System.Drawing.Point(469, 151);
            this.INT.Name = "INT";
            this.INT.Size = new System.Drawing.Size(44, 26);
            this.INT.TabIndex = 40;
            this.INT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // INTText
            // 
            this.INTText.Location = new System.Drawing.Point(422, 151);
            this.INTText.Margin = new System.Windows.Forms.Padding(3);
            this.INTText.Name = "INTText";
            this.INTText.Size = new System.Drawing.Size(41, 26);
            this.INTText.TabIndex = 39;
            this.INTText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VIT
            // 
            this.VIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.VIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VIT.Font = new System.Drawing.Font("Consolas", 12F);
            this.VIT.ForeColor = System.Drawing.Color.White;
            this.VIT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.VIT.Location = new System.Drawing.Point(372, 151);
            this.VIT.Name = "VIT";
            this.VIT.Size = new System.Drawing.Size(44, 26);
            this.VIT.TabIndex = 38;
            this.VIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VITText
            // 
            this.VITText.Location = new System.Drawing.Point(325, 151);
            this.VITText.Margin = new System.Windows.Forms.Padding(3);
            this.VITText.Name = "VITText";
            this.VITText.Size = new System.Drawing.Size(41, 26);
            this.VITText.TabIndex = 37;
            this.VITText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecScore
            // 
            this.SpecScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SpecScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecScore.Font = new System.Drawing.Font("Consolas", 12F);
            this.SpecScore.ForeColor = System.Drawing.Color.White;
            this.SpecScore.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SpecScore.Location = new System.Drawing.Point(577, 119);
            this.SpecScore.Name = "SpecScore";
            this.SpecScore.Size = new System.Drawing.Size(33, 26);
            this.SpecScore.TabIndex = 34;
            this.SpecScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpecScoreText
            // 
            this.SpecScoreText.Location = new System.Drawing.Point(530, 119);
            this.SpecScoreText.Margin = new System.Windows.Forms.Padding(3);
            this.SpecScoreText.Name = "SpecScoreText";
            this.SpecScoreText.Size = new System.Drawing.Size(41, 26);
            this.SpecScoreText.TabIndex = 35;
            this.SpecScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STR
            // 
            this.STR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STR.Font = new System.Drawing.Font("Consolas", 12F);
            this.STR.ForeColor = System.Drawing.Color.White;
            this.STR.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.STR.Location = new System.Drawing.Point(275, 151);
            this.STR.Name = "STR";
            this.STR.Size = new System.Drawing.Size(44, 26);
            this.STR.TabIndex = 36;
            this.STR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STRText
            // 
            this.STRText.Location = new System.Drawing.Point(228, 151);
            this.STRText.Margin = new System.Windows.Forms.Padding(3);
            this.STRText.Name = "STRText";
            this.STRText.Size = new System.Drawing.Size(41, 26);
            this.STRText.TabIndex = 33;
            this.STRText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spec
            // 
            this.Spec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spec.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.Spec.ForeColor = System.Drawing.Color.White;
            this.Spec.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Spec.Location = new System.Drawing.Point(228, 119);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(296, 26);
            this.Spec.TabIndex = 32;
            // 
            // SpecText
            // 
            this.SpecText.Location = new System.Drawing.Point(120, 118);
            this.SpecText.Margin = new System.Windows.Forms.Padding(3);
            this.SpecText.Name = "SpecText";
            this.SpecText.Size = new System.Drawing.Size(102, 26);
            this.SpecText.TabIndex = 31;
            this.SpecText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(6, 22);
            this.IDText.Margin = new System.Windows.Forms.Padding(3);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(35, 26);
            this.IDText.TabIndex = 30;
            this.IDText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Font = new System.Drawing.Font("Consolas", 11F);
            this.ID.Location = new System.Drawing.Point(47, 22);
            this.ID.Margin = new System.Windows.Forms.Padding(3);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(67, 26);
            this.ID.TabIndex = 29;
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EffectJPText
            // 
            this.EffectJPText.Location = new System.Drawing.Point(120, 86);
            this.EffectJPText.Margin = new System.Windows.Forms.Padding(3);
            this.EffectJPText.Name = "EffectJPText";
            this.EffectJPText.Size = new System.Drawing.Size(102, 26);
            this.EffectJPText.TabIndex = 28;
            this.EffectJPText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EffectJP
            // 
            this.EffectJP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EffectJP.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.EffectJP.Location = new System.Drawing.Point(228, 86);
            this.EffectJP.Margin = new System.Windows.Forms.Padding(3);
            this.EffectJP.Name = "EffectJP";
            this.EffectJP.Size = new System.Drawing.Size(382, 26);
            this.EffectJP.TabIndex = 27;
            this.EffectJP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TargetScore
            // 
            this.TargetScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TargetScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetScore.Font = new System.Drawing.Font("Consolas", 12F);
            this.TargetScore.ForeColor = System.Drawing.Color.White;
            this.TargetScore.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TargetScore.Location = new System.Drawing.Point(577, 54);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(33, 26);
            this.TargetScore.TabIndex = 25;
            this.TargetScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TargetScoreText
            // 
            this.TargetScoreText.Location = new System.Drawing.Point(530, 54);
            this.TargetScoreText.Margin = new System.Windows.Forms.Padding(3);
            this.TargetScoreText.Name = "TargetScoreText";
            this.TargetScoreText.Size = new System.Drawing.Size(41, 26);
            this.TargetScoreText.TabIndex = 24;
            this.TargetScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetCH
            // 
            this.TargetCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TargetCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetCH.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.TargetCH.ForeColor = System.Drawing.Color.White;
            this.TargetCH.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TargetCH.Location = new System.Drawing.Point(228, 55);
            this.TargetCH.Name = "TargetCH";
            this.TargetCH.Size = new System.Drawing.Size(296, 26);
            this.TargetCH.TabIndex = 19;
            // 
            // TargetCHText
            // 
            this.TargetCHText.Location = new System.Drawing.Point(120, 54);
            this.TargetCHText.Margin = new System.Windows.Forms.Padding(3);
            this.TargetCHText.Name = "TargetCHText";
            this.TargetCHText.Size = new System.Drawing.Size(102, 26);
            this.TargetCHText.TabIndex = 18;
            this.TargetCHText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetJPText
            // 
            this.TargetJPText.Location = new System.Drawing.Point(120, 22);
            this.TargetJPText.Margin = new System.Windows.Forms.Padding(3);
            this.TargetJPText.Name = "TargetJPText";
            this.TargetJPText.Size = new System.Drawing.Size(102, 26);
            this.TargetJPText.TabIndex = 16;
            this.TargetJPText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetJP
            // 
            this.TargetJP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetJP.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.TargetJP.Location = new System.Drawing.Point(228, 22);
            this.TargetJP.Margin = new System.Windows.Forms.Padding(3);
            this.TargetJP.Name = "TargetJP";
            this.TargetJP.Size = new System.Drawing.Size(382, 26);
            this.TargetJP.TabIndex = 15;
            this.TargetJP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoRegister
            // 
            this.InfoRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InfoRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InfoRegister.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InfoRegister.ButtonBackgroundImage = null;
            this.InfoRegister.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InfoRegister.ButtonColor = System.Drawing.Color.White;
            this.InfoRegister.ButtonEnabled = true;
            this.InfoRegister.ButtonImage = null;
            this.InfoRegister.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoRegister.ButtonText = "";
            this.InfoRegister.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.InfoRegister.ForeColor = System.Drawing.Color.White;
            this.InfoRegister.Location = new System.Drawing.Point(550, 292);
            this.InfoRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoRegister.Name = "InfoRegister";
            this.InfoRegister.Size = new System.Drawing.Size(60, 24);
            this.InfoRegister.TabIndex = 26;
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
            this.Sys_Close.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Sys_Close.Name = "Sys_Close";
            this.Sys_Close.Size = new System.Drawing.Size(50, 24);
            this.Sys_Close.TabIndex = 10;
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
            this.Sys_Min.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Sys_Min.Name = "Sys_Min";
            this.Sys_Min.Size = new System.Drawing.Size(50, 24);
            this.Sys_Min.TabIndex = 11;
            // 
            // BARegister
            // 
            this.BARegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BARegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BARegister.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BARegister.ButtonBackgroundImage = null;
            this.BARegister.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BARegister.ButtonColor = System.Drawing.Color.White;
            this.BARegister.ButtonEnabled = true;
            this.BARegister.ButtonImage = null;
            this.BARegister.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BARegister.ButtonText = "";
            this.BARegister.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.BARegister.ForeColor = System.Drawing.Color.White;
            this.BARegister.Location = new System.Drawing.Point(550, 292);
            this.BARegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BARegister.Name = "BARegister";
            this.BARegister.Size = new System.Drawing.Size(60, 24);
            this.BARegister.TabIndex = 26;
            // 
            // LSRegister
            // 
            this.LSRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LSRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LSRegister.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LSRegister.ButtonBackgroundImage = null;
            this.LSRegister.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LSRegister.ButtonColor = System.Drawing.Color.White;
            this.LSRegister.ButtonEnabled = true;
            this.LSRegister.ButtonImage = null;
            this.LSRegister.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LSRegister.ButtonText = "";
            this.LSRegister.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.LSRegister.ForeColor = System.Drawing.Color.White;
            this.LSRegister.Location = new System.Drawing.Point(550, 292);
            this.LSRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LSRegister.Name = "LSRegister";
            this.LSRegister.Size = new System.Drawing.Size(60, 24);
            this.LSRegister.TabIndex = 26;
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
            this.Box_Info.ResumeLayout(false);
            this.Box_Info.PerformLayout();
            this.Box_BA.ResumeLayout(false);
            this.Box_BA.PerformLayout();
            this.Box_LS.ResumeLayout(false);
            this.Box_LS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Title;
        public Button_SE_ Sys_Min;
        public Button_SE_ Sys_Close;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Label RegTarget;
        private System.Windows.Forms.Label RegTargetText;
        private System.Windows.Forms.GroupBox Box_BA;
        private System.Windows.Forms.Label BACHDesText;
        private System.Windows.Forms.Label BAJPDesText;
        private System.Windows.Forms.Label BAJPDes;
        private System.Windows.Forms.CheckBox BAForceByName;
        public Button_SE_ BARegister;
        private System.Windows.Forms.TextBox BAScore;
        private System.Windows.Forms.Label BAScoreText;
        private System.Windows.Forms.TextBox BASeries2;
        private System.Windows.Forms.Label BASeries2Text;
        private System.Windows.Forms.TextBox BASeries1;
        private System.Windows.Forms.Label BASeries1Text;
        private System.Windows.Forms.TextBox BACHDes;
        private System.Windows.Forms.Label PathText;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Label BAJPNameText;
        private System.Windows.Forms.Label BAJPName;
        private System.Windows.Forms.GroupBox Box_LS;
        private System.Windows.Forms.Label EffectJPText;
        private System.Windows.Forms.Label EffectJP;
        public Button_SE_ LSRegister;
        private System.Windows.Forms.TextBox TargetScore;
        private System.Windows.Forms.Label TargetScoreText;
        private System.Windows.Forms.TextBox TargetCH;
        private System.Windows.Forms.Label TargetCHText;
        private System.Windows.Forms.Label TargetJPText;
        private System.Windows.Forms.Label TargetJP;
        private System.Windows.Forms.TextBox Spec;
        private System.Windows.Forms.Label SpecText;
        private System.Windows.Forms.Label IDText;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox SS;
        private System.Windows.Forms.Label SSText;
        private System.Windows.Forms.TextBox HP;
        private System.Windows.Forms.Label HPText;
        private System.Windows.Forms.TextBox MEN;
        private System.Windows.Forms.Label MENText;
        private System.Windows.Forms.TextBox INT;
        private System.Windows.Forms.Label INTText;
        private System.Windows.Forms.TextBox VIT;
        private System.Windows.Forms.Label VITText;
        private System.Windows.Forms.TextBox SpecScore;
        private System.Windows.Forms.Label SpecScoreText;
        private System.Windows.Forms.TextBox STR;
        private System.Windows.Forms.Label STRText;
        private System.Windows.Forms.GroupBox Box_Info;
        public Button_SE_ InfoRegister;
        private System.Windows.Forms.TextBox FolkName1;
        private System.Windows.Forms.Label FolkNameText;
        private System.Windows.Forms.Label CharaIDText;
        private System.Windows.Forms.Label CharaID;
        private System.Windows.Forms.TextBox FolkName4;
        private System.Windows.Forms.TextBox FolkName3;
        private System.Windows.Forms.TextBox FolkName2;
        private System.Windows.Forms.DateTimePicker ReleaseDate;
        private System.Windows.Forms.TextBox GetMethod;
        private System.Windows.Forms.Label GetMethodText;
        private System.Windows.Forms.Label ReleaseDateText;
        private System.Windows.Forms.TextBox FolkName5;
    }
}