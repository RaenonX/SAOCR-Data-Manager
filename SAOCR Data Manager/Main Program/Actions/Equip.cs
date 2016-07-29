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
using SAOCR_Data_Manager.Resources;
using System.Drawing.Imaging;
using SAOCR_Data_Manager.APIs;
using SAOCR_Data_Manager.Module;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        WeaponData WPD;
        EEquipType EET = EEquipType.Weapon;

        private void EQ_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (EQ_WeaponID.Text != "")
                {
                    WData WD = new WData();
                    WD.DTs = DT;
                    WD.ID = EQ_WeaponID.Text;
                    WD.TitleP = TitleP;

                    WPD = new WeaponData(WD);

                    if (WPD.CreateSucceed)
                    {
                        RadioButton[] RDB = { EQ_R1, EQ_R2, EQ_R3, EQ_R4 };
                        bool OneChecked = false;

                        for (int i = 0; i < RDB.Length; i++)
                        {
                            if (RDB[i].Checked)
                            {
                                EQ_WStatus.OutputWeaponData(WPD, (ESharpness)i);
                                OneChecked = true;
                                break;
                            }
                        }

                        if (!OneChecked)
                        {
                            SystemAPI.Warning(RWarning.W_0xC0030001);
                        }
                    }
                } else
                {
                    SystemAPI.Warning(RWarning.W_0xC0030000);
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00030000, ex);
                throw;
            }
        }

        private void EQ_WSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] DRRes1 = null;
                string EX = "";

                EX += "SUBSTRING(C" + (int)EWeaponNameSecCol.ID + ", 2, 2) IN (";
                if (EQ_Condition2.SelectedItems.Count > 0)
                {
                    if (EQ_Condition2.SelectedItems[0].Index != EQ_Condition2.Items.Count - 1)
                    {
                        EX += "'" + (EQ_Condition2.SelectedItems[0].Index + 1).ToString("00") + "'";
                    } else
                    {
                        EX += "'01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12'";
                    }
                } else
                {
                    EX += "'01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12'";
                }
                EX += ") AND SUBSTRING(C" + (int)EWeaponNameSecCol.ID + ", 8, 1) IN (";
                if (EQ_Condition1.SelectedItems.Count > 0)
                {
                    if (EQ_Condition1.SelectedItems[0].Index != EQ_Condition1.Items.Count - 1)
                    {
                        EX += "'" + (EQ_Condition1.SelectedItems[0].Index + 1).ToString() + "'";
                    } else
                    {
                        EX += "'1', '2', '3', '4', '5', '6', '7', '8'";
                    }
                } else
                {
                    EX += "'1', '2', '3', '4', '5', '6', '7', '8'";
                }
                EX += ")";

                DRRes1 = DataAPI.Search("",
                         DT.Source,
                         TitleP.Start[(int)DataTitle.WeaponName],
                         TitleP.End[(int)DataTitle.WeaponName],
                         (int)EWeaponNameSecCol.ID,
                         (int)EWeaponNameSecCol.ID,
                         EX);

                EQ_Result.Items.Clear();
                if (DRRes1 != null)
                {
                    foreach (DataRow D in DRRes1)
                    {
                        ListViewItem LVI = new ListViewItem();
                        LVI.SubItems.Add(D[(int)EWeaponNameSecCol.ID].ToString());
                        LVI.SubItems.Add(D[(int)EWeaponNameSecCol.NAME].ToString());

                        EQ_Result.Items.Add(LVI);
                    }
                }
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00030001, ex);
                throw;
            }
        }

        private void EQ_Result_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EQ_WeaponID.Text = EQ_Result.SelectedItems[0].SubItems[1].Text;
            EQ_R4.Checked = true;
            EQ_Search_Click(sender, EventArgs.Empty);
        }

        private void EQ_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                EQ_Result_MouseDoubleClick(sender, null);
            }
        }

        private void EQ_FavAdd_Click(object sender, EventArgs e)
        {
            if (WPD != null) {
                if (WPD.CreateSucceed)
                {
                    AC.Weapon_Favorite.Add(WPD.Data.ID);
                    EQ_FavList_Refresh();
                }
            }
        }

        private void EQ_FavRem_Click(object sender, EventArgs e)
        {
            if (EQ_FavList.SelectedItems.Count > 0)
            {
                ListViewItem SLVIC = EQ_FavList.SelectedItems[0];
                AC.Weapon_Favorite.Remove(SLVIC.SubItems[2].ToString());
                EQ_FavList.Items.RemoveAt(SLVIC.Index);
            }
        }

        private void EQ_FavList_Refresh()
        {
            List<string> LS = new List<string>();

            InitializeList(InitItem.EQ_Favorite);

            foreach (string S in AC.Weapon_Favorite)
            {
                ListViewItem LVI = new ListViewItem();
                LVI.SubItems.Add(EnumTranslator.EquipTypeT(Extent.IDtoIdentifyEquipType(S)));
                LVI.SubItems.Add(S);

                string WName = DataAPI.Search(DT.Source, S, (int)EWeaponNameSecCol.NAME, 0, TitleP.Start[(int)DataTitle.WeaponName], (int)EWeaponNameSecCol.ID);

                if (Extent.isEmptyString(WName))
                {
                    LVI = null;
                    LS.Add(S);
                    SystemAPI.Warning(RWarning.W_0xC0030002);
                } else
                {
                    LVI.SubItems.Add(WName);
                    EQ_FavList.Items.Add(LVI);
                }
            }

            foreach (string S in LS)
            {
                AC.Weapon_Favorite.Remove(S);
            }
        }

        private void EQ_FavList_DoubleClick(object sender, EventArgs e)
        {
            if (EQ_FavList.SelectedItems.Count > 0)
            {
                ListViewItem SLVIC = EQ_FavList.SelectedItems[0];
                string ID = SLVIC.SubItems[2].Text;
                EQ_WeaponID.Text = ID;
                EQ_Search_Click(sender, e);
                SystemAPI.SEBeep();
            }
        }

        private void EQ_DisplayChange(object sender, EventArgs e)
        {
            Button_SE_ BSE = (Button_SE_)sender;
            EQ_GoWeapon.ButtonColor = EQ_GoArmor.ButtonColor = EQ_GoAccessory.ButtonColor = Color.White;

            EQ_WStatus.Visible = false;
            BSE.ButtonColor = Color.Red;

            switch (BSE.Name)
            {
                case "EQ_GoWeapon":
                    EQ_WStatus.Visible = true;
                    break;
                case "EQ_GoArmor":
                    break;
                case "EQ_GoAccessory":
                    break;
            }
        }
    }
}
