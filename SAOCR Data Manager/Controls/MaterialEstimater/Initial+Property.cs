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
        public MaterialEstimater()
        {
            try
            {
                InitializeComponent();
                InitializeEventHandler();
                InitializeFields();
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
               
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00001001, e);
                throw;
            }
        }

        public void InitializeFields()
        {
           
        }
    }
}
