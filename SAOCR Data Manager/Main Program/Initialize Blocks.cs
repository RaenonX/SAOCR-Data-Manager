using SAOCR_Data_Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.Reflection;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Message;
using Microsoft.Win32;
using System.Net;
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        public void InitializeUIText()
        {
            try
            {
                //Main
                MN_Min.ButtonText = RMain.Layout_Minimum;
                MN_Close.ButtonText = RMain.Layout_CloseProg;
                MN_Capture.Text = RMain.Layout_Capture;

                //Home
                HM_ToCharacterData.ButtonText = RHome.ToPage_WebPageChara;
                HM_ToEquipmentData.ButtonText = RHome.ToPage_WebPageEquip;
                HM_ToCsvTable.ButtonText = RHome.ToPage_CsvTable;
                HM_ToConfig.ButtonText = RHome.ToPage_Settings;
                HM_ToHomePage.ButtonText = RHome.ToPage_HomePage;
                HM_ToStatistics.ButtonText = RHome.ToPage_Statistics;
                HM_ToDownload.ButtonText = RHome.ToPage_Download;
                HM_ToEXPCalc.ButtonText = RHome.ToPage_ExpCalc;
                HM_Res_Load.ButtonText = RHome.Layout_ResourcesLoad;
                HM_Res_Select.ButtonText = RHome.Layout_ResourcesSelect;
                HM_Announcement.MarqueeText = RHome.Layout_LoadingAnnounce;

                //Config
                //Sound
                ST_SoundPath.Text = RConfig.Layout_SEGroupBox;
                ST_PathBeepText.Text = RConfig.Layout_PathBeep;
                ST_PathWarningText.Text = RConfig.Layout_PathWarning;
                ST_PathBeep.MarqueeText = UC.SE_Beep;
                ST_PathWarning.MarqueeText = UC.SE_Warning;
                ST_PathMessage.MarqueeText = UC.SE_Message;
                ST_PathBeepBrowse.ButtonText = RConfig.Layout_Browse;
                ST_PathWarningBrowse.ButtonText = RConfig.Layout_Browse;
                ST_PathBGMText.Text = RConfig.Layout_PathBGM;
                ST_PathBGMBrowse.ButtonText = RConfig.Layout_Browse;
                ST_PathMessageText.Text = RConfig.Layout_PathMessage;
                ST_PathMessageBrowse.ButtonText = RConfig.Layout_Browse;
                ST_PathBGM.MarqueeText = UC.SE_BGM;
                ST_PathBGMMute.Checked = UC.SE_BGMMute;
                ST_PathWarningMute.Checked = UC.SE_WarningMute;
                ST_PathBeepMute.Checked = UC.SE_BeepMute;
                ST_PathMessageMute.Checked = UC.SE_MessageMute;
                ST_PathBGMMute.Text = RConfig.Layout_Mute;
                ST_PathWarningMute.Text = RConfig.Layout_Mute;
                ST_PathBeepMute.Text = RConfig.Layout_Mute;
                ST_PathMessageMute.Text = RConfig.Layout_Mute;
                //Source
                ST_SourcePath.Text = RConfig.Layout_SourcePath;
                ST_SourceASBText.Text = RConfig.Layout_SourceASB;
                ST_SourceCSVText.Text = RConfig.Layout_SourceCSV;
                ST_SourceASB.MarqueeText = AC.Path_ASB;
                ST_SourceCSV.MarqueeText = AC.Path_CSV;
                //DataRelated
                ST_DataTitle.Text = RConfig.Layout_AboutData;
                ST_ReLoad.ButtonText = RConfig.Layout_Reload;
                ST_AutoLoad.Checked = UC.State_AutoLoad;
                ST_AutoLoad.Text = RConfig.Layout_AutoLoadText;
                ST_AUCsvModeText.Text = RConfig.Layout_AUResourceMode;
                ST_AUCsvPathText.Text = RConfig.Layout_AUResourcePath;
                ST_AUProgChannelText.Text = RConfig.Layout_AUProgramChannel;
                ST_AUProgModeText.Text = RConfig.Layout_AUProgramMode;
                ST_AUCsvPath.MarqueeText = UC.Path_Download;
                ST_AUCsvMode.SelectedIndex = UC.AU_CSVMode;
                ST_AUCsvCheckGo.ButtonText = RConfig.Layout_CheckUpdate;
                ST_AUCsvBrowse.ButtonText = RConfig.Layout_Browse;
                ST_AttachmentModeText.Text = RConfig.Layout_AttachmentMode;
                ST_AttachmentMode.SelectedIndex = UC.AMMode;
                ST_ClearAllAttachments.ButtonText = RConfig.Layout_ClearAllAttachments;
                //About Program
                ST_AUProg.Text = RConfig.Layout_AUProgram;
                ST_AUProgCurrentVerText.Text = RConfig.Layout_AUProgramCurrentVersion;
                ST_AUProgLatestVerText.Text = RConfig.Layout_AUProgramLatestVersion;
                ST_AUProgMode.SelectedIndex = UC.AU_ProgramMode;
                ST_AUProgChannel.SelectedIndex = UC.AU_ProgramChannel;
                ST_AUProgCheckGo.ButtonText = RConfig.Layout_CheckUpdate;
                ST_AUProgCurrentVer.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
                //About
                ST_Version.Text = Assembly.GetEntryAssembly().GetName().Version.ToString() + "\r\n" +
                    Application.ProductVersion;
                ST_VersionText.Text = RConfig.Layout_VersionText;
                ST_AboutProgram.Text = RConfig.Layout_About;
                ST_DevelopersText.Text = RConfig.Layout_DevelopersTextDev;
                ST_Developer.MarqueeText = RConfig.Layout_DevelopersDev1;

                //CsvTable
                CT_StepLabel.Text = RCsvTable.Layout_Step;
                CT_StepGo.ButtonText = RCsvTable.Layout_StepGo;
                CT_Tips.MarqueeText = RCsvTable.Message_WayToCopyContents;
                CT_SearchGo.ButtonText = RCsvTable.Layout_SearchGo;
                CT_StartColumnLabel.Text = RCsvTable.Layout_StartColumn;
                CT_EndColumnLabel.Text = RCsvTable.Layout_EndColumn;
                CT_SearchString.Text = RCsvTable.Layout_SearchString;

                //Character Data
                CD_CharacterIDText.Text = RCharaData.Layout_CharaIDText;
                CD_CharacterIDGo.ButtonText = RCharaData.Layout_CharaIDGo;
                CD_FavoriteText.Text = RCharaData.Layout_FavoriteText;

                //Statistics
                SS_Weapon.Text = RStatistics.Layout_WeaponRelated;
                SS_Character.Text = RStatistics.Layout_CharacterRelated;
                SS_Monster.Text = RStatistics.Layout_MonsterRelated;
                SS_CharaCalculate.ButtonText = RStatistics.Layout_Calculate;
                SS_MonsterCalculate.ButtonText = RStatistics.Layout_Calculate;
                SS_CharaWeaponUsingRateText.Text = RStatistics.Layout_CharaWeaponUsingRate;
                SS_CharaElementRateText.Text = RStatistics.Layout_CharaElementRate;
                SS_CharaRarityRateText.Text = RStatistics.Layout_CharaRarityRate;
                SS_CharaSceneRateText.Text = RStatistics.Layout_CharaSceneRate;
                SS_CharaSeriesRateText.Text = RStatistics.Layout_CharaSeriesRate;
                SS_MonsterTypeRateText.Text = RStatistics.Layout_MonsterTypeRate;
                SS_MonsterHPRateText.Text = RStatistics.Layout_MonsterHPRate;

                //Download
                DL_KeywordText.Text = RDownload.Layout_Keyword;
                DL_CharaPicBox.Text = RDownload.Layout_CharaPicDL;
                DL_RarityText.Text = RDownload.Layout_Rarity;
                DL_SeriesText.Text = RDownload.Layout_CharaSeries;
                DL_Search.ButtonText = RDownload.Layout_Search;
                DL_SeriesForm.Text = RDownload.Layout_CharaSeriesTable;
                DL_Add.ButtonText = RDownload.Layout_Add;
                DL_AddAll.ButtonText = RDownload.Layout_AddAll;
                DL_DownloadLogText.Text = RDownload.Layout_DownloadLog;
                DL_CompleteListText.Text = RDownload.Layout_CompleteList;
                DL_DownloadListText.Text = RDownload.Layout_DownloadList;
                DL_CharaIDText.Text = RDownload.Layout_CharaID;
                DL_StartDownload.ButtonText = RDownload.Layout_BeginDL;
                DL_Remove.ButtonText = RDownload.Layout_Remove;
                DL_CharaIDAdd.ButtonText = RDownload.Layout_Add;
                DL_ClearAll.ButtonText = RDownload.Layout_ClearAll;
                DL_PicCountText.Text = RDownload.Layout_PicCount;
                DL_PendingText.Text = RDownload.Layout_Pending;
                DL_CompletedText.Text = RDownload.Layout_Complete;
                DL_DLingText.Text = RDownload.Layout_Downloading;
                DL_FailedText.Text = RDownload.Layout_Failed;
                DL_AbortDownload.ButtonText = RDownload.DL_AbortDownload;

                //EXP Calculator
                EC_Main.Text = RExpCalc.Layout_Main;
                EC_Chara.Text = RExpCalc.Layout_Chara;
                EC_MainParamBefore.Text = EC_CharaBefore.Text = EC_MainBefore.Text = RExpCalc.Layout_Before;
                EC_MainParamAfter.Text = EC_CharaAfter.Text = EC_MainAfter.Text = RExpCalc.Layout_After;
                EC_MainCalc.ButtonText = EC_CharaCalc.ButtonText = RExpCalc.Layout_Calc;
                EC_MainExpNeedText.Text = EC_CharaExpNeedText.Text = RExpCalc.Layout_ExpNeed;
                EC_CharaExpBeforeText.Text = EC_CharaExpAfterText.Text = EC_MainExpBeforeText.Text = EC_MainExpAfterText.Text = RExpCalc.Layout_ExpLeft;
                EC_CharaLvBeforeText.Text = EC_CharaLvAfterText.Text = EC_MainLvBeforeText.Text = EC_MainLvAfterText.Text = RExpCalc.Layout_Lv;
                EC_MainSTRBeforeText.Text = EC_MainSTRAfterText.Text = RExpCalc.Layout_STR;
                EC_MainVITBeforeText.Text = EC_MainVITAfterText.Text = RExpCalc.Layout_VIT;
                EC_MainINTBeforeText.Text = EC_MainINTAfterText.Text = RExpCalc.Layout_INT;
                EC_MainMENBeforeText.Text = EC_MainMENAfterText.Text = RExpCalc.Layout_MEN;
                EC_MainHPBeforeText.Text = EC_MainHPAfterText.Text = RExpCalc.Layout_HP;
                EC_MainSSBeforeText.Text = EC_MainSSAfterText.Text = RExpCalc.Layout_SS;
                EC_CharaTips.MarqueeText = RExpCalc.Message_FastTip;
                EC_MainCostBeforeText.Text = EC_MainCostAfterText.Text = RExpCalc.Layout_Cost;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029010, e);
                throw;
            }
        }

        public void InitializeEventHandler()
        {
            try
            {
                //Main
                MN_Border.Paint += new PaintEventHandler(SystemAPI.DrawBorderCoral);
                MN_Title.MouseMove += new MouseEventHandler(MoveWindow_MouseMove);
                MN_Title.MouseDown += new MouseEventHandler(MoveWindow_MouseDown);
                MN_Close.ButtonClick += new EventHandler(Sys_Close_Click);
                MN_Min.ButtonClick += new EventHandler(Sys_Min_Click);
                MN_Button.DropDownItemClicked += MN_Button_DropDownItemClicked;
                MN_Capture.Click += MN_Capture_Click;

                UC.PropertyChanged += new PropertyChangedEventHandler(SettingsSave);
                Announce.DL.DownloadCompleted += Announce_DownloadCompleted;

                //InHomePage
                HM_ToHomePage.ButtonClick += new EventHandler(ToHomePage_Click);
                HM_ToConfig.ButtonClick += new EventHandler(ToSettings_Click);
                HM_ToCsvTable.ButtonClick += new EventHandler(ToCsvTable_Click);
                HM_ToCharacterData.ButtonClick += new EventHandler(ToCharacterData_Click);
                HM_ToEquipmentData.ButtonClick += new EventHandler(ToEquipmentData_Click);
                HM_ToStatistics.ButtonClick += ToStatistics_Click;
                HM_ToDownload.ButtonClick += ToDownload_Click;
                HM_ToEXPCalc.ButtonClick += ToEXPCalc_Click;
                HM_Res_Load.ButtonClick += new EventHandler(Res_Load_Click);
                HM_Res_Select.ButtonClick += new EventHandler(Res_Select_Click);
                HM_Announcement.ArriveToBorder += Announcement_ArriveToBorder;

                //Config
                ST_PathWarningBrowse.ButtonClick += new EventHandler(ST_FilePathSelect_Click);
                ST_PathBeepBrowse.ButtonClick += new EventHandler(ST_FilePathSelect_Click);
                ST_ReLoad.ButtonClick += new EventHandler(ST_ReLoad_Click);
                ST_AutoLoad.CheckedChanged += new EventHandler(ST_AutoLoad_CheckedChanged);
                ST_Developer.ArriveToBorder += new EventHandler(ST_Developer_ArriveToBorder);
                ST_PathBGMBrowse.ButtonClick += new EventHandler(ST_FilePathSelect_Click);
                ST_PathMessageBrowse.ButtonClick += new EventHandler(ST_FilePathSelect_Click);
                ST_PathBeepMute.CheckedChanged += new EventHandler(ST_MuteChanged);
                ST_PathMessageMute.CheckedChanged += new EventHandler(ST_MuteChanged);
                ST_PathBGMMute.CheckedChanged += new EventHandler(ST_MuteChanged);
                ST_PathWarningMute.CheckedChanged += new EventHandler(ST_MuteChanged);
                ST_Data.DoubleClick += new EventHandler(ST_Data_DoubleClick);
                ST_AUProgMode.KeyPress += new KeyPressEventHandler(Extent.DisableKeyEnter);
                ST_AUCsvMode.KeyPress += new KeyPressEventHandler(Extent.DisableKeyEnter);
                ST_AUCsvCheckGo.ButtonClick += new EventHandler(ST_AUCheckGoButtonClick);
                ST_AUProgCheckGo.ButtonClick += new EventHandler(ST_AUCheckGoButtonClick);
                ST_AUProgChannel.SelectedIndexChanged += new EventHandler(AUDataSave);
                ST_AUProgMode.SelectedIndexChanged += new EventHandler(AUDataSave);
                ST_AUCsvMode.SelectedIndexChanged += new EventHandler(AUDataSave);
                ST_AttachmentMode.SelectedIndexChanged += AUDataSave;
                ST_AUCsvBrowse.ButtonClick += ST_DirectoryPathSelect_Click;
                ST_ClearAllAttachments.ButtonClick += ST_ClearAllAttachments_ButtonClick;

                //CsvTable
                CT_StepGo.ButtonClick += new EventHandler(CT_StepGo_ButtonClick);
                CT_Step.KeyPress += new KeyPressEventHandler(Extent.VerifyTextIsNum);
                CT_Step.KeyPress += new KeyPressEventHandler(TextBoxEnter);
                CT_SearchGo.ButtonClick += new EventHandler(CT_SearchGo_ButtonClick);
                CT_Tips.ArriveToBorder += new EventHandler(CT_Tips_ArriveToBorder);
                CT_Search.KeyPress += new KeyPressEventHandler(TextBoxEnter);
                CT_Search.KeyPress += Extent.VerifyLetterDigitOnly;
                CT_FindResultList.DoubleClick += new EventHandler(CT_FindResultList_DoubleClick);

                //Character Data
                CD_CharacterID.KeyPress += new KeyPressEventHandler(Extent.VerifyTextIsNum);
                CD_CharacterID.KeyPress += new KeyPressEventHandler(TextBoxEnter);
                CD_CharacterIDGo.ButtonClick += new EventHandler(CD_CharacterIDGo_ButtonClick);
                CD_Favorite.DoubleClick += CD_Favorite_DoubleClick;
                CD_CloseTab.ButtonClick += CD_CloseTab_ButtonClick;
                CD_NewTab.ButtonClick += CD_NewTab_ButtonClick;
                CD_SearchCharacter.ItemSelected += CD_SearchCharacter_ItemSelected;
                CD_SearchCharacter.SearchClicked += CD_SearchCharacter_SearchClicked;
                CD_SearchCharacter.SeriesTableClicked += CD_SearchCharacter_SeriesTableClicked;

                //Statistics
                SS_CharaCalculate.ButtonClick += SS_WeaponCalculate_ButtonClick;
                SS_MonsterCalculate.ButtonClick += SS_MonsterCalculate_ButtonClick;

                //Download
                DL_Add.ButtonClick += DL_Add_Click;
                DL_AddAll.ButtonClick += DL_AddAll_Click;
                DL_Remove.ButtonClick += DL_Remove_Click;
                DL_StartDownload.ButtonClick += DL_BeginDownload_Click;
                DL_CharaIDAdd.ButtonClick += DL_CharaIDAdd_Click;
                DL_SeriesForm.LinkClicked += DL_CharaSeriesForm_LinkClick;
                DL_Search.ButtonClick += DL_Search_Click;
                DL_ClearAll.ButtonClick += DL_ClearAll_Click;
                DL_CharaID.KeyPress += Extent.VerifyTextIsNum;
                DL_CharaID.KeyPress += TextBoxEnter;
                DL_SearchResult.DoubleClick += DL_SearchResult_DoubleClick;
                DL_DownloadStatus.DoubleClick += DL_DownloadStatus_DoubleClick;
                DL_CompleteList.TextChanged += LogChanged;
                DL_AbortDownload.ButtonClick += DL_AbortDownload_Click;

                //EXP Calculator
                EC_MainCalc.ButtonClick += EC_MainCalc_Click;
                EC_CharaCalc.ButtonClick += EC_CharaCalc_Click;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002900F, e);
                throw;
            }
        }

        public void InitializeControlAttributes()
        {
            try
            {
                //Csv View
                CT_Tips.Marquee();
                CT_CsvView.DefaultCellStyle.ForeColor = Color.FromArgb((int)EForeColor.White);
                CT_CsvView.DefaultCellStyle.BackColor = Color.FromArgb((int)EForeColor.Grey70);

                //Config
                ST_PathBeep.Marquee();
                ST_PathWarning.Marquee();
                ST_Developer.Marquee();
                ST_PathBGM.Marquee();
                ST_PathMessage.Marquee();
                ST_AUCsvPath.Marquee();
                ST_SourceCSV.Marquee();
                ST_SourceASB.Marquee();

                AUProgram.CheckUpdate();
                AUCsv.CheckUpdate();
                AUResource.CheckUpdate();
                AU.isCheckAll = true;

                string[] AUMode = { RConfig.AU_ModeDLAndUpdate, RConfig.AU_ModeCheckAndDL, RConfig.AU_ModeCheckOnly, RConfig.AU_ModeNone };
                ST_AUProgMode.Items.AddRange(AUMode);
                ST_AUCsvMode.Items.AddRange(AUMode);
                string[] AUChannel = { RConfig.AU_ChannelBeta, RConfig.AU_ChannelStable };
                ST_AUProgChannel.Items.AddRange(AUChannel);
                string[] AMMode = { RConfig.AM_DLonce, RConfig.AM_AlwaysDL, RConfig.AM_DelAfterClose };
                ST_AttachmentMode.Items.AddRange(AMMode);

                //Main
                string[] StatusButton = { RMain.Layout_CheckLog, RMain.Layout_CheckProgramAnnouncements, RMain.Layout_ViewCaptureFolder };
                foreach (string item in StatusButton)
                {
                    ToolStripMenuItem TSMI = new ToolStripMenuItem();
                    TSMI.Text = item;
                    MN_Button.DropDownItems.Add(TSMI);
                }

                Announce.Local = Const.Path.ANNOUNCEMENT;
                Announce.URL = new Uri(Const.URL.NETWORK_FILE_AREA + Const.URL.ANNOUNCEMENT);
                Announce.Strings = new List<string>();

                if (Extent.HaveConnection())
                {
                    Announce.DL = new Downloader(Announce.URL, Announce.Local, SizeUnit.KB, null);
                    Announce.DL.DLStart();
                } else
                {
                    Announce_DownloadCompleted(this, EventArgs.Empty);
                }

                //Download
                InitializeList(InitItem.DL_DownloadList);

                //Exp Calculator
                EC_CharaTips.Marquee();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002900E, e);
                throw;
            }
        }

        public void InitializeList(InitItem ItemName)
        {
            try
            {
                switch (ItemName)
                {
                    case InitItem.ST_DataTitle:
                        ST_Data.Clear();
                        ST_Data.Columns.Add(Const.ColName.N_A, 0);
                        ST_Data.Columns.Add(Const.ColName.DATA, 110, HorizontalAlignment.Left);
                        ST_Data.Columns.Add(Const.ColName.DATATITLE_BEGIN, 60, HorizontalAlignment.Left);
                        ST_Data.Columns.Add(Const.ColName.DATATITLE_END, 60, HorizontalAlignment.Left);
                        break;
                    case InitItem.CT_FindResultList:
                        CT_FindResultList.Clear();
                        CT_FindResultList.Columns.Add(Const.ColName.COLUMN_POSITION, 194, HorizontalAlignment.Left);
                        break;
                    case InitItem.CD_Favorite:
                        CD_Favorite.Clear();
                        CD_Favorite.Columns.Add(Const.ColName.N_A, 0);
                        CD_Favorite.Columns.Add(Const.ColName.CHARA_ID, 85, HorizontalAlignment.Left);
                        CD_Favorite.Columns.Add(Const.ColName.CHARA_NAME, 200, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_CharaWeaponUsingRate:
                        SS_CharaWeaponUsingRate.Clear();
                        SS_CharaWeaponUsingRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_CharaWeaponUsingRate.Columns.Add(Const.ColName.WEAPON_CATEGORY_ID, 80, HorizontalAlignment.Left);
                        SS_CharaWeaponUsingRate.Columns.Add(Const.ColName.WEAPON_CATEGORY, 80, HorizontalAlignment.Left);
                        SS_CharaWeaponUsingRate.Columns.Add(Const.ColName.WEAPON_USING_RATE, 100, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_CharaElementRate:
                        SS_CharaElementRate.Clear();
                        SS_CharaElementRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_CharaElementRate.Columns.Add(Const.ColName.ELEMENT_CATEGORY_ID, 80, HorizontalAlignment.Left);
                        SS_CharaElementRate.Columns.Add(Const.ColName.ELEMENT_CATEGORY, 80, HorizontalAlignment.Left);
                        SS_CharaElementRate.Columns.Add(Const.ColName.ELEMENT_RATE, 100, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_CharaSceneRate:
                        SS_CharaSceneRate.Clear();
                        SS_CharaSceneRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_CharaSceneRate.Columns.Add(Const.ColName.SCENE_CATEGORY_ID, 80, HorizontalAlignment.Left);
                        SS_CharaSceneRate.Columns.Add(Const.ColName.SCENE_CATEGORY, 80, HorizontalAlignment.Left);
                        SS_CharaSceneRate.Columns.Add(Const.ColName.SCENE_RATE, 100, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_CharaRarityRate:
                        SS_CharaRarityRate.Clear();
                        SS_CharaRarityRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_CharaRarityRate.Columns.Add(Const.ColName.RARITY, 100, HorizontalAlignment.Left);
                        SS_CharaRarityRate.Columns.Add(Const.ColName.RARITY_RATE, 160, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_CharaSeriesRate:
                        SS_CharaSeriesRate.Clear();
                        SS_CharaSeriesRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_CharaSeriesRate.Columns.Add(Const.ColName.SERIES_CATEGORY_ID, 80, HorizontalAlignment.Left);
                        SS_CharaSeriesRate.Columns.Add(Const.ColName.SERIES_CATEGORY, 80, HorizontalAlignment.Left);
                        SS_CharaSeriesRate.Columns.Add(Const.ColName.SERIES_RATE, 100, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_MonsterTypeRate:
                        SS_MonsterTypeRate.Clear();
                        SS_MonsterTypeRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_MonsterTypeRate.Columns.Add(Const.ColName.MONSTER_TYPE_CATEGORY_ID, 80, HorizontalAlignment.Left);
                        SS_MonsterTypeRate.Columns.Add(Const.ColName.MONSTER_TYPE_CATEGORY, 80, HorizontalAlignment.Left);
                        SS_MonsterTypeRate.Columns.Add(Const.ColName.MONSTER_TYPE_RATE, 100, HorizontalAlignment.Left);
                        break;
                    case InitItem.SS_MonsterHPRate:
                        SS_MonsterHPRate.Clear();
                        SS_MonsterHPRate.Columns.Add(Const.ColName.N_A, 0);
                        SS_MonsterHPRate.Columns.Add(Const.ColName.MONSTER_HP_MIN, 100, HorizontalAlignment.Left);
                        SS_MonsterHPRate.Columns.Add(Const.ColName.MONSTER_HP_MAX, 100, HorizontalAlignment.Left);
                        SS_MonsterHPRate.Columns.Add(Const.ColName.MONSTER_HP_RATE, 100, HorizontalAlignment.Left);
                        break;
                    case InitItem.DL_SearchResult:
                        DL_SearchResult.Clear();
                        DL_SearchResult.Columns.Add(Const.ColName.N_A, 0);
                        DL_SearchResult.Columns.Add(Const.ColName.CHARA_ID, 70, HorizontalAlignment.Left);
                        DL_SearchResult.Columns.Add(Const.ColName.CHARA_NAME, 195, HorizontalAlignment.Left);
                        break;
                    case InitItem.DL_DownloadList:
                        DL_DownloadList.Clear();
                        DL_DownloadList.Columns.Add(Const.ColName.N_A, 0);
                        DL_DownloadList.Columns.Add(Const.ColName.CHARA_ID, 70, HorizontalAlignment.Left);
                        DL_DownloadList.Columns.Add(Const.ColName.CHARA_NAME, 195, HorizontalAlignment.Left);
                        break;
                    case InitItem.DL_DownloadStatus:
                        DL_DownloadStatus.Clear();
                        DL_DownloadStatus.Columns.Add(Const.ColName.N_A, 0);
                        DL_DownloadStatus.Columns.Add(Const.ColName.CHARA_ID, 70, HorizontalAlignment.Left);
                        DL_DownloadStatus.Columns.Add(Const.ColName.DOWNLOAD_FILE_SIZE, 60, HorizontalAlignment.Left);
                        DL_DownloadStatus.Columns.Add(Const.ColName.DOWNLOAD_PROGRESS, 70, HorizontalAlignment.Left);
                        DL_DownloadStatus.Columns.Add(Const.ColName.DOWNLOAD_STATUS, 110, HorizontalAlignment.Left);
                        break;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002900D, e);
                throw;
            }
        }

        #region InitializeDataTable
        public static void InitializeDataTable(ref DataTable DT, int ColumnCount, string TableName)
        {
            try
            {
                InitializeDataTable(ref DT, ColumnCount, null, true, TableName);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002900C, e);
                throw;
            }
        }

        public static void InitializeDataTable(ref DataTable DT, int ColumnCount, string TableName, bool InputStackNoColumn)
        {
            try
            {
                InitializeDataTable(ref DT, ColumnCount, null, InputStackNoColumn, TableName);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002900B, e);
                throw;
            }
        }

        public static void InitializeDataTable(ref DataTable DT, string TableName)
        {
            try
            {
                InitializeDataTable(ref DT, 70, null, true, TableName);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002900A, e);
                throw;
            }
        }

        public static void InitializeDataTable(ref DataTable DT, List<int> ColumnToSetUnique, string TableName)
        {
            try
            {
                InitializeDataTable(ref DT, 70, ColumnToSetUnique, true, TableName);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029009, e);
                throw;
            }
        }
        
        public static void InitializeDataTable(ref DataTable DT, int ColumnCount, List<int> ColumnToSetUnique, bool InputStackNoColumn, string TableName)
        {
            try
            {
                if (InputStackNoColumn)
                {
                    DT = new DataTable(TableName);
                    DataColumn DT_Column = new DataColumn(Const.NUM_COLUMN);
                    DT_Column.Unique = false;
                    DT_Column.AllowDBNull = true;
                    DT.Columns.Add(DT_Column);
                }

                for (int i = 1; i <= ColumnCount; i++)
                {
                    DataColumn DT_Column = new DataColumn("C" + Convert.ToString(i));
                    if (Extent.isContainFullElement(ColumnToSetUnique, i))
                    {
                        DT_Column.Unique = true;
                    }
                    else
                    {
                        DT_Column.Unique = false;
                    }

                    DT_Column.AllowDBNull = true;
                    DT.Columns.Add(DT_Column);
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029008, e);
                throw;
            }
        }
        #endregion

        public void InitializeDataTitle()
        {
            try
            {
                #region Read Data into Array
                if (Extent.isEmptyString(Const.Path.DATA_TITLE))
                {
                    SystemAPI.SEWarning();
                    if (new MessageDialog(RError.Error_Reinstall, RMessageBox.Title_Warning, MessageBoxButtonStyle.YesNo)
                        .ShowDialog(this) == DialogResult.Yes)
                    {
                        SystemAPI.CloseProgram(true);
                        return;
                    }
                }
                InitializeList(InitItem.ST_DataTitle);

                FDTL.Reader = My.FileSystem.OpenTextFieldParser(Const.Path.DATA_TITLE);
                FDTL.Reader.SetDelimiters(",");
                FDTL.Category.CategoryList = new List<string>();
                FDTL.Basis.BasisList = new List<string>();
                FDTL.EndKey.KeyList = new List<string>();

                while (!FDTL.Reader.EndOfData)
                {
                    FDTL.Category.CategoryList.Add(FDTL.Reader.ReadFields()[0]);
                    FDTL.Basis.BasisList.AddRange(FDTL.Reader.ReadFields());
                    FDTL.EndKey.KeyList.AddRange(FDTL.Reader.ReadFields());
                }
                FDTL.Category.Category = FDTL.Category.CategoryList.ToArray();
                FDTL.Basis.Basis = FDTL.Basis.BasisList.ToArray();
                FDTL.EndKey.Key = FDTL.EndKey.KeyList.ToArray();
                #endregion

                #region Find Title Location
                FDTL.Location.StartList = new List<int>();
                FDTL.Location.EndList = new List<int>();
                if (DT.Source.Rows.Count == 0)
                {
                    Status(RStatus.Warning_FileNotImported + RStatus.Warning_ReadCsvFirst);
                    SystemAPI.SEWarning();
                    return;
                }

                for (int i = 0; i < FDTL.Category.Category.Length; i++)
                {
                    string FindTitleCondition = "";
                    ListViewItem item = new ListViewItem();

                    for (int j = 0; j <= 4; j++)
                    {
                        FindTitleCondition += "C" + Convert.ToString(j + 2);

                        if (Extent.isEmptyString(FDTL.Basis.Basis[i * 5 + j]))
                        {
                            FindTitleCondition += " = ''";
                        }
                        else if (FDTL.Basis.Basis[i * 5 + j] == "*")
                        {
                            FindTitleCondition += " LIKE '*'";
                        }
                        else
                        {
                            FindTitleCondition += " = '" + FDTL.Basis.Basis[i * 5 + j] + "'";
                        }

                        if (j < 4)
                        {
                            FindTitleCondition += " AND ";
                        }
                    }
                    DataRow[] FindTitleResult = DT.Source.Select(FindTitleCondition);

                    item.SubItems.Add(FDTL.Category.Category[i].ToString());
                    if (FindTitleResult.Length != 0)
                    {
                        item.SubItems.Add(FindTitleResult[0][0].ToString());
                        FDTL.Location.StartList.Add(Convert.ToInt32(FindTitleResult[0][0]));
                    }
                    else
                    {
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        break;
                    }
                    int EndStack = Convert.ToInt32(FDTL.Location.StartList[i] + DataAPI.EndStack(DT.Source, FDTL.Location.StartList[i], FDTL.EndKey.Key[i], 1) - 1);
                    FDTL.Location.EndList.Add(EndStack);
                    item.SubItems.Add(EndStack.ToString());

                    ST_Data.Items.Add(item);
                }
                FDTL.Location.Start = FDTL.Location.StartList.ToArray();
                FDTL.Location.End = FDTL.Location.EndList.ToArray();

                TitleP.Start = FDTL.Location.Start;
                TitleP.End = FDTL.Location.End;
                #endregion
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029007, e);
                throw;
            }
        }

        public void InitializeCharaDict()
        {
            try
            {
                List<int> KeepCol = new List<int>(
                new int[] { (int)ENameSecCol.ID, (int)ENameSecCol.HEAD, (int)ENameSecCol.JP_NAME, (int)ENameSecCol.EN_NAME, (int)ENameSecCol.CV, (int)ENameSecCol.SEX, (int)ENameSecCol.INTRO });
                List<string> DelCol = new List<string>();

                for (int i = 1; i < DT.Source.Columns.Count; i++)
                {
                    if (!Extent.isContainFullElement(KeepCol, i))
                    {
                        DelCol.Add("C" + i.ToString());
                    }
                }

                DT.CharaDict = new DataTable();
                string ExCommand = Const.IS_ORG_CHARA_VERIFY_AT_C1;

                DT.CharaDict = DataAPI.Specified(DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], DelCol, "Chara Dictionary", ExCommand);

                DataAPI.Resort(ref DT.CharaDict, KeepCol);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029006, e);
                throw;
            }
        }

        public void InitializeDataTables()
        {
            try
            {
                DT.CharaSeries = new DataTable();
                InitializeDataTable(ref DT.CharaSeries, Const.Column.CHARA_SERIES, "Chara Series");
                DataAPI.LoadCSV(ref DT.CharaSeries, Const.Path.CHARA_SERIES, "\t");

                DT.CharaDim = new DataTable();
                InitializeDataTable(ref DT.CharaDim, Const.Column.CHARA_DIM, "Chara Dimensions");
                DataAPI.LoadCSV(ref DT.CharaDim, Const.Path.CHARA_DIM, "\t");

                DT.BADict = new DataTable();
                InitializeDataTable(ref DT.BADict, Const.Column.BA_DICT, "BA Dictionary");
                DataAPI.LoadCSV(ref DT.BADict, Const.Path.BA_DICT, "\t");

                DT.LSDict = new DataTable();
                InitializeDataTable(ref DT.LSDict, Const.Column.LS_DICT, "LS Dictionary");
                DataAPI.LoadCSV(ref DT.LSDict, Const.Path.LS_DICT, "\t");

                DT.WeaponEff = new DataTable();
                InitializeDataTable(ref DT.WeaponEff, Const.Column.WEAPON_EFFECT, "Weapon Effect");
                DataAPI.LoadCSV(ref DT.WeaponEff, Const.Path.WEAPON_EFFECT, "\t");
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029005, e);
                throw;
            }
        }

        public void InitializeBGM()
        {
            try
            {
                if (UC.SE_BGM != null)
                {
                    if (My.FileSystem.FileExists(UC.SE_BGM))
                    {
                        BGM.URL = UC.SE_BGM;
                        BGM.settings.mute = UC.SE_BGMMute;
                        BGM.Ctlenabled = true;
                        BGM.Ctlcontrols.play();
                        BGM.settings.setMode("loop", true);
                    }
                    else
                    {
                        Status(RError.Error_BGMNotFound);
                    }
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029004, e);
                throw;
            }
        }

        public void InitializeConfig()
        {
            try
            {
                if (Extent.isEmptyString(UC.Path_Download))
                {
                    UC.Path_Download = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", string.Empty).ToString();
                    UC.Save();
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029001, e);
                throw;
            }
        }

        public void InitializeAtLoadCompleted()
        {
            try
            {
                InitializeList(InitItem.CD_Favorite);
                RefreshFavoriteList(this, EventArgs.Empty);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029002, e);
                throw;
            }
        }

        public void Initialize()
        {
            try
            {
                InitializeConfig();
                InitializeUpdateChecker();
                InitializeControlAttributes();
                InitializeUIText();
                InitializeEventHandler();
                InitializeList(InitItem.ST_DataTitle);
                InitializeBGM();
                InitializeDataTables();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00029003, e);
                throw;
            }
        }

        public void InitializeAtBegin()
        {
            StatusLog.InitializeLog();

            BreezeLabel = new Timer();
            BreezeLabel.Interval = 10;
            BreezeLabel.Enabled = true;
            BreezeLabel.Start();
            MarqueeLabel = new Timer();
            MarqueeLabel.Interval = 10;
            MarqueeLabel.Enabled = true;
            MarqueeLabel.Start();

            DataAPI.LoadCSV(ref URLs, Const.Path.PATH_DICT);
        }
    }
}
