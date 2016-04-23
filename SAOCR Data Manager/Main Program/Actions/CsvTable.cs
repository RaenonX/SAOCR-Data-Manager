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
        private void CT_StepGo_ButtonClick(object sender = null, EventArgs e = null)
        {
            if (Extent.isEmptyString(CT_Step.Text))
            {
                new MessageDialog(RCsvTable.Error_EmptyStepStack).ShowDialog(this);
                return;
            }
            
            try
            {
                CT_CsvView.FirstDisplayedScrollingRowIndex = Convert.ToInt32(CT_Step.Text) - 1;
                CT_CsvView.CurrentCell = CT_CsvView.Rows[CT_CsvView.FirstDisplayedScrollingRowIndex].Cells[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (DT.Source.Columns.Count == 0)
                {
                    Status(RStatus.Error_DataNotInput);
                    SystemAPI.SEWarning();
                } else
                {
                    Status(RStatus.Error_DataNotFound);
                    SystemAPI.SEWarning();
                }
            }
        }

        private void CT_Tips_ArriveToBorder(object sender, EventArgs e)
        {
            CT_TipsCounter++;

            switch (CT_TipsCounter)
            {
                case 1:
                    CT_Tips.MarqueeText = RCsvTable.Message_WayToCopyContents;
                    break;
                case 2:
                    CT_Tips.MarqueeText = RCsvTable.Message_WayToPasteContents;
                    break;
                case 3:
                    CT_Tips.MarqueeText = RCsvTable.Message_AboutSearchingString;
                    break;
                case 4:
                    CT_Tips.MarqueeText = RCsvTable.Message_AboutFoundResult;
                    CT_TipsCounter = 0;
                    break;
            }
        }

        private void CT_SearchGo_ButtonClick(object sender, EventArgs e)
        {
            if (Extent.isEmptyString(CT_Search.Text))
            {
                SystemAPI.SEWarning();
                Status(RStatus.Error_KeywordEmpty);
                return;
            }
            if (CT_StartColumn.Value > CT_EndColumn.Value)
            {
                SystemAPI.SEWarning();
                Status(RStatus.Error_StartIsBiggerThanEnd);
                return;
            }
            InitializeList(InitItem.CrDataFindResultList);
            DataRow[] Result = DataAPI.Search(CT_Search.Text, DT.Source, 0, DT.Source.Rows.Count, Convert.ToInt32(CT_StartColumn.Value), Convert.ToInt32(CT_EndColumn.Value));

            try
            {
                foreach (DataRow item in Result)
                {
                    CT_FindResultList.Items.Add(item[Const.NUM_COLUMN].ToString());
                }
            }
            catch (NullReferenceException)
            {
                Status(RStatus.Result_StringNotFound);
                return;
            }
            catch (Exception)
            {
                throw;
            }

            if (CT_FindResultList.Items.Count == 0)
            {
                Status(RStatus.Result_StringNotFound);
                return;
            }

            Status(RStatus.Result_FoundString1 + CT_Search.Text + RStatus.Result_FoundString2 + CT_FindResultList.Items.Count + RStatus.Result_FoundString3);
        }

        private void CT_FindResultList_DoubleClick(object sender, EventArgs e)
        {
            ListView Sender = (ListView)sender;

            CT_CsvView.FirstDisplayedScrollingRowIndex = Convert.ToInt32(Sender.SelectedItems[0].Text) - 1;
            CT_CsvView.CurrentCell = CT_CsvView.Rows[CT_CsvView.FirstDisplayedScrollingRowIndex].Cells[0];
        }
    }
}
