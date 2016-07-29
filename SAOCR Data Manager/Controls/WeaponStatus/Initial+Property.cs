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
        List<Label[]> LBL = new List<Label[]>();

        public WeaponStatus()
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
                Parameters.Paint += SystemAPI.DrawBorderWhite;

                WEffect.Marquee();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00001001, e);
                throw;
            }
        }

        public void InitializeFields()
        {
            LBL.Add(new Label[] { S1 , V1 , I1 , M1 });
            LBL.Add(new Label[] { S2 , V2 , I2 , M2 });
            LBL.Add(new Label[] { S3 , V3 , I3 , M3 });
            LBL.Add(new Label[] { S4 , V4 , I4 , M4 });
            LBL.Add(new Label[] { S5 , V5 , I5 , M5 });
            LBL.Add(new Label[] { S6 , V6 , I6 , M6 });
            LBL.Add(new Label[] { S7 , V7 , I7 , M7 });
            LBL.Add(new Label[] { S8 , V8 , I8 , M8 });
            LBL.Add(new Label[] { S9 , V9 , I9 , M9 });
            LBL.Add(new Label[] { S10, V10, I10, M10 });
            LBL.Add(new Label[] { S11, V11, I11, M11 });
            LBL.Add(new Label[] { S12, V12, I12, M12 });
            LBL.Add(new Label[] { S13, V13, I13, M13 });
            LBL.Add(new Label[] { S14, V14, I14, M14 });
            LBL.Add(new Label[] { S15, V15, I15, M15 });
        }
    }
}
