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
    public partial class MaterialEstimater : UserControl
    {
        public void OutputWeaponData(WeaponData WData, ESharpness ES)
        {
            try
            {
               
            } 
            catch (Exception)
            {
                SystemAPI.Error(RError.E_0x00001002 + WData.Data.ID + "、" + EnumTranslator.SharpnessT(ES));
            }
        }
    }
}
