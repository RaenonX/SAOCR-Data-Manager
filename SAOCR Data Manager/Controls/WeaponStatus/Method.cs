using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager.Module
{
    public partial class WeaponStatus : UserControl
    {
        public void OutputWeaponData(WeaponData WData, ESharpness ES)
        {
            try
            {
                WName.Text = WData.Info.GetWeaponInfo(EWInfoCategory.NAME);
                WRarity.Text = WData.Info.GetWeaponInfo(EWInfoCategory.RARITY);
                WID.Text = WData.Info.GetWeaponInfo(EWInfoCategory.ID);
                WType.Text = WData.Info.GetWeaponInfo(EWInfoCategory.CATEGORY);

                WEffect.MarqueeText = WData.Info.GetWeaponInfo(EWInfoCategory.EFFECT_CH);

                for (int i = 1; i <= Const.Count.WEAPON_MAX_LEVEL; i++)
                {
                    int[] PRM = WData.Param.GetArray(i, ES);
                    for(int j = 0; j < Const.Count.PARAM_CATEGORY; j++)
                    {
                        LBL[i - 1][j].Text = PRM[j].ToString();
                    }
                }
            } 
            catch (Exception)
            {
                SystemAPI.Error(RError.E_0x00001002 + WData.Data.ID + "、" + EnumTranslator.SharpnessT(ES));
            }
        }

        public void Destroy()
        {
            Dispose(true);
        }

        public void Create()
        {
            CreateControl();
            CreateGraphics();
        }
    }
}
