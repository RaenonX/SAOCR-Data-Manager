using SAOCR_Data_Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Forms;
using SAOCR_Data_Manager.APIs;
using System.IO;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void EC_MainCalc_Click(object sender, EventArgs e)
        {
            DataTable Data = DataAPI.Separate(DT.Source, TitleP.Start[(int)DataTitle.MainCharacterParams], TitleP.End[(int)DataTitle.MainCharacterParams]);
        }

        private void EC_CharaCalc_Click(object sender, EventArgs e)
        {

        }
    }
}
