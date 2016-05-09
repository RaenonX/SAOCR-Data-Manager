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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MN_Title = new System.Windows.Forms.Label();
            this.P_HomePage = new System.Windows.Forms.Panel();
            this.HM_ToEXPCalc = new SAOCR_Data_Manager.Button_SE_();
            this.HM_ToDownload = new SAOCR_Data_Manager.Button_SE_();
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
            this.SS_MonsterCalculate = new SAOCR_Data_Manager.Button_SE_();
            this.SS_MonsterPanel = new System.Windows.Forms.Panel();
            this.SS_MonsterTypeRateText = new System.Windows.Forms.Label();
            this.SS_MonsterTypeRate = new System.Windows.Forms.ListView();
            this.SS_MonsterHPRate = new System.Windows.Forms.ListView();
            this.SS_MonsterHPRateText = new System.Windows.Forms.Label();
            this.SS_Character = new System.Windows.Forms.GroupBox();
            this.SS_CHaraPanel = new System.Windows.Forms.Panel();
            this.SS_CharaSceneRateText = new System.Windows.Forms.Label();
            this.SS_CharaSceneRate = new System.Windows.Forms.ListView();
            this.SS_CharaRarityRateText = new System.Windows.Forms.Label();
            this.SS_CharaRarityRate = new System.Windows.Forms.ListView();
            this.SS_CharaWeaponUsingRateText = new System.Windows.Forms.Label();
            this.SS_CharaSeriesRateText = new System.Windows.Forms.Label();
            this.SS_CharaWeaponUsingRate = new System.Windows.Forms.ListView();
            this.SS_CharaElementRate = new System.Windows.Forms.ListView();
            this.SS_CharaSeriesRate = new System.Windows.Forms.ListView();
            this.SS_CharaElementRateText = new System.Windows.Forms.Label();
            this.SS_CharaCalculate = new SAOCR_Data_Manager.Button_SE_();
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
            this.ST_SourcePath = new System.Windows.Forms.GroupBox();
            this.ST_SourceASBText = new System.Windows.Forms.Label();
            this.ST_SourceCSV = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_SourceASB = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_SourceCSVText = new System.Windows.Forms.Label();
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
            this.ST_ClearAllAttachments = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AttachmentMode = new System.Windows.Forms.ComboBox();
            this.ST_AttachmentModeText = new System.Windows.Forms.Label();
            this.ST_AUCsvBrowse = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AUCsvCheckGo = new SAOCR_Data_Manager.Button_SE_();
            this.ST_AUCsvPath = new SAOCR_Data_Manager.MarqueeableLabel();
            this.ST_AUCsvMode = new System.Windows.Forms.ComboBox();
            this.ST_AutoLoad = new System.Windows.Forms.CheckBox();
            this.ST_ReLoad = new SAOCR_Data_Manager.Button_SE_();
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
            this.CD_SearchCharacter = new SAOCR_Data_Manager.Controls.CharacterSearcher();
            this.CD_CloseTab = new SAOCR_Data_Manager.Button_SE_();
            this.CD_NewTab = new SAOCR_Data_Manager.Button_SE_();
            this.CD_CharacterTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CharaDataDisplay = new SAOCR_Data_Manager.Forms.CharaDataDisplay();
            this.CD_Favorite = new System.Windows.Forms.ListView();
            this.CD_CharacterIDText = new System.Windows.Forms.Label();
            this.CD_CharacterIDGo = new SAOCR_Data_Manager.Button_SE_();
            this.CD_CharacterID = new System.Windows.Forms.TextBox();
            this.CD_FavoriteText = new System.Windows.Forms.Label();
            this.P_Download = new System.Windows.Forms.Panel();
            this.DL_DownloadStatus = new System.Windows.Forms.ListView();
            this.DL_Failed = new System.Windows.Forms.Label();
            this.DL_FailedText = new System.Windows.Forms.Label();
            this.DL_Progress = new System.Windows.Forms.ProgressBar();
            this.DL_Completed = new System.Windows.Forms.Label();
            this.DL_CompletedText = new System.Windows.Forms.Label();
            this.DL_DLing = new System.Windows.Forms.Label();
            this.DL_DLingText = new System.Windows.Forms.Label();
            this.DL_Pending = new System.Windows.Forms.Label();
            this.DL_CompleteListText = new System.Windows.Forms.Label();
            this.DL_PendingText = new System.Windows.Forms.Label();
            this.DL_CompleteList = new System.Windows.Forms.RichTextBox();
            this.DL_DownloadLogText = new System.Windows.Forms.Label();
            this.DL_CharaPicBox = new System.Windows.Forms.GroupBox();
            this.DL_AbortDownload = new SAOCR_Data_Manager.Button_SE_();
            this.DL_PicCount = new System.Windows.Forms.Label();
            this.DL_PicCountText = new System.Windows.Forms.Label();
            this.DL_ClearAll = new SAOCR_Data_Manager.Button_SE_();
            this.DL_StartDownload = new SAOCR_Data_Manager.Button_SE_();
            this.DL_CharaIDAdd = new SAOCR_Data_Manager.Button_SE_();
            this.DL_CharaIDText = new System.Windows.Forms.Label();
            this.DL_CharaID = new System.Windows.Forms.TextBox();
            this.DL_Add = new SAOCR_Data_Manager.Button_SE_();
            this.DL_Remove = new SAOCR_Data_Manager.Button_SE_();
            this.DL_AddAll = new SAOCR_Data_Manager.Button_SE_();
            this.DL_DownloadListText = new System.Windows.Forms.Label();
            this.DL_DownloadList = new System.Windows.Forms.ListView();
            this.DL_Arrow = new System.Windows.Forms.Label();
            this.P_EXPCalc = new System.Windows.Forms.Panel();
            this.EC_Main = new System.Windows.Forms.GroupBox();
            this.EC_MainExpNeed = new SAOCR_Data_Manager.Controls.BreezeLabel();
            this.EC_MainParamAfter = new System.Windows.Forms.GroupBox();
            this.EC_MainRarityAfter = new SAOCR_Data_Manager.Controls.BreezeLabel();
            this.EC_MainSSAfter = new System.Windows.Forms.Label();
            this.EC_MainSSAfterText = new System.Windows.Forms.Label();
            this.EC_MainCostAfter = new System.Windows.Forms.Label();
            this.EC_MainHPAfter = new System.Windows.Forms.Label();
            this.EC_MainCostAfterText = new System.Windows.Forms.Label();
            this.EC_MainHPAfterText = new System.Windows.Forms.Label();
            this.EC_MainMENAfter = new System.Windows.Forms.Label();
            this.EC_MainINTAfter = new System.Windows.Forms.Label();
            this.EC_MainMENAfterText = new System.Windows.Forms.Label();
            this.EC_MainINTAfterText = new System.Windows.Forms.Label();
            this.EC_MainVITAfter = new System.Windows.Forms.Label();
            this.EC_MainSTRAfter = new System.Windows.Forms.Label();
            this.EC_MainVITAfterText = new System.Windows.Forms.Label();
            this.EC_MainSTRAfterText = new System.Windows.Forms.Label();
            this.EC_MainParamBefore = new System.Windows.Forms.GroupBox();
            this.EC_MainRarityBefore = new SAOCR_Data_Manager.Controls.BreezeLabel();
            this.EC_MainSSBefore = new System.Windows.Forms.Label();
            this.EC_MainSSBeforeText = new System.Windows.Forms.Label();
            this.EC_MainCostBefore = new System.Windows.Forms.Label();
            this.EC_MainHPBefore = new System.Windows.Forms.Label();
            this.EC_MainCostBeforeText = new System.Windows.Forms.Label();
            this.EC_MainHPBeforeText = new System.Windows.Forms.Label();
            this.EC_MainMENBefore = new System.Windows.Forms.Label();
            this.EC_MainINTBefore = new System.Windows.Forms.Label();
            this.EC_MainMENBeforeText = new System.Windows.Forms.Label();
            this.EC_MainINTBeforeText = new System.Windows.Forms.Label();
            this.EC_MainVITBefore = new System.Windows.Forms.Label();
            this.EC_MainSTRBefore = new System.Windows.Forms.Label();
            this.EC_MainVITBeforeText = new System.Windows.Forms.Label();
            this.EC_MainSTRBeforeText = new System.Windows.Forms.Label();
            this.EC_MainExpNeedText = new System.Windows.Forms.Label();
            this.EC_MainCalc = new SAOCR_Data_Manager.Button_SE_();
            this.EC_MainAfter = new System.Windows.Forms.GroupBox();
            this.EC_MainExpAfter = new System.Windows.Forms.TextBox();
            this.EC_MainExpAfterText = new System.Windows.Forms.Label();
            this.EC_MainLvAfter = new System.Windows.Forms.TextBox();
            this.EC_MainLvAfterText = new System.Windows.Forms.Label();
            this.EC_MainBefore = new System.Windows.Forms.GroupBox();
            this.EC_MainExpBefore = new System.Windows.Forms.TextBox();
            this.EC_MainExpBeforeText = new System.Windows.Forms.Label();
            this.EC_MainLvBefore = new System.Windows.Forms.TextBox();
            this.EC_MainLvBeforeText = new System.Windows.Forms.Label();
            this.EC_Chara = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EC_CharaTips = new SAOCR_Data_Manager.MarqueeableLabel();
            this.EC_CharaExpNeed = new SAOCR_Data_Manager.Controls.BreezeLabel();
            this.EC_CharaExpNeedText = new System.Windows.Forms.Label();
            this.EC_CharaCalc = new SAOCR_Data_Manager.Button_SE_();
            this.EC_CharaAfter = new System.Windows.Forms.GroupBox();
            this.EC_CharaExpAfter = new System.Windows.Forms.TextBox();
            this.EC_CharaExpAfterText = new System.Windows.Forms.Label();
            this.EC_CharaLvAfter = new System.Windows.Forms.TextBox();
            this.EC_CharaLvAfterText = new System.Windows.Forms.Label();
            this.EC_CharaBefore = new System.Windows.Forms.GroupBox();
            this.EC_CharaExpBefore = new System.Windows.Forms.TextBox();
            this.EC_CharaExpBeforeText = new System.Windows.Forms.Label();
            this.EC_CharaLvBefore = new System.Windows.Forms.TextBox();
            this.EC_CharaLvBeforeText = new System.Windows.Forms.Label();
            this.EX_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EX_DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.characterSearcher1 = new SAOCR_Data_Manager.Controls.CharacterSearcher();
            this.P_HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGM)).BeginInit();
            this.MN_Border.SuspendLayout();
            this.MN_StatusStrip.SuspendLayout();
            this.P_Statistics.SuspendLayout();
            this.SS_Monster.SuspendLayout();
            this.SS_MonsterPanel.SuspendLayout();
            this.SS_Character.SuspendLayout();
            this.SS_CHaraPanel.SuspendLayout();
            this.P_CsvTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_EndColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_StartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_CsvView)).BeginInit();
            this.P_Config.SuspendLayout();
            this.ST_SourcePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.ST_AUProg.SuspendLayout();
            this.ST_AboutProgram.SuspendLayout();
            this.ST_DataTitle.SuspendLayout();
            this.ST_SoundPath.SuspendLayout();
            this.P_CharacterData.SuspendLayout();
            this.CD_CharacterTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.P_Download.SuspendLayout();
            this.DL_CharaPicBox.SuspendLayout();
            this.P_EXPCalc.SuspendLayout();
            this.EC_Main.SuspendLayout();
            this.EC_MainParamAfter.SuspendLayout();
            this.EC_MainParamBefore.SuspendLayout();
            this.EC_MainAfter.SuspendLayout();
            this.EC_MainBefore.SuspendLayout();
            this.EC_Chara.SuspendLayout();
            this.EC_CharaAfter.SuspendLayout();
            this.EC_CharaBefore.SuspendLayout();
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
            this.P_HomePage.Controls.Add(this.HM_ToEXPCalc);
            this.P_HomePage.Controls.Add(this.HM_ToDownload);
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
            // HM_ToEXPCalc
            // 
            this.HM_ToEXPCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToEXPCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToEXPCalc.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToEXPCalc.ButtonBackgroundImage = null;
            this.HM_ToEXPCalc.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToEXPCalc.ButtonColor = System.Drawing.Color.White;
            this.HM_ToEXPCalc.ButtonEnabled = true;
            this.HM_ToEXPCalc.ButtonImage = null;
            this.HM_ToEXPCalc.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToEXPCalc.ButtonText = "";
            this.HM_ToEXPCalc.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToEXPCalc.ForeColor = System.Drawing.Color.White;
            this.HM_ToEXPCalc.Location = new System.Drawing.Point(277, 186);
            this.HM_ToEXPCalc.Margin = new System.Windows.Forms.Padding(4);
            this.HM_ToEXPCalc.Name = "HM_ToEXPCalc";
            this.HM_ToEXPCalc.Size = new System.Drawing.Size(258, 170);
            this.HM_ToEXPCalc.TabIndex = 14;
            // 
            // HM_ToDownload
            // 
            this.HM_ToDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToDownload.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HM_ToDownload.ButtonBackgroundImage = null;
            this.HM_ToDownload.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HM_ToDownload.ButtonColor = System.Drawing.Color.White;
            this.HM_ToDownload.ButtonEnabled = true;
            this.HM_ToDownload.ButtonImage = null;
            this.HM_ToDownload.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HM_ToDownload.ButtonText = "";
            this.HM_ToDownload.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.HM_ToDownload.ForeColor = System.Drawing.Color.White;
            this.HM_ToDownload.Location = new System.Drawing.Point(11, 186);
            this.HM_ToDownload.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.HM_ToDownload.Name = "HM_ToDownload";
            this.HM_ToDownload.Size = new System.Drawing.Size(258, 170);
            this.HM_ToDownload.TabIndex = 13;
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
            this.HM_ToStatistics.Location = new System.Drawing.Point(809, 8);
            this.HM_ToStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.HM_ToStatistics.Name = "HM_ToStatistics";
            this.HM_ToStatistics.Size = new System.Drawing.Size(258, 170);
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
            this.HM_ToConfig.Location = new System.Drawing.Point(847, 474);
            this.HM_ToConfig.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HM_ToConfig.Name = "HM_ToConfig";
            this.HM_ToConfig.Size = new System.Drawing.Size(220, 153);
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
            this.HM_ToCsvTable.Location = new System.Drawing.Point(543, 8);
            this.HM_ToCsvTable.Margin = new System.Windows.Forms.Padding(4);
            this.HM_ToCsvTable.Name = "HM_ToCsvTable";
            this.HM_ToCsvTable.Size = new System.Drawing.Size(258, 170);
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
            this.HM_ToEquipmentData.Location = new System.Drawing.Point(277, 8);
            this.HM_ToEquipmentData.Margin = new System.Windows.Forms.Padding(4);
            this.HM_ToEquipmentData.Name = "HM_ToEquipmentData";
            this.HM_ToEquipmentData.Size = new System.Drawing.Size(258, 170);
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
            this.HM_ToCharacterData.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.HM_ToCharacterData.Name = "HM_ToCharacterData";
            this.HM_ToCharacterData.Size = new System.Drawing.Size(258, 170);
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
            this.MN_Border.Controls.Add(this.P_Download);
            this.MN_Border.Controls.Add(this.P_EXPCalc);
            this.MN_Border.Controls.Add(this.P_HomePage);
            this.MN_Border.Controls.Add(this.P_Statistics);
            this.MN_Border.Controls.Add(this.P_CsvTable);
            this.MN_Border.Controls.Add(this.P_Config);
            this.MN_Border.Controls.Add(this.P_CharacterData);
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
            this.SS_Monster.Controls.Add(this.SS_MonsterCalculate);
            this.SS_Monster.Controls.Add(this.SS_MonsterPanel);
            this.SS_Monster.ForeColor = System.Drawing.Color.White;
            this.SS_Monster.Location = new System.Drawing.Point(387, 4);
            this.SS_Monster.Name = "SS_Monster";
            this.SS_Monster.Size = new System.Drawing.Size(369, 663);
            this.SS_Monster.TabIndex = 1;
            this.SS_Monster.TabStop = false;
            // 
            // SS_MonsterCalculate
            // 
            this.SS_MonsterCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SS_MonsterCalculate.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SS_MonsterCalculate.ButtonBackgroundImage = null;
            this.SS_MonsterCalculate.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SS_MonsterCalculate.ButtonColor = System.Drawing.Color.White;
            this.SS_MonsterCalculate.ButtonEnabled = true;
            this.SS_MonsterCalculate.ButtonImage = null;
            this.SS_MonsterCalculate.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SS_MonsterCalculate.ButtonText = "";
            this.SS_MonsterCalculate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.SS_MonsterCalculate.Location = new System.Drawing.Point(298, 628);
            this.SS_MonsterCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SS_MonsterCalculate.Name = "SS_MonsterCalculate";
            this.SS_MonsterCalculate.Size = new System.Drawing.Size(65, 28);
            this.SS_MonsterCalculate.TabIndex = 31;
            // 
            // SS_MonsterPanel
            // 
            this.SS_MonsterPanel.AutoScroll = true;
            this.SS_MonsterPanel.Controls.Add(this.SS_MonsterTypeRateText);
            this.SS_MonsterPanel.Controls.Add(this.SS_MonsterTypeRate);
            this.SS_MonsterPanel.Controls.Add(this.SS_MonsterHPRate);
            this.SS_MonsterPanel.Controls.Add(this.SS_MonsterHPRateText);
            this.SS_MonsterPanel.Location = new System.Drawing.Point(6, 22);
            this.SS_MonsterPanel.Name = "SS_MonsterPanel";
            this.SS_MonsterPanel.Size = new System.Drawing.Size(357, 599);
            this.SS_MonsterPanel.TabIndex = 31;
            // 
            // SS_MonsterTypeRateText
            // 
            this.SS_MonsterTypeRateText.Location = new System.Drawing.Point(0, 0);
            this.SS_MonsterTypeRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_MonsterTypeRateText.Name = "SS_MonsterTypeRateText";
            this.SS_MonsterTypeRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_MonsterTypeRateText.TabIndex = 25;
            this.SS_MonsterTypeRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_MonsterTypeRate
            // 
            this.SS_MonsterTypeRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_MonsterTypeRate.AllowColumnReorder = true;
            this.SS_MonsterTypeRate.AutoArrange = false;
            this.SS_MonsterTypeRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_MonsterTypeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_MonsterTypeRate.ForeColor = System.Drawing.Color.White;
            this.SS_MonsterTypeRate.FullRowSelect = true;
            this.SS_MonsterTypeRate.Location = new System.Drawing.Point(0, 24);
            this.SS_MonsterTypeRate.MultiSelect = false;
            this.SS_MonsterTypeRate.Name = "SS_MonsterTypeRate";
            this.SS_MonsterTypeRate.Size = new System.Drawing.Size(337, 150);
            this.SS_MonsterTypeRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_MonsterTypeRate.TabIndex = 24;
            this.SS_MonsterTypeRate.UseCompatibleStateImageBehavior = false;
            this.SS_MonsterTypeRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_MonsterHPRate
            // 
            this.SS_MonsterHPRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_MonsterHPRate.AllowColumnReorder = true;
            this.SS_MonsterHPRate.AutoArrange = false;
            this.SS_MonsterHPRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_MonsterHPRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_MonsterHPRate.ForeColor = System.Drawing.Color.White;
            this.SS_MonsterHPRate.FullRowSelect = true;
            this.SS_MonsterHPRate.Location = new System.Drawing.Point(0, 204);
            this.SS_MonsterHPRate.MultiSelect = false;
            this.SS_MonsterHPRate.Name = "SS_MonsterHPRate";
            this.SS_MonsterHPRate.Size = new System.Drawing.Size(337, 150);
            this.SS_MonsterHPRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_MonsterHPRate.TabIndex = 26;
            this.SS_MonsterHPRate.UseCompatibleStateImageBehavior = false;
            this.SS_MonsterHPRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_MonsterHPRateText
            // 
            this.SS_MonsterHPRateText.Location = new System.Drawing.Point(0, 180);
            this.SS_MonsterHPRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_MonsterHPRateText.Name = "SS_MonsterHPRateText";
            this.SS_MonsterHPRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_MonsterHPRateText.TabIndex = 27;
            this.SS_MonsterHPRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_Character
            // 
            this.SS_Character.Controls.Add(this.SS_CHaraPanel);
            this.SS_Character.Controls.Add(this.SS_CharaCalculate);
            this.SS_Character.ForeColor = System.Drawing.Color.White;
            this.SS_Character.Location = new System.Drawing.Point(12, 4);
            this.SS_Character.Name = "SS_Character";
            this.SS_Character.Size = new System.Drawing.Size(369, 663);
            this.SS_Character.TabIndex = 1;
            this.SS_Character.TabStop = false;
            // 
            // SS_CHaraPanel
            // 
            this.SS_CHaraPanel.AutoScroll = true;
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaSceneRateText);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaSceneRate);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaRarityRateText);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaRarityRate);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaWeaponUsingRateText);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaSeriesRateText);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaWeaponUsingRate);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaElementRate);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaSeriesRate);
            this.SS_CHaraPanel.Controls.Add(this.SS_CharaElementRateText);
            this.SS_CHaraPanel.Location = new System.Drawing.Point(6, 22);
            this.SS_CHaraPanel.Name = "SS_CHaraPanel";
            this.SS_CHaraPanel.Size = new System.Drawing.Size(357, 599);
            this.SS_CHaraPanel.TabIndex = 30;
            // 
            // SS_CharaSceneRateText
            // 
            this.SS_CharaSceneRateText.Location = new System.Drawing.Point(0, 718);
            this.SS_CharaSceneRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_CharaSceneRateText.Name = "SS_CharaSceneRateText";
            this.SS_CharaSceneRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_CharaSceneRateText.TabIndex = 33;
            this.SS_CharaSceneRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_CharaSceneRate
            // 
            this.SS_CharaSceneRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaSceneRate.AllowColumnReorder = true;
            this.SS_CharaSceneRate.AutoArrange = false;
            this.SS_CharaSceneRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaSceneRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaSceneRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaSceneRate.FullRowSelect = true;
            this.SS_CharaSceneRate.Location = new System.Drawing.Point(0, 742);
            this.SS_CharaSceneRate.MultiSelect = false;
            this.SS_CharaSceneRate.Name = "SS_CharaSceneRate";
            this.SS_CharaSceneRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaSceneRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_CharaSceneRate.TabIndex = 32;
            this.SS_CharaSceneRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaSceneRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_CharaRarityRateText
            // 
            this.SS_CharaRarityRateText.Location = new System.Drawing.Point(0, 538);
            this.SS_CharaRarityRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_CharaRarityRateText.Name = "SS_CharaRarityRateText";
            this.SS_CharaRarityRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_CharaRarityRateText.TabIndex = 31;
            this.SS_CharaRarityRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_CharaRarityRate
            // 
            this.SS_CharaRarityRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaRarityRate.AllowColumnReorder = true;
            this.SS_CharaRarityRate.AutoArrange = false;
            this.SS_CharaRarityRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaRarityRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaRarityRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaRarityRate.FullRowSelect = true;
            this.SS_CharaRarityRate.Location = new System.Drawing.Point(0, 562);
            this.SS_CharaRarityRate.MultiSelect = false;
            this.SS_CharaRarityRate.Name = "SS_CharaRarityRate";
            this.SS_CharaRarityRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaRarityRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_CharaRarityRate.TabIndex = 30;
            this.SS_CharaRarityRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaRarityRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_CharaWeaponUsingRateText
            // 
            this.SS_CharaWeaponUsingRateText.Location = new System.Drawing.Point(0, 0);
            this.SS_CharaWeaponUsingRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_CharaWeaponUsingRateText.Name = "SS_CharaWeaponUsingRateText";
            this.SS_CharaWeaponUsingRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_CharaWeaponUsingRateText.TabIndex = 25;
            this.SS_CharaWeaponUsingRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_CharaSeriesRateText
            // 
            this.SS_CharaSeriesRateText.Location = new System.Drawing.Point(0, 360);
            this.SS_CharaSeriesRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_CharaSeriesRateText.Name = "SS_CharaSeriesRateText";
            this.SS_CharaSeriesRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_CharaSeriesRateText.TabIndex = 29;
            this.SS_CharaSeriesRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SS_CharaWeaponUsingRate
            // 
            this.SS_CharaWeaponUsingRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaWeaponUsingRate.AllowColumnReorder = true;
            this.SS_CharaWeaponUsingRate.AutoArrange = false;
            this.SS_CharaWeaponUsingRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaWeaponUsingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaWeaponUsingRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaWeaponUsingRate.FullRowSelect = true;
            this.SS_CharaWeaponUsingRate.Location = new System.Drawing.Point(0, 24);
            this.SS_CharaWeaponUsingRate.MultiSelect = false;
            this.SS_CharaWeaponUsingRate.Name = "SS_CharaWeaponUsingRate";
            this.SS_CharaWeaponUsingRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaWeaponUsingRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_CharaWeaponUsingRate.TabIndex = 24;
            this.SS_CharaWeaponUsingRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaWeaponUsingRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_CharaElementRate
            // 
            this.SS_CharaElementRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaElementRate.AllowColumnReorder = true;
            this.SS_CharaElementRate.AutoArrange = false;
            this.SS_CharaElementRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaElementRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaElementRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaElementRate.FullRowSelect = true;
            this.SS_CharaElementRate.Location = new System.Drawing.Point(0, 204);
            this.SS_CharaElementRate.MultiSelect = false;
            this.SS_CharaElementRate.Name = "SS_CharaElementRate";
            this.SS_CharaElementRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaElementRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_CharaElementRate.TabIndex = 26;
            this.SS_CharaElementRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaElementRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_CharaSeriesRate
            // 
            this.SS_CharaSeriesRate.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SS_CharaSeriesRate.AllowColumnReorder = true;
            this.SS_CharaSeriesRate.AutoArrange = false;
            this.SS_CharaSeriesRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SS_CharaSeriesRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SS_CharaSeriesRate.ForeColor = System.Drawing.Color.White;
            this.SS_CharaSeriesRate.FullRowSelect = true;
            this.SS_CharaSeriesRate.Location = new System.Drawing.Point(0, 384);
            this.SS_CharaSeriesRate.MultiSelect = false;
            this.SS_CharaSeriesRate.Name = "SS_CharaSeriesRate";
            this.SS_CharaSeriesRate.Size = new System.Drawing.Size(337, 150);
            this.SS_CharaSeriesRate.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.SS_CharaSeriesRate.TabIndex = 28;
            this.SS_CharaSeriesRate.UseCompatibleStateImageBehavior = false;
            this.SS_CharaSeriesRate.View = System.Windows.Forms.View.Details;
            // 
            // SS_CharaElementRateText
            // 
            this.SS_CharaElementRateText.Location = new System.Drawing.Point(0, 180);
            this.SS_CharaElementRateText.Margin = new System.Windows.Forms.Padding(3);
            this.SS_CharaElementRateText.Name = "SS_CharaElementRateText";
            this.SS_CharaElementRateText.Size = new System.Drawing.Size(337, 18);
            this.SS_CharaElementRateText.TabIndex = 27;
            this.SS_CharaElementRateText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.SS_CharaCalculate.Location = new System.Drawing.Point(298, 628);
            this.SS_CharaCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SS_CharaCalculate.Name = "SS_CharaCalculate";
            this.SS_CharaCalculate.Size = new System.Drawing.Size(65, 28);
            this.SS_CharaCalculate.TabIndex = 23;
            // 
            // SS_Weapon
            // 
            this.SS_Weapon.ForeColor = System.Drawing.Color.White;
            this.SS_Weapon.Location = new System.Drawing.Point(762, 5);
            this.SS_Weapon.Name = "SS_Weapon";
            this.SS_Weapon.Size = new System.Drawing.Size(305, 662);
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
            this.CT_EndColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CT_StartColumnLabel
            // 
            this.CT_StartColumnLabel.Location = new System.Drawing.Point(11, 60);
            this.CT_StartColumnLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CT_StartColumnLabel.Name = "CT_StartColumnLabel";
            this.CT_StartColumnLabel.Size = new System.Drawing.Size(63, 23);
            this.CT_StartColumnLabel.TabIndex = 15;
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
            this.CT_CsvView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CT_CsvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_CsvView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_CsvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CT_CsvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CT_CsvView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CT_CsvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.CT_CsvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CT_CsvView.Location = new System.Drawing.Point(251, 8);
            this.CT_CsvView.Name = "CT_CsvView";
            this.CT_CsvView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_CsvView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.CT_CsvView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CT_CsvView.RowTemplate.Height = 20;
            this.CT_CsvView.Size = new System.Drawing.Size(816, 659);
            this.CT_CsvView.TabIndex = 8;
            // 
            // P_Config
            // 
            this.P_Config.Controls.Add(this.ST_SourcePath);
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
            // ST_SourcePath
            // 
            this.ST_SourcePath.Controls.Add(this.ST_SourceASBText);
            this.ST_SourcePath.Controls.Add(this.ST_SourceCSV);
            this.ST_SourcePath.Controls.Add(this.ST_SourceASB);
            this.ST_SourcePath.Controls.Add(this.ST_SourceCSVText);
            this.ST_SourcePath.ForeColor = System.Drawing.Color.White;
            this.ST_SourcePath.Location = new System.Drawing.Point(606, 8);
            this.ST_SourcePath.Name = "ST_SourcePath";
            this.ST_SourcePath.Size = new System.Drawing.Size(461, 87);
            this.ST_SourcePath.TabIndex = 26;
            this.ST_SourcePath.TabStop = false;
            // 
            // ST_SourceASBText
            // 
            this.ST_SourceASBText.Location = new System.Drawing.Point(6, 22);
            this.ST_SourceASBText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_SourceASBText.Name = "ST_SourceASBText";
            this.ST_SourceASBText.Size = new System.Drawing.Size(80, 25);
            this.ST_SourceASBText.TabIndex = 6;
            this.ST_SourceASBText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_SourceCSV
            // 
            this.ST_SourceCSV.Direction = MarqueeDirection.Horizontal;
            this.ST_SourceCSV.EnableMarquee = true;
            this.ST_SourceCSV.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_SourceCSV.FreezeTime = 2000;
            this.ST_SourceCSV.LabelSize = new System.Drawing.Size(359, 25);
            this.ST_SourceCSV.LeftDistance = 5;
            this.ST_SourceCSV.LForeColor = System.Drawing.Color.White;
            this.ST_SourceCSV.Location = new System.Drawing.Point(92, 53);
            this.ST_SourceCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_SourceCSV.MarqueeText = "";
            this.ST_SourceCSV.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_SourceCSV.MoveDifferenceEachTime = 1;
            this.ST_SourceCSV.MoveInterval = 15;
            this.ST_SourceCSV.Name = "ST_SourceCSV";
            this.ST_SourceCSV.OverBorderDistance = 15;
            this.ST_SourceCSV.Size = new System.Drawing.Size(359, 25);
            this.ST_SourceCSV.TabIndex = 15;
            // 
            // ST_SourceASB
            // 
            this.ST_SourceASB.Direction = MarqueeDirection.Horizontal;
            this.ST_SourceASB.EnableMarquee = true;
            this.ST_SourceASB.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_SourceASB.FreezeTime = 2000;
            this.ST_SourceASB.LabelSize = new System.Drawing.Size(359, 25);
            this.ST_SourceASB.LeftDistance = 5;
            this.ST_SourceASB.LForeColor = System.Drawing.Color.White;
            this.ST_SourceASB.Location = new System.Drawing.Point(92, 22);
            this.ST_SourceASB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_SourceASB.MarqueeText = "";
            this.ST_SourceASB.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_SourceASB.MoveDifferenceEachTime = 1;
            this.ST_SourceASB.MoveInterval = 15;
            this.ST_SourceASB.Name = "ST_SourceASB";
            this.ST_SourceASB.OverBorderDistance = 15;
            this.ST_SourceASB.Size = new System.Drawing.Size(359, 25);
            this.ST_SourceASB.TabIndex = 14;
            // 
            // ST_SourceCSVText
            // 
            this.ST_SourceCSVText.Location = new System.Drawing.Point(6, 53);
            this.ST_SourceCSVText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_SourceCSVText.Name = "ST_SourceCSVText";
            this.ST_SourceCSVText.Size = new System.Drawing.Size(80, 25);
            this.ST_SourceCSVText.TabIndex = 7;
            this.ST_SourceCSVText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ST_DataTitle.Controls.Add(this.ST_ClearAllAttachments);
            this.ST_DataTitle.Controls.Add(this.ST_AttachmentMode);
            this.ST_DataTitle.Controls.Add(this.ST_AttachmentModeText);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvBrowse);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvCheckGo);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvPath);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvMode);
            this.ST_DataTitle.Controls.Add(this.ST_AutoLoad);
            this.ST_DataTitle.Controls.Add(this.ST_ReLoad);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvPathText);
            this.ST_DataTitle.Controls.Add(this.ST_Data);
            this.ST_DataTitle.Controls.Add(this.ST_AUCsvModeText);
            this.ST_DataTitle.ForeColor = System.Drawing.Color.White;
            this.ST_DataTitle.Location = new System.Drawing.Point(11, 160);
            this.ST_DataTitle.Name = "ST_DataTitle";
            this.ST_DataTitle.Size = new System.Drawing.Size(589, 261);
            this.ST_DataTitle.TabIndex = 8;
            this.ST_DataTitle.TabStop = false;
            // 
            // ST_ClearAllAttachments
            // 
            this.ST_ClearAllAttachments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_ClearAllAttachments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_ClearAllAttachments.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_ClearAllAttachments.ButtonBackgroundImage = null;
            this.ST_ClearAllAttachments.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_ClearAllAttachments.ButtonColor = System.Drawing.Color.Red;
            this.ST_ClearAllAttachments.ButtonEnabled = true;
            this.ST_ClearAllAttachments.ButtonImage = null;
            this.ST_ClearAllAttachments.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_ClearAllAttachments.ButtonText = "";
            this.ST_ClearAllAttachments.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_ClearAllAttachments.ForeColor = System.Drawing.Color.White;
            this.ST_ClearAllAttachments.Location = new System.Drawing.Point(264, 173);
            this.ST_ClearAllAttachments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_ClearAllAttachments.Name = "ST_ClearAllAttachments";
            this.ST_ClearAllAttachments.Size = new System.Drawing.Size(319, 29);
            this.ST_ClearAllAttachments.TabIndex = 29;
            // 
            // ST_AttachmentMode
            // 
            this.ST_AttachmentMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ST_AttachmentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_AttachmentMode.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AttachmentMode.ForeColor = System.Drawing.Color.White;
            this.ST_AttachmentMode.FormattingEnabled = true;
            this.ST_AttachmentMode.Location = new System.Drawing.Point(365, 142);
            this.ST_AttachmentMode.Name = "ST_AttachmentMode";
            this.ST_AttachmentMode.Size = new System.Drawing.Size(122, 24);
            this.ST_AttachmentMode.TabIndex = 28;
            // 
            // ST_AttachmentModeText
            // 
            this.ST_AttachmentModeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AttachmentModeText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AttachmentModeText.Location = new System.Drawing.Point(264, 142);
            this.ST_AttachmentModeText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AttachmentModeText.Name = "ST_AttachmentModeText";
            this.ST_AttachmentModeText.Size = new System.Drawing.Size(95, 24);
            this.ST_AttachmentModeText.TabIndex = 27;
            this.ST_AttachmentModeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ST_AUCsvBrowse.Location = new System.Drawing.Point(541, 52);
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
            this.ST_AUCsvCheckGo.Location = new System.Drawing.Point(493, 111);
            this.ST_AUCsvCheckGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_AUCsvCheckGo.Name = "ST_AUCsvCheckGo";
            this.ST_AUCsvCheckGo.Size = new System.Drawing.Size(90, 55);
            this.ST_AUCsvCheckGo.TabIndex = 23;
            // 
            // ST_AUCsvPath
            // 
            this.ST_AUCsvPath.Direction = MarqueeDirection.Horizontal;
            this.ST_AUCsvPath.EnableMarquee = true;
            this.ST_AUCsvPath.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvPath.FreezeTime = 2000;
            this.ST_AUCsvPath.LabelSize = new System.Drawing.Size(271, 23);
            this.ST_AUCsvPath.LeftDistance = 5;
            this.ST_AUCsvPath.LForeColor = System.Drawing.Color.White;
            this.ST_AUCsvPath.Location = new System.Drawing.Point(264, 52);
            this.ST_AUCsvPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_AUCsvPath.MarqueeText = "";
            this.ST_AUCsvPath.Mode = ((MarqueeMode)((MarqueeMode.Continual | MarqueeMode.ContinualAndSneeze)));
            this.ST_AUCsvPath.MoveDifferenceEachTime = 1;
            this.ST_AUCsvPath.MoveInterval = 15;
            this.ST_AUCsvPath.Name = "ST_AUCsvPath";
            this.ST_AUCsvPath.OverBorderDistance = 15;
            this.ST_AUCsvPath.Size = new System.Drawing.Size(271, 23);
            this.ST_AUCsvPath.TabIndex = 22;
            // 
            // ST_AUCsvMode
            // 
            this.ST_AUCsvMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ST_AUCsvMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_AUCsvMode.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvMode.ForeColor = System.Drawing.Color.White;
            this.ST_AUCsvMode.FormattingEnabled = true;
            this.ST_AUCsvMode.Location = new System.Drawing.Point(365, 112);
            this.ST_AUCsvMode.Name = "ST_AUCsvMode";
            this.ST_AUCsvMode.Size = new System.Drawing.Size(122, 24);
            this.ST_AUCsvMode.TabIndex = 22;
            // 
            // ST_AutoLoad
            // 
            this.ST_AutoLoad.Location = new System.Drawing.Point(264, 82);
            this.ST_AutoLoad.Name = "ST_AutoLoad";
            this.ST_AutoLoad.Size = new System.Drawing.Size(212, 24);
            this.ST_AutoLoad.TabIndex = 17;
            this.ST_AutoLoad.UseVisualStyleBackColor = true;
            // 
            // ST_ReLoad
            // 
            this.ST_ReLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_ReLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_ReLoad.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ST_ReLoad.ButtonBackgroundImage = null;
            this.ST_ReLoad.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ST_ReLoad.ButtonColor = System.Drawing.Color.White;
            this.ST_ReLoad.ButtonEnabled = true;
            this.ST_ReLoad.ButtonImage = null;
            this.ST_ReLoad.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ST_ReLoad.ButtonText = "";
            this.ST_ReLoad.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.ST_ReLoad.ForeColor = System.Drawing.Color.White;
            this.ST_ReLoad.Location = new System.Drawing.Point(482, 82);
            this.ST_ReLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ST_ReLoad.Name = "ST_ReLoad";
            this.ST_ReLoad.Size = new System.Drawing.Size(101, 24);
            this.ST_ReLoad.TabIndex = 16;
            // 
            // ST_AUCsvPathText
            // 
            this.ST_AUCsvPathText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvPathText.Location = new System.Drawing.Point(264, 22);
            this.ST_AUCsvPathText.Margin = new System.Windows.Forms.Padding(3);
            this.ST_AUCsvPathText.Name = "ST_AUCsvPathText";
            this.ST_AUCsvPathText.Size = new System.Drawing.Size(88, 23);
            this.ST_AUCsvPathText.TabIndex = 21;
            this.ST_AUCsvPathText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ST_Data.Size = new System.Drawing.Size(252, 233);
            this.ST_Data.TabIndex = 0;
            this.ST_Data.UseCompatibleStateImageBehavior = false;
            this.ST_Data.View = System.Windows.Forms.View.Details;
            // 
            // ST_AUCsvModeText
            // 
            this.ST_AUCsvModeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ST_AUCsvModeText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.ST_AUCsvModeText.Location = new System.Drawing.Point(264, 112);
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
            this.P_CharacterData.Controls.Add(this.CD_SearchCharacter);
            this.P_CharacterData.Controls.Add(this.CD_CloseTab);
            this.P_CharacterData.Controls.Add(this.CD_NewTab);
            this.P_CharacterData.Controls.Add(this.CD_CharacterTab);
            this.P_CharacterData.Controls.Add(this.CD_Favorite);
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
            // CD_SearchCharacter
            // 
            this.CD_SearchCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CD_SearchCharacter.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.CD_SearchCharacter.ForeColor = System.Drawing.Color.White;
            this.CD_SearchCharacter.Location = new System.Drawing.Point(11, 51);
            this.CD_SearchCharacter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CD_SearchCharacter.Name = "CD_SearchCharacter";
            this.CD_SearchCharacter.Size = new System.Drawing.Size(294, 335);
            this.CD_SearchCharacter.TabIndex = 40;
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
            this.CD_CharacterIDGo.Size = new System.Drawing.Size(54, 36);
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
            // P_Download
            // 
            this.P_Download.Controls.Add(this.DL_DownloadStatus);
            this.P_Download.Controls.Add(this.DL_Failed);
            this.P_Download.Controls.Add(this.DL_FailedText);
            this.P_Download.Controls.Add(this.DL_Progress);
            this.P_Download.Controls.Add(this.DL_Completed);
            this.P_Download.Controls.Add(this.DL_CompletedText);
            this.P_Download.Controls.Add(this.DL_DLing);
            this.P_Download.Controls.Add(this.DL_DLingText);
            this.P_Download.Controls.Add(this.DL_Pending);
            this.P_Download.Controls.Add(this.DL_CompleteListText);
            this.P_Download.Controls.Add(this.DL_PendingText);
            this.P_Download.Controls.Add(this.DL_CompleteList);
            this.P_Download.Controls.Add(this.DL_DownloadLogText);
            this.P_Download.Controls.Add(this.DL_CharaPicBox);
            this.P_Download.Location = new System.Drawing.Point(1, 24);
            this.P_Download.Margin = new System.Windows.Forms.Padding(0);
            this.P_Download.Name = "P_Download";
            this.P_Download.Size = new System.Drawing.Size(1078, 695);
            this.P_Download.TabIndex = 13;
            this.P_Download.Visible = false;
            // 
            // DL_DownloadStatus
            // 
            this.DL_DownloadStatus.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.DL_DownloadStatus.AutoArrange = false;
            this.DL_DownloadStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_DownloadStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DL_DownloadStatus.ForeColor = System.Drawing.Color.White;
            this.DL_DownloadStatus.FullRowSelect = true;
            this.DL_DownloadStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DL_DownloadStatus.Location = new System.Drawing.Point(12, 457);
            this.DL_DownloadStatus.MultiSelect = false;
            this.DL_DownloadStatus.Name = "DL_DownloadStatus";
            this.DL_DownloadStatus.Size = new System.Drawing.Size(330, 210);
            this.DL_DownloadStatus.TabIndex = 51;
            this.DL_DownloadStatus.UseCompatibleStateImageBehavior = false;
            this.DL_DownloadStatus.View = System.Windows.Forms.View.Details;
            // 
            // DL_Failed
            // 
            this.DL_Failed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_Failed.Font = new System.Drawing.Font("Consolas", 13F);
            this.DL_Failed.ForeColor = System.Drawing.Color.Red;
            this.DL_Failed.Location = new System.Drawing.Point(643, 642);
            this.DL_Failed.Margin = new System.Windows.Forms.Padding(3);
            this.DL_Failed.Name = "DL_Failed";
            this.DL_Failed.Size = new System.Drawing.Size(76, 25);
            this.DL_Failed.TabIndex = 59;
            this.DL_Failed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_FailedText
            // 
            this.DL_FailedText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_FailedText.ForeColor = System.Drawing.Color.Red;
            this.DL_FailedText.Location = new System.Drawing.Point(643, 619);
            this.DL_FailedText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_FailedText.Name = "DL_FailedText";
            this.DL_FailedText.Size = new System.Drawing.Size(76, 17);
            this.DL_FailedText.TabIndex = 58;
            this.DL_FailedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_Progress
            // 
            this.DL_Progress.ForeColor = System.Drawing.Color.White;
            this.DL_Progress.Location = new System.Drawing.Point(643, 433);
            this.DL_Progress.Name = "DL_Progress";
            this.DL_Progress.Size = new System.Drawing.Size(76, 18);
            this.DL_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DL_Progress.TabIndex = 57;
            // 
            // DL_Completed
            // 
            this.DL_Completed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_Completed.Font = new System.Drawing.Font("Consolas", 13F);
            this.DL_Completed.Location = new System.Drawing.Point(643, 588);
            this.DL_Completed.Margin = new System.Windows.Forms.Padding(3);
            this.DL_Completed.Name = "DL_Completed";
            this.DL_Completed.Size = new System.Drawing.Size(76, 25);
            this.DL_Completed.TabIndex = 56;
            this.DL_Completed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_CompletedText
            // 
            this.DL_CompletedText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_CompletedText.Location = new System.Drawing.Point(643, 565);
            this.DL_CompletedText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_CompletedText.Name = "DL_CompletedText";
            this.DL_CompletedText.Size = new System.Drawing.Size(76, 17);
            this.DL_CompletedText.TabIndex = 55;
            this.DL_CompletedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_DLing
            // 
            this.DL_DLing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_DLing.Font = new System.Drawing.Font("Consolas", 13F);
            this.DL_DLing.Location = new System.Drawing.Point(643, 534);
            this.DL_DLing.Margin = new System.Windows.Forms.Padding(3);
            this.DL_DLing.Name = "DL_DLing";
            this.DL_DLing.Size = new System.Drawing.Size(76, 25);
            this.DL_DLing.TabIndex = 54;
            this.DL_DLing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_DLingText
            // 
            this.DL_DLingText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_DLingText.Location = new System.Drawing.Point(643, 511);
            this.DL_DLingText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_DLingText.Name = "DL_DLingText";
            this.DL_DLingText.Size = new System.Drawing.Size(76, 17);
            this.DL_DLingText.TabIndex = 53;
            this.DL_DLingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_Pending
            // 
            this.DL_Pending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_Pending.Font = new System.Drawing.Font("Consolas", 13F);
            this.DL_Pending.Location = new System.Drawing.Point(643, 480);
            this.DL_Pending.Margin = new System.Windows.Forms.Padding(3);
            this.DL_Pending.Name = "DL_Pending";
            this.DL_Pending.Size = new System.Drawing.Size(76, 25);
            this.DL_Pending.TabIndex = 52;
            this.DL_Pending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_CompleteListText
            // 
            this.DL_CompleteListText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_CompleteListText.Location = new System.Drawing.Point(348, 433);
            this.DL_CompleteListText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_CompleteListText.Name = "DL_CompleteListText";
            this.DL_CompleteListText.Size = new System.Drawing.Size(289, 18);
            this.DL_CompleteListText.TabIndex = 50;
            this.DL_CompleteListText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DL_PendingText
            // 
            this.DL_PendingText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_PendingText.Location = new System.Drawing.Point(643, 457);
            this.DL_PendingText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_PendingText.Name = "DL_PendingText";
            this.DL_PendingText.Size = new System.Drawing.Size(76, 17);
            this.DL_PendingText.TabIndex = 51;
            this.DL_PendingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_CompleteList
            // 
            this.DL_CompleteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_CompleteList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DL_CompleteList.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_CompleteList.ForeColor = System.Drawing.Color.White;
            this.DL_CompleteList.Location = new System.Drawing.Point(348, 457);
            this.DL_CompleteList.Name = "DL_CompleteList";
            this.DL_CompleteList.ReadOnly = true;
            this.DL_CompleteList.Size = new System.Drawing.Size(289, 210);
            this.DL_CompleteList.TabIndex = 49;
            this.DL_CompleteList.Text = "";
            // 
            // DL_DownloadLogText
            // 
            this.DL_DownloadLogText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_DownloadLogText.Location = new System.Drawing.Point(11, 433);
            this.DL_DownloadLogText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_DownloadLogText.Name = "DL_DownloadLogText";
            this.DL_DownloadLogText.Size = new System.Drawing.Size(331, 18);
            this.DL_DownloadLogText.TabIndex = 48;
            this.DL_DownloadLogText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DL_CharaPicBox
            // 
            this.DL_CharaPicBox.Controls.Add(this.characterSearcher1);
            this.DL_CharaPicBox.Controls.Add(this.DL_AbortDownload);
            this.DL_CharaPicBox.Controls.Add(this.DL_PicCount);
            this.DL_CharaPicBox.Controls.Add(this.DL_PicCountText);
            this.DL_CharaPicBox.Controls.Add(this.DL_ClearAll);
            this.DL_CharaPicBox.Controls.Add(this.DL_StartDownload);
            this.DL_CharaPicBox.Controls.Add(this.DL_CharaIDAdd);
            this.DL_CharaPicBox.Controls.Add(this.DL_CharaIDText);
            this.DL_CharaPicBox.Controls.Add(this.DL_CharaID);
            this.DL_CharaPicBox.Controls.Add(this.DL_Add);
            this.DL_CharaPicBox.Controls.Add(this.DL_Remove);
            this.DL_CharaPicBox.Controls.Add(this.DL_AddAll);
            this.DL_CharaPicBox.Controls.Add(this.DL_DownloadListText);
            this.DL_CharaPicBox.Controls.Add(this.DL_DownloadList);
            this.DL_CharaPicBox.Controls.Add(this.DL_Arrow);
            this.DL_CharaPicBox.ForeColor = System.Drawing.Color.White;
            this.DL_CharaPicBox.Location = new System.Drawing.Point(11, 4);
            this.DL_CharaPicBox.Name = "DL_CharaPicBox";
            this.DL_CharaPicBox.Size = new System.Drawing.Size(708, 423);
            this.DL_CharaPicBox.TabIndex = 28;
            this.DL_CharaPicBox.TabStop = false;
            // 
            // DL_AbortDownload
            // 
            this.DL_AbortDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_AbortDownload.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_AbortDownload.ButtonBackgroundImage = null;
            this.DL_AbortDownload.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_AbortDownload.ButtonColor = System.Drawing.Color.Red;
            this.DL_AbortDownload.ButtonEnabled = false;
            this.DL_AbortDownload.ButtonImage = null;
            this.DL_AbortDownload.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_AbortDownload.ButtonText = "";
            this.DL_AbortDownload.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_AbortDownload.Location = new System.Drawing.Point(625, 393);
            this.DL_AbortDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_AbortDownload.Name = "DL_AbortDownload";
            this.DL_AbortDownload.Size = new System.Drawing.Size(76, 23);
            this.DL_AbortDownload.TabIndex = 51;
            // 
            // DL_PicCount
            // 
            this.DL_PicCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_PicCount.Font = new System.Drawing.Font("Consolas", 13F);
            this.DL_PicCount.Location = new System.Drawing.Point(625, 333);
            this.DL_PicCount.Margin = new System.Windows.Forms.Padding(3);
            this.DL_PicCount.Name = "DL_PicCount";
            this.DL_PicCount.Size = new System.Drawing.Size(76, 25);
            this.DL_PicCount.TabIndex = 50;
            this.DL_PicCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_PicCountText
            // 
            this.DL_PicCountText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_PicCountText.Location = new System.Drawing.Point(625, 310);
            this.DL_PicCountText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_PicCountText.Name = "DL_PicCountText";
            this.DL_PicCountText.Size = new System.Drawing.Size(76, 17);
            this.DL_PicCountText.TabIndex = 49;
            this.DL_PicCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_ClearAll
            // 
            this.DL_ClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_ClearAll.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_ClearAll.ButtonBackgroundImage = null;
            this.DL_ClearAll.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_ClearAll.ButtonColor = System.Drawing.Color.White;
            this.DL_ClearAll.ButtonEnabled = true;
            this.DL_ClearAll.ButtonImage = null;
            this.DL_ClearAll.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_ClearAll.ButtonText = "";
            this.DL_ClearAll.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_ClearAll.Location = new System.Drawing.Point(625, 238);
            this.DL_ClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_ClearAll.Name = "DL_ClearAll";
            this.DL_ClearAll.Size = new System.Drawing.Size(76, 23);
            this.DL_ClearAll.TabIndex = 48;
            // 
            // DL_StartDownload
            // 
            this.DL_StartDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_StartDownload.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_StartDownload.ButtonBackgroundImage = null;
            this.DL_StartDownload.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_StartDownload.ButtonColor = System.Drawing.Color.Red;
            this.DL_StartDownload.ButtonEnabled = false;
            this.DL_StartDownload.ButtonImage = null;
            this.DL_StartDownload.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_StartDownload.ButtonText = "";
            this.DL_StartDownload.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_StartDownload.Location = new System.Drawing.Point(625, 364);
            this.DL_StartDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_StartDownload.Name = "DL_StartDownload";
            this.DL_StartDownload.Size = new System.Drawing.Size(76, 23);
            this.DL_StartDownload.TabIndex = 47;
            // 
            // DL_CharaIDAdd
            // 
            this.DL_CharaIDAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_CharaIDAdd.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_CharaIDAdd.ButtonBackgroundImage = null;
            this.DL_CharaIDAdd.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_CharaIDAdd.ButtonColor = System.Drawing.Color.White;
            this.DL_CharaIDAdd.ButtonEnabled = true;
            this.DL_CharaIDAdd.ButtonImage = null;
            this.DL_CharaIDAdd.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_CharaIDAdd.ButtonText = "";
            this.DL_CharaIDAdd.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_CharaIDAdd.Location = new System.Drawing.Point(649, 84);
            this.DL_CharaIDAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_CharaIDAdd.Name = "DL_CharaIDAdd";
            this.DL_CharaIDAdd.Size = new System.Drawing.Size(52, 25);
            this.DL_CharaIDAdd.TabIndex = 46;
            // 
            // DL_CharaIDText
            // 
            this.DL_CharaIDText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_CharaIDText.Location = new System.Drawing.Point(625, 22);
            this.DL_CharaIDText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_CharaIDText.Name = "DL_CharaIDText";
            this.DL_CharaIDText.Size = new System.Drawing.Size(76, 25);
            this.DL_CharaIDText.TabIndex = 45;
            this.DL_CharaIDText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DL_CharaID
            // 
            this.DL_CharaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DL_CharaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_CharaID.Font = new System.Drawing.Font("Consolas", 11F);
            this.DL_CharaID.ForeColor = System.Drawing.Color.White;
            this.DL_CharaID.Location = new System.Drawing.Point(625, 53);
            this.DL_CharaID.MaxLength = 8;
            this.DL_CharaID.Name = "DL_CharaID";
            this.DL_CharaID.Size = new System.Drawing.Size(76, 25);
            this.DL_CharaID.TabIndex = 44;
            // 
            // DL_Add
            // 
            this.DL_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_Add.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_Add.ButtonBackgroundImage = null;
            this.DL_Add.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_Add.ButtonColor = System.Drawing.Color.White;
            this.DL_Add.ButtonEnabled = false;
            this.DL_Add.ButtonImage = null;
            this.DL_Add.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_Add.ButtonText = "";
            this.DL_Add.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_Add.Location = new System.Drawing.Point(140, 392);
            this.DL_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_Add.Name = "DL_Add";
            this.DL_Add.Size = new System.Drawing.Size(71, 24);
            this.DL_Add.TabIndex = 43;
            // 
            // DL_Remove
            // 
            this.DL_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_Remove.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_Remove.ButtonBackgroundImage = null;
            this.DL_Remove.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_Remove.ButtonColor = System.Drawing.Color.White;
            this.DL_Remove.ButtonEnabled = true;
            this.DL_Remove.ButtonImage = null;
            this.DL_Remove.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_Remove.ButtonText = "";
            this.DL_Remove.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_Remove.Location = new System.Drawing.Point(625, 209);
            this.DL_Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_Remove.Name = "DL_Remove";
            this.DL_Remove.Size = new System.Drawing.Size(76, 23);
            this.DL_Remove.TabIndex = 42;
            // 
            // DL_AddAll
            // 
            this.DL_AddAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_AddAll.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DL_AddAll.ButtonBackgroundImage = null;
            this.DL_AddAll.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DL_AddAll.ButtonColor = System.Drawing.Color.White;
            this.DL_AddAll.ButtonEnabled = false;
            this.DL_AddAll.ButtonImage = null;
            this.DL_AddAll.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DL_AddAll.ButtonText = "";
            this.DL_AddAll.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_AddAll.Location = new System.Drawing.Point(217, 392);
            this.DL_AddAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DL_AddAll.Name = "DL_AddAll";
            this.DL_AddAll.Size = new System.Drawing.Size(71, 24);
            this.DL_AddAll.TabIndex = 41;
            // 
            // DL_DownloadListText
            // 
            this.DL_DownloadListText.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_DownloadListText.Location = new System.Drawing.Point(337, 22);
            this.DL_DownloadListText.Margin = new System.Windows.Forms.Padding(3);
            this.DL_DownloadListText.Name = "DL_DownloadListText";
            this.DL_DownloadListText.Size = new System.Drawing.Size(224, 18);
            this.DL_DownloadListText.TabIndex = 40;
            this.DL_DownloadListText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DL_DownloadList
            // 
            this.DL_DownloadList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.DL_DownloadList.AutoArrange = false;
            this.DL_DownloadList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DL_DownloadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL_DownloadList.ForeColor = System.Drawing.Color.White;
            this.DL_DownloadList.FullRowSelect = true;
            this.DL_DownloadList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DL_DownloadList.Location = new System.Drawing.Point(337, 46);
            this.DL_DownloadList.Name = "DL_DownloadList";
            this.DL_DownloadList.Size = new System.Drawing.Size(282, 370);
            this.DL_DownloadList.TabIndex = 39;
            this.DL_DownloadList.UseCompatibleStateImageBehavior = false;
            this.DL_DownloadList.View = System.Windows.Forms.View.Details;
            // 
            // DL_Arrow
            // 
            this.DL_Arrow.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.DL_Arrow.Location = new System.Drawing.Point(294, 226);
            this.DL_Arrow.Margin = new System.Windows.Forms.Padding(3);
            this.DL_Arrow.Name = "DL_Arrow";
            this.DL_Arrow.Size = new System.Drawing.Size(37, 25);
            this.DL_Arrow.TabIndex = 38;
            this.DL_Arrow.Text = "→";
            this.DL_Arrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_EXPCalc
            // 
            this.P_EXPCalc.Controls.Add(this.EC_Main);
            this.P_EXPCalc.Controls.Add(this.EC_Chara);
            this.P_EXPCalc.Location = new System.Drawing.Point(1, 24);
            this.P_EXPCalc.Margin = new System.Windows.Forms.Padding(0);
            this.P_EXPCalc.Name = "P_EXPCalc";
            this.P_EXPCalc.Size = new System.Drawing.Size(1078, 695);
            this.P_EXPCalc.TabIndex = 14;
            this.P_EXPCalc.Visible = false;
            // 
            // EC_Main
            // 
            this.EC_Main.Controls.Add(this.EC_MainExpNeed);
            this.EC_Main.Controls.Add(this.EC_MainParamAfter);
            this.EC_Main.Controls.Add(this.EC_MainParamBefore);
            this.EC_Main.Controls.Add(this.EC_MainExpNeedText);
            this.EC_Main.Controls.Add(this.EC_MainCalc);
            this.EC_Main.Controls.Add(this.EC_MainAfter);
            this.EC_Main.Controls.Add(this.EC_MainBefore);
            this.EC_Main.ForeColor = System.Drawing.Color.White;
            this.EC_Main.Location = new System.Drawing.Point(467, 6);
            this.EC_Main.Name = "EC_Main";
            this.EC_Main.Size = new System.Drawing.Size(450, 452);
            this.EC_Main.TabIndex = 8;
            this.EC_Main.TabStop = false;
            // 
            // EC_MainExpNeed
            // 
            this.EC_MainExpNeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EC_MainExpNeed.ChangeTime = 0;
            this.EC_MainExpNeed.ColorBegin = System.Drawing.Color.Empty;
            this.EC_MainExpNeed.ColorEnd = System.Drawing.Color.Empty;
            this.EC_MainExpNeed.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.EC_MainExpNeed.ForeColor = System.Drawing.Color.White;
            this.EC_MainExpNeed.LAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EC_MainExpNeed.LBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainExpNeed.LBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainExpNeed.LFont = new System.Drawing.Font("Consolas", 25F);
            this.EC_MainExpNeed.LForeColor = System.Drawing.Color.White;
            this.EC_MainExpNeed.Location = new System.Drawing.Point(115, 111);
            this.EC_MainExpNeed.LText = "";
            this.EC_MainExpNeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EC_MainExpNeed.Name = "EC_MainExpNeed";
            this.EC_MainExpNeed.Size = new System.Drawing.Size(329, 46);
            this.EC_MainExpNeed.TabIndex = 10;
            // 
            // EC_MainParamAfter
            // 
            this.EC_MainParamAfter.Controls.Add(this.EC_MainRarityAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainSSAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainSSAfterText);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainCostAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainHPAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainCostAfterText);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainHPAfterText);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainMENAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainINTAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainMENAfterText);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainINTAfterText);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainVITAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainSTRAfter);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainVITAfterText);
            this.EC_MainParamAfter.Controls.Add(this.EC_MainSTRAfterText);
            this.EC_MainParamAfter.ForeColor = System.Drawing.Color.White;
            this.EC_MainParamAfter.Location = new System.Drawing.Point(228, 164);
            this.EC_MainParamAfter.Name = "EC_MainParamAfter";
            this.EC_MainParamAfter.Size = new System.Drawing.Size(216, 282);
            this.EC_MainParamAfter.TabIndex = 22;
            this.EC_MainParamAfter.TabStop = false;
            // 
            // EC_MainRarityAfter
            // 
            this.EC_MainRarityAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EC_MainRarityAfter.ChangeTime = 0;
            this.EC_MainRarityAfter.ColorBegin = System.Drawing.Color.Empty;
            this.EC_MainRarityAfter.ColorEnd = System.Drawing.Color.Empty;
            this.EC_MainRarityAfter.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.EC_MainRarityAfter.ForeColor = System.Drawing.Color.White;
            this.EC_MainRarityAfter.LAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EC_MainRarityAfter.LBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainRarityAfter.LBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainRarityAfter.LFont = new System.Drawing.Font("微軟正黑體", 20F);
            this.EC_MainRarityAfter.LForeColor = System.Drawing.Color.White;
            this.EC_MainRarityAfter.Location = new System.Drawing.Point(6, 23);
            this.EC_MainRarityAfter.LText = "";
            this.EC_MainRarityAfter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EC_MainRarityAfter.Name = "EC_MainRarityAfter";
            this.EC_MainRarityAfter.Size = new System.Drawing.Size(204, 42);
            this.EC_MainRarityAfter.TabIndex = 20;
            // 
            // EC_MainSSAfter
            // 
            this.EC_MainSSAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainSSAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainSSAfter.Location = new System.Drawing.Point(107, 252);
            this.EC_MainSSAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSSAfter.Name = "EC_MainSSAfter";
            this.EC_MainSSAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainSSAfter.TabIndex = 19;
            this.EC_MainSSAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainSSAfterText
            // 
            this.EC_MainSSAfterText.Location = new System.Drawing.Point(6, 252);
            this.EC_MainSSAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSSAfterText.Name = "EC_MainSSAfterText";
            this.EC_MainSSAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainSSAfterText.TabIndex = 18;
            this.EC_MainSSAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainCostAfter
            // 
            this.EC_MainCostAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainCostAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainCostAfter.Location = new System.Drawing.Point(107, 222);
            this.EC_MainCostAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainCostAfter.Name = "EC_MainCostAfter";
            this.EC_MainCostAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainCostAfter.TabIndex = 17;
            this.EC_MainCostAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainHPAfter
            // 
            this.EC_MainHPAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainHPAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainHPAfter.Location = new System.Drawing.Point(107, 192);
            this.EC_MainHPAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainHPAfter.Name = "EC_MainHPAfter";
            this.EC_MainHPAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainHPAfter.TabIndex = 16;
            this.EC_MainHPAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainCostAfterText
            // 
            this.EC_MainCostAfterText.Location = new System.Drawing.Point(6, 222);
            this.EC_MainCostAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainCostAfterText.Name = "EC_MainCostAfterText";
            this.EC_MainCostAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainCostAfterText.TabIndex = 15;
            this.EC_MainCostAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainHPAfterText
            // 
            this.EC_MainHPAfterText.Location = new System.Drawing.Point(6, 192);
            this.EC_MainHPAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainHPAfterText.Name = "EC_MainHPAfterText";
            this.EC_MainHPAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainHPAfterText.TabIndex = 14;
            this.EC_MainHPAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainMENAfter
            // 
            this.EC_MainMENAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainMENAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainMENAfter.Location = new System.Drawing.Point(107, 162);
            this.EC_MainMENAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainMENAfter.Name = "EC_MainMENAfter";
            this.EC_MainMENAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainMENAfter.TabIndex = 13;
            this.EC_MainMENAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainINTAfter
            // 
            this.EC_MainINTAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainINTAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainINTAfter.Location = new System.Drawing.Point(107, 132);
            this.EC_MainINTAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainINTAfter.Name = "EC_MainINTAfter";
            this.EC_MainINTAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainINTAfter.TabIndex = 12;
            this.EC_MainINTAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainMENAfterText
            // 
            this.EC_MainMENAfterText.Location = new System.Drawing.Point(6, 162);
            this.EC_MainMENAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainMENAfterText.Name = "EC_MainMENAfterText";
            this.EC_MainMENAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainMENAfterText.TabIndex = 11;
            this.EC_MainMENAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainINTAfterText
            // 
            this.EC_MainINTAfterText.Location = new System.Drawing.Point(6, 132);
            this.EC_MainINTAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainINTAfterText.Name = "EC_MainINTAfterText";
            this.EC_MainINTAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainINTAfterText.TabIndex = 10;
            this.EC_MainINTAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainVITAfter
            // 
            this.EC_MainVITAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainVITAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainVITAfter.Location = new System.Drawing.Point(107, 102);
            this.EC_MainVITAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainVITAfter.Name = "EC_MainVITAfter";
            this.EC_MainVITAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainVITAfter.TabIndex = 9;
            this.EC_MainVITAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainSTRAfter
            // 
            this.EC_MainSTRAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainSTRAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainSTRAfter.Location = new System.Drawing.Point(107, 72);
            this.EC_MainSTRAfter.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSTRAfter.Name = "EC_MainSTRAfter";
            this.EC_MainSTRAfter.Size = new System.Drawing.Size(103, 24);
            this.EC_MainSTRAfter.TabIndex = 8;
            this.EC_MainSTRAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainVITAfterText
            // 
            this.EC_MainVITAfterText.Location = new System.Drawing.Point(6, 102);
            this.EC_MainVITAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainVITAfterText.Name = "EC_MainVITAfterText";
            this.EC_MainVITAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainVITAfterText.TabIndex = 2;
            this.EC_MainVITAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainSTRAfterText
            // 
            this.EC_MainSTRAfterText.Location = new System.Drawing.Point(6, 72);
            this.EC_MainSTRAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSTRAfterText.Name = "EC_MainSTRAfterText";
            this.EC_MainSTRAfterText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainSTRAfterText.TabIndex = 0;
            this.EC_MainSTRAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainParamBefore
            // 
            this.EC_MainParamBefore.Controls.Add(this.EC_MainRarityBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainSSBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainSSBeforeText);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainCostBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainHPBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainCostBeforeText);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainHPBeforeText);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainMENBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainINTBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainMENBeforeText);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainINTBeforeText);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainVITBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainSTRBefore);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainVITBeforeText);
            this.EC_MainParamBefore.Controls.Add(this.EC_MainSTRBeforeText);
            this.EC_MainParamBefore.ForeColor = System.Drawing.Color.White;
            this.EC_MainParamBefore.Location = new System.Drawing.Point(6, 164);
            this.EC_MainParamBefore.Name = "EC_MainParamBefore";
            this.EC_MainParamBefore.Size = new System.Drawing.Size(216, 282);
            this.EC_MainParamBefore.TabIndex = 5;
            this.EC_MainParamBefore.TabStop = false;
            // 
            // EC_MainRarityBefore
            // 
            this.EC_MainRarityBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EC_MainRarityBefore.ChangeTime = 0;
            this.EC_MainRarityBefore.ColorBegin = System.Drawing.Color.Empty;
            this.EC_MainRarityBefore.ColorEnd = System.Drawing.Color.Empty;
            this.EC_MainRarityBefore.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.EC_MainRarityBefore.ForeColor = System.Drawing.Color.White;
            this.EC_MainRarityBefore.LAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EC_MainRarityBefore.LBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainRarityBefore.LBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainRarityBefore.LFont = new System.Drawing.Font("微軟正黑體", 20F);
            this.EC_MainRarityBefore.LForeColor = System.Drawing.Color.White;
            this.EC_MainRarityBefore.Location = new System.Drawing.Point(6, 23);
            this.EC_MainRarityBefore.LText = "";
            this.EC_MainRarityBefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EC_MainRarityBefore.Name = "EC_MainRarityBefore";
            this.EC_MainRarityBefore.Size = new System.Drawing.Size(204, 42);
            this.EC_MainRarityBefore.TabIndex = 9;
            // 
            // EC_MainSSBefore
            // 
            this.EC_MainSSBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainSSBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainSSBefore.Location = new System.Drawing.Point(107, 252);
            this.EC_MainSSBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSSBefore.Name = "EC_MainSSBefore";
            this.EC_MainSSBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainSSBefore.TabIndex = 19;
            this.EC_MainSSBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainSSBeforeText
            // 
            this.EC_MainSSBeforeText.Location = new System.Drawing.Point(6, 252);
            this.EC_MainSSBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSSBeforeText.Name = "EC_MainSSBeforeText";
            this.EC_MainSSBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainSSBeforeText.TabIndex = 18;
            this.EC_MainSSBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainCostBefore
            // 
            this.EC_MainCostBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainCostBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainCostBefore.Location = new System.Drawing.Point(107, 222);
            this.EC_MainCostBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainCostBefore.Name = "EC_MainCostBefore";
            this.EC_MainCostBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainCostBefore.TabIndex = 17;
            this.EC_MainCostBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainHPBefore
            // 
            this.EC_MainHPBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainHPBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainHPBefore.Location = new System.Drawing.Point(107, 192);
            this.EC_MainHPBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainHPBefore.Name = "EC_MainHPBefore";
            this.EC_MainHPBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainHPBefore.TabIndex = 16;
            this.EC_MainHPBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainCostBeforeText
            // 
            this.EC_MainCostBeforeText.Location = new System.Drawing.Point(6, 222);
            this.EC_MainCostBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainCostBeforeText.Name = "EC_MainCostBeforeText";
            this.EC_MainCostBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainCostBeforeText.TabIndex = 15;
            this.EC_MainCostBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainHPBeforeText
            // 
            this.EC_MainHPBeforeText.Location = new System.Drawing.Point(6, 192);
            this.EC_MainHPBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainHPBeforeText.Name = "EC_MainHPBeforeText";
            this.EC_MainHPBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainHPBeforeText.TabIndex = 14;
            this.EC_MainHPBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainMENBefore
            // 
            this.EC_MainMENBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainMENBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainMENBefore.Location = new System.Drawing.Point(107, 162);
            this.EC_MainMENBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainMENBefore.Name = "EC_MainMENBefore";
            this.EC_MainMENBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainMENBefore.TabIndex = 13;
            this.EC_MainMENBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainINTBefore
            // 
            this.EC_MainINTBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainINTBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainINTBefore.Location = new System.Drawing.Point(107, 132);
            this.EC_MainINTBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainINTBefore.Name = "EC_MainINTBefore";
            this.EC_MainINTBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainINTBefore.TabIndex = 12;
            this.EC_MainINTBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainMENBeforeText
            // 
            this.EC_MainMENBeforeText.Location = new System.Drawing.Point(6, 162);
            this.EC_MainMENBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainMENBeforeText.Name = "EC_MainMENBeforeText";
            this.EC_MainMENBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainMENBeforeText.TabIndex = 11;
            this.EC_MainMENBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainINTBeforeText
            // 
            this.EC_MainINTBeforeText.Location = new System.Drawing.Point(6, 132);
            this.EC_MainINTBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainINTBeforeText.Name = "EC_MainINTBeforeText";
            this.EC_MainINTBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainINTBeforeText.TabIndex = 10;
            this.EC_MainINTBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainVITBefore
            // 
            this.EC_MainVITBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainVITBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainVITBefore.Location = new System.Drawing.Point(107, 102);
            this.EC_MainVITBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainVITBefore.Name = "EC_MainVITBefore";
            this.EC_MainVITBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainVITBefore.TabIndex = 9;
            this.EC_MainVITBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainSTRBefore
            // 
            this.EC_MainSTRBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainSTRBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainSTRBefore.Location = new System.Drawing.Point(107, 72);
            this.EC_MainSTRBefore.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSTRBefore.Name = "EC_MainSTRBefore";
            this.EC_MainSTRBefore.Size = new System.Drawing.Size(103, 24);
            this.EC_MainSTRBefore.TabIndex = 8;
            this.EC_MainSTRBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainVITBeforeText
            // 
            this.EC_MainVITBeforeText.Location = new System.Drawing.Point(6, 102);
            this.EC_MainVITBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainVITBeforeText.Name = "EC_MainVITBeforeText";
            this.EC_MainVITBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainVITBeforeText.TabIndex = 2;
            this.EC_MainVITBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainSTRBeforeText
            // 
            this.EC_MainSTRBeforeText.Location = new System.Drawing.Point(6, 72);
            this.EC_MainSTRBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainSTRBeforeText.Name = "EC_MainSTRBeforeText";
            this.EC_MainSTRBeforeText.Size = new System.Drawing.Size(95, 24);
            this.EC_MainSTRBeforeText.TabIndex = 0;
            this.EC_MainSTRBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainExpNeedText
            // 
            this.EC_MainExpNeedText.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.EC_MainExpNeedText.Location = new System.Drawing.Point(7, 112);
            this.EC_MainExpNeedText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainExpNeedText.Name = "EC_MainExpNeedText";
            this.EC_MainExpNeedText.Size = new System.Drawing.Size(102, 46);
            this.EC_MainExpNeedText.TabIndex = 4;
            this.EC_MainExpNeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainCalc
            // 
            this.EC_MainCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EC_MainCalc.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainCalc.ButtonBackgroundImage = null;
            this.EC_MainCalc.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EC_MainCalc.ButtonColor = System.Drawing.Color.White;
            this.EC_MainCalc.ButtonEnabled = true;
            this.EC_MainCalc.ButtonImage = null;
            this.EC_MainCalc.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EC_MainCalc.ButtonText = "";
            this.EC_MainCalc.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.EC_MainCalc.Location = new System.Drawing.Point(350, 22);
            this.EC_MainCalc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EC_MainCalc.Name = "EC_MainCalc";
            this.EC_MainCalc.Size = new System.Drawing.Size(94, 82);
            this.EC_MainCalc.TabIndex = 6;
            // 
            // EC_MainAfter
            // 
            this.EC_MainAfter.Controls.Add(this.EC_MainExpAfter);
            this.EC_MainAfter.Controls.Add(this.EC_MainExpAfterText);
            this.EC_MainAfter.Controls.Add(this.EC_MainLvAfter);
            this.EC_MainAfter.Controls.Add(this.EC_MainLvAfterText);
            this.EC_MainAfter.ForeColor = System.Drawing.Color.White;
            this.EC_MainAfter.Location = new System.Drawing.Point(177, 22);
            this.EC_MainAfter.Name = "EC_MainAfter";
            this.EC_MainAfter.Size = new System.Drawing.Size(165, 82);
            this.EC_MainAfter.TabIndex = 5;
            this.EC_MainAfter.TabStop = false;
            // 
            // EC_MainExpAfter
            // 
            this.EC_MainExpAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainExpAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainExpAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainExpAfter.ForeColor = System.Drawing.Color.White;
            this.EC_MainExpAfter.Location = new System.Drawing.Point(81, 52);
            this.EC_MainExpAfter.Name = "EC_MainExpAfter";
            this.EC_MainExpAfter.Size = new System.Drawing.Size(78, 24);
            this.EC_MainExpAfter.TabIndex = 3;
            this.EC_MainExpAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_MainExpAfterText
            // 
            this.EC_MainExpAfterText.Location = new System.Drawing.Point(6, 52);
            this.EC_MainExpAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainExpAfterText.Name = "EC_MainExpAfterText";
            this.EC_MainExpAfterText.Size = new System.Drawing.Size(69, 24);
            this.EC_MainExpAfterText.TabIndex = 2;
            this.EC_MainExpAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainLvAfter
            // 
            this.EC_MainLvAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainLvAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainLvAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainLvAfter.ForeColor = System.Drawing.Color.White;
            this.EC_MainLvAfter.Location = new System.Drawing.Point(81, 22);
            this.EC_MainLvAfter.Name = "EC_MainLvAfter";
            this.EC_MainLvAfter.Size = new System.Drawing.Size(78, 24);
            this.EC_MainLvAfter.TabIndex = 1;
            this.EC_MainLvAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_MainLvAfterText
            // 
            this.EC_MainLvAfterText.Location = new System.Drawing.Point(6, 22);
            this.EC_MainLvAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainLvAfterText.Name = "EC_MainLvAfterText";
            this.EC_MainLvAfterText.Size = new System.Drawing.Size(69, 24);
            this.EC_MainLvAfterText.TabIndex = 0;
            this.EC_MainLvAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainBefore
            // 
            this.EC_MainBefore.Controls.Add(this.EC_MainExpBefore);
            this.EC_MainBefore.Controls.Add(this.EC_MainExpBeforeText);
            this.EC_MainBefore.Controls.Add(this.EC_MainLvBefore);
            this.EC_MainBefore.Controls.Add(this.EC_MainLvBeforeText);
            this.EC_MainBefore.ForeColor = System.Drawing.Color.White;
            this.EC_MainBefore.Location = new System.Drawing.Point(6, 22);
            this.EC_MainBefore.Name = "EC_MainBefore";
            this.EC_MainBefore.Size = new System.Drawing.Size(165, 82);
            this.EC_MainBefore.TabIndex = 4;
            this.EC_MainBefore.TabStop = false;
            // 
            // EC_MainExpBefore
            // 
            this.EC_MainExpBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainExpBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainExpBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainExpBefore.ForeColor = System.Drawing.Color.White;
            this.EC_MainExpBefore.Location = new System.Drawing.Point(81, 52);
            this.EC_MainExpBefore.Name = "EC_MainExpBefore";
            this.EC_MainExpBefore.Size = new System.Drawing.Size(78, 24);
            this.EC_MainExpBefore.TabIndex = 3;
            this.EC_MainExpBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_MainExpBeforeText
            // 
            this.EC_MainExpBeforeText.Location = new System.Drawing.Point(6, 52);
            this.EC_MainExpBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainExpBeforeText.Name = "EC_MainExpBeforeText";
            this.EC_MainExpBeforeText.Size = new System.Drawing.Size(69, 24);
            this.EC_MainExpBeforeText.TabIndex = 2;
            this.EC_MainExpBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_MainLvBefore
            // 
            this.EC_MainLvBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_MainLvBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_MainLvBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_MainLvBefore.ForeColor = System.Drawing.Color.White;
            this.EC_MainLvBefore.Location = new System.Drawing.Point(81, 22);
            this.EC_MainLvBefore.Name = "EC_MainLvBefore";
            this.EC_MainLvBefore.Size = new System.Drawing.Size(78, 24);
            this.EC_MainLvBefore.TabIndex = 1;
            this.EC_MainLvBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_MainLvBeforeText
            // 
            this.EC_MainLvBeforeText.Location = new System.Drawing.Point(6, 22);
            this.EC_MainLvBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_MainLvBeforeText.Name = "EC_MainLvBeforeText";
            this.EC_MainLvBeforeText.Size = new System.Drawing.Size(69, 24);
            this.EC_MainLvBeforeText.TabIndex = 0;
            this.EC_MainLvBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_Chara
            // 
            this.EC_Chara.Controls.Add(this.label1);
            this.EC_Chara.Controls.Add(this.EC_CharaTips);
            this.EC_Chara.Controls.Add(this.EC_CharaExpNeed);
            this.EC_Chara.Controls.Add(this.EC_CharaExpNeedText);
            this.EC_Chara.Controls.Add(this.EC_CharaCalc);
            this.EC_Chara.Controls.Add(this.EC_CharaAfter);
            this.EC_Chara.Controls.Add(this.EC_CharaBefore);
            this.EC_Chara.ForeColor = System.Drawing.Color.White;
            this.EC_Chara.Location = new System.Drawing.Point(11, 6);
            this.EC_Chara.Name = "EC_Chara";
            this.EC_Chara.Size = new System.Drawing.Size(450, 655);
            this.EC_Chara.TabIndex = 0;
            this.EC_Chara.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label1.Location = new System.Drawing.Point(7, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 453);
            this.label1.TabIndex = 11;
            this.label1.Text = "將推出角色參數計算功能，敬請期待！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_CharaTips
            // 
            this.EC_CharaTips.Direction = MarqueeDirection.Horizontal;
            this.EC_CharaTips.EnableMarquee = true;
            this.EC_CharaTips.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.EC_CharaTips.FreezeTime = 2000;
            this.EC_CharaTips.LabelSize = new System.Drawing.Size(438, 25);
            this.EC_CharaTips.LeftDistance = 5;
            this.EC_CharaTips.LForeColor = System.Drawing.Color.White;
            this.EC_CharaTips.Location = new System.Drawing.Point(6, 164);
            this.EC_CharaTips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EC_CharaTips.MarqueeText = "";
            this.EC_CharaTips.Mode = MarqueeMode.ContinualAndSneeze;
            this.EC_CharaTips.MoveDifferenceEachTime = 1;
            this.EC_CharaTips.MoveInterval = 15;
            this.EC_CharaTips.Name = "EC_CharaTips";
            this.EC_CharaTips.OverBorderDistance = 15;
            this.EC_CharaTips.Size = new System.Drawing.Size(438, 25);
            this.EC_CharaTips.TabIndex = 10;
            // 
            // EC_CharaExpNeed
            // 
            this.EC_CharaExpNeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EC_CharaExpNeed.ChangeTime = 0;
            this.EC_CharaExpNeed.ColorBegin = System.Drawing.Color.Empty;
            this.EC_CharaExpNeed.ColorEnd = System.Drawing.Color.Empty;
            this.EC_CharaExpNeed.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.EC_CharaExpNeed.ForeColor = System.Drawing.Color.White;
            this.EC_CharaExpNeed.LAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EC_CharaExpNeed.LBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_CharaExpNeed.LBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_CharaExpNeed.LFont = new System.Drawing.Font("Consolas", 25F);
            this.EC_CharaExpNeed.LForeColor = System.Drawing.Color.White;
            this.EC_CharaExpNeed.Location = new System.Drawing.Point(115, 111);
            this.EC_CharaExpNeed.LText = "";
            this.EC_CharaExpNeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EC_CharaExpNeed.Name = "EC_CharaExpNeed";
            this.EC_CharaExpNeed.Size = new System.Drawing.Size(329, 46);
            this.EC_CharaExpNeed.TabIndex = 9;
            // 
            // EC_CharaExpNeedText
            // 
            this.EC_CharaExpNeedText.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.EC_CharaExpNeedText.Location = new System.Drawing.Point(7, 112);
            this.EC_CharaExpNeedText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_CharaExpNeedText.Name = "EC_CharaExpNeedText";
            this.EC_CharaExpNeedText.Size = new System.Drawing.Size(102, 46);
            this.EC_CharaExpNeedText.TabIndex = 4;
            this.EC_CharaExpNeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_CharaCalc
            // 
            this.EC_CharaCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EC_CharaCalc.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_CharaCalc.ButtonBackgroundImage = null;
            this.EC_CharaCalc.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EC_CharaCalc.ButtonColor = System.Drawing.Color.White;
            this.EC_CharaCalc.ButtonEnabled = true;
            this.EC_CharaCalc.ButtonImage = null;
            this.EC_CharaCalc.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EC_CharaCalc.ButtonText = "";
            this.EC_CharaCalc.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.EC_CharaCalc.Location = new System.Drawing.Point(350, 22);
            this.EC_CharaCalc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EC_CharaCalc.Name = "EC_CharaCalc";
            this.EC_CharaCalc.Size = new System.Drawing.Size(94, 82);
            this.EC_CharaCalc.TabIndex = 6;
            // 
            // EC_CharaAfter
            // 
            this.EC_CharaAfter.Controls.Add(this.EC_CharaExpAfter);
            this.EC_CharaAfter.Controls.Add(this.EC_CharaExpAfterText);
            this.EC_CharaAfter.Controls.Add(this.EC_CharaLvAfter);
            this.EC_CharaAfter.Controls.Add(this.EC_CharaLvAfterText);
            this.EC_CharaAfter.ForeColor = System.Drawing.Color.White;
            this.EC_CharaAfter.Location = new System.Drawing.Point(177, 22);
            this.EC_CharaAfter.Name = "EC_CharaAfter";
            this.EC_CharaAfter.Size = new System.Drawing.Size(165, 82);
            this.EC_CharaAfter.TabIndex = 5;
            this.EC_CharaAfter.TabStop = false;
            // 
            // EC_CharaExpAfter
            // 
            this.EC_CharaExpAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_CharaExpAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_CharaExpAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_CharaExpAfter.ForeColor = System.Drawing.Color.White;
            this.EC_CharaExpAfter.Location = new System.Drawing.Point(81, 52);
            this.EC_CharaExpAfter.Name = "EC_CharaExpAfter";
            this.EC_CharaExpAfter.Size = new System.Drawing.Size(78, 24);
            this.EC_CharaExpAfter.TabIndex = 3;
            this.EC_CharaExpAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_CharaExpAfterText
            // 
            this.EC_CharaExpAfterText.Location = new System.Drawing.Point(6, 52);
            this.EC_CharaExpAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_CharaExpAfterText.Name = "EC_CharaExpAfterText";
            this.EC_CharaExpAfterText.Size = new System.Drawing.Size(69, 24);
            this.EC_CharaExpAfterText.TabIndex = 2;
            this.EC_CharaExpAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_CharaLvAfter
            // 
            this.EC_CharaLvAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_CharaLvAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_CharaLvAfter.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_CharaLvAfter.ForeColor = System.Drawing.Color.White;
            this.EC_CharaLvAfter.Location = new System.Drawing.Point(81, 22);
            this.EC_CharaLvAfter.Name = "EC_CharaLvAfter";
            this.EC_CharaLvAfter.Size = new System.Drawing.Size(78, 24);
            this.EC_CharaLvAfter.TabIndex = 1;
            this.EC_CharaLvAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_CharaLvAfterText
            // 
            this.EC_CharaLvAfterText.Location = new System.Drawing.Point(6, 22);
            this.EC_CharaLvAfterText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_CharaLvAfterText.Name = "EC_CharaLvAfterText";
            this.EC_CharaLvAfterText.Size = new System.Drawing.Size(69, 24);
            this.EC_CharaLvAfterText.TabIndex = 0;
            this.EC_CharaLvAfterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_CharaBefore
            // 
            this.EC_CharaBefore.Controls.Add(this.EC_CharaExpBefore);
            this.EC_CharaBefore.Controls.Add(this.EC_CharaExpBeforeText);
            this.EC_CharaBefore.Controls.Add(this.EC_CharaLvBefore);
            this.EC_CharaBefore.Controls.Add(this.EC_CharaLvBeforeText);
            this.EC_CharaBefore.ForeColor = System.Drawing.Color.White;
            this.EC_CharaBefore.Location = new System.Drawing.Point(6, 22);
            this.EC_CharaBefore.Name = "EC_CharaBefore";
            this.EC_CharaBefore.Size = new System.Drawing.Size(165, 82);
            this.EC_CharaBefore.TabIndex = 4;
            this.EC_CharaBefore.TabStop = false;
            // 
            // EC_CharaExpBefore
            // 
            this.EC_CharaExpBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_CharaExpBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_CharaExpBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_CharaExpBefore.ForeColor = System.Drawing.Color.White;
            this.EC_CharaExpBefore.Location = new System.Drawing.Point(81, 52);
            this.EC_CharaExpBefore.Name = "EC_CharaExpBefore";
            this.EC_CharaExpBefore.Size = new System.Drawing.Size(78, 24);
            this.EC_CharaExpBefore.TabIndex = 3;
            this.EC_CharaExpBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_CharaExpBeforeText
            // 
            this.EC_CharaExpBeforeText.Location = new System.Drawing.Point(6, 52);
            this.EC_CharaExpBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_CharaExpBeforeText.Name = "EC_CharaExpBeforeText";
            this.EC_CharaExpBeforeText.Size = new System.Drawing.Size(69, 24);
            this.EC_CharaExpBeforeText.TabIndex = 2;
            this.EC_CharaExpBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EC_CharaLvBefore
            // 
            this.EC_CharaLvBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EC_CharaLvBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EC_CharaLvBefore.Font = new System.Drawing.Font("Consolas", 15F);
            this.EC_CharaLvBefore.ForeColor = System.Drawing.Color.White;
            this.EC_CharaLvBefore.Location = new System.Drawing.Point(81, 22);
            this.EC_CharaLvBefore.Name = "EC_CharaLvBefore";
            this.EC_CharaLvBefore.Size = new System.Drawing.Size(78, 24);
            this.EC_CharaLvBefore.TabIndex = 1;
            this.EC_CharaLvBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EC_CharaLvBeforeText
            // 
            this.EC_CharaLvBeforeText.Location = new System.Drawing.Point(6, 22);
            this.EC_CharaLvBeforeText.Margin = new System.Windows.Forms.Padding(3);
            this.EC_CharaLvBeforeText.Name = "EC_CharaLvBeforeText";
            this.EC_CharaLvBeforeText.Size = new System.Drawing.Size(69, 24);
            this.EC_CharaLvBeforeText.TabIndex = 0;
            this.EC_CharaLvBeforeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EX_FileDialog
            // 
            this.EX_FileDialog.Filter = "csv 檔案|*.csv|assetbundle 檔案|*.assetbundle|wav 檔案|*.wav|mp3 檔案|*.mp3|所有檔案|*.*";
            // 
            // characterSearcher1
            // 
            this.characterSearcher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.characterSearcher1.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.characterSearcher1.ForeColor = System.Drawing.Color.White;
            this.characterSearcher1.Location = new System.Drawing.Point(6, 25);
            this.characterSearcher1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.characterSearcher1.Name = "characterSearcher1";
            this.characterSearcher1.Size = new System.Drawing.Size(294, 335);
            this.characterSearcher1.TabIndex = 0;
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
            this.SS_Monster.ResumeLayout(false);
            this.SS_MonsterPanel.ResumeLayout(false);
            this.SS_Character.ResumeLayout(false);
            this.SS_CHaraPanel.ResumeLayout(false);
            this.P_CsvTable.ResumeLayout(false);
            this.P_CsvTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_EndColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_StartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_CsvView)).EndInit();
            this.P_Config.ResumeLayout(false);
            this.ST_SourcePath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ST_AUProg.ResumeLayout(false);
            this.ST_AboutProgram.ResumeLayout(false);
            this.ST_DataTitle.ResumeLayout(false);
            this.ST_SoundPath.ResumeLayout(false);
            this.P_CharacterData.ResumeLayout(false);
            this.P_CharacterData.PerformLayout();
            this.CD_CharacterTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.P_Download.ResumeLayout(false);
            this.DL_CharaPicBox.ResumeLayout(false);
            this.DL_CharaPicBox.PerformLayout();
            this.P_EXPCalc.ResumeLayout(false);
            this.EC_Main.ResumeLayout(false);
            this.EC_MainParamAfter.ResumeLayout(false);
            this.EC_MainParamBefore.ResumeLayout(false);
            this.EC_MainAfter.ResumeLayout(false);
            this.EC_MainAfter.PerformLayout();
            this.EC_MainBefore.ResumeLayout(false);
            this.EC_MainBefore.PerformLayout();
            this.EC_Chara.ResumeLayout(false);
            this.EC_CharaAfter.ResumeLayout(false);
            this.EC_CharaAfter.PerformLayout();
            this.EC_CharaBefore.ResumeLayout(false);
            this.EC_CharaBefore.PerformLayout();
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
        public Button_SE_ ST_ReLoad;
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
        private System.Windows.Forms.Label SS_CharaElementRateText;
        private System.Windows.Forms.ListView SS_CharaElementRate;
        private Button_SE_ SS_CharaCalculate;
        private System.Windows.Forms.Label SS_CharaWeaponUsingRateText;
        private System.Windows.Forms.ListView SS_CharaWeaponUsingRate;
        private System.Windows.Forms.Panel SS_CHaraPanel;
        private System.Windows.Forms.Label SS_CharaSceneRateText;
        private System.Windows.Forms.ListView SS_CharaSceneRate;
        private System.Windows.Forms.Label SS_CharaRarityRateText;
        private System.Windows.Forms.ListView SS_CharaRarityRate;
        private System.Windows.Forms.Label SS_CharaSeriesRateText;
        private System.Windows.Forms.ListView SS_CharaSeriesRate;
        private System.Windows.Forms.Panel SS_MonsterPanel;
        private System.Windows.Forms.Label SS_MonsterTypeRateText;
        private System.Windows.Forms.ListView SS_MonsterTypeRate;
        private System.Windows.Forms.ListView SS_MonsterHPRate;
        private System.Windows.Forms.Label SS_MonsterHPRateText;
        private Button_SE_ SS_MonsterCalculate;
        private System.Windows.Forms.GroupBox ST_SourcePath;
        private System.Windows.Forms.Label ST_SourceASBText;
        private MarqueeableLabel ST_SourceCSV;
        private MarqueeableLabel ST_SourceASB;
        private System.Windows.Forms.Label ST_SourceCSVText;
        public Button_SE_ HM_ToDownload;
        private System.Windows.Forms.Panel P_Download;
        private System.Windows.Forms.GroupBox DL_CharaPicBox;
        private Button_SE_ DL_Add;
        private Button_SE_ DL_Remove;
        private Button_SE_ DL_AddAll;
        private System.Windows.Forms.Label DL_DownloadListText;
        private System.Windows.Forms.ListView DL_DownloadList;
        private System.Windows.Forms.Label DL_Arrow;
        private Button_SE_ DL_StartDownload;
        private Button_SE_ DL_CharaIDAdd;
        private System.Windows.Forms.Label DL_CharaIDText;
        private System.Windows.Forms.TextBox DL_CharaID;
        private System.Windows.Forms.Label DL_CompleteListText;
        private System.Windows.Forms.RichTextBox DL_CompleteList;
        private System.Windows.Forms.Label DL_DownloadLogText;
        private Button_SE_ DL_ClearAll;
        private System.Windows.Forms.Label DL_PicCount;
        private System.Windows.Forms.Label DL_PicCountText;
        private System.Windows.Forms.ProgressBar DL_Progress;
        private System.Windows.Forms.Label DL_Completed;
        private System.Windows.Forms.Label DL_CompletedText;
        private System.Windows.Forms.Label DL_DLing;
        private System.Windows.Forms.Label DL_DLingText;
        private System.Windows.Forms.Label DL_Pending;
        private System.Windows.Forms.Label DL_PendingText;
        private System.Windows.Forms.Label DL_Failed;
        private System.Windows.Forms.Label DL_FailedText;
        private System.Windows.Forms.ListView DL_DownloadStatus;
        private Button_SE_ DL_AbortDownload;
        private System.Windows.Forms.ComboBox ST_AttachmentMode;
        private System.Windows.Forms.Label ST_AttachmentModeText;
        private System.Windows.Forms.Panel P_EXPCalc;
        public Button_SE_ HM_ToEXPCalc;
        private System.Windows.Forms.GroupBox EC_Main;
        private System.Windows.Forms.GroupBox EC_MainParamBefore;
        private System.Windows.Forms.Label EC_MainSSBefore;
        private System.Windows.Forms.Label EC_MainSSBeforeText;
        private System.Windows.Forms.Label EC_MainCostBefore;
        private System.Windows.Forms.Label EC_MainHPBefore;
        private System.Windows.Forms.Label EC_MainCostBeforeText;
        private System.Windows.Forms.Label EC_MainHPBeforeText;
        private System.Windows.Forms.Label EC_MainMENBefore;
        private System.Windows.Forms.Label EC_MainINTBefore;
        private System.Windows.Forms.Label EC_MainMENBeforeText;
        private System.Windows.Forms.Label EC_MainINTBeforeText;
        private System.Windows.Forms.Label EC_MainVITBefore;
        private System.Windows.Forms.Label EC_MainSTRBefore;
        private System.Windows.Forms.Label EC_MainVITBeforeText;
        private System.Windows.Forms.Label EC_MainSTRBeforeText;
        private System.Windows.Forms.Label EC_MainExpNeedText;
        private Button_SE_ EC_MainCalc;
        private System.Windows.Forms.GroupBox EC_MainAfter;
        private System.Windows.Forms.TextBox EC_MainExpAfter;
        private System.Windows.Forms.Label EC_MainExpAfterText;
        private System.Windows.Forms.TextBox EC_MainLvAfter;
        private System.Windows.Forms.Label EC_MainLvAfterText;
        private System.Windows.Forms.GroupBox EC_MainBefore;
        private System.Windows.Forms.TextBox EC_MainExpBefore;
        private System.Windows.Forms.Label EC_MainExpBeforeText;
        private System.Windows.Forms.TextBox EC_MainLvBefore;
        private System.Windows.Forms.Label EC_MainLvBeforeText;
        private System.Windows.Forms.GroupBox EC_Chara;
        private System.Windows.Forms.Label EC_CharaExpNeedText;
        private Button_SE_ EC_CharaCalc;
        private System.Windows.Forms.GroupBox EC_CharaAfter;
        private System.Windows.Forms.TextBox EC_CharaExpAfter;
        private System.Windows.Forms.Label EC_CharaExpAfterText;
        private System.Windows.Forms.TextBox EC_CharaLvAfter;
        private System.Windows.Forms.Label EC_CharaLvAfterText;
        private System.Windows.Forms.GroupBox EC_CharaBefore;
        private System.Windows.Forms.TextBox EC_CharaExpBefore;
        private System.Windows.Forms.Label EC_CharaExpBeforeText;
        private System.Windows.Forms.TextBox EC_CharaLvBefore;
        private System.Windows.Forms.Label EC_CharaLvBeforeText;
        private Controls.BreezeLabel EC_MainExpNeed;
        private System.Windows.Forms.GroupBox EC_MainParamAfter;
        private Controls.BreezeLabel EC_MainRarityAfter;
        private System.Windows.Forms.Label EC_MainSSAfter;
        private System.Windows.Forms.Label EC_MainSSAfterText;
        private System.Windows.Forms.Label EC_MainCostAfter;
        private System.Windows.Forms.Label EC_MainHPAfter;
        private System.Windows.Forms.Label EC_MainCostAfterText;
        private System.Windows.Forms.Label EC_MainHPAfterText;
        private System.Windows.Forms.Label EC_MainMENAfter;
        private System.Windows.Forms.Label EC_MainINTAfter;
        private System.Windows.Forms.Label EC_MainMENAfterText;
        private System.Windows.Forms.Label EC_MainINTAfterText;
        private System.Windows.Forms.Label EC_MainVITAfter;
        private System.Windows.Forms.Label EC_MainSTRAfter;
        private System.Windows.Forms.Label EC_MainVITAfterText;
        private System.Windows.Forms.Label EC_MainSTRAfterText;
        private Controls.BreezeLabel EC_MainRarityBefore;
        private MarqueeableLabel EC_CharaTips;
        private Controls.BreezeLabel EC_CharaExpNeed;
        private System.Windows.Forms.Label label1;
        public Button_SE_ ST_ClearAllAttachments;
        private Controls.CharacterSearcher CD_SearchCharacter;
        private Controls.CharacterSearcher characterSearcher1;
    }
}

