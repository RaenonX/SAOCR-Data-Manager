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
        public WeaponStatus()
        {
            try
            {
                InitializeComponent();
                InitializeEventHandler();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00001000, e);
                throw;
            }
        }

        public void InitializeEventHandler()
        {
            try
            {
                Parameters.Paint += SystemAPI.DrawBorderWhite;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00001001, e);
                throw;
            }
        }
    }
}
