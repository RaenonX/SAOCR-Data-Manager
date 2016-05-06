using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 訊息方塊
/// <summary>
/// 訊息方塊的按鈕排列組合。
/// </summary>
[Flags]
public enum MessageBoxButtonStyle
{
    OK = 1,
    OKCancel = 2,
    YesNoCancel = 3,
    RetryCancel = 4,
    YesNo = 5,
    Downlaoder
}
#endregion

#region 跑馬燈相關
/// <summary>
/// 跑馬燈的捲動方向。
/// </summary>
[Flags]
public enum MarqueeDirection
{
    Horizontal = 1,
    Vertical = 2
}

/// <summary>
/// 跑馬燈到底時的動作。
/// </summary>
[Flags]
public enum MarqueeMode
{
    Continual = 1,
    ContinualAndSneeze = 2,
    ResetAtOriginal = 3
}
#endregion

#region 自動更新系統相關
[Flags]
public enum AutoUpdateMode
{
    DownloadAndUpdate,
    CheckAndDownload,
    CheckOnly,
    None
}

[Flags]
public enum AutoUpdateChannel
{
    Beta,
    Stable
}

[Flags]
public enum DataSource
{
    Local,
    Network
}

[Flags]
public enum AUCheckStatus
{
    NoConnection = -2,
    CheckFailed = -1,
    HaveNotChecked = 0,
    IsLatest = 1,
    UpdateAvailable = 2,
}

[Flags]
public enum AUSetDataTarget
{
    Local,
    Network
}

[Flags]
public enum EPathRowCode
{
    PROGRAM_VERSION_NET,
    PROGRAM_VERSION_LOCAL,
    PROGRAM_DOWNLOAD_NET,
    PROGRAM_DESCRIPTION,
    CSV_VERSION_NET,
    CSV_VERSION_LOCAL,
    CSV_DOWNLOAD_NET,
    CSV_DESCRIPTION,
    RESOURCES_VERSION_NET,
    RESOURCES_VERSION_LOCAL,
    RESOURCES_DOWNLOAD_NET,
    RESOURCES_DESCRIPTION
}
#endregion

#region 資料表初始化、標頭欄位點
[Flags]
public enum InitItem
{
    CrDataTitle,
    CrDataFindResultList,
    CharaFindResult,
    Favorite,
    CharaWeaponUsingRate,
    CharaElementRate,
    CharaSceneRate,
    CharaRarityRate,
    CharaSeriesRate,
    MonsterTypeRate,
    MonsterHPRate
}

[Flags] 
public enum DataTitle
{
    Accessory,
    AccessoryEffect,
    Armor,
    ArmorEffect,
    WeaponID,
    WeaponName,
    WeaponParams,
    WeaponEffect,
    LeaderSkillID,
    LeaderSkillEffect,
    MainCharacterParams,
    CharacterAwakedID,
    CharacterNameAndCV,
    CharacterParams,
    CharacterExpTable,
    CharacterBATable,
    MonsterParams,
    DeniedPlayerIGN,
    Titles,
    RegistoneCampaignRecord,
    QuestInformations
}
#endregion

#region 角色參數相關
[Flags]
public enum EParamCategory
{
    HP, STR, VIT, INT, MEN, Null
}

[Flags]
public enum EParamType
{
    Mebius, Force, Aegis, Magius
}

[Flags]
public enum EParamLv
{
    Lv1, LvMAX, Null
}

[Flags]
public enum EParamAwaked
{
    Unawaked, Awaked, Null
}

[Flags]
public enum EGrowRateCatergory
{
    HP, Param
}

[Flags]
public enum EDeployPos
{
    STR = 0, VIT = 5, INT = 10, MEN = 11
}

[Flags]
public enum EPosInPList
{
    HP_MIN = 0,
    HP_MAX = 1,
    STR_MIN = 2,
    STR_MAX = 3,
    VIT_MAX = 5,
    INT_MAX = 7,
    MEN_MAX = 9,
    STR = 13,
    VIT = 25,
    INT = 37,
    MEN = 39
}

