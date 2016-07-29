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
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain : System.Windows.Forms.Form
    {
        public static UI_WMPOnly WMPO = new UI_WMPOnly();

        Computer My = new Computer();
        UserConfig UC = new UserConfig();
        AppConfig AC = new AppConfig();
        WindowPosition WndPos = new WindowPosition();
        DataTables DT = new DataTables();
        TitlePos TitleP = new TitlePos();
        AUSystem AU = new AUSystem();
        Announcement Announce = new Announcement();
        public static List<string> URLs = new List<string>(); 
        public static string LaunchTime = DateTime.Now.ToString(Const.FORMAT_DATETIME_NOW);
        public static string LogPath = @"Log\" + LaunchTime + ".txt";
        string LastImportedFileExt, LastCaptureName;
        FindDataTitleLocation FDTL = new FindDataTitleLocation();
        UpdateChecker AUProgram, AUResource, AUCsv;
        int CT_TipsCounter = 0, ST_DevelopersCounter = 0;
        public static Timer BreezeLabel = new Timer(), MarqueeLabel = new Timer();

        List<Downloader> DLs = new List<Downloader>();
        PicDownloadInfo PDI = new PicDownloadInfo();
        Button_SE_[] FunctionButtons;

        public FMain()
        {
            InitializeAtBegin();
            InitializeComponent();

            FunctionButtons = new Button_SE_[] { HM_ToCharacterData, HM_ToEquipmentData, HM_ToCsvTable, HM_ToDownload,
            HM_ToEXPCalc, HM_ToStatistics };
        }
    }
}
