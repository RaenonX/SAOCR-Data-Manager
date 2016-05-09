using SAOCR_Data_Manager.Resources;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager.Forms
{
    public partial class DataViewF : Form
    {
        WindowPosition WndPos = new WindowPosition();
        DataTable Source;
        public string ReturnValue;

        public DataViewF()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001B001, e);
                throw;
            }
        }

        public void InitializeUIText()
        {
            try
            {
                Sys_Close.ButtonText = RMain.Layout_CloseProg;
                Sys_Min.ButtonText = RMain.Layout_Minimum;

                KeywordText.Text = RDataView.Layout_Keyword;
                KeywordGo.ButtonText = RDataView.Layout_KeywordGo;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001B002, e);
                throw;
            }
           
        }

        public void InitializeEventHandler()
        {
            try
            {
                Sys_Close.ButtonClick += new EventHandler((sender, e) => SystemAPI.CloseWindow(this));
                Sys_Min.ButtonClick += new EventHandler((sender, e) => SystemAPI.MinimizeProgram(this));
                Title.MouseMove += new MouseEventHandler(MoveWindow_MouseMove);
                Title.MouseDown += new MouseEventHandler(MoveWindow_MouseDown);

                Border.Paint += SystemAPI.DrawBorderCoral;
                Keyword.KeyPress += Keyword_KeyPress;
                Keyword.KeyPress += Extent.VerifyLetterDigitOnly;
                KeywordGo.ButtonClick += KeywordGo_ButtonClick;
                KeywordResult.DoubleClick += KeywordResult_DoubleClick;
                Data.DoubleClick += Data_DoubleClick;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0001B003, e);
                throw;
            }
        }

        private void Data_DoubleClick(object sender, EventArgs e)
        {
            ReturnValue = Data.Items[Data.SelectedIndices[0]].SubItems[(int)ECharaSeriesCode.CODE + 1].Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        public void ImportData(DataTable DT, string[] ColName)
        {
            Source = DT;
            Data.Clear();
            Data.Columns.Add("N/A", 0, HorizontalAlignment.Left);
            Data.Columns.Add(Const.NUM_COLUMN, 0, HorizontalAlignment.Left);
            foreach (string item in ColName)
            {
                Data.Columns.Add(item, (Data.Size.Width - Const.SCROLL_BAR_WIDTH) / ColName.Length, HorizontalAlignment.Left);
            }

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow DR = DT.Rows[i];

                ListViewItem item = new ListViewItem();
                for (int j = 0; j < DR.ItemArray.Length; j++)
                {
                    item.SubItems.Add(DR.ItemArray[j].ToString());
                }
                Data.Items.Add(item);
            }
        }

        private void KeywordResult_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListView Sender = (ListView)sender;
                int StackPos = Convert.ToInt32(Sender.SelectedItems[0].Text) - 1;
                Data.EnsureVisible(StackPos);
                Data.Items[StackPos].Selected = true;
                Data.Select();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001B005, ex);
                throw;
            }
        }

        private void KeywordGo_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                KeywordResult.Clear();
                KeywordResult.Columns.Add("欄位號碼", KeywordResult.Size.Width - Const.SCROLL_BAR_WIDTH, HorizontalAlignment.Left);
                DataRow[] Result = DataAPI.Search(Keyword.Text, Source, 0, Source.Rows.Count, 1, Source.Columns.Count - 1);
                if (Result == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC001B001);
                    return;
                }
                foreach (DataRow item in Result)
                {
                    KeywordResult.Items.Add(item[Const.NUM_COLUMN].ToString());
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001B004, ex);
                throw;
            }
        }

        private void Keyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox senderTextBox = (TextBox)sender;

                if (e.KeyChar == (Char)Keys.Enter)
                {
                    KeywordGo_ButtonClick(this, null);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001B008, ex);
                throw;
            }
        }

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SystemAPI.MoveWindow_MouseDown(Left, Top, e.X, e.Y, ref WndPos);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001B006, ex);
                throw;
            }
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                if (lbl.Capture == true)
                {
                    SystemAPI.MoveWindow_MouseMove(Left, Top, e.X, e.Y, ref WndPos, this);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0001B007, ex);
                throw;
            }
        }
    }
}
