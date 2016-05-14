using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Controls;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager.Controls
{
    public partial class CharacterSearcher : UserControl
    {
        public event EventHandler ItemSelected, SearchClicked, SeriesTableClicked, ItemChanged;
        Size OrgSize;

        public CharacterSearcher()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();
                InitializeResultList();

                OrgSize = Size;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000400C, ex);
                throw;
            }
        }

        private void InitializeUIText()
        {
            try
            {
                GroupBox.Text = RCharaSearcher.Layout_SearchChara;
                KeywordText.Text = RCharaSearcher.Layout_Keyword;
                Search.ButtonText = RCharaSearcher.Layout_Search;
                RarityText.Text = RCharaSearcher.Layout_Rarity;
                SeriesText.Text = RCharaSearcher.Layout_Series;
                SeriesTable.Text = RCharaSearcher.Layout_Series + RCharaSearcher.Layout_CodeTable;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00004009, ex);
                throw;
            }
        }

        private void InitializeEventHandler()
        {
            try
            {
                Keyword.KeyPress += SearchBox_KeyPress;
                Keyword.KeyPress += Extent.VerifyLetterDigitOnly;
                Search.ButtonClick += (sender, e) => SearchClicked?.Invoke(sender, e);
                Result.DoubleClick += (sender, e) => ItemSelected?.Invoke(sender, e);
                Rarity.KeyPress += SearchBox_KeyPress;
                Rarity.KeyPress += Extent.VerifyTextIsNum;
                Series.KeyPress += SearchBox_KeyPress;
                Series.KeyPress += Extent.VerifyTextIsNum;
                SeriesTable.LinkClicked += (sender, e) => SeriesTableClicked?.Invoke(sender, e);

                SizeChanged += CharacterSearcher_SizeChanged;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000400A, ex);
                throw;
            }
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchClicked?.Invoke(sender, e);
            }
        }

        private void CharacterSearcher_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                Size = OrgSize;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00004008, ex);
                throw;
            }
        }

        private void InitializeResultList()
        {
            try
            {
                Result.Clear();
                Result.Columns.Add(Const.ColName.N_A, 0);
                Result.Columns.Add(Const.ColName.CHARA_ID, 70, HorizontalAlignment.Left);
                Result.Columns.Add(Const.ColName.CHARA_NAME, 195, HorizontalAlignment.Left);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000400B, ex);
                throw;
            }
        }
    }
}