[Flags]
public enum EParamSecCol
{
    ID_WITH_TYPE = 1,
    ID = 2,
    WEAPON = 5,
    ELEMENT = 6,
    PARAM_START = 7,
    PARAM_END = 16,
    BA1 = 17,
    BA2 = 18,
    BA3 = 19,
    COST = 22,

    PARAM_GAP = 2,
}
#endregion

#region 角色資料相關
[Flags]
public enum EElement
{
    Fire = 1, Wind = 2, Water = 3
}

[Flags]
public enum EScene
{
    SAO = 1, ALO = 2, GGO = 3, ALL = 4
}

[Flags]
public enum ESex
{
    Male = 1, Female = 2
}

[Flags]
public enum ECharaDimCode
{
    ID = 1,
    GET_METHOD,
    RELEASE_YEAR,
    RELEASE_MONTH,
    RELEASE_DATE,
    FOLKNAME
}

[Flags]
public enum ECharaDictCode
{
    ID = 1,
    HEAD,
    JP_NAME,
    EN_NAME,
    CV,
    SEX,
    INTRO
}

[Flags]
public enum ECharaSeriesCode
{
    CODE = 1,
    JP_NAME,
    EN_NAME,
    CH_NAME
}
#endregion

#region 角色名稱相關
[Flags]
public enum ENameSecCol
{
    ID = 1,
    JP_NAME = 2,
    EN_NAME = 3,
    SEX = 4,
    INTRO = 5,
    RARITY = 6,
    ID_ORG = 7,
    HEAD = 14,
    LONG_NAME = 15,
    CV = 24,
    CHARA_SERIES = 25
}

[Flags]
public enum ECharaIDCol
{
    ORG_ID = 2,
    AWAKED_ID = 3
}

[Flags]
public enum ECharaID
{
    SCENE_START = 0,
    SCENE_LENGTH = 1
}

[Flags] 
public enum EBattleInfoCode
{
    WEAPON,
    ELEMENT, 
    SCENE,
    SEX
}

[Flags]
public enum EBasicInfoCode
{
    JP_NAME,
    EN_NAME,
    CV,
    INTRO
}

[Flags]
public enum ECharaMixCode
{
    STACK,
    ID,
    HEAD,
    NAME,
    EN,
    CV,
    SEX,
    INTRO,
    ID2,
    GET_METHOD,
    RELEASE_YEAR,
    RELEASE_MONTH,
    RELEASE_DATE,
    FOLK_NAME
}
#endregion

#region 怪物資訊相關
[Flags]
public enum EMonsterType
{
    HalfMan,
    Bug,
    Plant,
    Animal,
    Phantom,
    Human,
    Ghost,
    Dragon
}

[Flags]
public enum EMonsterSecCol
{
    RARITY = 3,
    TYPE = 4,
    ELEMENT = 5,
    HP = 6,
    STR = 7,
    VIT = 8,
    INT = 9,
    MEN = 10,
    CRT = 11
}
#endregion

#region 顏色相關
[Flags]
public enum EForeColor
{
    Red = -65536,
    Blue = -16776961,
    Green = -13395610,
    Purple = -6749953,
    Orange = -26368,
    Yellow = -256,
    Grey70 = -12171706,
    RG120B70 = -8882106,
    White = -1,
    LightBlue = -16744193
}

[Flags]
public enum EBackColorAlpha
{
    Red = 184483840,
    Blue = 167772415,
    Green = 171114240,
    Purple = 173670655,
    Orange = 184523008,
    Yellow = 184549120,
    Grey70 = 172377670,
    RG120B70 = 175667270,
    White = 184549375,
    LightBlue = 167805183
}

[Flags]
public enum EBackColorBreeze
{
    Grey70 = -12171706,
    Yellow = -6908366,
    Red = -6933966
}

[Flags]
public enum ColorCategory
{
    A = 16777216,
    R = 65536,
    G = 256,
    B = 1
}
#endregion

