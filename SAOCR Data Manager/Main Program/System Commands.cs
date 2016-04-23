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
using SAOCR_Data_Manager.Resources;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void Sys_Min_Click(object sender, EventArgs e)
        {
            SystemAPI.MinimizeProgram(this);
        }

        private void Sys_Close_Click(object sender, EventArgs e)
        {
            if (new MessageDialog(RMain.Warning_Close,
                RMain.Warning_CloseTitle,
                MessageBoxButtonStyle.OKCancel).ShowDialog(this) ==
                DialogResult.OK)
            {
                SystemAPI.CloseProgram(true);
            }
        }

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            SystemAPI.MoveWindow_MouseDown(Left, Top, e.X, e.Y, ref WndPos);
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Capture == true)
            {
                SystemAPI.MoveWindow_MouseMove(Left, Top, e.X, e.Y, ref WndPos, this);
            }
        }
    }
}
