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
                } else
                {
                    SystemAPI.Warning(RWarning.W_0xC0011003);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00011002, ex);
                throw;
            }
        }

        private void CD_SearchCharacter_ItemSelected(object sender, EventArgs e)
        {
            ListView Sender = (ListView)sender;

            CD_CharacterID.Text = Sender.SelectedItems[0].SubItems[1].Text;
            Application.DoEvents();
            CD_CharacterIDGo_ButtonClick(this, null);
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
                InitializeList(InitItem.CD_Favorite);
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
        
        private void CD_SearchCharacter_SeriesTableClicked(object sender, EventArgs e)
        {
            CD_SearchCharacter.OpenSeriesTable(ref DT.CharaSeries, Status);
        }

        private void CD_SearchCharacter_SearchClicked(object sender, EventArgs e)
        {
            CD_SearchCharacter.FindCharacter(ref DT.CharaMix, Status);
        }

        private void CD_MakeIDTable_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
