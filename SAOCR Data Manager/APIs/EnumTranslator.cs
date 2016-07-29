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
    public class EnumTranslator
    {
        public static string BASeriesTextT(BASeriesType series)
        {
            try
            {
                switch (series)
                {
                    case BASeriesType.Abnormal:
                        return RDictEnumString.BA_SeriesAbnormal;
                    case BASeriesType.Attack:
                        return RDictEnumString.BA_SeriesAttack;
                    case BASeriesType.Heal:
                        return RDictEnumString.BA_SeriesHeal;
                    case BASeriesType.Support:
                        return RDictEnumString.BA_SeriesSupport;
                    case BASeriesType.Null:
                        return RDictEnumString.BA_SeriesSupport;
                    default:
                        throw new ArgumentException(RError.E_0x0000300D);
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000300D, e);
                throw;
            }
        }
        
        public static BASeriesType BASeriesTextT(string series)
        {
            try
            {
                if (series.Contains(RDictEnumString.BA_SeriesAttack))
                {
                    return BASeriesType.Attack;
                }
                else if (series.Contains(RDictEnumString.BA_SeriesSupport))
                {
                    return BASeriesType.Support;
                }
                else if (series.Contains(RDictEnumString.BA_SeriesHeal))
                {
                    return BASeriesType.Heal;
                }
                else if (series.Contains(RDictEnumString.BA_SeriesAbnormal))
                {
                    return BASeriesType.Abnormal;
                }
                else
                {
                    return BASeriesType.Null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003005, e);
                throw;
            }
        }
        
        public static string AutoUpdateModeT(AutoUpdateMode AUM)
        {
            switch (AUM)
            {
                case AutoUpdateMode.CheckOnly:
                    return RDictEnumString.AU_ModeCheckOnly;
                case AutoUpdateMode.CheckAndDownload:
                    return RDictEnumString.AU_ModeCheckAndUpdate;
                case AutoUpdateMode.None:
                    return RDictEnumString.AU_ModeNone;
                default:
                    throw new ArgumentException(RError.Error_WrongAUMode);
            }
        }
        
        public static AutoUpdateMode AutoUpdateModeT(string AUM)
        {
            if (AUM.Contains(RDictEnumString.AU_ModeCheckOnly))
            {
                return AutoUpdateMode.CheckOnly;
            }
            else if (AUM.Contains(RDictEnumString.AU_ModeCheckAndUpdate))
            {
                return AutoUpdateMode.CheckAndDownload;
            }
            else if (AUM.Contains(RDictEnumString.AU_ModeNone))
            {
                return AutoUpdateMode.None;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongBASeries);
            }
        }
        
        public static string AutoUpdateChannelT(AutoUpdateChannel AUC)
        {
            switch (AUC)
            {
                case AutoUpdateChannel.Stable:
                    return RDictEnumString.AU_ChannelStable;
                case AutoUpdateChannel.Beta:
                    return RDictEnumString.AU_ChannelBeta;
                default:
                    throw new ArgumentException(RError.Error_WrongAUMode);
            }
        }
        
        public static AutoUpdateChannel AutoUpdateChannelT(string AUC)
        {
            if (AUC.Contains(RDictEnumString.AU_ChannelStable))
            {
                return AutoUpdateChannel.Stable;
            }
            else if (AUC.Contains(RDictEnumString.AU_ChannelBeta))
            {
                return AutoUpdateChannel.Beta;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongBASeries);
            }
        }
        
        public static string AUCheckStatusT(AUCheckStatus AUC)
        {
            switch (AUC)
            {
                case AUCheckStatus.CheckFailed:
                    return RDictEnumString.AU_StatusCheckFailed;
                case AUCheckStatus.HaveNotChecked:
                    return RDictEnumString.AU_StatusHaveNotChecked;
                case AUCheckStatus.IsLatest:
                    return RDictEnumString.AU_StatusIsLatest;
                case AUCheckStatus.NoConnection:
                    return RDictEnumString.AU_StatusNoConnection;
                case AUCheckStatus.UpdateAvailable:
                    return RDictEnumString.AU_StatusUpdateAvailable;
                default:
                    throw new ArgumentException(RError.Error_WrongAUMode);
            }
        }
        
        public static AUCheckStatus AUCheckStatusT(string AUC)
        {
            if (AUC.Contains(RDictEnumString.AU_StatusCheckFailed))
            {
                return AUCheckStatus.CheckFailed;
            }
            else if (AUC.Contains(RDictEnumString.AU_StatusHaveNotChecked))
            {
                return AUCheckStatus.HaveNotChecked;
            }
            else if (AUC.Contains(RDictEnumString.AU_StatusIsLatest))
            {
                return AUCheckStatus.IsLatest;
            }
            else if (AUC.Contains(RDictEnumString.AU_StatusNoConnection))
            {
                return AUCheckStatus.NoConnection;
            }
            else if (AUC.Contains(RDictEnumString.AU_StatusUpdateAvailable))
            {
                return AUCheckStatus.UpdateAvailable;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongBASeries);
            }
        }

        public static string SizeUnitT(SizeUnit SU, bool isText)
        {
            if (isText)
            {
                switch (SU)
                {
                    case SizeUnit.B:
                        return RDictEnumString.DL_BText;
                    case SizeUnit.KB:
                        return RDictEnumString.DL_KBText;
                    case SizeUnit.MB:
                        return RDictEnumString.DL_MBText;
                    default:
                        throw new ArgumentException(RError.Error_WrongSizeUnit);
                }
            } else
            {
                switch (SU)
                {
                    case SizeUnit.B:
                        return RDictEnumString.DL_B;
                    case SizeUnit.KB:
                        return RDictEnumString.DL_KB;
                    case SizeUnit.MB:
                        return RDictEnumString.DL_MB;
                    default:
                        throw new ArgumentException(RError.Error_WrongSizeUnit);
                }
            }
        }

        public static SizeUnit SizeUnitT(string SU, bool isText){
            if (SU.Contains(RDictEnumString.DL_B) || SU.Contains(RDictEnumString.DL_BText))
            {
                return SizeUnit.B;
            }
            else if (SU.Contains(RDictEnumString.DL_KB) || SU.Contains(RDictEnumString.DL_KBText))
            {
                return SizeUnit.KB;
            }
            else if (SU.Contains(RDictEnumString.DL_MB) || SU.Contains(RDictEnumString.DL_MBText))
            {
                return SizeUnit.MB;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongSizeUnit);
            }
        }

        public static string WeaponT(EWeapon EW)
        {
            switch (EW)
            {
                case EWeapon.Sword_1H:
                    return RDictEnumString.WP_1HSword;
                case EWeapon.Sword_Dual:
                    return RDictEnumString.WP_DualSword;
                case EWeapon.Axe_1H:
                    return RDictEnumString.WP_1HAxe;
                case EWeapon.Axe_2H:
                    return RDictEnumString.WP_2HAxe;
                case EWeapon.Mace_1H:
                    return RDictEnumString.WP_1HMace;
                case EWeapon.Mace_2H:
                    return RDictEnumString.WP_2HMace;
                case EWeapon.Bow:
                    return RDictEnumString.WP_Bow;
                case EWeapon.Gun:
                    return RDictEnumString.WP_Gun;
                case EWeapon.Dagger:
                    return RDictEnumString.WP_Dagger;
                case EWeapon.Rapier:
                    return RDictEnumString.WP_Rapier;
                case EWeapon.Sword_2H:
                    return RDictEnumString.WP_2HSword;
                case EWeapon.Katana:
                    return RDictEnumString.WP_Katana;
                default:
                    throw new ArgumentException(RError.Error_WrongWeaponCategory);
            }
        }

        public static EWeapon WeaponT(string EW)
        {
            if (EW.Contains(RDictEnumString.WP_1HSword))
            {
                return EWeapon.Sword_1H;
            }
            else if (EW.Contains(RDictEnumString.WP_DualSword))
            {
                return EWeapon.Sword_Dual;
            }
            else if (EW.Contains(RDictEnumString.WP_1HAxe))
            {
                return EWeapon.Axe_1H;
            }
            else if (EW.Contains(RDictEnumString.WP_2HAxe))
            {
                return EWeapon.Axe_2H;
            }
            else if (EW.Contains(RDictEnumString.WP_1HMace))
            {
                return EWeapon.Mace_1H;
            }
            else if (EW.Contains(RDictEnumString.WP_2HMace))
            {
                return EWeapon.Mace_2H;
            }
            else if (EW.Contains(RDictEnumString.WP_Bow))
            {
                return EWeapon.Bow;
            }
            else if (EW.Contains(RDictEnumString.WP_Gun))
            {
                return EWeapon.Gun;
            }
            else if (EW.Contains(RDictEnumString.WP_Dagger))
            {
                return EWeapon.Dagger;
            }
            else if (EW.Contains(RDictEnumString.WP_Rapier))
            {
                return EWeapon.Rapier;
            }
            else if (EW.Contains(RDictEnumString.WP_2HSword))
            {
                return EWeapon.Sword_2H;
            }
            else if (EW.Contains(RDictEnumString.WP_Katana))
            {
                return EWeapon.Katana;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongWeaponCategoryString);
            }
        }

        public static string ElementT(EElement EE)
        {
            try
            {
                switch (EE)
                {
                    case EElement.Fire:
                        return RDictEnumString.EL_Fire;
                    case EElement.Wind:
                        return RDictEnumString.EL_Wind;
                    case EElement.Water:
                        return RDictEnumString.EL_Water;
                    default:
                        throw new ArgumentException(RError.E_0x0000300A);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000300A, ex);
                throw;
            }
        }

        public static EElement ElementT(string EE)
        {
            try
            {
                if (EE.Contains(RDictEnumString.EL_Fire))
                {
                    return EElement.Fire;
                }
                else if (EE.Contains(RDictEnumString.EL_Wind))
                {
                    return EElement.Wind;
                }
                else if (EE.Contains(RDictEnumString.EL_Water))
                {
                    return EElement.Water;
                }
                else
                {
                    throw new ArgumentException(RError.E_0x0000300B);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000300B, ex);
                throw;
            }
        }

        public static string SceneT(EScene ES)
        {
            switch (ES)
            {
                case EScene.SAO:
                    return RDictEnumString.SC_SAO;
                case EScene.ALO:
                    return RDictEnumString.SC_ALO;
                case EScene.GGO:
                    return RDictEnumString.SC_GGO;
                case EScene.ALL:
                    return RDictEnumString.SC_ALL;
                default:
                    throw new ArgumentException(RError.Error_WrongScene);
            }
        }

        public static EScene SceneT(string ES)
        {
            if (ES.Contains(RDictEnumString.SC_SAO))
            {
                return EScene.SAO;
            }
            else if (ES.Contains(RDictEnumString.SC_ALO))
            {
                return EScene.ALO;
            }
            else if (ES.Contains(RDictEnumString.SC_GGO))
            {
                return EScene.GGO;
            }
            else if (ES.Contains(RDictEnumString.SC_ALL))
            {
                return EScene.ALL;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongSceneString);
            }
        }

        public static string SexT(ESex ESX)
        {
            switch (ESX)
            {
                case ESex.Male:
                    return RDictEnumString.SX_Male;
                case ESex.Female:
                    return RDictEnumString.SX_Female;
                default:
                    throw new ArgumentException(RError.Error_WrongSex);
            }
        }

        public static ESex SexT(string ESX)
        {
            if (ESX.Contains(RDictEnumString.SX_Male))
            {
                return ESex.Male;
            }
            else if (ESX.Contains(RDictEnumString.SX_Female))
            {
                return ESex.Female;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongSexString);
            }
        }

        public static string SharpnessT(ESharpness ESP)
        {
            switch (ESP)
            {
                case ESharpness.R1:
                    return RDictEnumString.SP_R1;
                case ESharpness.R2:
                    return RDictEnumString.SP_R2;
                case ESharpness.R3:
                    return RDictEnumString.SP_R3;
                case ESharpness.R4:
                    return RDictEnumString.SP_R4;
                default:
                    throw new ArgumentException(RError.Error_WrongSharpness);
            }
        }

        public static ESharpness SharpnessT(string ESP)
        {
            if (ESP.Contains(RDictEnumString.SP_R1))
            {
                return ESharpness.R1;
            }
            else if (ESP.Contains(RDictEnumString.SP_R2))
            {
                return ESharpness.R2;
            }
            else if (ESP.Contains(RDictEnumString.SP_R3))
            {
                return ESharpness.R3;
            }
            else if (ESP.Contains(RDictEnumString.SP_R4))
            {
                return ESharpness.R4;
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongSexString);
            }
        }

        public static string LSDictCodeT(ELSDictCode ELDC)
        {
            try
            {
                switch (ELDC)
                {
                    case ELSDictCode.STR:
                        return RDictEnumString.PR_STR;
                    case ELSDictCode.VIT:
                        return RDictEnumString.PR_VIT;
                    case ELSDictCode.INT:
                        return RDictEnumString.PR_INT;
                    case ELSDictCode.MEN:
                        return RDictEnumString.PR_MEN;
                    case ELSDictCode.HP:
                        return RDictEnumString.PR_HP;
                    case ELSDictCode.SS:
                        return RDictEnumString.PR_SS;
                    default:
                        SystemAPI.Warning(RWarning.W_0xC0003001);
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003001, e);
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
                        return RDictEnumString.PR_STR;
                    case EParamCategory.VIT:
                        return RDictEnumString.PR_VIT;
                    case EParamCategory.INT:
                        return RDictEnumString.PR_INT;
                    case EParamCategory.MEN:
                        return RDictEnumString.PR_MEN;
                    case EParamCategory.HP:
                        return RDictEnumString.PR_HP;
                    default:
                        SystemAPI.Error(RError.E_0x00003002);
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003002, e);
                throw;
            }
        }

        public static EParamCategory EParamCategoryT(string EPC)
        {
            try
            {
                if (EPC.Contains(RDictEnumString.PR_STR))
                {
                    return EParamCategory.STR;
                }
                else if (EPC.Contains(RDictEnumString.PR_VIT))
                {
                    return EParamCategory.VIT;
                }
                else if (EPC.Contains(RDictEnumString.PR_INT))
                {
                    return EParamCategory.INT;
                }
                else if (EPC.Contains(RDictEnumString.PR_MEN))
                {
                    return EParamCategory.MEN;
                }
                else if (EPC.Contains(RDictEnumString.PR_HP))
                {
                    return EParamCategory.HP;
                }
                else
                {
                    throw new ArgumentException(RError.E_0x0000300C);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000300C, ex);
                throw;
            }
        }

        public static string WeekDayT(DayOfWeek WOD)
        {
            try
            {
                switch (WOD)
                {
                    case DayOfWeek.Sunday:
                        return RDictEnumString.WD_Sun;
                    case DayOfWeek.Monday:
                        return RDictEnumString.WD_Mon;
                    case DayOfWeek.Tuesday:
                        return RDictEnumString.WD_Tue;
                    case DayOfWeek.Wednesday:
                        return RDictEnumString.WD_Wed;
                    case DayOfWeek.Thursday:
                        return RDictEnumString.WD_Thu;
                    case DayOfWeek.Friday:
                        return RDictEnumString.WD_Fri;
                    case DayOfWeek.Saturday:
                        return RDictEnumString.WD_Sat;
                    default:
                        SystemAPI.Warning(RWarning.W_0xC0003003);
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003003, e);
                throw;
            }
        }

        public static string LogCategoryT(ELogCategory ELC)
        {
            try
            {
                switch (ELC)
                {
                    case ELogCategory.Debug:
                        return RDictEnumString.LG_Debug;
                    case ELogCategory.Info:
                        return RDictEnumString.LG_Info;
                    case ELogCategory.Warning:
                        return RDictEnumString.LG_Warning;
                    case ELogCategory.Error:
                        return RDictEnumString.LG_Error;
                    case ELogCategory.Status:
                        return RDictEnumString.LG_Status;
                    default:
                        SystemAPI.Warning(RWarning.W_0xC0003004);
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003004, e);
                throw;
            }
        }

        public static string DLStatusT(DLStatus DLS)
        {
            try
            {
                switch (DLS)
                {
                    case DLStatus.NoConnection:
                        return RDictEnumString.DL_NoConnection;
                    case DLStatus.DownloadFailed:
                        return RDictEnumString.DL_DownloadFailed;
                    case DLStatus.Ready:
                        return RDictEnumString.DL_Ready;
                    case DLStatus.Downloading:
                        return RDictEnumString.DL_Downloading;
                    case DLStatus.DownloadSucceed:
                        return RDictEnumString.DL_DownloadSucceed;
                    case DLStatus.DownloadCancelled:
                        return RDictEnumString.DL_DownloadCancelled;
                    default:
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003006, e);
                throw;
            }
        }

        public static string MonsterTypeT(EMonsterType EMS)
        {
            try
            {
                switch (EMS)
                {
                    case EMonsterType.HalfMan:
                        return RDictEnumString.MS_HalfMan;
                    case EMonsterType.Bug:
                        return RDictEnumString.MS_Bug;
                    case EMonsterType.Plant:
                        return RDictEnumString.MS_Plant;
                    case EMonsterType.Animal:
                        return RDictEnumString.MS_Animal;
                    case EMonsterType.Phantom:
                        return RDictEnumString.MS_Phantom;
                    case EMonsterType.Ghost:
                        return RDictEnumString.MS_Ghost;
                    case EMonsterType.Human:
                        return RDictEnumString.MS_Human;
                    case EMonsterType.Dragon:
                        return RDictEnumString.MS_Dragon;
                    default:
                        return null;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00003007, e);
                throw;
            }
        }

        public static string DataRegT(EDataRegCategory DRC)
        {
            try
            {
                switch (DRC)
                {
                    case EDataRegCategory.BA:
                        return RDictEnumString.DREG_BA;
                    case EDataRegCategory.LS:
                        return RDictEnumString.DREG_LS;
                    case EDataRegCategory.CharaInfo:
                        return RDictEnumString.DREG_Info;
                    default:
                        throw new ArgumentException(RError.E_0x00003008);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00003008, ex);
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
                        return RDictEnumString.CT_Force;
                    case EParamType.Aegis:
                        return RDictEnumString.CT_Aegis;
                    case EParamType.Mebius:
                        return RDictEnumString.CT_Mebius;
                    case EParamType.Magius:
                        return RDictEnumString.CT_Magius;
                    case EParamType.Null:
                        return RDictEnumString.CT_Null;
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00003009, ex);
                throw;
            }
        }

        public static string AttachmentManageT(EAttachmentManageMode EAMM)
        {
            try
            {
                switch (EAMM)
                {
                    case EAttachmentManageMode.AlwaysDL:
                        return RDictEnumString.AM_AlwaysDL;
                    case EAttachmentManageMode.DelAfterClose:
                        return RDictEnumString.AM_DelAfterClose;
                    case EAttachmentManageMode.DLonce:
                        return RDictEnumString.AM_DLonce;
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00003001, ex);
                throw;
            }
        }

        public static string EquipTypeT(EEquipType EET)
        {
            switch (EET)
            {
                case EEquipType.Accessory:
                    return RDictEnumString.ET_Accessory;
                case EEquipType.Armor:
                    return RDictEnumString.ET_Armor;
                case EEquipType.Character:
                    return RDictEnumString.ET_Character;
                case EEquipType.Null:
                    return RDictEnumString.ET_Null;
                case EEquipType.Weapon:
                    return RDictEnumString.ET_Weapon;
                default:
                    return null;
            }
        }
    } 
}
