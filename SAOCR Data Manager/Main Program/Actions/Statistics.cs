using System;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Forms;
using System.Data;
using SAOCR_Data_Manager.Resources.Message;
using System.Diagnostics;

namespace SAOCR_Data_Manager
{
    public partial class FMain
    {
        private void SS_WeaponCalculate_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                int CharaCount = 0;
                DataRow[] Param = DataAPI.Search("", DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.ID, Const.IS_ORG_CHARA_VERIFY_AT_C1);
                if (Param != null)
                {
                    CharaCount = Param.Length;
                }

                SS_Character.Text = RStatistics.Layout_CharacterRelated + RStatistics.Message_CharaSamples1 + CharaCount + RStatistics.Message_CharaSamples2;

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_CharacterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_CharaWeaponUsingRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 武器使用比率
                    InitializeList(InitItem.SS_CharaWeaponUsingRate);
                    for (int i = 0; i < Const.Count.WEAPON_CATEGORY; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = 0;

                        DataRow[] Result = DataAPI.Search((i + 1).ToString(), DT.Source, TitleP.Start[(int)DataTitle.CharacterParams], TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.WEAPON, true, Const.IS_ORG_CHARA_IN_PARAMS);
                        if (Result != null)
                        {
                            Count = Result.Length;
                        }

                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(EnumTranslator.WeaponT((EWeapon)(i + 1)));
                        LVI.SubItems.Add(((double)Count / CharaCount).ToString("0.00%"));
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
                    InitializeList(InitItem.SS_CharaElementRate);
                    for (int i = 0; i < Const.Count.ELEMENT_CATEGORY; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = DataAPI.Search((i + 1).ToString(), DT.Source, TitleP.Start[(int)DataTitle.CharacterParams], TitleP.End[(int)DataTitle.CharacterParams], (int)EParamSecCol.ELEMENT, Const.IS_ORG_CHARA_IN_PARAMS).Length;

                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(EnumTranslator.ElementT((EElement)(i + 1)));
                        LVI.SubItems.Add(((double)Count / CharaCount).ToString("0.00%"));
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
                    InitializeList(InitItem.SS_CharaSceneRate);
                    for (int i = 0; i < Const.Count.SCENE_CATEGORY; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = 0;

                        foreach (DataRow DR in DataAPI.Search("", DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.ID, Const.IS_ORG_CHARA_VERIFY_AT_C1))
                        {
                            if (DR[(int)ENameSecCol.ID].ToString().Substring(0, 1) == (i + 1).ToString())
                            {
                                Count++;
                            }
                        }
                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(EnumTranslator.SceneT((EScene)(i + 1)));
                        LVI.SubItems.Add(((double)Count / CharaCount).ToString("0.00%"));
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
                    InitializeList(InitItem.SS_CharaSeriesRate);
                    for (int i = 0; i < DT.CharaSeries.Rows.Count; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        string CurrentCode = Convert.ToInt32(DT.CharaSeries.Rows[i][(int)ECharaSeriesCode.CODE]).ToString("D3");

                        int Count = 0;
                        DataRow[] DRs = DataAPI.Search("", DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.ID, Const.SPECIFIED_ON_SERIES_AT_C1_1 + CurrentCode + Const.SPECIFIED_ON_SERIES_AT_C1_2 + " AND " + Const.IS_ORG_CHARA_VERIFY_AT_C1);
                        if (DRs != null)
                        {
                            Count = DRs.Length;
                        }

                        LVI.SubItems.Add(CurrentCode);
                        LVI.SubItems.Add(DataAPI.Search(DT.CharaSeries, CurrentCode, (int)ECharaSeriesCode.CH_NAME, 0, (int)ECharaSeriesCode.CODE));
                        LVI.SubItems.Add(((double)Count / CharaCount).ToString("0.00%"));
                        SS_CharaSeriesRate.Items.Add(LVI);
                        Application.DoEvents();
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
                    InitializeList(InitItem.SS_CharaRarityRate);
                    for (int i = 0; i < Const.Count.RARITY; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = 0;

                        foreach (DataRow DR in DataAPI.Search("", DT.Source, TitleP.Start[(int)DataTitle.CharacterNameAndCV], TitleP.End[(int)DataTitle.CharacterNameAndCV], (int)ENameSecCol.ID, Const.IS_ORG_CHARA_VERIFY_AT_C1))
                        {
                            if (DR[(int)ENameSecCol.ID].ToString().Substring(6, 1) == (i + 1).ToString())
                            {
                                Count++;
                            }
                        }
                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(((double)Count / CharaCount).ToString("0.00%"));
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

        private void SS_MonsterCalculate_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                int TotalCount = TitleP.End[(int)DataTitle.MonsterParams] - TitleP.Start[(int)DataTitle.MonsterParams];
                SS_Monster.Text = RStatistics.Layout_MonsterRelated + RStatistics.Message_MonsterSamples1 + TotalCount + RStatistics.Message_MonsterSamples2;

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_MonsterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_MonsterTypeRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 怪物種類占比
                    InitializeList(InitItem.SS_MonsterTypeRate);
                    for (int i = 0; i < Const.Count.MONSTER_TYPE; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = DataAPI.Search((i + 1).ToString(), DT.Source, TitleP.Start[(int)DataTitle.MonsterParams], TitleP.End[(int)DataTitle.MonsterParams], (int)EMonsterSecCol.TYPE).Length;
                        LVI.SubItems.Add((i + 1).ToString());
                        LVI.SubItems.Add(EnumTranslator.MonsterTypeT((EMonsterType)i));
                        LVI.SubItems.Add(((double)Count / TotalCount).ToString("0.00%"));
                        SS_MonsterTypeRate.Items.Add(LVI);
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A008, ex);
                    throw;
                }

                try
                {
                    Status(RStatistics.Log_Calculating1 + RStatistics.Layout_MonsterRelated + RStatistics.Log_Calculating2 + RStatistics.Layout_MonsterHPRate + RStatistics.Log_Calculating3);
                    Application.DoEvents();
                    #region 怪物血量占比
                    DataTable SDT = new DataTable();
                    SDT = DataAPI.Specified<int>(DT.Source, TitleP.Start[(int)DataTitle.MonsterParams] + 1, TitleP.End[(int)DataTitle.MonsterParams], null, "Monster Parameters");

                    InitializeList(InitItem.SS_MonsterHPRate);
                    for (int i = 0; i < Const.Count.MONSTER_HP_K; i++)
                    {
                        ListViewItem LVI = new ListViewItem();
                        int Count = 0;
                        int MinHP = i * 10000, MaxHP = ((i + 1) * 10000) - 1;

                        string AddtFilter = "Convert(C" + (int)EMonsterSecCol.HP + ", 'System.Int32') >= " + MinHP.ToString() + " AND Convert(C" + (int)EMonsterSecCol.HP + ", 'System.Int32') <= " + MaxHP.ToString();

                        DataRow[] Result = DataAPI.Search("", SDT, TitleP.Start[(int)DataTitle.MonsterParams], TitleP.End[(int)DataTitle.MonsterParams], (int)EMonsterSecCol.HP, AddtFilter);

                        if (Result != null)
                        {
                            Count = Result.Length;
                        }

                        LVI.SubItems.Add(MinHP.ToString());
                        LVI.SubItems.Add(MaxHP.ToString());
                        LVI.SubItems.Add(((double)Count / TotalCount).ToString("0.00%"));
                        SS_MonsterHPRate.Items.Add(LVI);
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    SystemAPI.Error(RError.E_0x0002A009, ex);
                    throw;
                }

                Status(RStatistics.Log_Calculated1 + RStatistics.Layout_MonsterRelated + RStatistics.Log_Calculated2);
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0002A007, ex);
                throw;
            }
        }
    }
}
