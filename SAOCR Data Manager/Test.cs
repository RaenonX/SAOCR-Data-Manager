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
using System.Reflection;
using System.Threading;
using System.Text.RegularExpressions;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Module;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        public void Test()
        {
            WData WDT = new WData();
            WDT.ID = "101000730";
            WDT.DTs = DT;
            WDT.TitleP = TitleP;

            WeaponData WD = new WeaponData(WDT);
            Debug.Print(WD.Sharp.GetParamArray(ESharpness.R4)[0].ToString());
        }
    }
}
