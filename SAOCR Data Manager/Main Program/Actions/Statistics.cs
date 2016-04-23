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

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void SS_WeaponCalculate_ButtonClick(object sender, EventArgs e)
        {
            int AllCount = TitleP.End[(int)DataTitle.CharacterParams] - TitleP.Start[(int)DataTitle.CharacterParams];
            SS_CharaCalculate.ButtonText = RStatistics.Layout_Calculate + RStatistics.Message_Samples1 + AllCount + RStatistics.Message_Samples2;

            #region 武器使用比率
            InitializeList(InitItem.WeaponUsingRate);
            SS_CharaCalculate.ButtonText = RStatistics.Layout_Calculate;
            for (int i = 0; i < Const.Count.WEAPON_CATEGORY; i++)
            {
                ListViewItem LVI = new ListViewItem();
                LVI.SubItems.Add((i + 1).ToString());
                LVI.SubItems.Add(EnumTranslator.WeaponT((EWeapon)(i + 1)));
                int SingleCount = DataAPI.Search((i + 1).ToString(), DT.Source, TitleP.Start[(int)DataTitle.CharacterParams], TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.WEAPON).Length;
                LVI.SubItems.Add(((double)SingleCount / AllCount).ToString("0.00%"));
                SS_CharaWeaponUsingRate.Items.Add(LVI);
            }
            #endregion
        }
    }
}
