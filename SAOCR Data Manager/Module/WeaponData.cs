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
    class WeaponData
    {
        public WInfo Info;
        public WSharp Param;
        public bool CreateSucceed;
        WData Data;

        public WeaponData(WData WData)
        {
            try
            {
                Data.ID = WData.ID;

                WData.Data.Name = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponName], WData.TitleP.End[(int)DataTitle.WeaponName], (int)EWeaponNameSecCol.ID);
                WData.Data.Effect = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponEffect], WData.TitleP.End[(int)DataTitle.WeaponEffect], (int)EWeaponEffectSecCol.ID);
                WData.Data.ID = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponID], WData.TitleP.End[(int)DataTitle.WeaponID], (int)EWeaponIDSecCol.ID);
                WData.Data.Param = DataAPI.Search(WData.ID, WData.DTs.Source, WData.TitleP.Start[(int)DataTitle.WeaponParams], WData.TitleP.End[(int)DataTitle.WeaponParams], (int)EWeaponParamSecCol.ID);

                Info = new WInfo(WData);
                Param = new WSharp(WData);

                if (WData.Data.Name != null && WData.Data.ID != null && WData.Data.Param != null)
                {
                    CreateSucceed = true;
                }
                else
                {
                    CreateSucceed = false;
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
                            InfoList.Add(InfoList[3] + RWarning.W_0xC002B001.Replace("\\n", " "));
                        }
                    }
                    else
                    {
                        InfoList.Add(Const.EMPTY);
                        InfoList.Add(Const.EMPTY);
                    }
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

        public class WSharp
        {
            WData DT;

            public WSharp(WData WData)
            {
                try
                {
                    DT = WData;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B003, e);
                    throw;
                }
            }

            public int[] GetArray(ESharpness ESP)
            {
                try
                {
                    List<int> ParamList = new List<int>();

                    for (int j = 0; j < Const.Count.PARAM_CATEGORY; j++)
                    {
                        string X = DT.Data.Param[(int)ESP - 1][(int)EWeaponParamSecCol.STR_MAX + j].ToString();
                        ParamList.Add(Convert.ToInt32(DT.Data.Param[(int)ESP - 1][(int)EWeaponParamSecCol.STR_MAX + j]));
                    }

                    return ParamList.ToArray();
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0002B006, e);
                    throw;
                }
            }

            public class WParam
            {
                public WParam(WData WData)
                {
                    //塞資料成一個陣列
                }

                public int[] GetArray(int Level)
                {
                    return null;
                }

                public int[] GetArrayAtMax()
                {
                    return null;
                }

                public int GetParam(int Level)
                {
                    return 0;
                }
            }
        }

        public class WMaterial
        {

            public WMaterial(WData WData)
            {

            }
        }
    }
}
