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

namespace SAOCR_Data_Manager
{
    public partial class LsDisplay : UserControl
    {
        public void DisplayCharacterLeaderSkill(CharaData Data)
        {
            try
            {
                CDT = Data;
                LSDataImported = false;
                Effect.MarqueeText = Data.LS.GetInfo(ELSDictCode.EFFECT_CH);
                Target.MarqueeText = Data.LS.GetInfo(ELSDictCode.TARGET_CH);
                EffectScore.Text = Data.LS.GetInfo(ELSDictCode.EFFECT_SCORE);
                TargetScore.Text = Data.LS.GetInfo(ELSDictCode.TARGET_SCORE);
                if (Data.LS.GetDisplayStatus() == EDisplayStatus.ForceJP)
                {
                    Effect.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                    Target.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                } else
                {
                    Effect.BackColor = Color.FromArgb((int)EBackColorAlpha.Grey70);
                    Target.BackColor = Color.FromArgb((int)EBackColorAlpha.Grey70);
                }
                LSDataImported = true;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002D001, ex);
                LSDataImported = false;
                throw;
            }
        }

        /// <returns>對象、對象分數、效果、效果分數、角色ID</returns>
        public string[] OutputForHTML()
        {
            string[] L = {
                Target.MarqueeText,
                TargetScore.Text,
                Effect.MarqueeText,
                EffectScore.Text,
                CDT.Data.CharaID
            };
            return L;
        }
    }
}
