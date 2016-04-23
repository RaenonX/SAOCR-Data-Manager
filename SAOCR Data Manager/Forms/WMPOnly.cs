using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public partial class UI_WMPOnly : Form
    {
        public bool isGateOpen = true;

        public UI_WMPOnly()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            isGateOpen = true;
            Timer.Stop();
            Timer.Enabled = false;
        }
    }
}
