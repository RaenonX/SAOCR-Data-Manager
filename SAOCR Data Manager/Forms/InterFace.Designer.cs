namespace SAOCR_Data_Manager
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MN_Title = new System.Windows.Forms.Label();
            this.P_HomePage = new System.Windows.Forms.Panel();
            this.HM_ToStatistics = new SAOCR_Data_Manager.Button_SE_();
            this.HM_Announcement = new SAOCR_Data_Manager.MarqueeableLabel();
            this.HM_ToConfig = new SAOCR_Data_Manager.Button_SE_();
            this.HM_ToCsvTable = new SAOCR_Data_Manager.Button_SE_();
            this.HM_Res_Load = new SAOCR_Data_Manager.Button_SE_();
            this.HM_Res_Select = new SAOCR_Data_Manager.Button_SE_();
            this.HM_ToEquipmentData = new SAOCR_Data_Manager.Button_SE_();
            this.HM_ToCharacterData = new SAOCR_Data_Manager.Button_SE_();
            this.BGM = new AxWMPLib.AxWindowsMediaPlayer();
            this.MN_Border = new System.Windows.Forms.Panel();
            this.MN_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MN_Capture = new System.Windows.Forms.ToolStripButton();
            this.MN_Button = new System.Windows.Forms.ToolStripDropDownButton();
            this.MN_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.HM_ToHomePage = new SAOCR_Data_Manager.Button_SE_();
            this.MN_Close = new SAOCR_Data_Manager.Button_SE_();
            this.MN_Min = new SAOCR_Data_Manager.Button_SE_();
            this.P_Statistics = new System.Windows.Forms.Panel();
            this.SS_Monster = new System.Windows.Forms.GroupBox();
            this.SS_Character = new System.Windows.Forms.GroupBox();
            this.SS_ChsaraElementRateText = new System.Windows.Forms.Label();
            this.SS_CharaElementRate = new System.Windows.Forms.ListView();
            this.SS_CharaCalculate = new SAOCR_Data_Manager.Button_SE_();
            this.SS_CharaWeaponUsingRateText = new System.Windows.Forms.Label();
            this.SS_CharaWeaponUsingRate = new System.Windows.Forms.ListView();
            this.SS_Weapon = new System.Windows.Forms.GroupBox();
            this.P_CsvTable = new System.Windows.Forms.Panel();
            this.CT_FindResultList = new System.Windows.Forms.ListView();
            this.CT_SearchGo = new SAOCR_Data_Manager.Button_SE_();
            this.CT_Search = new System.Windows.Forms.TextBox();
            this.CT_SearchString = new System.Windows.Forms.Label();
            this.CT_EndColumnLabel = new System.Windows.Forms.Label();
            this.CT_StartColumnLabel = new System.Windows.Forms.Label();
            this.CT_EndColumn = new System.Windows.Forms.NumericUpDown();
            this.CT_StartColumn = new System.Windows.Forms.NumericUpDown();
            this.CT_Tips = new SAOCR_Data_Manager.MarqueeableLabel();
            this.CT_StepGo = new SAOCR_Data_Manager.Button_SE_();
            this.CT_StepLabel = new System.Windows.Forms.Label();
            this.CT_Step = new System.Windows.Forms.TextBox();
            this.CT_CsvView = new System.Windows.Forms.DataGridView();
            this.P_Config = new System.Windows.Forms.Panel();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.ST_AUProg = new System.Windows.Forms.GroupBox();
            this.ST_AUProgCheckGo = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AUProgChannel = new System.Windows.Forms.ComboBox();
            this.ST_AUProgMode = new System.Windows.Forms.ComboBox();
            this.ST_AUProgChannelText = new System.Windows.Forms.Label();
            this.ST_AUProgModeText = new System.Windows.Forms.Label();
            this.ST_AUProgLatestVerText = new System.Windows.Forms.Label();
            this.ST_AUProgLatestVer = new System.Windows.Forms.Label();
            this.ST_AUProgCurrentVerText = new System.Windows.Forms.Label();
            this.ST_AUProgCurrentVer = new System.Windows.Forms.Label();
            this.ST_AboutProgram = new System.Windows.Forms.GroupBox();
            this.ST_DevelopersText = new System.Windows.Forms.Label();
            this.ST_Developer = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_VersionText = new System.Windows.Forms.Label();
            this.ST_Version = new System.Windows.Forms.Label();
            this.ST_DataTitle = new System.Windows.Forms.GroupBox();
            this.ST_AUCsvBrowse = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AUCsvCheckGo = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AUCsvPath = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_AUCsvMode = new System.Windows.Forms.ComboBox();
            this.ST_AutoLoad = new System.Windows.Forms.CheckBox();
            this.ST_ReadTitle = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AUCsvPathText = new System.Windows.Forms.Label();
            this.ST_Data = new System.Windows.Forms.ListView();
            this.ST_AUCsvModeText = new System.Windows.Forms.Label();
            this.ST_SoundPath = new System.Windows.Forms.GroupBox();
            this.ST_PathMessageMute = new System.Windows.Forms.CheckBox();
            this.ST_PathMessageBrowse = new SAOCR_Data_Manager.Button_SE_();
            this.ST_PathMessage = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_PathMessageText = new System.Windows.Forms.Label();
            this.ST_PathBGMMute = new System.Windows.Forms.CheckBox();
            this.ST_PathWarningMute = new System.Windows.Forms.CheckBox();
            this.ST_PathBeepMute = new System.Windows.Forms.CheckBox();
            this.ST_PathBGMText = new System.Windows.Forms.Label();
            this.ST_PathBGM = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_PathWarningBrowse = new SAOCR_Data_Manager.Button_SE_();
            this.ST_PathBGMBrowse = new SAOCR_Data_Manager.Button_SE_();
            this.ST_PathBeepText = new System.Windows.Forms.Label();
            this.ST_PathBeepBrowse = new SAOCR_Data_Manager.Button_SE_();
            this.ST_PathWarning = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_PathBeep = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_PathWarningText = new System.Windows.Forms.Label();
            this.P_CharacterData = new System.Windows.Forms.Panel();
            this.CD_CloseTab = new SAOCR_Data_Manager.Button_SE_();
            this.CD_NewTab = new SAOCR_Data_Manager.Button_SE_();
            this.CD_CharacterTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CharaDataDisplay = new SAOCR_Data_Manager.Forms.CharaDataDisplay();
            this.CD_Favorite = new System.Windows.Forms.ListView();
            this.CD_SearchGB = new System.Windows.Forms.GroupBox();
            this.CD_SeriesCodeGo = new System.Windows.Forms.LinkLabel();
            this.CD_CharaSeries = new System.Windows.Forms.TextBox();
            this.CD_CharaSeriesText = new System.Windows.Forms.Label();
            this.CD_Rarity = new System.Windows.Forms.TextBox();
            this.CD_RarityText = new System.Windows.Forms.Label();
            this.CD_KeywordResult = new System.Windows.Forms.ListView();
            this.CD_KeywordText = new System.Windows.Forms.Label();
            this.CD_Keyword = new System.Windows.Forms.TextBox();
            this.CD_KeywordGo = new SAOCR_Data_Manager.Button_SE_();
            this.CD_CharacterIDText = new System.Windows.Forms.Label();
            this.CD_CharacterIDGo = new SAOCR_Data_Manager.Button_SE_();
            this.CD_CharacterID = new System.Windows.Forms.TextBox();
            this.CD_FavoriteText = new System.Windows.Forms.Label();
            this.EX_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EX_DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.P_HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).BeginInit();
            this.MN_Border.SuspendLayout();
            this.MN_StatusStrip.SuspendLayout();
            this.P_Statistics.SuspendLayout();
            this.SS_Character.SuspendLayout();
            this.P_CsvTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_EndColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_StartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_CsvView)).BeginInit();
            this.P_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.ST_AUProg.SuspendLayout();
            this.ST_AboutProgram.SuspendLayout();
            this.ST_DataTitle.SuspendLayout();
            this.ST_SoundPath.SuspendLayout();
            this.P_CharacterData.SuspendLayout();
            this.CD_CharacterTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CD_SearchGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MN_Title
            // 
            this.MN_Title.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.MN_Title.ForeColor = System.Drawing.Color.Coral;
            this.MN_Title.Location = new System.Drawing.Point(1, 1);
            this.MN_Title.Margin = new System.Windows.Forms.Padding(0);
            this.MN_Title.Name = "MN_Title";
            this.MN_Title.Size = new System.Drawing.Size(978, 24);
            this.MN_Title.TabIndex = 0;
            this.MN_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_HomePage
            // 
            this.P_HomePage.Controls.Add(this.HM_ToStatistics);
            this.P_HomePage.Controls.Add(this.HM_Announcement);
            this.P_HomePage.Controls.Add(this.HM_ToConfig);
            this.P_HomePage.Controls.Add(this.HM_ToCsvTable);
            this.P_HomePage.Controls.Add(this.HM_Res_Load);
            this.P_HomePage.Controls.Add(this.HM_Res_Select);
            this.P_HomePage.Controls.Add(this.HM_ToEquipmentData);
            this.P_HomePage.Controls.Add(this.HM_ToCharacterData);
            this.P_HomePage.Location = new System.Drawing.Point(1, 24);
            this.P_HomePage.Margin = new System.Windows.Forms.Padding(0);
            this.P_HomePage.Name = "P_HomePage";
            this.P_HomePage.Size = new System.Drawing.Size(1078, 695);
            this.P_HomePage.TabIndex = 4;
            // 
            // HM_ToStatistics
            // 
            this.HM_ToStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToStatistics.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToStatistics.ButtonBackgroundImage = null;
            this.HM_ToStatistics.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToStatistics.ButtonColor = System.Drawing.Color.White;
            this.HM_ToStatistics.ButtonEnabled = true;
            this.HM_ToStatistics.ButtonImage = null;
            this.HM_ToStatistics.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToStatistics.ButtonText = "";
            this.HM_ToStatistics.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToStatistics.ForeColor = System.Drawing.Color.White;
            this.HM_ToStatistics.Location = new System.Drawing.Point(11, 184);
            this.HM_ToStatistics.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_ToStatistics.Name = "HM_ToStatistics";
            this.HM_ToStatistics.Size = new System.Drawing.Size(237, 170);
            this.HM_ToStatistics.TabIndex = 12;
            // 
            // HM_Announcement
            // 
            this.HM_Announcement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.HM_Announcement.Direction = MarqueeDirection.Vertical;
            this.HM_Announcement.EnableMarquee = true;
            this.HM_Announcement.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.HM_Announcement.FreezeTime = 3000;
            this.HM_Announcement.LabelSize = new System.Drawing.Size(829, 30);
            this.HM_Announcement.LeftDistance = 5;
            this.HM_Announcement.LForeColor = System.Drawing.Color.White;
            this.HM_Announcement.Location = new System.Drawing.Point(12, 637);
            this.HM_Announcement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HM_Announcement.MarqueeText = "";
            this.HM_Announcement.Mode = MarqueeMode.ContinualAndSneeze;
            this.HM_Announcement.MoveDifferenceEachTime = 1;
            this.HM_Announcement.MoveInterval = 15;
            this.HM_Announcement.Name = "HM_Announcement";
            this.HM_Announcement.OverBorderDistance = 0;
            this.HM_Announcement.Size = new System.Drawing.Size(829, 30);
            this.HM_Announcement.TabIndex = 11;
            // 
            // HM_ToConfig
            // 
            this.HM_ToConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToConfig.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToConfig.ButtonBackgroundImage = null;
            this.HM_ToConfig.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToConfig.ButtonColor = System.Drawing.Color.White;
            this.HM_ToConfig.ButtonEnabled = true;
            this.HM_ToConfig.ButtonImage = null;
            this.HM_ToConfig.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToConfig.ButtonText = "";
            this.HM_ToConfig.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToConfig.ForeColor = System.Drawing.Color.White;
            this.HM_ToConfig.Location = new System.Drawing.Point(740, 9);
            this.HM_ToConfig.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_ToConfig.Name = "HM_ToConfig";
            this.HM_ToConfig.Size = new System.Drawing.Size(237, 170);
            this.HM_ToConfig.TabIndex = 10;
            // 
            // HM_ToCsvTable
            // 
            this.HM_ToCsvTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToCsvTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToCsvTable.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToCsvTable.ButtonBackgroundImage = null;
            this.HM_ToCsvTable.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToCsvTable.ButtonColor = System.Drawing.Color.White;
            this.HM_ToCsvTable.ButtonEnabled = true;
            this.HM_ToCsvTable.ButtonImage = null;
            this.HM_ToCsvTable.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToCsvTable.ButtonText = "";
            this.HM_ToCsvTable.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToCsvTable.ForeColor = System.Drawing.Color.White;
            this.HM_ToCsvTable.Location = new System.Drawing.Point(497, 9);
            this.HM_ToCsvTable.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_ToCsvTable.Name = "HM_ToCsvTable";
            this.HM_ToCsvTable.Size = new System.Drawing.Size(237, 170);
            this.HM_ToCsvTable.TabIndex = 9;
            // 
            // HM_Res_Load
            // 
            this.HM_Res_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_Res_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_Res_Load.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_Res_Load.ButtonBackgroundImage = null;
            this.HM_Res_Load.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_Res_Load.ButtonColor = System.Drawing.Color.White;
            this.HM_Res_Load.ButtonEnabled = true;
            this.HM_Res_Load.ButtonImage = null;
            this.HM_Res_Load.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_Res_Load.ButtonText = "";
            this.HM_Res_Load.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.HM_Res_Load.ForeColor = System.Drawing.Color.White;
            this.HM_Res_Load.Location = new System.Drawing.Point(847, 637);
            this.HM_Res_Load.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_Res_Load.Name = "HM_Res_Load";
            this.HM_Res_Load.Size = new System.Drawing.Size(107, 30);
            this.HM_Res_Load.TabIndex = 7;
            // 
            // HM_Res_Select
            // 
            this.HM_Res_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_Res_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_Res_Select.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_Res_Select.ButtonBackgroundImage = null;
            this.HM_Res_Select.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_Res_Select.ButtonColor = System.Drawing.Color.White;
            this.HM_Res_Select.ButtonEnabled = true;
            this.HM_Res_Select.ButtonImage = null;
            this.HM_Res_Select.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_Res_Select.ButtonText = "";
            this.HM_Res_Select.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.HM_Res_Select.ForeColor = System.Drawing.Color.White;
            this.HM_Res_Select.Location = new System.Drawing.Point(960, 637);
            this.HM_Res_Select.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_Res_Select.Name = "HM_Res_Select";
            this.HM_Res_Select.Size = new System.Drawing.Size(107, 30);
            this.HM_Res_Select.TabIndex = 6;
            // 
            // HM_ToEquipmentData
            // 
            this.HM_ToEquipmentData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToEquipmentData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToEquipmentData.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToEquipmentData.ButtonBackgroundImage = null;
            this.HM_ToEquipmentData.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToEquipmentData.ButtonColor = System.Drawing.Color.White;
            this.HM_ToEquipmentData.ButtonEnabled = true;
            this.HM_ToEquipmentData.ButtonImage = null;
            this.HM_ToEquipmentData.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToEquipmentData.ButtonText = "";
            this.HM_ToEquipmentData.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToEquipmentData.ForeColor = System.Drawing.Color.White;
            this.HM_ToEquipmentData.Location = new System.Drawing.Point(254, 9);
            this.HM_ToEquipmentData.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_ToEquipmentData.Name = "HM_ToEquipmentData";
            this.HM_ToEquipmentData.Size = new System.Drawing.Size(237, 170);
            this.HM_ToEquipmentData.TabIndex = 4;
            // 
            // HM_ToCharacterData
            // 
            this.HM_ToCharacterData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToCharacterData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToCharacterData.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToCharacterData.ButtonBackgroundImage = null;
            this.HM_ToCharacterData.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToCharacterData.ButtonColor = System.Drawing.Color.White;
            this.HM_ToCharacterData.ButtonEnabled = true;
            this.HM_ToCharacterData.ButtonImage = null;
            this.HM_ToCharacterData.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToCharacterData.ButtonText = "";
            this.HM_ToCharacterData.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToCharacterData.ForeColor = System.Drawing.Color.White;
            this.HM_ToCharacterData.Location = new System.Drawing.Point(11, 8);
            this.HM_ToCharacterData.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_ToCharacterData.Name = "HM_ToCharacterData";
            this.HM_ToCharacterData.Size = new System.Drawing.Size(237, 170);
            this.HM_ToCharacterData.TabIndex = 3;
            // 
            // BGM
            // 
            this.BGM.Enabled = true;
            this.BGM.Location = new System.Drawing.Point(576, 2);
            this.BGM.Name = "BGM";
            this.BGM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGM.OcxState")));
            this.BGM.Size = new System.Drawing.Size(75, 23);
            this.BGM.TabIndex = 22;
            this.BGM.Visible = false;
            // 
            // MN_Border
            // 
            this.MN_Border.Controls.Add(this.MN_StatusStrip);
            this.MN_Border.Controls.Add(this.HM_ToHomePage);
            this.MN_Border.Controls.Add(this.MN_Close);
            this.MN_Border.Controls.Add(this.MN_Min);
            this.MN_Border.Controls.Add(this.MN_Title);
            this.MN_Border.Controls.Add(this.BGM);
            this.MN_Border.Controls.Add(this.P_Statistics);
            this.MN_Border.Controls.Add(this.P_CsvTable);
            this.MN_Border.Controls.Add(this.P_Config);
            this.MN_Border.Controls.Add(this.P_CharacterData);
            this.MN_Border.Controls.Add(this.P_HomePage);
            this.MN_Border.Location = new System.Drawing.Point(0, 0);
            this.MN_Border.Name = "MN_Border";
            this.MN_Border.Size = new System.Drawing.Size(1080, 720);
            this.MN_Border.TabIndex = 5;
            // 
            // MN_StatusStrip
            // 
            this.MN_StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MN_StatusStrip.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.MN_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_Capture,
            this.MN_Button,
            this.MN_Status});
            this.MN_StatusStrip.Location = new System.Drawing.Point(0, 698);
            this.MN_StatusStrip.Name = "MN_StatusStrip";
            this.MN_StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MN_StatusStrip.Size = new System.Drawing.Size(1080, 22);
            this.MN_StatusStrip.SizingGrip = false;
            this.MN_StatusStrip.TabIndex = 12;
            // 
            // MN_Capture
            // 
            this.MN_Capture.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MN_Capture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MN_Capture.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.MN_Capture.ForeColor = System.Drawing.Color.White;
            this.MN_Capture.Image = ((System.Drawing.Image)(resources.GetObject("MN_Capture.Image")));
            this.MN_Capture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MN_Capture.Name = "MN_Capture";
            this.MN_Capture.Size = new System.Drawing.Size(23, 20);
            // 
            // MN_Button
            // 
            this.MN_Button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MN_Button.AutoToolTip = false;
            this.MN_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MN_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MN_Button.ForeColor = System.Drawing.Color.White;
            this.MN_Button.Image = global::SAOCR_Data_Manager.Properties.Resources.Icon;
            this.MN_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MN_Button.MergeIndex = 1;
            this.MN_Button.Name = "MN_Button";
            this.MN_Button.Size = new System.Drawing.Size(29, 20);
            // 
            // MN_Status
            // 
            this.MN_Status.MergeIndex = 0;
            this.MN_Status.Name = "MN_Status";
            this.MN_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // HM_ToHomePage
            // 
            this.HM_ToHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToHomePage.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToHomePage.ButtonBackgroundImage = null;
            this.HM_ToHomePage.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToHomePage.ButtonColor = System.Drawing.Color.White;
            this.HM_ToHomePage.ButtonEnabled = true;
            this.HM_ToHomePage.ButtonImage = null;
            this.HM_ToHomePage.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToHomePage.ButtonText = "";
            this.HM_ToHomePage.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.HM_ToHomePage.ForeColor = System.Drawing.Color.White;
            this.HM_ToHomePage.Location = new System.Drawing.Point(888, 1);
            this.HM_ToHomePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HM_ToHomePage.Name = "HM_ToHomePage";
            this.HM_ToHomePage.Size = new System.Drawing.Size(67, 24);
            this.HM_ToHomePage.TabIndex = 5;
            // 
            // MN_Close
            // 
            this.MN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MN_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MN_Close.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MN_Close.ButtonBackgroundImage = null;
            this.MN_Close.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MN_Close.ButtonColor = System.Drawing.Color.Red;
            this.MN_Close.ButtonEnabled = true;
            this.MN_Close.ButtonImage = null;
            this.MN_Close.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MN_Close.ButtonText = "";
            this.MN_Close.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.MN_Close.ForeColor = System.Drawing.Color.Red;
            this.MN_Close.Location = new System.Drawing.Point(1029, 1);
            this.MN_Close.Margin = new System.Windows.Forms.Padding(0);
            this.MN_Close.Name = "MN_Close";
            this.MN_Close.Size = new System.Drawing.Size(50, 24);
            this.MN_Close.TabIndex = 1;
            // 
            // MN_Min
            // 
            this.MN_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MN_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MN_Min.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MN_Min.ButtonBackgroundImage = null;
            this.MN_Min.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MN_Min.ButtonColor = System.Drawing.Color.White;
            this.MN_Min.ButtonEnabled = true;
            this.MN_Min.ButtonImage = null;
            this.MN_Min.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MN_Min.ButtonText = "";
            this.MN_Min.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.MN_Min.ForeColor = System.Drawing.Color.White;
            this.MN_Min.Location = new System.Drawing.Point(979, 1);
            this.MN_Min.Margin = new System.Windows.Forms.Padding(0);
            this.MN_Min.Name = "MN_Min";
            this.MN_Min.Size = new System.Drawing.Size(50, 24);
            this.MN_Min.TabIndex = 2;
            // 
            // P_Statistics
            // 
            this.P_Statistics.Controls.Add(this.SS_Monster);
            this.P_Statistics.Controls.Add(this.SS_Character);
            this.P_Statistics.Controls.Add(this.SS_Weapon);
            this.P_Statistics.Location = new System.Drawing.Point(1, 24);
            this.P_Statistics.Margin = new System.Windows.Forms.Padding(0);
            this.P_Statistics.Name = "P_Statistics";
            this.P_Statistics.Size = new System.Drawing.Size(1078, 695);
            this.P_Statistics.TabIndex = 21;
            this.P_Statistics.Visible = false;
            // 
            // SS_Monster
            // 
            this.SS_Monster.ForeColor = System.Drawing.Color.White;
            this.SS_Monster.Location = new System.Drawing.Point(365, 92);
            this.SS_Monster.Name = "SS_Monster";
            this.SS_Monster.Size = new System.Drawing.Size(200, 185);
            this.SS_Monster.TabIndex = 1;
            this.SS_Monster.TabStop = false;
            // 
            // SS_Character
            // 
            this.SS_Character.Controls.Add(this.SS_ChsaraElementRateText);
            this.SS_Character.Controls.Add(this.SS_CharaElementRate);
            this.SS_Character.Controls.Add(this.SS_CharaCalculate);
            this.SS_Character.Controls.Add(this.SS_CharaWeaponUsingRateText);
            this.SS_Character.Controls.Add(this.SS_CharaWeaponUsingRate);
            this.SS_Character.ForeColor = System.Drawing.Color.White;
            this.SS_Character.Location = new System.Drawing.Point(12, 4);
            this.SS_Character.Name = "SS_Character";
            this.SS_Character.Size = new System.Drawing.Size(349, 663);
            this.SS_Character.TabIndex = 1;
            this.SS_Character.TabStop = false;
            // 
            // SS_ChsaraElementRateText
            // 
            this.SS_ChsaraElementRateText.Location = new System.Drawing.Point(6, 202);
            this.SS_ChsaraElementRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_ChsaraElementRateText.Name = "SS_ChsaraElementRateText";
            this.SS_ChsaraElementRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_ChsaraElementRateText.TabIndex = 27;
            this.SS_ChsaraElementRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_CharaElementRate
            // 
            this.SS_CharaElementRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaElementRate.AutoArrange = false;
            this.SS_CharaElementRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaElementRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaElementRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaElementRate.FullRowSelect = true;
            this.SS_CharaElementRate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SS_CharaElementRate.Location = new System.Drawing.Point(6, 226);
            this.SS_CharaElementRate.MultiSelect = false;
            this.SS_CharaElementRate.Name = "SS_CharaElementRate";
            this.SS_CharaElementRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaElementRate.TabIndex = 26;
            this.SS_CharaElementRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaElementRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_CharaCalculate
            // 
            this.SS_CharaCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SS_CharaCalculate.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SS_CharaCalculate.ButtonBackgroundImage = null;
            this.SS_CharaCalculate.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SS_CharaCalculate.ButtonColor = System.Drawing.Color.White;
            this.SS_CharaCalculate.ButtonEnabled = true;
            this.SS_CharaCalculate.ButtonImage = null;
            this.SS_CharaCalculate.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SS_CharaCalculate.ButtonText = "";
            this.SS_CharaCalculate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.SS_CharaCalculate.Location = new System.Drawing.Point(278, 628);
            this.SS_CharaCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SS_CharaCalculate.Name = "SS_CharaCalculate";
            this.SS_CharaCalculate.Size = new System.Drawing.Size(65, 28);
            this.SS_CharaCalculate.TabIndex = 23;
            // 
            // SS_CharaWeaponUsingRateText
            // 
            this.SS_CharaWeaponUsingRateText.Location = new System.Drawing.Point(6, 22);
            this.SS_CharaWeaponUsingRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_CharaWeaponUsingRateText.Name = "SS_CharaWeaponUsingRateText";
            this.SS_CharaWeaponUsingRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_CharaWeaponUsingRateText.TabIndex = 25;
            this.SS_CharaWeaponUsingRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_CharaWeaponUsingRate
            // 
            this.SS_CharaWeaponUsingRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaWeaponUsingRate.AutoArrange = false;
            this.SS_CharaWeaponUsingRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaWeaponUsingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaWeaponUsingRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaWeaponUsingRate.FullRowSelect = true;
            this.SS_CharaWeaponUsingRate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SS_CharaWeaponUsingRate.Location = new System.Drawing.Point(6, 46);
            this.SS_CharaWeaponUsingRate.MultiSelect = false;
            this.SS_CharaWeaponUsingRate.Name = "SS_CharaWeaponUsingRate";
            this.SS_CharaWeaponUsingRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaWeaponUsingRate.TabIndex = 24;
            this.SS_CharaWeaponUsingRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaWeaponUsingRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_Weapon
            // 
            this.SS_Weapon.ForeColor = System.Drawing.Color.White;
            this.SS_Weapon.Location = new System.Drawing.Point(632, 120);
            this.SS_Weapon.Name = "SS_Weapon";
            this.SS_Weapon.Size = new System.Drawing.Size(332, 375);
            this.SS_Weapon.TabIndex = 0;
            this.SS_Weapon.TabStop = false;
            // 
            // P_CsvTable
            // 
            this.P_CsvTable.Controls.Add(this.CT_FindResultList);
            this.P_CsvTable.Controls.Add(this.CT_SearchGo);
            this.P_CsvTable.Controls.Add(this.CT_Search);
            this.P_CsvTable.Controls.Add(this.CT_SearchString);
            this.P_CsvTable.Controls.Add(this.CT_EndColumnLabel);
            this.P_CsvTable.Controls.Add(this.CT_StartColumnLabel);
            this.P_CsvTable.Controls.Add(this.CT_EndColumn);
            this.P_CsvTable.Controls.Add(this.CT_StartColumn);
            this.P_CsvTable.Controls.Add(this.CT_Tips);
            this.P_CsvTable.Controls.Add(this.CT_StepGo);
            this.P_CsvTable.Controls.Add(this.CT_StepLabel);
            this.P_CsvTable.Controls.Add(this.CT_Step);
            this.P_CsvTable.Controls.Add(this.CT_CsvView);
            this.P_CsvTable.Location = new System.Drawing.Point(1, 24);
            this.P_CsvTable.Margin = new System.Windows.Forms.Padding(0);
            this.P_CsvTable.Name = "P_CsvTable";
            this.P_CsvTable.Size = new System.Drawing.Size(1078, 695);
            this.P_CsvTable.TabIndex = 10;
            this.P_CsvTable.Visible = false;
            // 
            // CT_FindResultList
            // 
            this.CT_FindResultList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.CT_FindResultList.AutoArrange = false;
            this.CT_FindResultList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CT_FindResultList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CT_FindResultList.ForeColor = System.Drawing.Color.White;
            this.CT_FindResultList.FullRowSelect = true;
            this.CT_FindResultList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CT_FindResultList.Location = new System.Drawing.Point(11, 147);
            this.CT_FindResultList.MultiSelect = false;
            this.CT_FindResultList.Name = "CT_FindResultList";
            this.CT_FindResultList.Size = new System.Drawing.Size(234, 255);
            this.CT_FindResultList.TabIndex = 20;
            this.CT_FindResultList.UseCompatibleStateImageBehavior = false;
            this.CT_FindResultList.View = System.Windows.Forms.View.Details;
            // 
            // CT_SearchGo
            // 
            this.CT_SearchGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CT_SearchGo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CT_SearchGo.ButtonBackgroundImage = null;
            this.CT_SearchGo.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CT_SearchGo.ButtonColor = System.Drawing.Color.White;
            this.CT_SearchGo.ButtonEnabled = true;
            this.CT_SearchGo.ButtonImage = null;
            this.CT_SearchGo.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CT_SearchGo.ButtonText = "";
            this.CT_SearchGo.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CT_SearchGo.Location = new System.Drawing.Point(193, 118);
            this.CT_SearchGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CT_SearchGo.Name = "CT_SearchGo";
            this.CT_SearchGo.Size = new System.Drawing.Size(52, 23);
            this.CT_SearchGo.TabIndex = 19;
            // 
            // CT_Search
            // 
            this.CT_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CT_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CT_Search.ForeColor = System.Drawing.Color.White;
            this.CT_Search.Location = new System.Drawing.Point(11, 118);
            this.CT_Search.Name = "CT_Search";
            this.CT_Search.Size = new System.Drawing.Size(176, 23);
            this.CT_Search.TabIndex = 18;
            // 
            // CT_SearchString
            // 
            this.CT_SearchString.Location = new System.Drawing.Point(11, 88);
            this.CT_SearchString.Margin = new System.Windows.Forms.Padding(3);
            this.CT_SearchString.Name = "CT_SearchString";
            this.CT_SearchString.Size = new System.Drawing.Size(234, 23);
            this.CT_SearchString.TabIndex = 17;
            this.CT_SearchString.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CT_EndColumnLabel
            // 
            this.CT_EndColumnLabel.Location = new System.Drawing.Point(131, 60);
            this.CT_EndColumnLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CT_EndColumnLabel.Name = "CT_EndColumnLabel";
            this.CT_EndColumnLabel.Size = new System.Drawing.Size(63, 23);
            this.CT_EndColumnLabel.TabIndex = 16;
            this.CT_EndColumnLabel.Text = "截止欄位";
            this.CT_EndColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CT_StartColumnLabel
            // 
            this.CT_StartColumnLabel.Location = new System.Drawing.Point(11, 60);
            this.CT_StartColumnLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CT_StartColumnLabel.Name = "CT_StartColumnLabel";
            this.CT_StartColumnLabel.Size = new System.Drawing.Size(63, 23);
            this.CT_StartColumnLabel.TabIndex = 15;
            this.CT_StartColumnLabel.Text = "起始欄位";
            this.CT_StartColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CT_EndColumn
            // 
            this.CT_EndColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CT_EndColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CT_EndColumn.ForeColor = System.Drawing.Color.White;
            this.CT_EndColumn.Location = new System.Drawing.Point(200, 60);
            this.CT_EndColumn.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.CT_EndColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CT_EndColumn.Name = "CT_EndColumn";
            this.CT_EndColumn.Size = new System.Drawing.Size(45, 23);
            this.CT_EndColumn.TabIndex = 14;
            this.CT_EndColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CT_EndColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CT_StartColumn
            // 
            this.CT_StartColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CT_StartColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CT_StartColumn.ForeColor = System.Drawing.Color.White;
            this.CT_StartColumn.Location = new System.Drawing.Point(80, 60);
            this.CT_StartColumn.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.CT_StartColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CT_StartColumn.Name = "CT_StartColumn";
            this.CT_StartColumn.Size = new System.Drawing.Size(45, 23);
            this.CT_StartColumn.TabIndex = 13;
            this.CT_StartColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CT_StartColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CT_Tips
            // 
            this.CT_Tips.Direction = MarqueeDirection.Horizontal;
            this.CT_Tips.EnableMarquee = true;
            this.CT_Tips.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CT_Tips.FreezeTime = 2000;
            this.CT_Tips.LabelSize = new System.Drawing.Size(234, 23);
            this.CT_Tips.LeftDistance = 5;
            this.CT_Tips.LForeColor = System.Drawing.Color.White;
            this.CT_Tips.Location = new System.Drawing.Point(11, 8);
            this.CT_Tips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CT_Tips.MarqueeText = "";
            this.CT_Tips.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.CT_Tips.MoveDifferenceEachTime = 1;
            this.CT_Tips.MoveInterval = 20;
            this.CT_Tips.Name = "CT_Tips";
            this.CT_Tips.OverBorderDistance = 15;
            this.CT_Tips.Size = new System.Drawing.Size(234, 23);
            this.CT_Tips.TabIndex = 12;
            // 
            // CT_StepGo
            // 
            this.CT_StepGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CT_StepGo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CT_StepGo.ButtonBackgroundImage = null;
            this.CT_StepGo.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CT_StepGo.ButtonColor = System.Drawing.Color.White;
            this.CT_StepGo.ButtonEnabled = true;
            this.CT_StepGo.ButtonImage = null;
            this.CT_StepGo.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CT_StepGo.ButtonText = "";
            this.CT_StepGo.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CT_StepGo.Location = new System.Drawing.Point(193, 430);
            this.CT_StepGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CT_StepGo.Name = "CT_StepGo";
            this.CT_StepGo.Size = new System.Drawing.Size(52, 23);
            this.CT_StepGo.TabIndex = 11;
            // 
            // CT_StepLabel
            // 
            this.CT_StepLabel.Location = new System.Drawing.Point(49, 430);
            this.CT_StepLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CT_StepLabel.Name = "CT_StepLabel";
            this.CT_StepLabel.Size = new System.Drawing.Size(63, 23);
            this.CT_StepLabel.TabIndex = 10;
            this.CT_StepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CT_Step
            // 
            this.CT_Step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CT_Step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CT_Step.ForeColor = System.Drawing.Color.White;
            this.CT_Step.Location = new System.Drawing.Point(118, 430);
            this.CT_Step.MaxLength = 5;
            this.CT_Step.Name = "CT_Step";
            this.CT_Step.Size = new System.Drawing.Size(69, 23);
            this.CT_Step.TabIndex = 9;
            // 
            // CT_CsvView
            // 
            this.CT_CsvView.AllowUserToAddRows = false;
            this.CT_CsvView.AllowUserToDeleteRows = false;
            this.CT_CsvView.AllowUserToResizeRows = false;
            this.CT_CsvView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_CsvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CT_CsvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CT_CsvView.DefaultCellStyle = dataGridViewCellStyle5;
            this.CT_CsvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.CT_CsvView.Location = new System.Drawing.Point(251, 8);
            this.CT_CsvView.Name = "CT_CsvView";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.CT_CsvView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CT_CsvView.RowTemplate.Height = 20;
            this.CT_CsvView.Size = new System.Drawing.Size(816, 659);
            this.CT_CsvView.TabIndex = 8;
            // 
            // P_Config
            // 
            this.P_Config.Controls.Add(this.WMP);
            this.P_Config.Controls.Add(this.ST_AUProg);
            this.P_Config.Controls.Add(this.ST_AboutProgram);
            this.P_Config.Controls.Add(this.ST_DataTitle);
            this.P_Config.Controls.Add(this.ST_SoundPath);
            this.P_Config.Location = new System.Drawing.Point(1, 24);
            this.P_Config.Margin = new System.Windows.Forms.Padding(0);
            this.P_Config.Name = "P_Config";
            this.P_Config.Size = new System.Drawing.Size(1078, 695);
            this.P_Config.TabIndex = 11;
            this.P_Config.Visible = false;
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(1091, 352);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 21;
            this.WMP.Visible = false;
            // 
            // ST_AUProg
            // 
            this.ST_AUProg.Controls.Add(this.ST_AUProgCheckGo);
            this.ST_AUProg.Controls.Add(this.ST_AUProgChannel);
            this.ST_AUProg.Controls.Add(this.ST_AUProgMode);
            this.ST_AUProg.Controls.Add(this.ST_AUProgChannelText);
            this.ST_AUProg.Controls.Add(this.ST_AUProgModeText);
            this.ST_AUProg.Controls.Add(this.ST_AUProgLatestVerText);
            this.ST_AUProg.Controls.Add(this.ST_AUProgLatestVer);
            this.ST_AUProg.Controls.Add(this.ST_AUProgCurrentVerText);
            this.ST_AUProg.Controls.Add(this.ST_AUProgCurrentVer);
            this.ST_AUProg.ForeColor = System.Drawing.Color.White;
            this.ST_AUProg.Location = new System.Drawing.Point(768, 381);
            this.ST_AUProg.Name = "ST_AUProg";
            this.ST_AUProg.Size = new System.Drawing.Size(299, 181);
            this.ST_AUProg.TabIndex = 20;
            this.ST_AUProg.TabStop = false;
            // 
            // ST_AUProgCheckGo
            // 
            this.ST_AUProgCheckGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_AUProgCheckGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_AUProgCheckGo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_AUProgCheckGo.ButtonBackgroundImage = null;
            this.ST_AUProgCheckGo.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_AUProgCheckGo.ButtonColor = System.Drawing.Color.White;
            this.ST_AUProgCheckGo.ButtonEnabled = true;
            this.ST_AUProgCheckGo.ButtonImage = null;
            this.ST_AUProgCheckGo.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_AUProgCheckGo.ButtonText = "";
            this.ST_AUProgCheckGo.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_AUProgCheckGo.ForeColor = System.Drawing.Color.White;
            this.ST_AUProgCheckGo.Location = new System.Drawing.Point(192, 151);
            this.ST_AUProgCheckGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_AUProgCheckGo.Name = "ST_AUProgCheckGo";
            this.ST_AUProgCheckGo.Size = new System.Drawing.Size(101, 24);
            this.ST_AUProgCheckGo.TabIndex = 23;
            // 
            // ST_AUProgChannel
            // 
            this.ST_AUProgChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ST_AUProgChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_AUProgChannel.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgChannel.ForeColor = System.Drawing.Color.White;
            this.ST_AUProgChannel.FormattingEnabled = true;
            this.ST_AUProgChannel.Location = new System.Drawing.Point(101, 90);
            this.ST_AUProgChannel.Name = "ST_AUProgChannel";
            this.ST_AUProgChannel.Size = new System.Drawing.Size(192, 24);
            this.ST_AUProgChannel.TabIndex = 24;
            // 
            // ST_AUProgMode
            // 
            this.ST_AUProgMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ST_AUProgMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_AUProgMode.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgMode.ForeColor = System.Drawing.Color.White;
            this.ST_AUProgMode.FormattingEnabled = true;
            this.ST_AUProgMode.Location = new System.Drawing.Point(101, 120);
            this.ST_AUProgMode.Name = "ST_AUProgMode";
            this.ST_AUProgMode.Size = new System.Drawing.Size(192, 24);
            this.ST_AUProgMode.TabIndex = 23;
            // 
            // ST_AUProgChannelText
            // 
            this.ST_AUProgChannelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AUProgChannelText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgChannelText.Location = new System.Drawing.Point(6, 90);
            this.ST_AUProgChannelText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUProgChannelText.Name = "ST_AUProgChannelText";
            this.ST_AUProgChannelText.Size = new System.Drawing.Size(89, 24);
            this.ST_AUProgChannelText.TabIndex = 23;
            this.ST_AUProgChannelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_AUProgModeText
            // 
            this.ST_AUProgModeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AUProgModeText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgModeText.Location = new System.Drawing.Point(6, 120);
            this.ST_AUProgModeText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUProgModeText.Name = "ST_AUProgModeText";
            this.ST_AUProgModeText.Size = new System.Drawing.Size(89, 24);
            this.ST_AUProgModeText.TabIndex = 22;
            this.ST_AUProgModeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_AUProgLatestVerText
            // 
            this.ST_AUProgLatestVerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AUProgLatestVerText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgLatestVerText.Location = new System.Drawing.Point(6, 56);
            this.ST_AUProgLatestVerText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUProgLatestVerText.Name = "ST_AUProgLatestVerText";
            this.ST_AUProgLatestVerText.Size = new System.Drawing.Size(80, 28);
            this.ST_AUProgLatestVerText.TabIndex = 19;
            this.ST_AUProgLatestVerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_AUProgLatestVer
            // 
            this.ST_AUProgLatestVer.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgLatestVer.Location = new System.Drawing.Point(92, 56);
            this.ST_AUProgLatestVer.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUProgLatestVer.Name = "ST_AUProgLatestVer";
            this.ST_AUProgLatestVer.Size = new System.Drawing.Size(201, 28);
            this.ST_AUProgLatestVer.TabIndex = 18;
            this.ST_AUProgLatestVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ST_AUProgCurrentVerText
            // 
            this.ST_AUProgCurrentVerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AUProgCurrentVerText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgCurrentVerText.Location = new System.Drawing.Point(6, 22);
            this.ST_AUProgCurrentVerText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUProgCurrentVerText.Name = "ST_AUProgCurrentVerText";
            this.ST_AUProgCurrentVerText.Size = new System.Drawing.Size(80, 28);
            this.ST_AUProgCurrentVerText.TabIndex = 17;
            this.ST_AUProgCurrentVerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_AUProgCurrentVer
            // 
            this.ST_AUProgCurrentVer.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUProgCurrentVer.Location = new System.Drawing.Point(92, 22);
            this.ST_AUProgCurrentVer.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUProgCurrentVer.Name = "ST_AUProgCurrentVer";
            this.ST_AUProgCurrentVer.Size = new System.Drawing.Size(201, 28);
            this.ST_AUProgCurrentVer.TabIndex = 16;
            this.ST_AUProgCurrentVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ST_AboutProgram
            // 
            this.ST_AboutProgram.Controls.Add(this.ST_DevelopersText);
            this.ST_AboutProgram.Controls.Add(this.ST_Developer);
            this.ST_AboutProgram.Controls.Add(this.ST_VersionText);
            this.ST_AboutProgram.Controls.Add(this.ST_Version);
            this.ST_AboutProgram.ForeColor = System.Drawing.Color.White;
            this.ST_AboutProgram.Location = new System.Drawing.Point(768, 568);
            this.ST_AboutProgram.Name = "ST_AboutProgram";
            this.ST_AboutProgram.Size = new System.Drawing.Size(299, 99);
            this.ST_AboutProgram.TabIndex = 18;
            this.ST_AboutProgram.TabStop = false;
            // 
            // ST_DevelopersText
            // 
            this.ST_DevelopersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_DevelopersText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_DevelopersText.Location = new System.Drawing.Point(6, 22);
            this.ST_DevelopersText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_DevelopersText.Name = "ST_DevelopersText";
            this.ST_DevelopersText.Size = new System.Drawing.Size(80, 24);
            this.ST_DevelopersText.TabIndex = 19;
            this.ST_DevelopersText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_Developer
            // 
            this.ST_Developer.Direction = MarqueeDirection.Vertical;
            this.ST_Developer.EnableMarquee = true;
            this.ST_Developer.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_Developer.FreezeTime = 3000;
            this.ST_Developer.LabelSize = new System.Drawing.Size(201, 24);
            this.ST_Developer.LeftDistance = 3;
            this.ST_Developer.LForeColor = System.Drawing.Color.White;
            this.ST_Developer.Location = new System.Drawing.Point(92, 22);
            this.ST_Developer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_Developer.MarqueeText = "";
            this.ST_Developer.Mode = MarqueeMode.ContinualAndSneeze;
            this.ST_Developer.MoveDifferenceEachTime = 1;
            this.ST_Developer.MoveInterval = 30;
            this.ST_Developer.Name = "ST_Developer";
            this.ST_Developer.OverBorderDistance = 30;
            this.ST_Developer.Size = new System.Drawing.Size(201, 24);
            this.ST_Developer.TabIndex = 18;
            // 
            // ST_VersionText
            // 
            this.ST_VersionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_VersionText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_VersionText.Location = new System.Drawing.Point(6, 52);
            this.ST_VersionText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_VersionText.Name = "ST_VersionText";
            this.ST_VersionText.Size = new System.Drawing.Size(80, 41);
            this.ST_VersionText.TabIndex = 17;
            this.ST_VersionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_Version
            // 
            this.ST_Version.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_Version.Location = new System.Drawing.Point(92, 52);
            this.ST_Version.Margin = new System.Windows.Forms.Padding(3);
            this.ST_Version.Name = "ST_Version";
            this.ST_Version.Size = new System.Drawing.Size(201, 41);
            this.ST_Version.TabIndex = 16;
            this.ST_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ST_DataTitle
            // 
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvBrowse);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvCheckGo);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvPath);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvMode);
            this.ST_DataTitle.Controls.Add(this.ST_AutoLoad);
            this.ST_DataTitle.Controls.Add(this.ST_ReadTitle);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvPathText);
            this.ST_DataTitle.Controls.Add(this.ST_Data);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvModeText);
            this.ST_DataTitle.ForeColor = System.Drawing.Color.White;
            this.ST_DataTitle.Location = new System.Drawing.Point(11, 162);
            this.ST_DataTitle.Name = "ST_DataTitle";
            this.ST_DataTitle.Size = new System.Drawing.Size(348, 431);
            this.ST_DataTitle.TabIndex = 8;
            this.ST_DataTitle.TabStop = false;
            // 
            // ST_AUCsvBrowse
            // 
            this.ST_AUCsvBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_AUCsvBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_AUCsvBrowse.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_AUCsvBrowse.ButtonBackgroundImage = null;
            this.ST_AUCsvBrowse.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_AUCsvBrowse.ButtonColor = System.Drawing.Color.White;
            this.ST_AUCsvBrowse.ButtonEnabled = true;
            this.ST_AUCsvBrowse.ButtonImage = null;
            this.ST_AUCsvBrowse.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_AUCsvBrowse.ButtonText = "";
            this.ST_AUCsvBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_AUCsvBrowse.ForeColor = System.Drawing.Color.White;
            this.ST_AUCsvBrowse.Location = new System.Drawing.Point(300, 372);
            this.ST_AUCsvBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_AUCsvBrowse.Name = "ST_AUCsvBrowse";
            this.ST_AUCsvBrowse.Size = new System.Drawing.Size(42, 23);
            this.ST_AUCsvBrowse.TabIndex = 26;
            // 
            // ST_AUCsvCheckGo
            // 
            this.ST_AUCsvCheckGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_AUCsvCheckGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_AUCsvCheckGo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_AUCsvCheckGo.ButtonBackgroundImage = null;
            this.ST_AUCsvCheckGo.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_AUCsvCheckGo.ButtonColor = System.Drawing.Color.White;
            this.ST_AUCsvCheckGo.ButtonEnabled = true;
            this.ST_AUCsvCheckGo.ButtonImage = null;
            this.ST_AUCsvCheckGo.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_AUCsvCheckGo.ButtonText = "";
            this.ST_AUCsvCheckGo.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_AUCsvCheckGo.ForeColor = System.Drawing.Color.White;
            this.ST_AUCsvCheckGo.Location = new System.Drawing.Point(240, 401);
            this.ST_AUCsvCheckGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_AUCsvCheckGo.Name = "ST_AUCsvCheckGo";
            this.ST_AUCsvCheckGo.Size = new System.Drawing.Size(102, 24);
            this.ST_AUCsvCheckGo.TabIndex = 23;
            // 
            // ST_AUCsvPath
            // 
            this.ST_AUCsvPath.Direction = MarqueeDirection.Horizontal;
            this.ST_AUCsvPath.EnableMarquee = true;
            this.ST_AUCsvPath.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvPath.FreezeTime = 2000;
            this.ST_AUCsvPath.LabelSize = new System.Drawing.Size(288, 23);
            this.ST_AUCsvPath.LeftDistance = 5;
            this.ST_AUCsvPath.LForeColor = System.Drawing.Color.White;
            this.ST_AUCsvPath.Location = new System.Drawing.Point(6, 372);
            this.ST_AUCsvPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_AUCsvPath.MarqueeText = "";
            this.ST_AUCsvPath.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_AUCsvPath.MoveDifferenceEachTime = 1;
            this.ST_AUCsvPath.MoveInterval = 15;
            this.ST_AUCsvPath.Name = "ST_AUCsvPath";
            this.ST_AUCsvPath.OverBorderDistance = 15;
            this.ST_AUCsvPath.Size = new System.Drawing.Size(288, 23);
            this.ST_AUCsvPath.TabIndex = 22;
            // 
            // ST_AUCsvMode
            // 
            this.ST_AUCsvMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ST_AUCsvMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_AUCsvMode.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvMode.ForeColor = System.Drawing.Color.White;
            this.ST_AUCsvMode.FormattingEnabled = true;
            this.ST_AUCsvMode.Location = new System.Drawing.Point(107, 401);
            this.ST_AUCsvMode.Name = "ST_AUCsvMode";
            this.ST_AUCsvMode.Size = new System.Drawing.Size(127, 24);
            this.ST_AUCsvMode.TabIndex = 22;
            // 
            // ST_AutoLoad
            // 
            this.ST_AutoLoad.Location = new System.Drawing.Point(6, 310);
            this.ST_AutoLoad.Name = "ST_AutoLoad";
            this.ST_AutoLoad.Size = new System.Drawing.Size(336, 25);
            this.ST_AutoLoad.TabIndex = 17;
            this.ST_AutoLoad.UseVisualStyleBackColor = true;
            // 
            // ST_ReadTitle
            // 
            this.ST_ReadTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_ReadTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_ReadTitle.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_ReadTitle.ButtonBackgroundImage = null;
            this.ST_ReadTitle.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_ReadTitle.ButtonColor = System.Drawing.Color.White;
            this.ST_ReadTitle.ButtonEnabled = true;
            this.ST_ReadTitle.ButtonImage = null;
            this.ST_ReadTitle.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_ReadTitle.ButtonText = "";
            this.ST_ReadTitle.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_ReadTitle.ForeColor = System.Drawing.Color.White;
            this.ST_ReadTitle.Location = new System.Drawing.Point(241, 280);
            this.ST_ReadTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_ReadTitle.Name = "ST_ReadTitle";
            this.ST_ReadTitle.Size = new System.Drawing.Size(101, 24);
            this.ST_ReadTitle.TabIndex = 16;
            // 
            // ST_AUCsvPathText
            // 
            this.ST_AUCsvPathText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvPathText.Location = new System.Drawing.Point(6, 341);
            this.ST_AUCsvPathText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUCsvPathText.Name = "ST_AUCsvPathText";
            this.ST_AUCsvPathText.Size = new System.Drawing.Size(336, 24);
            this.ST_AUCsvPathText.TabIndex = 21;
            this.ST_AUCsvPathText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ST_Data
            // 
            this.ST_Data.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ST_Data.AutoArrange = false;
            this.ST_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ST_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_Data.ForeColor = System.Drawing.Color.White;
            this.ST_Data.FullRowSelect = true;
            this.ST_Data.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ST_Data.Location = new System.Drawing.Point(6, 22);
            this.ST_Data.MultiSelect = false;
            this.ST_Data.Name = "ST_Data";
            this.ST_Data.Size = new System.Drawing.Size(336, 251);
            this.ST_Data.TabIndex = 0;
            this.ST_Data.UseCompatibleStateImageBehavior = false;
            this.ST_Data.View = System.Windows.Forms.View.Details;
            // 
            // ST_AUCsvModeText
            // 
            this.ST_AUCsvModeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AUCsvModeText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvModeText.Location = new System.Drawing.Point(6, 402);
            this.ST_AUCsvModeText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUCsvModeText.Name = "ST_AUCsvModeText";
            this.ST_AUCsvModeText.Size = new System.Drawing.Size(95, 24);
            this.ST_AUCsvModeText.TabIndex = 20;
            this.ST_AUCsvModeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_SoundPath
            // 
            this.ST_SoundPath.Controls.Add(this.ST_PathMessageMute);
            this.ST_SoundPath.Controls.Add(this.ST_PathMessageBrowse);
            this.ST_SoundPath.Controls.Add(this.ST_PathMessage);
            this.ST_SoundPath.Controls.Add(this.ST_PathMessageText);
            this.ST_SoundPath.Controls.Add(this.ST_PathBGMMute);
            this.ST_SoundPath.Controls.Add(this.ST_PathWarningMute);
            this.ST_SoundPath.Controls.Add(this.ST_PathBeepMute);
            this.ST_SoundPath.Controls.Add(this.ST_PathBGMText);
            this.ST_SoundPath.Controls.Add(this.ST_PathBGM);
            this.ST_SoundPath.Controls.Add(this.ST_PathWarningBrowse);
            this.ST_SoundPath.Controls.Add(this.ST_PathBGMBrowse);
            this.ST_SoundPath.Controls.Add(this.ST_PathBeepText);
            this.ST_SoundPath.Controls.Add(this.ST_PathBeepBrowse);
            this.ST_SoundPath.Controls.Add(this.ST_PathWarning);
            this.ST_SoundPath.Controls.Add(this.ST_PathBeep);
            this.ST_SoundPath.Controls.Add(this.ST_PathWarningText);
            this.ST_SoundPath.ForeColor = System.Drawing.Color.White;
            this.ST_SoundPath.Location = new System.Drawing.Point(11, 8);
            this.ST_SoundPath.Name = "ST_SoundPath";
            this.ST_SoundPath.Size = new System.Drawing.Size(589, 146);
            this.ST_SoundPath.TabIndex = 7;
            this.ST_SoundPath.TabStop = false;
            // 
            // ST_PathMessageMute
            // 
            this.ST_PathMessageMute.Location = new System.Drawing.Point(531, 84);
            this.ST_PathMessageMute.Name = "ST_PathMessageMute";
            this.ST_PathMessageMute.Size = new System.Drawing.Size(52, 25);
            this.ST_PathMessageMute.TabIndex = 25;
            this.ST_PathMessageMute.UseVisualStyleBackColor = true;
            // 
            // ST_PathMessageBrowse
            // 
            this.ST_PathMessageBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathMessageBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathMessageBrowse.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathMessageBrowse.ButtonBackgroundImage = null;
            this.ST_PathMessageBrowse.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathMessageBrowse.ButtonColor = System.Drawing.Color.White;
            this.ST_PathMessageBrowse.ButtonEnabled = true;
            this.ST_PathMessageBrowse.ButtonImage = null;
            this.ST_PathMessageBrowse.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_PathMessageBrowse.ButtonText = "";
            this.ST_PathMessageBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_PathMessageBrowse.ForeColor = System.Drawing.Color.White;
            this.ST_PathMessageBrowse.Location = new System.Drawing.Point(458, 84);
            this.ST_PathMessageBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathMessageBrowse.Name = "ST_PathMessageBrowse";
            this.ST_PathMessageBrowse.Size = new System.Drawing.Size(67, 25);
            this.ST_PathMessageBrowse.TabIndex = 23;
            // 
            // ST_PathMessage
            // 
            this.ST_PathMessage.Direction = MarqueeDirection.Horizontal;
            this.ST_PathMessage.EnableMarquee = true;
            this.ST_PathMessage.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_PathMessage.FreezeTime = 2000;
            this.ST_PathMessage.LabelSize = new System.Drawing.Size(381, 25);
            this.ST_PathMessage.LeftDistance = 5;
            this.ST_PathMessage.LForeColor = System.Drawing.Color.White;
            this.ST_PathMessage.Location = new System.Drawing.Point(71, 84);
            this.ST_PathMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathMessage.MarqueeText = "";
            this.ST_PathMessage.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_PathMessage.MoveDifferenceEachTime = 1;
            this.ST_PathMessage.MoveInterval = 15;
            this.ST_PathMessage.Name = "ST_PathMessage";
            this.ST_PathMessage.OverBorderDistance = 15;
            this.ST_PathMessage.Size = new System.Drawing.Size(381, 25);
            this.ST_PathMessage.TabIndex = 24;
            // 
            // ST_PathMessageText
            // 
            this.ST_PathMessageText.Location = new System.Drawing.Point(6, 84);
            this.ST_PathMessageText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_PathMessageText.Name = "ST_PathMessageText";
            this.ST_PathMessageText.Size = new System.Drawing.Size(59, 25);
            this.ST_PathMessageText.TabIndex = 22;
            this.ST_PathMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_PathBGMMute
            // 
            this.ST_PathBGMMute.Location = new System.Drawing.Point(531, 115);
            this.ST_PathBGMMute.Name = "ST_PathBGMMute";
            this.ST_PathBGMMute.Size = new System.Drawing.Size(52, 25);
            this.ST_PathBGMMute.TabIndex = 21;
            this.ST_PathBGMMute.UseVisualStyleBackColor = true;
            // 
            // ST_PathWarningMute
            // 
            this.ST_PathWarningMute.Location = new System.Drawing.Point(531, 53);
            this.ST_PathWarningMute.Name = "ST_PathWarningMute";
            this.ST_PathWarningMute.Size = new System.Drawing.Size(52, 25);
            this.ST_PathWarningMute.TabIndex = 20;
            this.ST_PathWarningMute.UseVisualStyleBackColor = true;
            // 
            // ST_PathBeepMute
            // 
            this.ST_PathBeepMute.Location = new System.Drawing.Point(531, 22);
            this.ST_PathBeepMute.Name = "ST_PathBeepMute";
            this.ST_PathBeepMute.Size = new System.Drawing.Size(52, 25);
            this.ST_PathBeepMute.TabIndex = 19;
            this.ST_PathBeepMute.UseVisualStyleBackColor = true;
            // 
            // ST_PathBGMText
            // 
            this.ST_PathBGMText.Location = new System.Drawing.Point(6, 115);
            this.ST_PathBGMText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_PathBGMText.Name = "ST_PathBGMText";
            this.ST_PathBGMText.Size = new System.Drawing.Size(59, 25);
            this.ST_PathBGMText.TabIndex = 16;
            this.ST_PathBGMText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_PathBGM
            // 
            this.ST_PathBGM.Direction = MarqueeDirection.Horizontal;
            this.ST_PathBGM.EnableMarquee = true;
            this.ST_PathBGM.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_PathBGM.FreezeTime = 2000;
            this.ST_PathBGM.LabelSize = new System.Drawing.Size(381, 25);
            this.ST_PathBGM.LeftDistance = 5;
            this.ST_PathBGM.LForeColor = System.Drawing.Color.White;
            this.ST_PathBGM.Location = new System.Drawing.Point(71, 115);
            this.ST_PathBGM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathBGM.MarqueeText = "";
            this.ST_PathBGM.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_PathBGM.MoveDifferenceEachTime = 1;
            this.ST_PathBGM.MoveInterval = 15;
            this.ST_PathBGM.Name = "ST_PathBGM";
            this.ST_PathBGM.OverBorderDistance = 15;
            this.ST_PathBGM.Size = new System.Drawing.Size(381, 25);
            this.ST_PathBGM.TabIndex = 18;
            // 
            // ST_PathWarningBrowse
            // 
            this.ST_PathWarningBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathWarningBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathWarningBrowse.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathWarningBrowse.ButtonBackgroundImage = null;
            this.ST_PathWarningBrowse.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathWarningBrowse.ButtonColor = System.Drawing.Color.White;
            this.ST_PathWarningBrowse.ButtonEnabled = true;
            this.ST_PathWarningBrowse.ButtonImage = null;
            this.ST_PathWarningBrowse.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_PathWarningBrowse.ButtonText = "";
            this.ST_PathWarningBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_PathWarningBrowse.ForeColor = System.Drawing.Color.White;
            this.ST_PathWarningBrowse.Location = new System.Drawing.Point(458, 53);
            this.ST_PathWarningBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathWarningBrowse.Name = "ST_PathWarningBrowse";
            this.ST_PathWarningBrowse.Size = new System.Drawing.Size(67, 25);
            this.ST_PathWarningBrowse.TabIndex = 13;
            // 
            // ST_PathBGMBrowse
            // 
            this.ST_PathBGMBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathBGMBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathBGMBrowse.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathBGMBrowse.ButtonBackgroundImage = null;
            this.ST_PathBGMBrowse.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathBGMBrowse.ButtonColor = System.Drawing.Color.White;
            this.ST_PathBGMBrowse.ButtonEnabled = true;
            this.ST_PathBGMBrowse.ButtonImage = null;
            this.ST_PathBGMBrowse.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_PathBGMBrowse.ButtonText = "";
            this.ST_PathBGMBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_PathBGMBrowse.ForeColor = System.Drawing.Color.White;
            this.ST_PathBGMBrowse.Location = new System.Drawing.Point(458, 115);
            this.ST_PathBGMBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathBGMBrowse.Name = "ST_PathBGMBrowse";
            this.ST_PathBGMBrowse.Size = new System.Drawing.Size(67, 25);
            this.ST_PathBGMBrowse.TabIndex = 17;
            // 
            // ST_PathBeepText
            // 
            this.ST_PathBeepText.Location = new System.Drawing.Point(6, 22);
            this.ST_PathBeepText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_PathBeepText.Name = "ST_PathBeepText";
            this.ST_PathBeepText.Size = new System.Drawing.Size(59, 25);
            this.ST_PathBeepText.TabIndex = 6;
            this.ST_PathBeepText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_PathBeepBrowse
            // 
            this.ST_PathBeepBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathBeepBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathBeepBrowse.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_PathBeepBrowse.ButtonBackgroundImage = null;
            this.ST_PathBeepBrowse.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_PathBeepBrowse.ButtonColor = System.Drawing.Color.White;
            this.ST_PathBeepBrowse.ButtonEnabled = true;
            this.ST_PathBeepBrowse.ButtonImage = null;
            this.ST_PathBeepBrowse.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_PathBeepBrowse.ButtonText = "";
            this.ST_PathBeepBrowse.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_PathBeepBrowse.ForeColor = System.Drawing.Color.White;
            this.ST_PathBeepBrowse.Location = new System.Drawing.Point(458, 22);
            this.ST_PathBeepBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathBeepBrowse.Name = "ST_PathBeepBrowse";
            this.ST_PathBeepBrowse.Size = new System.Drawing.Size(67, 25);
            this.ST_PathBeepBrowse.TabIndex = 12;
            // 
            // ST_PathWarning
            // 
            this.ST_PathWarning.Direction = MarqueeDirection.Horizontal;
            this.ST_PathWarning.EnableMarquee = true;
            this.ST_PathWarning.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_PathWarning.FreezeTime = 2000;
            this.ST_PathWarning.LabelSize = new System.Drawing.Size(381, 25);
            this.ST_PathWarning.LeftDistance = 5;
            this.ST_PathWarning.LForeColor = System.Drawing.Color.White;
            this.ST_PathWarning.Location = new System.Drawing.Point(71, 53);
            this.ST_PathWarning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathWarning.MarqueeText = "";
            this.ST_PathWarning.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_PathWarning.MoveDifferenceEachTime = 1;
            this.ST_PathWarning.MoveInterval = 15;
            this.ST_PathWarning.Name = "ST_PathWarning";
            this.ST_PathWarning.OverBorderDistance = 15;
            this.ST_PathWarning.Size = new System.Drawing.Size(381, 25);
            this.ST_PathWarning.TabIndex = 15;
            // 
            // ST_PathBeep
            // 
            this.ST_PathBeep.Direction = MarqueeDirection.Horizontal;
            this.ST_PathBeep.EnableMarquee = true;
            this.ST_PathBeep.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_PathBeep.FreezeTime = 2000;
            this.ST_PathBeep.LabelSize = new System.Drawing.Size(381, 25);
            this.ST_PathBeep.LeftDistance = 5;
            this.ST_PathBeep.LForeColor = System.Drawing.Color.White;
            this.ST_PathBeep.Location = new System.Drawing.Point(71, 22);
            this.ST_PathBeep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_PathBeep.MarqueeText = "";
            this.ST_PathBeep.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_PathBeep.MoveDifferenceEachTime = 1;
            this.ST_PathBeep.MoveInterval = 15;
            this.ST_PathBeep.Name = "ST_PathBeep";
            this.ST_PathBeep.OverBorderDistance = 15;
            this.ST_PathBeep.Size = new System.Drawing.Size(381, 25);
            this.ST_PathBeep.TabIndex = 14;
            // 
            // ST_PathWarningText
            // 
            this.ST_PathWarningText.Location = new System.Drawing.Point(6, 53);
            this.ST_PathWarningText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_PathWarningText.Name = "ST_PathWarningText";
            this.ST_PathWarningText.Size = new System.Drawing.Size(59, 25);
            this.ST_PathWarningText.TabIndex = 7;
            this.ST_PathWarningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_CharacterData
            // 
            this.P_CharacterData.Controls.Add(this.CD_CloseTab);
            this.P_CharacterData.Controls.Add(this.CD_NewTab);
            this.P_CharacterData.Controls.Add(this.CD_CharacterTab);
            this.P_CharacterData.Controls.Add(this.CD_Favorite);
            this.P_CharacterData.Controls.Add(this.CD_SearchGB);
            this.P_CharacterData.Controls.Add(this.CD_CharacterIDText);
            this.P_CharacterData.Controls.Add(this.CD_CharacterIDGo);
            this.P_CharacterData.Controls.Add(this.CD_CharacterID);
            this.P_CharacterData.Controls.Add(this.CD_FavoriteText);
            this.P_CharacterData.Location = new System.Drawing.Point(1, 24);
            this.P_CharacterData.Margin = new System.Windows.Forms.Padding(0);
            this.P_CharacterData.Name = "P_CharacterData";
            this.P_CharacterData.Size = new System.Drawing.Size(1078, 695);
            this.P_CharacterData.TabIndex = 11;
            this.P_CharacterData.Visible = false;
            // 
            // CD_CloseTab
            // 
            this.CD_CloseTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_CloseTab.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CD_CloseTab.ButtonBackgroundImage = null;
            this.CD_CloseTab.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_CloseTab.ButtonColor = System.Drawing.Color.Red;
            this.CD_CloseTab.ButtonEnabled = true;
            this.CD_CloseTab.ButtonImage = null;
            this.CD_CloseTab.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CD_CloseTab.ButtonText = "×";
            this.CD_CloseTab.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.CD_CloseTab.Location = new System.Drawing.Point(1015, 8);
            this.CD_CloseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CD_CloseTab.Name = "CD_CloseTab";
            this.CD_CloseTab.Size = new System.Drawing.Size(23, 23);
            this.CD_CloseTab.TabIndex = 39;
            // 
            // CD_NewTab
            // 
            this.CD_NewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_NewTab.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CD_NewTab.ButtonBackgroundImage = null;
            this.CD_NewTab.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_NewTab.ButtonColor = System.Drawing.Color.White;
            this.CD_NewTab.ButtonEnabled = true;
            this.CD_NewTab.ButtonImage = null;
            this.CD_NewTab.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CD_NewTab.ButtonText = "+";
            this.CD_NewTab.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_NewTab.Location = new System.Drawing.Point(1044, 8);
            this.CD_NewTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CD_NewTab.Name = "CD_NewTab";
            this.CD_NewTab.Size = new System.Drawing.Size(23, 23);
            this.CD_NewTab.TabIndex = 38;
            // 
            // CD_CharacterTab
            // 
            this.CD_CharacterTab.Controls.Add(this.tabPage1);
            this.CD_CharacterTab.HotTrack = true;
            this.CD_CharacterTab.Location = new System.Drawing.Point(311, 30);
            this.CD_CharacterTab.Multiline = true;
            this.CD_CharacterTab.Name = "CD_CharacterTab";
            this.CD_CharacterTab.SelectedIndex = 0;
            this.CD_CharacterTab.ShowToolTips = true;
            this.CD_CharacterTab.Size = new System.Drawing.Size(756, 631);
            this.CD_CharacterTab.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CharaDataDisplay);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "角色資料 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CharaDataDisplay
            // 
            this.CharaDataDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CharaDataDisplay.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CharaDataDisplay.ForeColor = System.Drawing.Color.White;
            this.CharaDataDisplay.Location = new System.Drawing.Point(0, 0);
            this.CharaDataDisplay.Name = "CharaDataDisplay";
            this.CharaDataDisplay.Padding = new System.Windows.Forms.Padding(5);
            this.CharaDataDisplay.Size = new System.Drawing.Size(748, 602);
            this.CharaDataDisplay.TabIndex = 0;
            // 
            // CD_Favorite
            // 
            this.CD_Favorite.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.CD_Favorite.AutoArrange = false;
            this.CD_Favorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_Favorite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CD_Favorite.ForeColor = System.Drawing.Color.White;
            this.CD_Favorite.FullRowSelect = true;
            this.CD_Favorite.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CD_Favorite.Location = new System.Drawing.Point(11, 418);
            this.CD_Favorite.MultiSelect = false;
            this.CD_Favorite.Name = "CD_Favorite";
            this.CD_Favorite.Size = new System.Drawing.Size(294, 243);
            this.CD_Favorite.TabIndex = 36;
            this.CD_Favorite.UseCompatibleStateImageBehavior = false;
            this.CD_Favorite.View = System.Windows.Forms.View.Details;
            // 
            // CD_SearchGB
            // 
            this.CD_SearchGB.Controls.Add(this.CD_SeriesCodeGo);
            this.CD_SearchGB.Controls.Add(this.CD_CharaSeries);
            this.CD_SearchGB.Controls.Add(this.CD_CharaSeriesText);
            this.CD_SearchGB.Controls.Add(this.CD_Rarity);
            this.CD_SearchGB.Controls.Add(this.CD_RarityText);
            this.CD_SearchGB.Controls.Add(this.CD_KeywordResult);
            this.CD_SearchGB.Controls.Add(this.CD_KeywordText);
            this.CD_SearchGB.Controls.Add(this.CD_Keyword);
            this.CD_SearchGB.Controls.Add(this.CD_KeywordGo);
            this.CD_SearchGB.ForeColor = System.Drawing.Color.White;
            this.CD_SearchGB.Location = new System.Drawing.Point(11, 50);
            this.CD_SearchGB.Name = "CD_SearchGB";
            this.CD_SearchGB.Size = new System.Drawing.Size(294, 335);
            this.CD_SearchGB.TabIndex = 28;
            this.CD_SearchGB.TabStop = false;
            // 
            // CD_SeriesCodeGo
            // 
            this.CD_SeriesCodeGo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.CD_SeriesCodeGo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CD_SeriesCodeGo.Location = new System.Drawing.Point(114, 53);
            this.CD_SeriesCodeGo.Name = "CD_SeriesCodeGo";
            this.CD_SeriesCodeGo.Size = new System.Drawing.Size(116, 24);
            this.CD_SeriesCodeGo.TabIndex = 35;
            this.CD_SeriesCodeGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CD_CharaSeries
            // 
            this.CD_CharaSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_CharaSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CD_CharaSeries.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.CD_CharaSeries.ForeColor = System.Drawing.Color.White;
            this.CD_CharaSeries.Location = new System.Drawing.Point(69, 53);
            this.CD_CharaSeries.MaxLength = 3;
            this.CD_CharaSeries.Name = "CD_CharaSeries";
            this.CD_CharaSeries.Size = new System.Drawing.Size(39, 25);
            this.CD_CharaSeries.TabIndex = 34;
            // 
            // CD_CharaSeriesText
            // 
            this.CD_CharaSeriesText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_CharaSeriesText.Location = new System.Drawing.Point(6, 53);
            this.CD_CharaSeriesText.Margin = new System.Windows.Forms.Padding(3);
            this.CD_CharaSeriesText.Name = "CD_CharaSeriesText";
            this.CD_CharaSeriesText.Size = new System.Drawing.Size(57, 24);
            this.CD_CharaSeriesText.TabIndex = 33;
            this.CD_CharaSeriesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CD_Rarity
            // 
            this.CD_Rarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_Rarity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CD_Rarity.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.CD_Rarity.ForeColor = System.Drawing.Color.White;
            this.CD_Rarity.Location = new System.Drawing.Point(242, 22);
            this.CD_Rarity.MaxLength = 1;
            this.CD_Rarity.Name = "CD_Rarity";
            this.CD_Rarity.Size = new System.Drawing.Size(46, 25);
            this.CD_Rarity.TabIndex = 32;
            // 
            // CD_RarityText
            // 
            this.CD_RarityText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_RarityText.Location = new System.Drawing.Point(199, 22);
            this.CD_RarityText.Margin = new System.Windows.Forms.Padding(3);
            this.CD_RarityText.Name = "CD_RarityText";
            this.CD_RarityText.Size = new System.Drawing.Size(37, 25);
            this.CD_RarityText.TabIndex = 31;
            this.CD_RarityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CD_KeywordResult
            // 
            this.CD_KeywordResult.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.CD_KeywordResult.AutoArrange = false;
            this.CD_KeywordResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_KeywordResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CD_KeywordResult.ForeColor = System.Drawing.Color.White;
            this.CD_KeywordResult.FullRowSelect = true;
            this.CD_KeywordResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CD_KeywordResult.Location = new System.Drawing.Point(6, 85);
            this.CD_KeywordResult.MultiSelect = false;
            this.CD_KeywordResult.Name = "CD_KeywordResult";
            this.CD_KeywordResult.Size = new System.Drawing.Size(282, 244);
            this.CD_KeywordResult.TabIndex = 30;
            this.CD_KeywordResult.UseCompatibleStateImageBehavior = false;
            this.CD_KeywordResult.View = System.Windows.Forms.View.Details;
            // 
            // CD_KeywordText
            // 
            this.CD_KeywordText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_KeywordText.Location = new System.Drawing.Point(6, 22);
            this.CD_KeywordText.Margin = new System.Windows.Forms.Padding(3);
            this.CD_KeywordText.Name = "CD_KeywordText";
            this.CD_KeywordText.Size = new System.Drawing.Size(54, 25);
            this.CD_KeywordText.TabIndex = 29;
            this.CD_KeywordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CD_Keyword
            // 
            this.CD_Keyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_Keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CD_Keyword.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.CD_Keyword.ForeColor = System.Drawing.Color.White;
            this.CD_Keyword.Location = new System.Drawing.Point(66, 22);
            this.CD_Keyword.Name = "CD_Keyword";
            this.CD_Keyword.Size = new System.Drawing.Size(127, 25);
            this.CD_Keyword.TabIndex = 26;
            // 
            // CD_KeywordGo
            // 
            this.CD_KeywordGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_KeywordGo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CD_KeywordGo.ButtonBackgroundImage = null;
            this.CD_KeywordGo.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_KeywordGo.ButtonColor = System.Drawing.Color.White;
            this.CD_KeywordGo.ButtonEnabled = true;
            this.CD_KeywordGo.ButtonImage = null;
            this.CD_KeywordGo.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CD_KeywordGo.ButtonText = "";
            this.CD_KeywordGo.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_KeywordGo.Location = new System.Drawing.Point(236, 53);
            this.CD_KeywordGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CD_KeywordGo.Name = "CD_KeywordGo";
            this.CD_KeywordGo.Size = new System.Drawing.Size(52, 25);
            this.CD_KeywordGo.TabIndex = 27;
            // 
            // CD_CharacterIDText
            // 
            this.CD_CharacterIDText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_CharacterIDText.Location = new System.Drawing.Point(11, 8);
            this.CD_CharacterIDText.Margin = new System.Windows.Forms.Padding(3);
            this.CD_CharacterIDText.Name = "CD_CharacterIDText";
            this.CD_CharacterIDText.Size = new System.Drawing.Size(54, 36);
            this.CD_CharacterIDText.TabIndex = 22;
            this.CD_CharacterIDText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CD_CharacterIDGo
            // 
            this.CD_CharacterIDGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_CharacterIDGo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CD_CharacterIDGo.ButtonBackgroundImage = null;
            this.CD_CharacterIDGo.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CD_CharacterIDGo.ButtonColor = System.Drawing.Color.White;
            this.CD_CharacterIDGo.ButtonEnabled = true;
            this.CD_CharacterIDGo.ButtonImage = null;
            this.CD_CharacterIDGo.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CD_CharacterIDGo.ButtonText = "";
            this.CD_CharacterIDGo.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_CharacterIDGo.Location = new System.Drawing.Point(251, 8);
            this.CD_CharacterIDGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CD_CharacterIDGo.Name = "CD_CharacterIDGo";
            this.CD_CharacterIDGo.Size = new System.Drawing.Size(52, 36);
            this.CD_CharacterIDGo.TabIndex = 21;
            // 
            // CD_CharacterID
            // 
            this.CD_CharacterID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_CharacterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CD_CharacterID.Font = new System.Drawing.Font("Consolas", 18F);
            this.CD_CharacterID.ForeColor = System.Drawing.Color.White;
            this.CD_CharacterID.Location = new System.Drawing.Point(71, 8);
            this.CD_CharacterID.MaxLength = 8;
            this.CD_CharacterID.Name = "CD_CharacterID";
            this.CD_CharacterID.Size = new System.Drawing.Size(176, 36);
            this.CD_CharacterID.TabIndex = 20;
            this.CD_CharacterID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CD_FavoriteText
            // 
            this.CD_FavoriteText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_FavoriteText.Location = new System.Drawing.Point(11, 391);
            this.CD_FavoriteText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CD_FavoriteText.Name = "CD_FavoriteText";
            this.CD_FavoriteText.Size = new System.Drawing.Size(294, 24);
            this.CD_FavoriteText.TabIndex = 36;
            this.CD_FavoriteText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // EX_FileDialog
            // 
            this.EX_FileDialog.Filter = "csv 檔案|*.csv|assetbundle 檔案|*.assetbundle|wav 檔案|*.wav|mp3 檔案|*.mp3|所有檔案|*.*";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.MN_Border);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FMain";
            this.Text = "SAOCR Data Manager";
            this.Load += new System.EventHandler(this.Form_Load);
            this.P_HomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).EndInit();
            this.MN_Border.ResumeLayout(false);
            this.MN_Border.PerformLayout();
            this.MN_StatusStrip.ResumeLayout(false);
            this.MN_StatusStrip.PerformLayout();
            this.P_Statistics.ResumeLayout(false);
            this.SS_Character.ResumeLayout(false);
            this.P_CsvTable.ResumeLayout(false);
            this.P_CsvTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_EndColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_StartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_CsvView)).EndInit();
            this.P_Config.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ST_AUProg.ResumeLayout(false);
            this.ST_AboutProgram.ResumeLayout(false);
            this.ST_DataTitle.ResumeLayout(false);
            this.ST_SoundPath.ResumeLayout(false);
            this.P_CharacterData.ResumeLayout(false);
            this.P_CharacterData.PerformLayout();
            this.CD_CharacterTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CD_SearchGB.ResumeLayout(false);
            this.CD_SearchGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label MN_Title;
        public SAOCR_Data_Manager.Button_SE_ MN_Close;
        public SAOCR_Data_Manager.Button_SE_ MN_Min;
        public SAOCR_Data_Manager.Button_SE_ HM_ToCharacterData;
        private System.Windows.Forms.Panel P_HomePage;
        public SAOCR_Data_Manager.Button_SE_ HM_ToEquipmentData;
        private System.Windows.Forms.Panel MN_Border;
        public SAOCR_Data_Manager.Button_SE_ HM_Res_Select;
        private System.Windows.Forms.OpenFileDialog EX_FileDialog;
        public SAOCR_Data_Manager.Button_SE_ HM_Res_Load;
        public SAOCR_Data_Manager.Button_SE_ HM_ToCsvTable;
        public SAOCR_Data_Manager.Button_SE_ HM_ToHomePage;
        private System.Windows.Forms.Panel P_CsvTable;
        private System.Windows.Forms.DataGridView CT_CsvView;
        public SAOCR_Data_Manager.Button_SE_ HM_ToConfig;
        private System.Windows.Forms.Panel P_Config;
        private System.Windows.Forms.GroupBox ST_SoundPath;
        private System.Windows.Forms.Label ST_PathBeepText;
        private System.Windows.Forms.Label ST_PathWarningText;
        public SAOCR_Data_Manager.Button_SE_ ST_PathWarningBrowse;
        public SAOCR_Data_Manager.Button_SE_ ST_PathBeepBrowse;
        private MarqueeableLabel ST_PathWarning;
        private MarqueeableLabel ST_PathBeep;
        private System.Windows.Forms.GroupBox ST_DataTitle;
        private System.Windows.Forms.ListView ST_Data;
        public Button_SE_ ST_ReadTitle;
        private System.Windows.Forms.Label CT_StepLabel;
        private System.Windows.Forms.TextBox CT_Step;
        private Button_SE_ CT_StepGo;
        private MarqueeableLabel CT_Tips;
        private System.Windows.Forms.CheckBox ST_AutoLoad;
        private Button_SE_ CT_SearchGo;
        private System.Windows.Forms.TextBox CT_Search;
        private System.Windows.Forms.Label CT_SearchString;
        private System.Windows.Forms.Label CT_EndColumnLabel;
        private System.Windows.Forms.Label CT_StartColumnLabel;
        private System.Windows.Forms.NumericUpDown CT_EndColumn;
        private System.Windows.Forms.NumericUpDown CT_StartColumn;
        private System.Windows.Forms.GroupBox ST_AboutProgram;
        private System.Windows.Forms.Label ST_Version;
        private System.Windows.Forms.Label ST_VersionText;
        private System.Windows.Forms.Label ST_DevelopersText;
        private MarqueeableLabel ST_Developer;
        private AxWMPLib.AxWindowsMediaPlayer BGM;
        public Button_SE_ ST_PathBGMBrowse;
        private MarqueeableLabel ST_PathBGM;
        private System.Windows.Forms.Label ST_PathBGMText;
        private System.Windows.Forms.CheckBox ST_PathBGMMute;
        private System.Windows.Forms.CheckBox ST_PathWarningMute;
        private System.Windows.Forms.CheckBox ST_PathBeepMute;
        private System.Windows.Forms.GroupBox ST_AUProg;
        private System.Windows.Forms.Label ST_AUProgLatestVerText;
        private System.Windows.Forms.Label ST_AUProgLatestVer;
        private System.Windows.Forms.Label ST_AUProgCurrentVerText;
        private System.Windows.Forms.Label ST_AUProgCurrentVer;
        private System.Windows.Forms.ListView CT_FindResultList;
        private System.Windows.Forms.Label ST_AUCsvModeText;
        private System.Windows.Forms.Label ST_AUProgChannelText;
        private System.Windows.Forms.Label ST_AUProgModeText;
        private System.Windows.Forms.Label ST_AUCsvPathText;
        private System.Windows.Forms.ComboBox ST_AUProgChannel;
        private System.Windows.Forms.ComboBox ST_AUProgMode;
        private MarqueeableLabel ST_AUCsvPath;
        private System.Windows.Forms.ComboBox ST_AUCsvMode;
        public Button_SE_ ST_AUProgCheckGo;
        public Button_SE_ ST_AUCsvCheckGo;
        private System.Windows.Forms.Panel P_CharacterData;
        private System.Windows.Forms.Label CD_CharacterIDText;
        private Button_SE_ CD_CharacterIDGo;
        private System.Windows.Forms.TextBox CD_CharacterID;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.GroupBox CD_SearchGB;
        private Button_SE_ CD_KeywordGo;
        private System.Windows.Forms.TextBox CD_Keyword;
        private System.Windows.Forms.Label CD_KeywordText;
        private System.Windows.Forms.ListView CD_KeywordResult;
        private System.Windows.Forms.Label CD_CharaSeriesText;
        private System.Windows.Forms.TextBox CD_Rarity;
        private System.Windows.Forms.Label CD_RarityText;
        private System.Windows.Forms.TextBox CD_CharaSeries;
        private System.Windows.Forms.LinkLabel CD_SeriesCodeGo;
        private System.Windows.Forms.CheckBox ST_PathMessageMute;
        public Button_SE_ ST_PathMessageBrowse;
        private MarqueeableLabel ST_PathMessage;
        private System.Windows.Forms.Label ST_PathMessageText;
        private System.Windows.Forms.StatusStrip MN_StatusStrip;
        private System.Windows.Forms.ToolStripDropDownButton MN_Button;
        private System.Windows.Forms.ToolStripStatusLabel MN_Status;
        private MarqueeableLabel HM_Announcement;
        private System.Windows.Forms.ToolStripButton MN_Capture;
        private System.Windows.Forms.ListView CD_Favorite;
        private System.Windows.Forms.Label CD_FavoriteText;
        public Button_SE_ ST_AUCsvBrowse;
        private System.Windows.Forms.FolderBrowserDialog EX_DirectoryDialog;
        private System.Windows.Forms.TabControl CD_CharacterTab;
        private Button_SE_ CD_CloseTab;
        private Button_SE_ CD_NewTab;
        private System.Windows.Forms.TabPage tabPage1;
        private Forms.CharaDataDisplay CharaDataDisplay;
        public Button_SE_ HM_ToStatistics;
        private System.Windows.Forms.Panel P_Statistics;
        private System.Windows.Forms.GroupBox SS_Weapon;
        private System.Windows.Forms.GroupBox SS_Monster;
        private System.Windows.Forms.GroupBox SS_Character;
        private System.Windows.Forms.Label SS_ChsaraElementRateText;
        private System.Windows.Forms.ListView SS_CharaElementRate;
        private Button_SE_ SS_CharaCalculate;
        private System.Windows.Forms.Label SS_CharaWeaponUsingRateText;
        private System.Windows.Forms.ListView SS_CharaWeaponUsingRate;
    }
}

