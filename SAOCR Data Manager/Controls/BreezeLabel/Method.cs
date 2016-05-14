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

namespace SAOCR_Data_Manager.Controls
{
    public partial class BreezeLabel : UserControl
    {
        public void BreezeBegin()
        {
            try
            {
                FMain.BreezeLabel.Enabled = true;
                FMain.BreezeLabel.Start();

                CConfig.To2ndColor = true;
                if (ColorBegin.ToArgb() == 0)
                {
                    CConfig.Begin = Color.FromArgb((int)EBackColorBreeze.Grey70);
                }
                if (CConfig.End.ToArgb() == 0)
                {
                    CConfig.End = Color.FromArgb((int)EBackColorBreeze.Yellow);
                }
                CConfig.CurColor = CConfig.Begin.ToArgb();

                InitializeParameters();

                CTimer.Gate = true;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001700F, e);
                throw;
            }
            
        }

        public void BreezeStop()
        {
            try
            {
                CTimer.Gate = false;
                CConfig.CurColor = CConfig.Begin.ToArgb();
                label.BackColor = Color.FromArgb(CConfig.CurColor);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00017016, e);
                throw;
            }
        }

        public void BreezeRestart()
        {
            try
            {
                CConfig.CurColor = CConfig.Begin.ToArgb();
                CConfig.To2ndColor = true;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001701E, e);
                throw;
            }
        }
    }
}
