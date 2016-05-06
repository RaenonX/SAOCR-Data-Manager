using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources.Controls;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Forms;

namespace SAOCR_Data_Manager
{
    public partial class LsDisplay : UserControl
    {
        private void LSRegister(object sender, EventArgs e)
        {
            try
            {
                if (!LSDataImported)
                {
                    return;
                }

                new DataRegister(EDataRegCategory.LS, Const.Path.LS_DICT, CDT.LS.GetArray()).ShowDialog();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002D000, ex);
                throw;
            }
        }
    }
}
