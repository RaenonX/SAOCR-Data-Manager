using SAOCR_Data_Manager.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOCR_Data_Manager
{
    public static class Const
    {
        public const string NUM_COLUMN = "Stack";
        public const string CHARA_DIM_EX_COMMAND = "SUBSTRING(C1, 8, 1) IN (0)";

        public const int SCROLL_BAR_WIDTH = 17;
        public const string FORMAT_DATETIME_NOW = "yyyy-MM-dd HH-mm-ss";
        public const int SPEED_BUFFER = 5;
        
        public static class Default
        {
            public const int EMPTY_COLUMN = 0;
            public const string CHARA_DATA_TAB = "角色資料 ";
            public const int FREEZE_CHANGE_TIME = 2000;
            public const int MARQUEE_FREEZE_TIME = 2000;
            public const int MARQUEE_MOVE_INTERVAL = 10;
        }

        public static class AnnouncementKeyword
        {
            public static string IMPORTANT = "[IMP]";
            public static string INFO = "[INF]";
            public static string WARNING = "[WRN]";
        }

        public static class ColName
        {
            public const string CHARA_ID = "角色ID";
            public const string N_A = "N/A";
            public const string CHARA_NAME = "角色名稱";
            public const string DATA = "資料";
            public const string DATATITLE_BEGIN = "起始位置";
            public const string DATATITLE_END = "終止位置";
            public const string COLUMN_POSITION = "位置(欄位號碼)";
            public const string CHARA_NAME_CH = "角色名稱(中文)";
            public const string CHARA_NAME_EN = "角色名稱(英文)";
            public const string CHARA_NAME_JP = "角色名稱(日文)";
            public const string WEAPON_CATEGORY_ID = "武器種類ID";
            public const string WEAPON_CATEGORY = "武器種類";
            public const string WEAPON_USING_RATE = "武器使用比率";
            public const string ELEMENT_CATEGORY_ID = "屬性ID";
            public const string ELEMENT_CATEGORY = "屬性名稱";
            public const string ELEMENT_RATE = "屬性占比";
            public const string SCENE_CATEGORY_ID = "舞台ID";
            public const string SCENE_CATEGORY = "舞台名稱";
            public const string SCENE_RATE = "舞台占比";
            public const string RARITY = "星級";
            public const string RARITY_RATE = "占比";
            public const string SERIES_CATEGORY_ID = "角色系ID";
            public const string SERIES_CATEGORY = "角色系名稱";
            public const string SERIES_RATE = "角色系占比";
        }

        public static class Path
        {
            public const string DEFAULT_CSV = "csv.assetbundle";
            public const string CHARA_DIM = "Dimension/CharaDim.txt";
            public const string CHARA_SERIES = "Dimension/CharaSeries.txt";
            public const string DATA_TITLE = "Dimension/DataTitle.txt";
            public const string BA_DICT = "Dimension/BADict.txt";
            public const string LS_DICT = "Dimension/LSDict.txt";
            public const string PATH_DICT = "Dimension/PathDict.txt";
            public const string ANNOUNCEMENT = "Properties/Announcement.txt";
            public const string SCREENSHOT = "ScreenShot";
            public const string SCREENSHOT_NAME = "/Screenshot@";

            public const string PROGRAM = "/SAOCR Data Manager Installer.exe";
        }
    
        public static class URL
        {
            public const string PIC_AREA = "https://sites.google.com/site/saocrpictures/home/pre-released";
            public const string CHARA_PIC = "/charas";
            public const string NETWORK_FILE_AREA = "https://sites.google.com/site/raenonx/datamanager";
            public const string ANNOUNCEMENT = "/Announcement.txt";
            public const string FOLDER_DIMENSION = "/Dimension";
        }

        public static class Count
        {
            public const int FOLK_NAME = 5;
            public const int BA = 3;
            public const int PARAM_TYPE = 4;
            public const int WEAPON_CATEGORY = 12;
            public const int ELEMENT_CATEGORY = 3;
            public const int SCENE_CATEGORY = 4;
            public const int RARITY = 6;
        }

        public static class Column
        {
            public const int CHARA_SERIES = 4;
            public const int CHARA_DIM = 12;
            public const int BA_DICT = 7;
            public const int LS_DICT = 13;
            public const int PATH_DICT = 2;
        }

        public static class Log
        {
            public const string TITLE = "建立時間: ";
            public const string PROGRAM_VERSION = "程式版本號: ";
            public const string NETWORK_AVAILABLE = "啟動時網路狀態: ";
            public const string SEPARATOR = "----------------------";
        }
    }
}
