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
            try
            {
                CharaExp CE = new CharaExp();
                DataTable Data = DT.ExpMain;

                #region Check Section
                if (Data == null || Data.Rows.Count <= 0)
                {
                    SystemAPI.Warning(RWarning.W_0xC0006005);
                    return;
                }

                if (Extent.isEmptyString(EC_MainLvBefore.Text))
                {
                    EC_CharaLvBeforeText.ForeColor = Color.FromArgb((int)EForeColor.Red);
                    SystemAPI.Warning(RWarning.W_0xC0006002);
                    return;
                } else
                {
                    EC_CharaLvBeforeText.ForeColor = Color.FromArgb((int)EForeColor.White);
                    CE.Before.Lv = Convert.ToInt32(EC_MainLvBefore.Text);
                }

                if (Extent.isEmptyString(EC_MainLvAfter.Text))
                {
                    EC_CharaLvAfterText.ForeColor = Color.FromArgb((int)EForeColor.Red);
                    SystemAPI.Warning(RWarning.W_0xC0006003);
                    return;
                }
                else
                {
                    EC_CharaLvAfterText.ForeColor = Color.FromArgb((int)EForeColor.White);
                    CE.After.Lv = Convert.ToInt32(EC_MainLvAfter.Text);
                }
                #endregion

                #region Verify and Calculate Exp Needed
                CE.Before.SpecifiedLv = DataAPI.Search(CE.Before.Lv.ToString(), Data, 0, Data.Rows.Count, (int)EMainExpSecCol.LEVEL, true);
                CE.Before.AtNextLv = DataAPI.Search((CE.Before.Lv + 1).ToString(), Data, 0, Data.Rows.Count, (int)EMainExpSecCol.LEVEL, true);
                CE.After.SpecifiedLv = DataAPI.Search(CE.After.Lv.ToString(), Data, 0, Data.Rows.Count, (int)EMainExpSecCol.LEVEL, true);
                CE.After.AtNextLv = DataAPI.Search((CE.After.Lv + 1).ToString(), Data, 0, Data.Rows.Count, (int)EMainExpSecCol.LEVEL, true);

                if (CE.Before.SpecifiedLv == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC0006006);
                    EC_MainExpNeed.BreezeStop();
                    EC_MainRarityBefore.BreezeStop();
                    EC_MainRarityAfter.BreezeStop();
                    return;
                }

                if (CE.Before.AtNextLv == null)
                {
                    CE.Before.Sum += Convert.ToInt32(CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]);
                    CE.Before.ExpLeft = 0;
                } else
                {
                    CE.Before.Sum += Convert.ToInt32(CE.Before.AtNextLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]);

                    if (!Extent.isEmptyString(EC_MainExpBefore.Text))
                    {
                        CE.Before.ExpLeft = Convert.ToInt32(EC_MainExpBefore.Text);
                    } else
                    {
                        CE.Before.ExpLeft = Convert.ToInt32(CE.Before.AtNextLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]) - Convert.ToInt32(CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]);
                    }
                }

                EC_MainExpBefore.Text = CE.Before.ExpLeft.ToString();
                CE.Before.Sum -= CE.Before.ExpLeft;
                
                if (CE.After.SpecifiedLv == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC0006006);
                    EC_MainExpNeed.BreezeStop();
                    EC_MainRarityBefore.BreezeStop();
                    EC_MainRarityAfter.BreezeStop();
                    return;
                }

                if (CE.After.AtNextLv == null)
                {
                    CE.After.Sum += Convert.ToInt32(CE.After.SpecifiedLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]);
                    CE.After.ExpLeft = 0;
                }
                else
                {
                    CE.After.Sum += Convert.ToInt32(CE.After.AtNextLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]);

                    if (!Extent.isEmptyString(EC_MainExpAfter.Text))
                    {
                        CE.After.ExpLeft = Convert.ToInt32(EC_MainExpAfter.Text);
                    }
                    else
                    {
                        CE.After.ExpLeft = Convert.ToInt32(CE.After.AtNextLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]) - Convert.ToInt32(CE.After.SpecifiedLv[0][(int)EMainExpSecCol.SUM_EXP_REQUIRED]);
                    }
                }

                EC_MainExpAfter.Text = CE.After.ExpLeft.ToString();
                CE.After.Sum -= CE.After.ExpLeft;
                
                if (CE.Before.Lv > CE.After.Lv)
                {
                    SystemAPI.Warning(RWarning.W_0xC0006004);
                    EC_MainExpNeed.BreezeStop();
                    EC_MainRarityBefore.BreezeStop();
                    EC_MainRarityAfter.BreezeStop();
                    return;
                }

                int Result = CE.After.Sum - CE.Before.Sum;
                EC_MainExpNeed.LText = Result.ToString();
                EC_MainExpNeed.BreezeBegin();
                #endregion

                #region Display Params
                EC_MainRarityBefore.LText = "★" + CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.RARITY].ToString();
                EC_MainRarityBefore.ColorEnd = SFColorTrans.RarityT(CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.RARITY].ToString());
                EC_MainRarityBefore.BreezeBegin();

                EC_MainCostBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.COST].ToString();
                EC_MainHPBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.HP].ToString();
                EC_MainSTRBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.STR].ToString();
                EC_MainVITBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.VIT].ToString();
                EC_MainINTBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.INT].ToString();
                EC_MainMENBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.MEN].ToString();
                EC_MainSSBefore.Text = CE.Before.SpecifiedLv[0][(int)EMainExpSecCol.SS].ToString();

                EC_MainRarityAfter.LText = "★" + CE.After.SpecifiedLv[0][(int)EMainExpSecCol.RARITY].ToString();
                EC_MainRarityAfter.ColorEnd = SFColorTrans.RarityT(CE.After.SpecifiedLv[0][(int)EMainExpSecCol.RARITY].ToString());
                EC_MainRarityAfter.BreezeBegin();

                EC_MainCostAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.COST].ToString();
                EC_MainHPAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.HP].ToString();
                EC_MainSTRAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.STR].ToString();
                EC_MainVITAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.VIT].ToString();
                EC_MainINTAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.INT].ToString();
                EC_MainMENAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.MEN].ToString();
                EC_MainSSAfter.Text = CE.After.SpecifiedLv[0][(int)EMainExpSecCol.SS].ToString();
                #endregion
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00006000, ex);
                throw;
            }
        }

        private void EC_CharaCalc_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00006001, ex);
                throw;
            }
        }

        private void EC_MainChara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EC_MainCalc_Click(sender, e);
            }
        }
    }
}
