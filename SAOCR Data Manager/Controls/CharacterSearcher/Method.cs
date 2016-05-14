using SAOCR_Data_Manager.Forms;
using SAOCR_Data_Manager.Resources.Controls;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager.Controls
{
    public partial class CharacterSearcher : UserControl
    {
        public void FindCharacter(ref DataTable Source, Action<string> StatusFunc)
        {
            try
            {
                if (!(Source.Rows.Count > 0) || Source == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC0004003);
                    return;
                }
                if (Extent.isEmptyString(Keyword.Text) && Extent.isEmptyString(Rarity.Text) && Extent.isEmptyString(Series.Text))
                {
                    SystemAPI.Warning(RWarning.W_0xC0004002);
                    return;
                }
                InitializeResultList();
                DataRow[] SearchRes = DataAPI.Search(Keyword.Text, Source, 0, Source.Rows.Count, 1, Source.Columns.Count - 1);
                for (int i = 0; i < SearchRes.Length; i++)
                {
                    ListViewItem LVI = new ListViewItem();
                    if ((Extent.isEmptyString(Rarity.Text) ^ SearchRes[i][(int)ECharaMixCode.ID].ToString().Substring(6, 1) == Rarity.Text) &&
                        (Extent.isEmptyString(Series.Text) ^ SearchRes[i][(int)ECharaMixCode.ID].ToString().Substring(1, 3) == Series.Text))
                    {
                        DataRow[] CharaName = DataAPI.Search(SearchRes[i][(int)ECharaMixCode.ID].ToString(), Source, 0, (int)ECharaMixCode.ID);
                        string HEAD = CharaName[0][(int)ECharaMixCode.HEAD].ToString();
                        string NAME = CharaName[0][(int)ECharaMixCode.NAME].ToString();
                        LVI.SubItems.Add(SearchRes[i][(int)ECharaMixCode.ID].ToString());
                        LVI.SubItems.Add(HEAD + NAME);
                    }
                    if (LVI.SubItems.Count > 1)
                    {
                        Result.Items.Add(LVI);
                    }
                }
                ItemChanged?.Invoke(Result, EventArgs.Empty);
                StatusFunc(RCharaSearcher.Log_FindChara1 + Keyword.Text + RCharaSearcher.Log_FindChara2 + Rarity.Text + RCharaSearcher.Log_FindChara3 + Series.Text);
            }
            catch (NullReferenceException)
            {
                SystemAPI.Warning(RWarning.W_0xC0004005);
            }
            catch (SyntaxErrorException)
            {
                SystemAPI.Warning(RWarning.W_0xC0004001);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00004000, ex);
                throw;
            }
        }

        public void OpenSeriesTable(ref DataTable CharaSeries, Action<string> StatusFunc)
        {
            try
            {
                if (!(CharaSeries.Rows.Count > 0) || CharaSeries == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC0004004);
                    return;
                }
                DataViewF DVF = new DataViewF();
                string[] ColumnName = { Const.ColName.CHARA_ID, Const.ColName.CHARA_NAME_JP, Const.ColName.CHARA_NAME_EN, Const.ColName.CHARA_NAME_CH };
                DVF.ImportData(CharaSeries, ColumnName);
                if (DVF.ShowDialog(this) == DialogResult.OK)
                {
                    Series.Text = DVF.ReturnValue;
                    StatusFunc(RCharaSearcher.Log_FindSeriesCode + Series.Text);
                }
                DVF.Close();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00004001, ex);
                throw;
            }
        }
    }
}
