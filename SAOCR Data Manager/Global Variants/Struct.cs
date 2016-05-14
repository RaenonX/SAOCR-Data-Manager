using Microsoft.VisualBasic.FileIO;
using SAOCR_Data_Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct WindowPosition
{
    public int LEFT;
    public int TOP;
    public int X;
    public int Y;
}

#region 自動更新系統相關
public struct AULocation
{
    public string Local;
    public Uri Network;
    public string NetworkDL;
}

public struct AUVersion
{
    public List<string> LocalList;
    public List<string> NetworkList;
    public string[] Local;
    public string[] Network;
}

public struct AUData
{
    public List<string> FileList;
    public List<string> LocalList;
    public List<string> NetworkList;
    public string[] Local;
    public string[] Network;
}

public struct AUParser
{
    public TextFieldParser Local;
    public TextFieldParser Network;
}

public struct AUSystemObjects
{
    public AULocation Location;
    public AUVersion Version;
    public AUData Data;
    public AUParser Parser;
    public AUCheckStatus Status;
    public string Delimeters;
}

public struct AUSystem
{
    public int Counter;
    public bool isCheckAll;
}
#endregion

#region 下載相關
public struct DLLocation
{
    public List<Uri> NetworkList;
    public List<string> LocalList;
    public Uri[] Network;
    public string[] Local;
    public Uri NetworkDLing;
    public string LocalDLing;
    public Uri NetworkVer;
    public string LocalVer;
}

public struct DLInfo
{
    public double Percent;
    public double Speed;
    public long BytesReceived;
    public long TotalBytes;
    public SizeUnit DLSizeUnit;
    public string Description;
}

public struct DLCount
{
    public int Items;
    public int Current;
}

public struct DLSystemObjects
{
    public DLLocation Location;
    public DLInfo Info;
    public List<long> TempForSpeed;
    public DLStatus Status;
    public DLCount Count;
}

public struct PicDownloadInfo
{
    public int Pending;
    public int Total;
    public int Completed;
    public int Downloading;
    public int Failed;
    public int Percent;
    public string FolderName;
    public bool AllowDL;
}
#endregion

public struct FindEndStack
{
    public string Condition;
    public DataRow[] DataRows;
    public List<int> StackList;
    public int[] Stack;
    public int min;
}

#region 尋找終點堆棧
public struct FDTL_Basis
{
    public List<string> BasisList;
    public string[] Basis;
}

public struct FDTL_Category
{
    public List<string> CategoryList;
    public string[] Category;
}

public struct FDTL_EndKeyword
{
    public List<string> KeyList;
    public string[] Key;
}

public struct FDTL_Location
{
    public List<int> StartList;
    public int[] Start;
    public List<int> EndList;
    public int[] End;
}

public struct FindDataTitleLocation
{
    public FDTL_Basis Basis;
    public FDTL_Category Category;
    public FDTL_EndKeyword EndKey;
    public FDTL_Location Location;
    public TextFieldParser Reader;
}
#endregion

#region 資料表集合
public struct DataTables
{
    public DataTable Source;
    public DataTable BADict;
    public DataTable LSDict;
    public DataTable CharaDict;
    public DataTable CharaDim;
    public DataTable CharaSeries;
    public DataTable CharaMix;
    public DataTable WeaponEff;
    public DataTable ExpMain;
    public DataTable ExpChara;
}
#endregion

public struct TitlePos
{
    public int[] Start;
    public int[] End;
}

public struct Announcement
{
    public Downloader DL;
    public List<string> Strings;
    public string Local;
    public Uri URL;
    public int Counter;
    public int Max;
}

public struct DataTableCounts
{
    public int ColumnC;
    public int RowC;
}

#region 武器資訊
public struct WData
{
    public string ID;
    public TitlePos TitleP;
    public DataTables DTs;
    public WeaponDataRow Data;
}

public struct WeaponDataRow
{
    public DataRow[] Name;
    public DataRow[] Effect;
    public DataRow[] ID;
    public DataRow[] Param;
}
#endregion

#region 角色資料相關
public struct SData
{
    public string CharaID;
    public TitlePos TitleP;
    public DataTables DTs;
}

public struct CData
{
    public CParam Param;
    public DataRow[] Info;
    public DataRow[] CharaDim;
    public DataRow[] CharaSeries;
}

public struct CParam
{
    public CParamData Awaked;
    public CParamData Unawaked;
}

public struct CParamData
{
    public int Cost;
    public DataRow[] DataRow;
    public int[] Array;
}
#endregion

#region 角色經驗相關
public struct CharaExp
{
    public CharaExpData Before;
    public CharaExpData After;
}

public struct CharaExpData
{
    public DataRow[] SpecifiedLv;
    public DataRow[] AtNextLv;
    public int Lv;
    public int ExpLeft;
    public int Sum;
}
#endregion

