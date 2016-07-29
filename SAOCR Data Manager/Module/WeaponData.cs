using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOCR_Data_Manager.Module
{
    public class WeaponData
    {
        public WInfo Info;
        public WParam Param;
        public bool CreateSucceed;
        public WData Data;

        public WeaponData(WData WData)
        {
            try
            {
                if (WData.ID.Length != 9)
                {
                    SystemAPI.Warning(RWarning.W_0xC002B003);
                    CreateSucceed = false;
                    return;
                }
                Data.ID = WData.ID;

                WData.Data.Name = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponName], WData.TitleP.End[(int)DataTitle.WeaponName], (int)EWeaponNameSecCol.ID);
                WData.Data.Effect = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponEffect], WData.TitleP.End[(int)DataTitle.WeaponEffect], (int)EWeaponEffectSecCol.ID);
                WData.Data.ID = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponID], WData.TitleP.End[(int)DataTitle.WeaponID], (int)EWeaponIDSecCol.ID);
                WData.Data.Param = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponParams], WData.TitleP.End[(int)DataTitle.WeaponParams], (int)EWeaponParamSecCol.ID);

                Info = new WInfo(WData);
                Param = new WParam(WData);

                if (WData.Data.Name != null && WData.Data.ID != null && WData.Data.Param != null)
                {
                    CreateSucceed = true;
                }
                else
                {
                    CreateSucceed = false;
                    return;
                }
            } 
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002B003, e);
                throw;
            }
        }

        public class WInfo
        {
            WData Data;
            List<string> InfoList = new List<string>();

            public WInfo(WData WData)
            {
                try
                {
                    Data = WData;

                    InfoList.Add(Data.ID);
                    InfoList.Add(WData.Data.Name[0][(int)EWeaponNameSecCol.NAME].ToString());
                    InfoList.Add(Data.ID.Substring(7, 1));

                    string JPRes = "";
                    if (WData.Data.Effect != null)
                    {
                        JPRes = WData.Data.Effect[0][(int)EWeaponEffectSecCol.DESCRIPTION].ToString();
                    }
                    
                    if (!Extent.isEmptyString(JPRes))
                    {
                        InfoList.Add(JPRes);
                        string CHRes = DataAPI.Search(Data.DTs.WeaponEff, InfoList[(int)EWInfoCategory.EFFECT_JP], (int)EWeaponEffDictCode.DESCRIPTION_CH, 0, (int)EWeaponEffDictCode.DESCRIPTION_JP);
                        if (!Extent.isEmptyString(CHRes))
                        {
                            InfoList.Add(CHRes);
                        }
                        else
                        {
                            InfoList.Add(InfoList[3] + " - " + RWarning.W_0xC002B001.Replace("\\n", " "));
                        }
                    }
                    else
                    {
                        InfoList.Add(Const.EMPTY);
                        InfoList.Add(Const.EMPTY);
                    }

                    InfoList.Add(EnumTranslator.WeaponT((EWeapon)Convert.ToInt32(Data.ID.Substring(1, 2))));
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B004, e);
                    throw;
                }
            }
            
            public string GetWeaponInfo(EWInfoCategory EWC)
            {
                try
                {
                    return InfoList[(int)EWC];
                } 
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B001, e);
                    throw;
                }
            }

            /// <summary>
            /// 回傳陣列。
            /// </summary>
            /// <returns>ID、名稱、稀有度、日文效果、中文效果</returns>
            public string[] GetWeaponInfoArray()
            {
                try
                {
                    return InfoList.ToArray();
                } 
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B002, e);
                    throw;
                }
    }
        }

        public class WParam
        {
            WData DT;

            List<int> PRM_S = new List<int>();
            List<int> PRM_V = new List<int>();
            List<int> PRM_I = new List<int>();
            List<int> PRM_M = new List<int>();

            public WParam(WData WData)
            {
                try
                {
                    DT = WData;
                    List<double> MAX = new List<double>();
                    List<double> MIN = new List<double>();
                    DataRow[] MAXRes = DT.Data.Param;
                    DataRow[] MINRes = DT.Data.Name;
                    for (int j = 0; j < Const.Count.WEAPON_SHARPNESS; j++)
                    {
                        for (int i = (int)EWeaponParamSecCol.STR_MAX; i <= (int)EWeaponParamSecCol.MEN_MAX; i++)
                        {
                            if (MAXRes == null)
                            {
                                MAX.Add(0);
                            }
                            else
                            {
                                try
                                {
                                    MAX.Add(Convert.ToDouble(MAXRes[j][i]));
                                } catch (IndexOutOfRangeException)
                                {
                                    MAX.Add(0);
                                }
                            }
                        }
                    }
                    for (int i = (int)EWeaponNameSecCol.STR_MIN; i <= (int)EWeaponNameSecCol.MEN_MIN; i++)
                    {
                        if (MINRes == null)
                        {
                            MIN.Add(0);
                        }
                        else
                        {
                            MIN.Add(Convert.ToDouble(MINRes[0][i]));
                        }
                    }

                    for (int j = 0; j < Const.Count.WEAPON_SHARPNESS; j++)
                    {
                        for (int Lv = 0; Lv < Const.Count.WEAPON_MAX_LEVEL; Lv++)
                        {
                            double LvP = Lv / ((double)Const.Count.WEAPON_MAX_LEVEL - 1);

                            double SumP = MIN[(int)EParamCategory.STR - 1] + (MAX[j * 4 + (int)EParamCategory.STR - 1] - MIN[(int)EParamCategory.STR - 1]) * LvP;
                            PRM_S.Add(Convert.ToInt32(SumP));

                            SumP = MIN[(int)EParamCategory.VIT - 1] + (MAX[j * 4 + (int)EParamCategory.VIT - 1] - MIN[(int)EParamCategory.VIT - 1]) * LvP;
                            PRM_V.Add(Convert.ToInt32(SumP));

                            SumP = MIN[(int)EParamCategory.INT - 1] + (MAX[j * 4 + (int)EParamCategory.INT - 1] - MIN[(int)EParamCategory.INT - 1]) * LvP;
                            PRM_I.Add(Convert.ToInt32(SumP));

                            SumP = MIN[(int)EParamCategory.MEN - 1] + (MAX[j * 4 + (int)EParamCategory.MEN - 1] - MIN[(int)EParamCategory.MEN - 1]) * LvP;
                            PRM_M.Add(Convert.ToInt32(SumP));
                        }
                    }
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B007, e);
                    throw;
                }
            }

            public int[] GetArray(int Level, ESharpness ES)
            {
                try
                {
                    List<int> Ret = new List<int>();
                    int Pos = (int)ES * Const.Count.WEAPON_MAX_LEVEL + Level - 1;

                    Ret.Add(PRM_S[Pos]);
                    Ret.Add(PRM_V[Pos]);
                    Ret.Add(PRM_I[Pos]);
                    Ret.Add(PRM_M[Pos]);

                    return Ret.ToArray();
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B008 + Level.ToString() + "、" + DT.ID + "、" + (int)ES, e);
                    throw;
                }
            }
        }
    }
}
