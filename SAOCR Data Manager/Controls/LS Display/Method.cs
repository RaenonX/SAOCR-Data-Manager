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

namespace SAOCR_Data_Manager
{
    public partial class LsDisplay : UserControl
    {
        public void DisplayCharacterLeaderSkill(CharaData Data)
        {
            Effect.MarqueeText = Data.LS.GetInfo(ELSDictCode.EFFECT_CH);
            Target.MarqueeText = Data.LS.GetInfo(ELSDictCode.TARGET_CH);
            EffectScore.Text = Data.LS.GetInfo(ELSDictCode.EFFECT_SCORE);
            TargetScore.Text = Data.LS.GetInfo(ELSDictCode.TARGET_SCORE);
        }
    }
}
