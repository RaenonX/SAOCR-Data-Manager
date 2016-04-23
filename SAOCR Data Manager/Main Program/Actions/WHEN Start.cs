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
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                SetAllSEMute(true);
                Initialize();

                MN_Title.Text = RMain.AtPage_ProgramName + " - " + RMain.AtPage_HomePage;
                Status(RStatus.Result_Standby);
                Application.DoEvents();

                if (UC.State_AutoLoad)
                {
                    AutoLoadItems();
                }
                if (DT.Source == null)
                {
                    Button_SE_[] FunctionButtons = { HM_ToCharacterData, HM_ToEquipmentData, HM_ToCsvTable };
                    foreach (Button_SE_ item in FunctionButtons)
                    {
                        item.ButtonEnabled = false;
                    }
                }
                InitializeAtLoadCompleted();
                SetAllSEMute(false);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00021001, ex);
                throw;
            }
        }

        public void AutoLoadItems()
        {
            try
            {
                if (!LoadCSVData())
                {
                    SystemAPI.SEWarning();
                    Status(RStatus.Result_DataCSVPreloadInCompleted, true);
                    return;
                }
                DT.CharaMix = DataAPI.MergeWithKey(DT.CharaDict, DT.CharaDim, (int)ECharaDictCode.ID, (int)ECharaDimCode.ID);
                ST_ReadTtile_Click(this, EventArgs.Empty);

                if (!LoadBADictionary())
                {
                    SystemAPI.SEWarning();
                    Status(RStatus.Result_DataBADictPreloadInCompleted, true);
                    return;
                }
                Status(RStatus.Result_DataPreloadCompleted, true);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00021002, e);
                throw;
            }
        }

        private void SetAllSEMute(bool Mute)
        {
            try
            {
                WMPO.Beep.settings.mute = Mute;
                WMPO.Warning.settings.mute = Mute;
                WMPO.Message.settings.mute = Mute;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00021003, e);
                throw;
            }
        }
    }
}
