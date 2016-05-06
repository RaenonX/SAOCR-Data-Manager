using SAOCR_Data_Manager;
using SAOCR_Data_Manager.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAOCR_Data_Manager.Resources.Message;
using System.Drawing;

namespace SAOCR_Data_Manager
{
    public class CharaData
    {
        public bool CreateSucceed = false;
        public CParameters Parameters;
        public CInfo Info;
        public CBA BA;
        public CLS LS;
        SData data;
        CData CDT;

        public CharaData(SData Data)
        {
            try
            {
                data = Data;
                if (Extent.isEmptyString(Data.CharaID))
                {
                    SystemAPI.Warning(RWarning.W_0xC0007003);
                    return;
                }
                if (Data.CharaID.Length != 8)
                {
                    SystemAPI.Warning(RWarning.W_0xC0007001);
                    return;
                }
                if (Data.DTs.Source == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC0007002);
                    return;
                }
                if (Extent.isEmptyString(Data.TitleP.Start[(int)DataTitle.CharacterParams].ToString()))
                {
                    SystemAPI.Warning(RWarning.W_0xC0007004);
                    return;
                }

                for (int k = 0; k <= (int)EParamAwaked.Awaked; k++)
                {
                    CDT.Param.Unawaked.DataRow = DataAPI.Search(Data.CharaID, Data.DTs.Source, Data.TitleP.Start[(int)DataTitle.CharacterParams], Data.TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.ID);
                    CDT.Param.Awaked.DataRow =
                        DataAPI.Search(CharaAPI.AwakedID(Data.CharaID), Data.DTs.Source, Data.TitleP.Start[(int)DataTitle.CharacterParams], Data.TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.ID);
                    if (Convert.ToInt32(Data.CharaID.Substring(6, 1)) < 3 || CDT.Param.Awaked.DataRow == null)
                    {
                        CDT.Param.Awaked = CDT.Param.Unawaked;
                    }
                }
                CDT.Info = DataAPI.Search(Data.CharaID, Data.DTs.Source, Data.TitleP.Start[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.ID);
                CDT.CharaDim = DataAPI.Search(Data.CharaID, Data.DTs.CharaDim, 0, (int)ECharaDimCode.ID);
                CDT.CharaSeries = DataAPI.Search(Data.CharaID.Substring(1, 3), Data.DTs.CharaSeries, 0, (int)ECharaSeriesCode.CODE);

                if (CDT.Info == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC0007005);
                    return;
                }

                Parameters = new CParameters(Data, ref CDT);
                Info = new CInfo(Data, ref CDT);
                BA = new CBA(Data, ref CDT);
                LS = new CLS(Data);
                CreateSucceed = true;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00007000, e);
                throw;
            }
        }

        public SData Data
        {
            get
            {
                try
                {
                    return data;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007001, e);
                    throw;
                }
            }
        }

        public class CParameters
        {
            public BasicP Basic;
            public ExtraP Extra;

            public CParameters(SData Data, ref CData CDT)
            {
                try
                {
                    Basic = new BasicP(Data, ref CDT);
                    Extra = new ExtraP(Data, ref CDT);
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007011, e);
                    throw;
                }
            }

            public class BasicP
            {
                public ParamType Awaked, Unawaked;

                public BasicP(SData Data, ref CData DataC)
                {
                    try
                    {
                        Awaked = new ParamType(Data, ref DataC, true);
                        Unawaked = new ParamType(Data, ref DataC, false);
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007013, e);
                        throw;
                    }
                }

                public class ParamType
                {
                    public ParamLv Mebius, Force, Aegis, Magius;
                    List<int> ToMebius = new List<int>(), ToForce = new List<int>(), ToAegis = new List<int>(), ToMagius = new List<int>(); //HP, HP, STR, STR, VIT, VIT, INT, INT, MEN, MEN
                    CData CDT;
                    bool Awaked;

                    public ParamType(SData Data, ref CData DataC, bool awaked)
                    {
                        try
                        {
                            Awaked = awaked;
                            List<int>[] SArray = { ToMebius, ToForce, ToAegis, ToMagius };
                            List<int> L = new List<int>();

                            for (int i = 0; i < SArray.Length; i++)
                            {
                                int[] Arr = new int[10];

                                if (awaked)
                                {
                                    for (int j = 0; j < Arr.Length; j++)
                                    {
                                        try
                                        {
                                            SArray[i].Add(Convert.ToInt32(DataC.Param.Awaked.DataRow[i][(int)EParamSecCol.PARAM_START + j]));
                                        }
                                        catch (IndexOutOfRangeException)
                                        {
                                            SArray[i].Add(0);
                                        }
                                    }
                                    L.AddRange(SArray[i]);
                                }
                                else
                                {
                                    for (int j = 0; j < Arr.Length; j++)
                                    {
                                        try
                                        {
                                            SArray[i].Add(Convert.ToInt32(DataC.Param.Unawaked.DataRow[i][(int)EParamSecCol.PARAM_START + j]));
                                        }
                                        catch (IndexOutOfRangeException)
                                        {
                                            SArray[i].Add(0);
                                        }
                                    }
                                    L.AddRange(SArray[i]);
                                }
                            }

                            if (awaked)
                            {
                                DataC.Param.Awaked.Array = L.ToArray();
                                DataC.Param.Awaked.Cost = Convert.ToInt32(DataC.Param.Awaked.DataRow[(int)EParamType.Mebius][(int)EParamSecCol.COST]);
                            }
                            else
                            {
                                DataC.Param.Unawaked.Array = L.ToArray();
                                DataC.Param.Unawaked.Cost = Convert.ToInt32(DataC.Param.Unawaked.DataRow[(int)EParamType.Mebius][(int)EParamSecCol.COST]);
                            }
                            
                            Mebius = new ParamLv(Data, ToMebius);
                            Force = new ParamLv(Data, ToForce);
                            Aegis = new ParamLv(Data, ToAegis);
                            Magius = new ParamLv(Data, ToMagius);

                            CDT = DataC;
                        }
                        catch (Exception e)
                        {
                            SystemAPI.Error(RError.E_0x00007014, e);
                            throw;
                        }
                    }

                    public int Cost()
                    {
                        try
                        {
                            if (Awaked)
                            {
                                return CDT.Param.Awaked.Cost;
                            } else
                            {
                                return CDT.Param.Unawaked.Cost;
                            }
                        }
                        catch (Exception e)
                        {
                            SystemAPI.Error(RError.E_0x00007015, e);
                            throw;
                        }
                    }

                    public int[] GetArray()
                    {
                        try
                        {
                            if (Awaked)
                            {
                                return CDT.Param.Awaked.Array;
                            }
                            else
                            {
                                return CDT.Param.Unawaked.Array;
                            }
                        }
                        catch (Exception e)
                        {
                            SystemAPI.Error(RError.E_0x00007012, e);
                            throw;
                        }
                    }

                    public int[] GetArray(EParamType Type)
                    {
                        try
                        {
                            List<int>[] SPList = { ToMebius, ToForce, ToAegis, ToMagius };
                            return SPList[(int)Type].ToArray();
                        }
                        catch (Exception e)
                        {
                            SystemAPI.Error(RError.E_0x00007016, e);
                            throw;
                        }
                    }

                    public class ParamLv
                    {
                        public Params Lv1, LvMax;
                        List<int> ToLv1 = new List<int>(), ToLvMAX = new List<int>(); //HP, STR, VIT, INT, MEN

                        public ParamLv(SData Data, List<int> ParamsL)
                        {
                            try
                            {
                                for (int i = 0; i < ParamsL.Count; i += (int)EParamSecCol.PARAM_GAP)
                                {
                                    ToLv1.Add(ParamsL[i]);
                                    ToLvMAX.Add(ParamsL[i + 1]);
                                }
                                Lv1 = new Params(Data, ToLv1);
                                LvMax = new Params(Data, ToLvMAX);
                            }
                            catch (Exception e)
                            {
                                SystemAPI.Error(RError.E_0x00007017, e);
                                throw;
                            }
                        }

                        public int[] GetArray(EParamLv Lv)
                        {
                            try
                            {
                                List<int>[] SPList = { ToLv1, ToLvMAX };
                                return SPList[(int)Lv].ToArray();
                            }
                            catch (Exception e)
                            {
                                SystemAPI.Error(RError.E_0x00007018, e);
                                throw;
                            }
                        }

                        public class Params
                        {
                            public List<int> PList; //HP, STR, VIT, INT, MEN

                            public Params(SData Data, List<int> ParamsL)
                            {
                                try
                                {
                                    PList = ParamsL;
                                }
                                catch (Exception e)
                                {
                                    SystemAPI.Error(RError.E_0x00007019, e);
                                    throw;
                                }
                            }

                            public int GetParameter(EParamCategory EPC)
                            {
                                try
                                {
                                    return PList[(int)EParamCategory.HP];
                                }
                                catch (Exception e)
                                {
                                    SystemAPI.Error(RError.E_0x0000701A, e);
                                    throw;
                                }
                            }

                            public int[] GetArray()
                            {
                                try
                                {
                                    return PList.ToArray();
                                }
                                catch (Exception e)
                                {
                                    SystemAPI.Error(RError.E_0x0000701B, e);
                                    throw;
                                }
                                
                            }

                            public EParamCategory MaxP()
                            {
                                try
                                {
                                    for (int i = 0; i < PList.Count; i++)
                                    {
                                        if (PList[i] == PList.Max())
                                        {
                                            return (EParamCategory)i;
                                        }
                                    }
                                    return EParamCategory.Null;
                                }
                                catch (Exception e)
                                {
                                    SystemAPI.Error(RError.E_0x0000701C, e);
                                    throw;
                                }
                                
                            }
                        }
                    }
                }
            }

            public class ExtraP
            {
                public ExAwaked GrowRate;
                public PDeploy Deploy;
                EParamCategory Mainparam;
                List<int> MParam = new List<int>();
                List<double> GrowRateL = new List<double>();

                public ExtraP(SData Data, ref CData DataC)
                {   
                    int[] Col = { (int)EPosInPList.STR, (int)EPosInPList.VIT, (int)EPosInPList.INT, (int)EPosInPList.MEN };
                    int[] Col2 = { (int)EPosInPList.HP_MIN, (int)EPosInPList.HP_MAX, (int)EPosInPList.STR_MIN, (int)EPosInPList.STR_MAX };

                    for (int i = 0; i < Col.Length; i++)
                    {
                        MParam.Add(DataC.Param.Unawaked.Array[Col[i]]);
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        for (int i = 0; i < Col2.Length / 2; i++)
                        {
                            if ((EParamAwaked)j == EParamAwaked.Awaked) {
                                GrowRateL.Add((double)DataC.Param.Awaked.Array[Col2[i * 2 + 1]] / DataC.Param.Awaked.Array[Col2[i * 2]]);
                            } else
                            {
                                GrowRateL.Add((double)DataC.Param.Unawaked.Array[Col2[i * 2 + 1]] / DataC.Param.Unawaked.Array[Col2[i * 2]]);
                            }
                        }
                    }

                    int Max = MParam.Max();
                    int x = MParam.IndexOf(Max);

                    Mainparam = (EParamCategory)MParam.IndexOf(MParam.Max()) + 1;

                    GrowRate = new ExAwaked(Data, ref DataC, GrowRateL);
                    Deploy = new PDeploy(Data, ref DataC);
                }

                public EParamCategory MainParam
                {
                    get { return Mainparam; }
                }

                /// <summary>
                /// HPx, PARAMx and Unawaked, Awaked
                /// </summary>
                public double[] GetArray
                {
                    get { return GrowRateL.ToArray(); }
                }

                public class ExAwaked
                {
                    public Rate Awaked, Unawaked;
                    double[] ToAwaked = new double[2], ToUnawaked = new double[2];

                    public ExAwaked(SData Data, ref CData DataC, List<double> GrowRateL)
                    {
                        GrowRateL.CopyTo(0, ToUnawaked, 0, 2);
                        Unawaked = new Rate(Data, ref DataC, new List<double>(ToUnawaked));
                        GrowRateL.CopyTo(2, ToAwaked, 0, 2);
                        Awaked = new Rate(Data, ref DataC, new List<double>(ToAwaked));
                    }

                    public double[] GetArray(EParamAwaked EPA)
                    {
                        double[][] TAList = { ToUnawaked, ToAwaked };
                        return TAList[(int)EPA];
                    }

                    public class Rate
                    {
                        double hp, param;

                        public Rate(SData Data, ref CData DataC, List<double> GrowRateL)
                        {
                            hp = GrowRateL[(int)EGrowRateCatergory.HP];
                            param = GrowRateL[(int)EGrowRateCatergory.Param];
                        }

                        public double HP
                        {
                            get { return hp; }
                        }

                        public double Param
                        {
                            get { return param; }
                        }
                    }
                }

                public class PDeploy
                {
                    List<int> DArray = new List<int>();

                    public PDeploy(SData Data, ref CData DataC)
                    {
                        List<int> TempP = new List<int>();

                        for (int i = 0; i < DataC.Param.Unawaked.Array.Length; i += 2)
                        {
                            if (i % 10 != 0)
                            {
                                TempP.Add(DataC.Param.Unawaked.Array[i]);
                            }
                        }

                        for (int i = 4; i < TempP.Count; i++)
                        {
                            TempP[i] = Math.Abs(TempP[i] - TempP[i % 4]);
                        }

                        TempP.RemoveRange(0, 4);

                        int min = 0;
                        try
                        {
                            min = TempP.Where(f => f > 0).Min();
                        }
                        catch (InvalidOperationException)
                        {
                        }
                        

                        for (int i = 0; i < TempP.Count; i++)
                        {
                            TempP[i] = (int)Math.Round((double)TempP[i] / min);
                        }

                        int[] Pos = { (int)EDeployPos.STR, (int)EDeployPos.VIT, (int)EDeployPos.INT, (int)EDeployPos.MEN };
                        for (int i = 0; i < Pos.Length; i++)
                        {
                            DArray.Add(TempP[Pos[i]]);
                        }
                    }

                    public int GetDeploy(EParamCategory EPC)
                    {
                        switch (EPC)
                        {
                            case EParamCategory.STR:
                            case EParamCategory.VIT:
                            case EParamCategory.INT:
                            case EParamCategory.MEN:
                                return DArray[(int)EPC - 1];
                            default:
                                SystemAPI.Error(RError.E_0x0000701D);
                                return -1;
                        }
                    }
                    
                    public int[] GetArray()
                    {
                        return DArray.ToArray();
                    }
                }
            }
        }

        public class CInfo
        {
            public Battle BattleRelated;
            public BasicI Basic;
            public ExtraI Extra;
            DataRow InfoData;

            public CInfo(SData Data, ref CData CDT)
            {
                try
                {
                    InfoData = CDT.Info[0];

                    BattleRelated = new Battle(Data, InfoData, ref CDT);
                    Basic = new BasicI(Data, InfoData);
                    Extra = new ExtraI(Data, ref CDT);
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007021, e);
                    throw;
                }
            }

            public class Battle
            {
                List<int> BattleInfoCode = new List<int>(); // WEAPON, ELEMENT, SCENE, SEX

                public Battle(SData Data, DataRow DataR, ref CData CDT)
                {
                    try
                    {
                        DataRow[] WpnAndEle = CDT.Param.Unawaked.DataRow;
                        int[] Temp = { (int)EParamSecCol.WEAPON, (int)EParamSecCol.ELEMENT };

                        for (int i = 0; i < Temp.Length; i++)
                        {
                            BattleInfoCode.Add(Convert.ToInt32(WpnAndEle[(int)EParamType.Mebius][Temp[i]]));
                        }

                        BattleInfoCode.Add(Convert.ToInt32(Data.CharaID.Substring((int)ECharaID.SCENE_START, (int)ECharaID.SCENE_LENGTH)));
                        BattleInfoCode.Add(Convert.ToInt32(DataR[(int)ENameSecCol.SEX]));
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007022, e);
                        throw;
                    }
                }

                public string GetBattleInfo(EBattleInfoCode EBIC)
                {
                    try
                    {
                        switch (EBIC)
                        {
                            case EBattleInfoCode.ELEMENT:
                                return EnumTranslator.ElementT((EElement)BattleInfoCode[(int)EBIC]);
                            case EBattleInfoCode.SCENE:
                                return EnumTranslator.SceneT((EScene)BattleInfoCode[(int)EBIC]);
                            case EBattleInfoCode.SEX:
                                return EnumTranslator.SexT((ESex)BattleInfoCode[(int)EBIC]);
                            case EBattleInfoCode.WEAPON:
                                return EnumTranslator.WeaponT((EWeapon)BattleInfoCode[(int)EBIC]);
                        }
                        return EnumTranslator.ElementT((EElement)BattleInfoCode[(int)EBIC]);
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007023, e);
                        throw;
                    }
                }

                /// <summary>
                /// 獲得武器、屬性、舞台、性別的代碼。
                /// </summary>
                /// <returns></returns>
                public int[] GetArray()
                {
                    try
                    {
                        return BattleInfoCode.ToArray();
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007024, e);
                        throw;
                    }
                }

                /// <summary>
                /// 獲得武器、屬性、舞台、性別的字串。
                /// </summary>
                public string[] GetStringArray()
                {
                    List<string> Infos = new List<string>();
                    for (int i = 0; i < BattleInfoCode.Count; i++)
                    {
                        switch (i)
                        {
                            case (int)EBattleInfoCode.ELEMENT:
                                Infos.Add(EnumTranslator.ElementT((EElement)BattleInfoCode[i]));
                                break;
                            case (int)EBattleInfoCode.SCENE:
                                Infos.Add(EnumTranslator.SceneT((EScene)BattleInfoCode[i]));
                                break;
                            case (int)EBattleInfoCode.SEX:
                                Infos.Add(EnumTranslator.SexT((ESex)BattleInfoCode[i]));
                                break;
                            case (int)EBattleInfoCode.WEAPON:
                                Infos.Add(EnumTranslator.WeaponT((EWeapon)BattleInfoCode[i]));
                                break;
                        }
                    }

                    return Infos.ToArray();
                }
            }

            public class BasicI
            {
                List<string> infos = new List<string>(); //NAME, EN, CV, INTRO

                public BasicI(SData Data, DataRow DataR)
                {
                    try
                    {
                        int[] Temp = { (int)ENameSecCol.JP_NAME, (int)ENameSecCol.EN_NAME, (int)ENameSecCol.CV, (int)ENameSecCol.INTRO };
                        for (int i = 0; i < Temp.Length; i++)
                        {
                            if (i == 0)
                            {
                                infos.Add(DataR[(int)ENameSecCol.HEAD].ToString() + DataR[Temp[i]].ToString());
                            } else
                            {
                                infos.Add(DataR[Temp[i]].ToString());
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007025, e);
                        throw;
                    }
                }

                public string GetBasicInfo(EBasicInfoCode EBIC)
                {
                    try
                    {
                        return infos[(int)EBIC];
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007026, e);
                        throw;
                    }
                }

                /// <summary>
                /// 日文名稱、英文名稱、CV、介紹
                /// </summary>
                public string[] GetArray()
                {
                    try
                    {
                        return infos.ToArray();
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007027, e);
                        throw;
                    }
                }
            }

            public class ExtraI
            {
                public CharaSeries Serie;
                DataRow info;
                SData DT;

                public ExtraI(SData Data, ref CData CDT)
                {
                    try
                    {
                        DT = Data;
                        DataRow[] Result = CDT.CharaDim;
                        if (Result != null)
                        {
                            info = Result[0];
                        } else
                        {
                            info = Data.DTs.CharaDim.Rows[Const.Default.EMPTY_COLUMN];
                        }
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007025, e);
                        throw;
                    }
                }

                public string GetMethod
                {
                    get { return info[(int)ECharaDimCode.GET_METHOD].ToString(); }
                }

                public DateTime ReleaseDate
                {
                    get
                    {
                        DateTime Date = new DateTime(Const.Default.RELEASE_DATE_UNKNOWN_YEAR, 1, 1);
                        try
                        {
                            Date = new DateTime(
                            Convert.ToInt32(info[(int)ECharaDimCode.RELEASE_YEAR]),
                            Convert.ToInt32(info[(int)ECharaDimCode.RELEASE_MONTH]),
                            Convert.ToInt32(info[(int)ECharaDimCode.RELEASE_DATE]));
                        }
                        catch (FormatException)
                        {
                        }
                        catch (Exception e)
                        {
                            SystemAPI.Error(RError.E_0x00007036, e);
                            throw;
                        }
                        return Date;
                    }
                }

                public string FolkName
                {
                    get
                    {
                        string folkname = "";

                        for (int i = 0; i < Const.Count.FOLK_NAME; i++)
                        {
                            folkname += info[(int)ECharaDimCode.FOLKNAME + i].ToString();
                            if (!Extent.isEmptyString(info[(int)ECharaDimCode.FOLKNAME + 1 + i].ToString()))
                            {
                                folkname += "、";
                            } else
                            {
                                break;
                            }
                        }
                        return folkname;
                    }
                }

                public string[] FolkNameArray()
                {
                    List<string> L = new List<string>();

                    for (int i = 0; i < Const.Count.FOLK_NAME; i++)
                    {
                        L.Add(info[(int)ECharaDimCode.FOLKNAME + i].ToString());
                    }
                    return L.ToArray();
                }

                /// <summary>
                /// 角色ID、獲得方法、釋出年、釋出月、釋出日、俗名1~5
                /// </summary>
                /// <returns></returns>
                public string[] GetArray()
                {
                    try
                    {
                        List<string> L = new List<string>();
                        L.Add(DT.CharaID);
                        L.Add(GetMethod);
                        L.Add(ReleaseDate.Year.ToString());
                        L.Add(ReleaseDate.Month.ToString());
                        L.Add(ReleaseDate.Day.ToString());
                        L.AddRange(FolkNameArray());
                        return L.ToArray();
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007047, e);
                        throw;
                    }
                }

                public class CharaSeries
                {
                    DataRow dataArr;

                    public CharaSeries(SData Data, ref CData CDT)
                    {
                        try
                        {
                            dataArr = CDT.CharaSeries[0];
                        }
                        catch (Exception e)
                        {
                            SystemAPI.Error(RError.E_0x00007048, e);
                            throw;
                        }
                    }

                    public string Code
                    {
                        get { return dataArr[(int)ECharaSeriesCode.CODE].ToString(); }
                    }

                    public string Name(ELang L)
                    {
                        switch (L)
                        {
                            case ELang.JP:
                                return dataArr[(int)ECharaSeriesCode.JP_NAME].ToString();
                            case ELang.EN:
                                return dataArr[(int)ECharaSeriesCode.EN_NAME].ToString();
                            case ELang.CH:
                                return dataArr[(int)ECharaSeriesCode.CH_NAME].ToString();
                            default:
                                throw new ArgumentException(RError.Error_WrongLanguage);
                        }
                    }

                    public string[] GetArray()
                    {
                        List<string> L = new List<string>();

                        for (int i = 0; i < Const.Column.CHARA_SERIES; i++)
                        {
                            L.Add(dataArr[i].ToString());
                        }

                        return L.ToArray();
                    }
                }
            }
        }

        public class CBA
        {
            public BAData BA1, BA2, BA3;
            EDisplayStatus DSP;

            public CBA(SData Data, ref CData CDT)
            {
                try
                {
                    DataRow ToGetBAID = CDT.Param.Unawaked.DataRow[0];

                    int[] BAIDCol = { (int)EParamSecCol.BA1, (int)EParamSecCol.BA2, (int)EParamSecCol.BA3 };
                    BAData[] BAD = { BA1, BA2, BA3 };

                    for (int i = 0; i < Const.Count.BA; i++)
                    {
                        List<string> BAInfo = new List<string>();
                        BAInfo.Add(ToGetBAID[BAIDCol[i]].ToString());
                        if (ToGetBAID[BAIDCol[i]].ToString() != "0")
                        {
                            DataRow BADataInTable = DataAPI.Search(BAInfo[(int)EBADataInfo.ID], Data.DTs.Source, Data.TitleP.Start[(int)DataTitle.CharacterBATable], Data.TitleP.End[(int)DataTitle.CharacterBATable], (int)EBASecCol.ID, true)[0];
                            int[] ColT = { (int)EBASecCol.NAME, (int)EBASecCol.DESCRIPTION, (int)EBASecCol.POWER, (int)EBASecCol.HEAL_RATE };

                            for (int j = 0; j < ColT.Length; j++)
                            {
                                if (j == 1)
                                {
                                    BAInfo.Add(BADataInTable[ColT[j]].ToString());
                                } 
                                else if (j == 3)
                                {
                                    BAInfo.Add((Convert.ToDouble(BADataInTable[ColT[j]]) * 100).ToString());
                                }
                                else
                                {
                                    BAInfo.Add(BADataInTable[ColT[j]].ToString());
                                }
                            }

                            int[] ColD = { (int)EBADictCode.DESCRIPTION_CH, (int)EBADictCode.SCORE, (int)EBADictCode.SERIES_1, (int)EBADictCode.SERIES_2 };
                            try
                            {
                                DataRow BAAddData = DataAPI.Search(BAInfo[(int)EBADataInfo.DesJP], Data.DTs.BADict, 0, (int)EBADictCode.DESCRIPTION_JP)[0];
                                
                                for (int j = 0; j < ColD.Length; j++)
                                {
                                    if (j == 0)
                                    {
                                        if (Extent.isEmptyString(BAAddData[ColD[j]].ToString()))
                                        {
                                            DSP = EDisplayStatus.ForceJP;
                                            BAInfo.Add(BAAddData[(int)EBADictCode.DESCRIPTION_JP].ToString());
                                        } else
                                        {
                                            BAInfo.Add(BAAddData[ColD[j]].ToString());
                                        }
                                    }
                                    else
                                    {
                                        BAInfo.Add(BAAddData[ColD[j]].ToString());
                                    }
                                }
                            }
                            catch (NullReferenceException)
                            {
                                for (int j = 0; j < ColD.Length; j++)
                                {
                                    if (j == 0)
                                    {
                                        DSP = EDisplayStatus.ForceJP;
                                        BAInfo.Add(BADataInTable[(int)EBASecCol.DESCRIPTION].ToString());
                                    } else
                                    {
                                        BAInfo.Add("");
                                    }
                                }
                            }
                        } else
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                BAInfo.Add("");
                            }
                        }

                        switch (i)
                        {
                            case 0:
                                BA1 = new BAData(Data, BAInfo, DSP);
                                break;
                            case 1:
                                BA2 = new BAData(Data, BAInfo, DSP);
                                break;
                            case 2:
                                BA3 = new BAData(Data, BAInfo, DSP);
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007034, e);
                    throw;
                }
            }

            public class BAData
            {
                List<string> Info = new List<string>();
                EDisplayStatus ESP;

                public BAData(SData Data, List<string> BAData, EDisplayStatus DSP)
                {
                    try
                    {
                        Info.AddRange(BAData);
                        ESP = DSP;
                    }
                    catch (Exception)
                    {
                        SystemAPI.Error(RError.E_0x00007033);
                        throw;
                    }
                    
                }

                /// <summary>
                /// ID、日文名稱、日文敘述、威力、治癒量(%)、中文敘述、分數、系列一、系列二
                /// </summary>
                /// <returns></returns>
                public string[] GetArray()
                {
                    try
                    {
                        return Info.ToArray();
                    }
                    catch (Exception)
                    {
                        SystemAPI.Error(RError.E_0x00007032);
                        throw;
                    }
                }

                public string GetInfo(EBADataInfo EBDI)
                {
                    try
                    {
                        return Info[(int)EBDI].ToString().Replace("[", "").Replace("]", "");
                    }
                    catch (Exception)
                    {
                        SystemAPI.Error(RError.E_0x00007031);
                        throw;
                    }
                }

                public EDisplayStatus GetDisplayStatus()
                {
                    try
                    {
                        return ESP;
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00007032, e);
                        throw;
                    }
                }
            }
        }

        public class CLS
        {
            List<object> Result = new List<object>();
            string LSID;
            EDisplayStatus ESP;

            public CLS(SData Data)
            {
                try
                {
                    LSID = DataAPI.Search(Data.DTs.Source, CharaAPI.AwakedID(Data.CharaID), (int)ELSIDSecCol.ID, 0, Data.TitleP.Start[(int)DataTitle.LeaderSkillID], (int)ELSIDSecCol.CharaID);
                    DataRow[] Res2 = DataAPI.Search(LSID, Data.DTs.LSDict, 0, (int)ELSDictCode.ID);
                    if (Res2 != null)
                    {
                        Result = Res2[0].ItemArray.ToList();
                    } else
                    {
                        ESP = EDisplayStatus.ForceJP;
                        List<object> ItemArr = new List<object>();
                        DataRow[] LSInfoJP = DataAPI.Search(LSID, Data.DTs.Source, Data.TitleP.Start[(int)DataTitle.LeaderSkillEffect], Data.TitleP.End[(int)DataTitle.LeaderSkillEffect], (int)ELSEffectSecCol.ID);
                        
                        for (int i = 0; i <= Const.Column.LS_DICT; i++)
                        {
                            if (LSInfoJP != null)
                            {
                                switch (i)
                                {
                                    case (int)ELSDictCode.ID:
                                        ItemArr.Add(LSInfoJP[0][(int)ELSEffectSecCol.ID].ToString());
                                        break;
                                    case (int)ELSDictCode.EFFECT_CH:
                                    case (int)ELSDictCode.EFFECT_JP:
                                        ItemArr.Add(LSInfoJP[0][(int)ELSEffectSecCol.Effect].ToString());
                                        break;
                                    case (int)ELSDictCode.TARGET_CH:
                                    case (int)ELSDictCode.TARGET_JP:
                                        ItemArr.Add(LSInfoJP[0][(int)ELSEffectSecCol.Target].ToString());
                                        break;
                                    default:
                                        ItemArr.Add("");
                                        break;
                                }
                            } else
                            {
                                ItemArr.Add("");
                            }
                        }
                        Result.AddRange(ItemArr);
                    }
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007041, e);
                    throw;
                }
            }

            public string GetInfo(ELSDictCode ELDC)
            {
                try
                {
                    if (Result == null)
                    {
                        return "";
                    } else
                    {
                        if (ELDC == ELSDictCode.EFFECT_CH)
                        {
                            try
                            {
                                string str = "";
                                for (int i = (int)ELSDictCode.STR; i <= (int)ELSDictCode.SS; i++)
                                {
                                    if (!Extent.isEmptyString(Result[i].ToString()))
                                    {
                                        if (!Extent.isEmptyString(str))
                                        {
                                            str += "、";
                                        }
                                        str += EnumTranslator.LSDictCodeT((ELSDictCode)i) + "+" + Result[i].ToString() + "%";
                                    }
                                }
                                if (!Extent.isEmptyString(Result[(int)ELSDictCode.SPEC_EFFECT_CH].ToString()))
                                {
                                    if (!Extent.isEmptyString(str))
                                    {
                                        str += "、";
                                    }
                                    str += Result[(int)ELSDictCode.SPEC_EFFECT_CH].ToString();
                                }
                                if (Extent.isEmptyString(str))
                                {
                                    str = Result[(int)ELSDictCode.EFFECT_JP].ToString();
                                }
                                return str;
                            }
                            catch (Exception e)
                            {
                                SystemAPI.Error(RError.E_0x00007044, e);
                                throw;
                            }
                        }
                        else if (ELDC == ELSDictCode.EFFECT_SCORE)
                        {
                            try
                            {
                                LSScoring LSS = new LSScoring();
                                int Score = 0;
                                double[] MPCs = { LSS.MPC_STR, LSS.MPC_VIT, LSS.MPC_INT, LSS.MPC_MEN, LSS.MPC_HP, LSS.MPC_SS };

                                for (int i = (int)ELSDictCode.STR; i <= (int)ELSDictCode.SS; i++)
                                {
                                    if (!Extent.isEmptyString(Result[i].ToString()))
                                    {
                                        Score += Convert.ToInt32(Convert.ToDouble(Result[i]) * MPCs[i - (int)ELSDictCode.STR]);
                                    }
                                }
                                if (!Extent.isEmptyString(Result[(int)ELSDictCode.SPEC].ToString()))
                                {
                                    Score += Convert.ToInt32(Result[(int)ELSDictCode.SPEC]);
                                }

                                return Score.ToString();
                            }
                            catch (Exception e)
                            {
                                SystemAPI.Error(RError.E_0x00007046, e);
                                throw;
                            }
                        }
                        else
                        {
                            try
                            {
                                return Result[(int)ELDC].ToString();
                            }
                            catch (Exception e)
                            {
                                SystemAPI.Error(RError.E_0x00007043, e);
                                throw;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007042, e);
                    throw;
                }
            }

            public EDisplayStatus GetDisplayStatus()
            {
                try
                {
                    return ESP;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007037, e);
                    throw;
                }
            }

            /// <summary>
            /// LS ID、日文對象、中文對象、中文效果、對象分數、STR、VIT、INT、MEN、HP、SS、Spec
            /// </summary>
            /// <returns></returns>
            public string[] GetArray()
            {
                try
                {
                    return Result.Cast<string>().ToArray();
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x00007045, e);
                    throw;
                }
            }
        }
    }
}
