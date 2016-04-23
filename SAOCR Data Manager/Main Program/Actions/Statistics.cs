using System;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Forms;
using System.Data;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void SS_WeaponCalculate_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                int ParamCount = TitleP.End[(int)DataTitle.CharacterParams] - TitleP.Start[(int)DataTitle.CharacterParams];
                int InfoCount = TitleP.End[(int)DataTitle.CharacterNameAndCV] - TitleP.Start[(int)DataTitle.CharacterNameAndCV];

                SS_Character.Text = RStatistics.Layout_CharacterRelated + RStatistics.Message_Samples1 + ParamCount + RStatistics.Message_Samples2;

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_CharaWeaponUsingRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 武器使用比率
                    InitializeList(InitItem.CharaWeaponUsingRate);
                    for (int i = 0; i < Const.Count.WEAPON_CATEGORY; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = DataAPI.Search((i + 1).ToString(), DT.Source, TitleP.Start[(int)DataTitle.CharacterParams], TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.WEAPON).Length;

                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(EnumTranslator.WeaponT((EWeapon)(i + 1)));
                        LVI.SubItems.Add(((double)Count / ParamCount).ToString("0.00%"));
                        SS_CharaWeaponUsingRate.Items.Add(LVI);
                    }
                        #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A002, ex);
                    throw;
                }

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_CharaElementRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 角色屬性占比
                InitializeList(InitItem.CharaElementRate);
                for (int i = 0; i < Const.Count.ELEMENT_CATEGORY; i++)
                {
                    ListViewItem LVI = new ListViewItem();
                    int Count = DataAPI.Search((i + 1).ToString(), DT.Source, TitleP.Start[(int)DataTitle.CharacterParams], TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.ELEMENT).Length;

                    LVI.SubItems.Add((i + 1).ToString());
                    LVI.SubItems.Add(EnumTranslator.ElementT((EElement)(i + 1)));
                    LVI.SubItems.Add(((double)Count / ParamCount).ToString("0.00%"));
                    SS_CharaElementRate.Items.Add(LVI);
                }
                #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A003, ex);
                    throw;
                }

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_CharaSceneRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 角色舞台占比
                    InitializeList(InitItem.CharaSceneRate);
                    for (int i = 0; i < Const.Count.SCENE_CATEGORY; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = DataAPI.Search(EnumTranslator.SceneT((EScene)(i + 1)), DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.LONG_NAME).Length;

                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(EnumTranslator.SceneT((EScene)(i + 1)));
                        LVI.SubItems.Add(((double)Count / ParamCount).ToString("0.00%"));
                        SS_CharaSceneRate.Items.Add(LVI);
                    }
                        #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A004, ex);
                    throw;
                }

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_CharaSeriesRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 角色系列占比
                    InitializeList(InitItem.CharaSeriesRate);
                    for (int i = 0; i < DT.CharaSeries.Rows.Count; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        string CurrentCode = DT.CharaSeries.Rows[i][(int)ECharaSeriesCode.CODE].ToString();
                        int Count = DataAPI.Search(CurrentCode, DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.CHARA_SERIES).Length;

                        LVI.SubItems.Add(CurrentCode);
                        LVI.SubItems.Add(DataAPI.Search(DT.CharaSeries, CurrentCode, (int)ECharaSeriesCode.CH_NAME, 0, (int)ECharaSeriesCode.CODE));
                        LVI.SubItems.Add(((double)Count / ParamCount).ToString("0.00%"));
                        SS_CharaSeriesRate.Items.Add(LVI);
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A005, ex);
                    throw;
                }

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_CharaRarityRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 角色星級占比
                InitializeList(InitItem.CharaRarityRate);
                for (int i = 0; i < Const.Count.RARITY; i++)
                {
                    ListViewItem LVI = new ListViewItem();
                    int Count = 0;

                    foreach (DataRow DR in DataAPI.Search("", DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.ID_ORG))
                    {
                        if (DR[(int)ENameSecCol.ID_ORG].ToString().Substring(6, 1) == (i + 1).ToString())
                        {
                            Count++;
                        }
                    }
                    LVI.SubItems.Add((i + 1).ToString());
                    LVI.SubItems.Add(((double)Count / ParamCount).ToString("0.00%"));
                    SS_CharaRarityRate.Items.Add(LVI);
                }
            #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A006, ex);
                    throw;
                }

                Status(RStatistics.Log_Calculated1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculated2);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002A001, ex);
                throw;
            }
        }
    }
}
