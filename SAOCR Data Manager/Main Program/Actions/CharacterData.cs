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
using System.IO;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Forms;
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.APIs;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void CD_CharacterIDGo_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (CD_CharacterIDGo.ButtonEnabled)
                {
                    StatusLog.Log(RCharaData.Log_RequestCharacter + CD_CharacterID.Text);
                    SData Data = new SData();
                    Data.CharaID = CD_CharacterID.Text;
                    Data.DTs = DT;
                    Data.TitleP = TitleP;

                    CharaData CD = new CharaData(Data);

                    if (CD.CreateSucceed)
                    {
                        foreach (Control item in CD_CharacterTab.SelectedTab.Controls)
                        {
                            if (typeof(CharaDataDisplay) == item.GetType())
                            {
                                CharaDataDisplay CDD = (CharaDataDisplay)item;
                                CDD.DisplayCharacterData(CD, RefreshFavoriteList);
                                CD_CharacterTab.SelectedTab.Text = CD_CharacterTab.SelectedTab.ToolTipText = CD.Data.CharaID;
                                CD_CharacterTab.SelectedTab.ToolTipText += " - " + CD.Info.Basic.GetBasicInfo(EBasicInfoCode.JP_NAME);
                                Status(RCharaData.Log_ShowCharacter1 + CD.Data.CharaID + RCharaData.Log_ShowCharacter2 + CD.Info.Basic.GetBasicInfo(EBasicInfoCode.JP_NAME));
                                break;
                            }
                        }
                    }
                    else
                    {
                        Status(RCharaData.Log_ShowCharacterFail + CD.Data.CharaID);
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00011002, ex);
                throw;
            }
        }

        private void CD_KeywordGo_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (Extent.isEmptyString(CD_Keyword.Text) && Extent.isEmptyString(CD_Rarity.Text) && Extent.isEmptyString(CD_CharaSeries.Text))
                {
                    SystemAPI.Warning(RWarning.W_0xC0007006);
                    return;
                }
                InitializeList(InitItem.CharaFindResult);
                DataRow[] Result = DataAPI.Search(CD_Keyword.Text, DT.CharaMix, 0, DT.CharaMix.Rows.Count, 1, DT.CharaMix.Columns.Count - 1);
                for (int i = 0; i < Result.Length; i++)
                {
                    ListViewItem LVI = new ListViewItem();
                    if ((Extent.isEmptyString(CD_Rarity.Text) ^ Result[i][(int)ECharaMixCode.ID].ToString().Substring(6, 1) == CD_Rarity.Text) &&
                        (Extent.isEmptyString(CD_CharaSeries.Text) ^ Result[i][(int)ECharaMixCode.ID].ToString().Substring(1, 3) == CD_CharaSeries.Text))
                    {
                        DataRow[] CharaName = DataAPI.Search(Result[i][(int)ECharaMixCode.ID].ToString(), DT.CharaMix, 0, (int)ECharaMixCode.ID);
                        string HEAD = CharaName[0][(int)ECharaMixCode.HEAD].ToString();
                        string NAME = CharaName[0][(int)ECharaMixCode.NAME].ToString();
                        LVI.SubItems.Add(Result[i][(int)ECharaMixCode.ID].ToString());
                        LVI.SubItems.Add(HEAD + NAME);
                    }
                    if (LVI.SubItems.Count > 1)
                    {
                        CD_KeywordResult.Items.Add(LVI);
                    }
                }

                Status(RCharaData.Log_FindChara1 + CD_Keyword.Text + RCharaData.Log_FindChara2 + CD_Rarity.Text + RCharaData.Log_FindChara3 + CD_CharaSeries.Text);
            }
            catch (NullReferenceException)
            {
                SystemAPI.Warning(RWarning.W_0xC0011001);
            }
            catch (SyntaxErrorException)
            {
                SystemAPI.Warning(RWarning.W_0xC0011002);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00011001, ex);
                throw;
            }
        }

        private void CD_KeywordResult_DoubleClick(object sender, EventArgs e)
        {
            ListView Sender = (ListView)sender;

            CD_CharacterID.Text = Sender.SelectedItems[0].SubItems[1].Text;
            Application.DoEvents();
            CD_CharacterIDGo.Button_Click(this, null);
        }
        
        private void CD_SeriesCodeGo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataViewF DVF = new DataViewF();
            string[] ColumnName = {Const.ColName.CHARA_ID, Const.ColName.CHARA_NAME_JP, Const.ColName.CHARA_NAME_EN, Const.ColName.CHARA_NAME_CH };
            DVF.ImportData(DT.CharaSeries, ColumnName);
            if (DVF.ShowDialog(this) == DialogResult.OK)
            {
                CD_CharaSeries.Text = DVF.ReturnValue;
            } 
        }
        
        private void CD_Favorite_DoubleClick(object sender, EventArgs e)
        {
            ListView Sender = (ListView)sender;
            
            CD_CharacterID.Text = Sender.SelectedItems[0].SubItems[1].Text;
            CD_CharacterIDGo_ButtonClick(this, null);
        }

        private void RefreshFavoriteList(object sender, EventArgs e)
        {
            try
            {
                InitializeList(InitItem.Favorite);
                AppConfig AC = new AppConfig();

                if (AC.Chara_Favorite != null)
                {
                    foreach (string item in AC.Chara_Favorite)
                    {
                        ListViewItem LVI = new ListViewItem();
                        LVI.SubItems.Add(item);

                        DataRow[] CharaData = DataAPI.Search(item, DT.CharaMix, 0, (int)ECharaMixCode.ID);
                        if (CharaData != null)
                        {
                            string HEAD = CharaData[0][(int)ECharaMixCode.HEAD].ToString();
                            string NAME = CharaData[0][(int)ECharaMixCode.NAME].ToString();
                            LVI.SubItems.Add(HEAD + NAME);
                        }
                        CD_Favorite.Items.Add(LVI);
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00011005, ex);
                throw;
            }
        }

        private void CD_NewTab_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                CD_CharacterIDGo.ButtonEnabled = true;

                TabPage TP = new TabPage();
                CharaDataDisplay CDD = new CharaDataDisplay();

                TP.SuspendLayout();

                TP.Text = TP.ToolTipText = Const.Default.CHARA_DATA_TAB + (CD_CharacterTab.TabCount + 1).ToString();
                TP.Controls.Add(CDD);
                CDD.BackColor = Color.FromArgb((int)EForeColor.Grey70);
                CDD.Font = new Font("微軟正黑體", 9F);
                CDD.ForeColor = Color.White;
                CDD.Location = new Point(0, 0);
                CDD.Name = "CharaDataDisplay";
                CDD.Padding = new Padding(5);
                CDD.Size = new Size(748, 602);
                CD_CharacterTab.Controls.Add(TP);

                TP.ResumeLayout(false);

                CD_CharacterTab.SelectedTab = TP;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00011003, ex);
                throw;
            }
        }

        private void CD_CloseTab_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (CD_CharacterTab.TabCount != 0)
                {
                    CD_CharacterTab.SelectedTab.Dispose();
                    if (CD_CharacterTab.TabCount == 0)
                    {
                        CD_CharacterIDGo.ButtonEnabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00011004, ex);
                throw;
            }
        }
    }
}
