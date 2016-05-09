using Microsoft.VisualBasic.Devices;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public class SFColorTrans
    {
        public static string BASeriesTextT(BASeriesType series)
        {
            try
            {
                switch (series)
                {
                    case BASeriesType.Abnormal:
                        return RDictColor.Blue;
                    case BASeriesType.Attack:
                        return RDictColor.Red;
                    case BASeriesType.Heal:
                        return RDictColor.Green;
                    case BASeriesType.Support:
                        return RDictColor.Orange;
                    case BASeriesType.Null:
                        return RDictColor.Grey70;
                    default:
                        throw new ArgumentException(RError.E_0x0002E001);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002E001, ex);
                throw;
            }
        }

        public static string ElementT(EElement EE)
        {
            try
            {
                switch (EE)
                {
                    case EElement.Fire:
                        return RDictColor.Red;
                    case EElement.Wind:
                        return RDictColor.Green;
                    case EElement.Water:
                        return RDictColor.Blue;
                    default:
                        throw new ArgumentException(RError.E_0x0002E000);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002E000, ex);
                throw;
            }
        }

        public static string SceneT(EScene ES)
        {
            try
            {
                switch (ES)
                {
                    case EScene.SAO:
                        return RDictColor.Blue;
                    case EScene.ALO:
                        return RDictColor.Green;
                    case EScene.GGO:
                        return RDictColor.Purple;
                    case EScene.ALL:
                        return RDictColor.Grey70;
                    default:
                        throw new ArgumentException(RError.E_0x0002E002);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002E002, ex);
                throw;
            }
        }

        public static string CharaTypeT(EParamType EPT)
        {
            try
            {
                switch (EPT)
                {
                    case EParamType.Force:
                        return RDictColor.Red;
                    case EParamType.Aegis:
                        return RDictColor.Blue;
                    case EParamType.Mebius:
                        return RDictColor.Green;
                    case EParamType.Magius:
                        return RDictColor.Purple;
                    case EParamType.Null:
                        return RDictColor.Grey70;
                    default:
                        throw new ArgumentException(RError.E_0x0002E003);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002E003, ex);
                throw;
            }
        }

        public static string EParamCategoryT(EParamCategory EPC)
        {
            try
            {
                switch (EPC)
                {
                    case EParamCategory.STR:
                        return RDictColor.Red;
                    case EParamCategory.VIT:
                        return RDictColor.Blue;
                    case EParamCategory.INT:
                        return RDictColor.Green;
                    case EParamCategory.MEN:
                        return RDictColor.Purple;
                    default:
                        SystemAPI.Error(RError.E_0x0002E004);
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002E004, e);
                throw;
            }
        }

        public static string SpecColTranslate(EBackColorAlpha EBCA)
        {
            try
            {
                switch (EBCA)
                {
                    case EBackColorAlpha.Red:
                        return RDictColor.Red;
                    case EBackColorAlpha.Grey70:
                        return RDictColor.Grey70;
                    default:
                        SystemAPI.Error(RError.E_0x0002E005);
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0002E005, e);
                throw;
            }
        }
    }
}