#region 下載相關
[Flags]
public enum DLStatus
{
    NoConnection = -2,
    DownloadFailed = -1,
    Ready = 0,
    Downloading = 1,
    DownloadSucceed = 2,
    DownloadCancelled = 3,
    DownloadInCompleted = 4
}

[Flags]
public enum SizeUnit
{
    B = 1,
    KB = 1024,
    MB = 1048576
}

[Flags]
public enum DLInfoCategory
{
    ItemPercentage,
    SizeReceived,
    TotalSize,
    Speed,
    TotalItems,
    CurrentCount,
    TotalPercentage,
    Status,
    Description
}
#endregion

[Flags]
public enum ELang
{
    JP, EN, CH
}

#region 隊長技、BA相關
[Flags]
public enum EDisplayStatus
{
    JP,
    ForceJP,
    Chinese
}

[Flags]
public enum BASeriesType
{
    Attack,
    Support,
    Heal,
    Abnormal,
    Null
}

[Flags]
public enum EBADictCode
{
    NAME_JP = 1,
    DESCRIPTION_JP,
    DESCRIPTION_CH,
    SERIES_1,
    SERIES_2,
    SCORE
}

[Flags]
public enum EBASecCol
{
    ID = 1,
    NAME = 2,
    DESCRIPTION = 3,
    POWER = 6,
    HEAL_RATE = 8
}

[Flags]
public enum EBADataInfo
{
    ID, Name, DesJP, PWR, HealRate, DesCH, Score, Series1, Series2
}

[Flags]
public enum ELSDictCode
{
    ID = 1,
    TARGET_JP,
    TARGET_CH,
    EFFECT_JP,
    SPEC_EFFECT_CH,
    TARGET_SCORE,
    STR,
    VIT,
    INT,
    MEN,
    HP,
    SS,
    SPEC,
    EFFECT_CH,
    EFFECT_SCORE
}

[Flags]
public enum ELSIDSecCol
{
    CharaID = 2,
    ID = 4
}

[Flags]
public enum ELSEffectSecCol
{
    ID = 1,
    Target,
    Effect
}
#endregion

[Flags] 
public enum ELogCategory
{
    Debug,
    Info,
    Status,
    Warning,
    Error
}

#region 武器資訊相關
[Flags]
public enum EWInfoCategory
{
    ID,
    NAME,
    RARITY,
    EFFECT_JP,
    EFFECT_CH
}

[Flags] 
public enum EWeaponIDSecCol
{
    ID = 3,
    CRAFT_PRICE = 4,
    REQUIRED_RANK = 5
}

[Flags]
public enum EWeaponParamSecCol
{
    ID_WITH_QUALITY = 1,
    ID = 2,
    QUALITY = 3,
    STR_MAX = 4,
    VIT_MAX = 5,
    INT_MAX = 6,
    MEN_MAX = 7,
}

[Flags]
public enum EWeaponNameSecCol
{
    ID = 1,
    NAME = 2,
    CATEGORY = 3,
    RARITY = 5,
    STR_MIN = 6,
    VIT_MIN = 7,
    INT_MIN = 8,
    MEN_MIN = 9,
}

[Flags]
public enum EWeaponEffectSecCol
{
    ID = 2,
    NAME = 3,
    DESCRIPTION = 4
}

[Flags]
public enum EWeaponEffDictCode
{
    DESCRIPTION_JP = 1,
    DESCRIPTION_CH = 2
}

/// <summary>
/// R1=良，R4=極上
/// </summary>
[Flags]
public enum ESharpness
{
    R1 = 1, R2 = 2, R3 = 3, R4 = 4
}

[Flags]
public enum EWeapon
{
    Sword_1H = 1,
    Sword_Dual = 2,
    Axe_1H = 3,
    Axe_2H = 4,
    Mace_1H = 5,
    Mace_2H = 6,
    Bow = 7,
    Gun = 8,
    Dagger = 9,
    Rapier = 10,
    Sword_2H = 11,
    Katana = 12
}

#endregion

#region 資料註冊相關
[Flags]
public enum EDataRegCategory
{
    BA,
    LS,
    CharaInfo
}
#endregion
