﻿using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public class DataAPI
    {
        #region Search
        /// <summary>
        /// (區間，單欄) 在指定的資料表範圍內，根據已定義的欄位範圍搜尋並回傳找到的所有資料行。如果沒有找到資料則會回傳null。
        /// </summary>
        /// <param name="TargetText">資料表</param>
        /// <param name="DT">搜尋目標</param>
        /// <param name="RowToStartFind">搜尋目標的起始行號</param>
        /// <param name="ColumnToFind">定義的搜尋欄位</param>
        /// <returns>根據條件所回傳的資料行陣列。如果沒找到則會回傳null。</returns>
        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int ColumnToFind)
        {
            return Search(TargetText, DT, RowToStartFind, DT.Rows.Count, ColumnToFind, ColumnToFind, false, null);
        }

        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToFind, bool isFullConform)
        {
            return Search(TargetText, DT, RowToStartFind, RowToEndFind, ColumnToFind, ColumnToFind, isFullConform, null);
        }

        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToFind, string AdditionalFilter)
        {
            return Search(TargetText, DT, RowToStartFind, RowToEndFind, ColumnToFind, ColumnToFind, false, AdditionalFilter);
        }

        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToFind, bool isFullConformstring, string AdditionalFilter)
        {
            return Search(TargetText, DT, RowToStartFind, RowToEndFind, ColumnToFind, ColumnToFind, isFullConformstring, AdditionalFilter);
        }

        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToFind)
        {
            return Search(TargetText, DT, RowToStartFind, RowToEndFind, ColumnToFind, ColumnToFind, false, null);
        }

        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToStartFInd, int ColumnToEndFind)
        {
            return Search(TargetText, DT, RowToStartFind, RowToEndFind, ColumnToStartFInd, ColumnToEndFind, false, null);
        }

        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToStartFInd, int ColumnToEndFind, string AdditionalFilter)
        {
            return Search(TargetText, DT, RowToStartFind, RowToEndFind, ColumnToStartFInd, ColumnToEndFind, false, AdditionalFilter);
        }
        
        public static DataRow[] Search
            (string TargetText, DataTable DT, int RowToStartFind, int RowToEndFind, int ColumnToStartFind, int ColumnToEndFind, bool isFullConform, string AdditionalFilter)
        {
            Debug.Print("Search Func Called. Return DataRow[]. Text = {0}, DTName = {1}, RowStart = {2}, RowEnd = {3}, ColStart = {4}, ColEnd = {5}, FullConform = {6}, AddFilter = {7}", TargetText, DT.TableName, RowToStartFind, RowToEndFind, ColumnToStartFind, ColumnToEndFind, isFullConform, AdditionalFilter);

            string FindStringCondition = "";

            if (ColumnToStartFind > ColumnToEndFind)
            {
                new MessageDialog(RError.Error_ArrayWithSectionNotLegal).ShowDialog();
                SystemAPI.SEWarning();
                return null;
            }

            FindStringCondition += "(";
            for (int i = ColumnToStartFind; i <= ColumnToEndFind; i++)
            {
                FindStringCondition += "C" + Convert.ToString(i);
                if (isFullConform)
                {
                    FindStringCondition += " = '" + EscapeLikeValue(TargetText) + "'";
                } else
                {
                    FindStringCondition += " LIKE '*" + EscapeLikeValue(TargetText) + "*'";
                }
                
                if (i < ColumnToEndFind)
                {
                    FindStringCondition += " OR ";
                }
            }
            FindStringCondition += ")";
            if (!Extent.isEmptyString(AdditionalFilter))
            {
                if (!Extent.isEmptyString(FindStringCondition))
                {
                    FindStringCondition += " AND ";
                }
                FindStringCondition += AdditionalFilter;
            }

            DataRow[] OriginalResult = DT.Select(FindStringCondition), Result;
            List<DataRow> ResultList = new List<DataRow>();

            foreach (DataRow item in OriginalResult)
            {
                if (RowToStartFind != 0)
                {
                    if (Convert.ToInt32(item[Const.NUM_COLUMN]) >= RowToStartFind && Convert.ToInt32(item[Const.NUM_COLUMN]) <= RowToEndFind)
                    {
                        ResultList.Add(item);
                    }
                } else
                {
                    ResultList.Add(item);
                }
            }
            Result = ResultList.ToArray();

            if (Result.Length == 0)
            {
                return null;
            }

            return Result;
        }
        
        public static string Search
            (DataTable DT, string TargetText, int ColumnToReturn, int RowInResult, int RowToStartFind, int ColumnToStartFind, int ColumnToEndFind)
        {
            Debug.Print("Search Func Called. Return String. Text = {0}, DTName = {1}, RowStart = {2}, RowInResult = {3}, ColStart = {4}, ColEnd = {5}, ColReturn = {6}", TargetText, DT.TableName, RowToStartFind, RowInResult, ColumnToStartFind, ColumnToEndFind, ColumnToReturn);

            string FindStringCondition = "";

            if (ColumnToStartFind > ColumnToEndFind)
            {
                new MessageDialog(RError.Error_ArrayWithSectionNotLegal).ShowDialog();
                SystemAPI.SEWarning();
                return null;
            }

            for (int i = ColumnToStartFind; i <= ColumnToEndFind; i++)
            {
                FindStringCondition += "C" + Convert.ToString(i);
                FindStringCondition += " LIKE '*" + EscapeLikeValue(TargetText) + "*'";
                if (i < ColumnToEndFind)
                {
                    FindStringCondition += " OR ";
                }
            }
            DataRow[] CT_FindStringResult = DT.Select(FindStringCondition);

            if (CT_FindStringResult.Length == 0)
            {
                return null;
            }

            try
            {
                while (Convert.ToInt32(CT_FindStringResult[RowInResult][0]) < RowToStartFind)
                {
                    RowInResult++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }

            if (CT_FindStringResult.Length <= RowInResult)
            {
                SystemAPI.SEWarning();
                return null;
            }
            
            return CT_FindStringResult[RowInResult][ColumnToReturn].ToString();
        }
        
        public static string Search
            (DataTable DT, string TargetText, int ColumnToReturn, int RowInResult, int RowToStartFind, int ColumnToFind)
        {
           return Search(DT, TargetText, ColumnToReturn, RowInResult, RowToStartFind, ColumnToFind, ColumnToFind);
        }
        
        public static string Search (DataTable DT, string TargetText, bool isMultiColumn, int ColumnToReturn, int RowInResult, int ColumnToStartFind, int ColumnToEndFind)
        {
            if (isMultiColumn)
            {
                return Search(DT, TargetText, ColumnToReturn, RowInResult, 0, ColumnToStartFind, ColumnToEndFind);
            }
            else
            {
                throw new ArgumentException(RError.Error_WrongFindDataMethodCalled);
            }
        }
        
        public static string Search(DataTable DT, string TargetText, int ColumnToReturn, int RowInResult, int ColumnToFind)
        {
            return Search(DT, TargetText, ColumnToReturn, RowInResult, 0, ColumnToFind, ColumnToFind);
        }
        
        public static bool Search(DataTable DT, string TargetText, int Column)
        {
            if (Search(DT, TargetText, Column, 0, 0, Column, Column) != RWarning.W_0xC0000002.Replace("\\n", " "))
            {
                return true;
            } else
            {
                return false;
            }
        }
        
        public static bool Search(DataTable DT, string TargetText, int ColumnToStartFind, int ColumnToEndFind)
        {
            if (Search(DT, TargetText, ColumnToStartFind, 0, 0, ColumnToStartFind, ColumnToEndFind) != RWarning.W_0xC0000002.Replace("\\n", " "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Specified
        /// <summary>
        /// (主函式) 擷取指定範圍的資料。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始位置</param>
        /// <param name="EndStack">終止位置</param>
        /// <param name="EndKey">終止關鍵字</param>
        /// <param name="EndKeyColumnLocation">終止關鍵字所在欄位</param>
        /// <param name="ColumnToRemove">保留欄位</param>
        /// <returns></returns>
        private static DataTable Specified<T>(DataTable OrgDT, int StartStack, int EndStack, string EndKey, int[] EndKeyColumnLocation, List<T> ColumnToRemove, string TableName, string AdditionalCommand = null)
        {
            DataTable DT = new DataTable();
            
            FMain.InitializeDataTable(ref DT, TableName);

            if (EndStack == 0)
            {
                EndStack = DataAPI.EndStack(OrgDT, StartStack, EndKey, EndKeyColumnLocation);
            }
            string StackCondition = "Convert(" + Const.NUM_COLUMN + ", 'System.Int32') >= " + StartStack + " AND Convert(" + Const.NUM_COLUMN + ", 'System.Int32') <= " + EndStack;
            if (AdditionalCommand != null)
            {
                StackCondition += " AND " + AdditionalCommand;
            }

            DataRow[] Section = OrgDT.Select(StackCondition);
            foreach (DataRow item in Section)
            {
                DT.ImportRow(item);
            }

            int DTColumnsCount = DT.Columns.Count;

            if (ColumnToRemove != null)
            {
                foreach (T item in ColumnToRemove)
                {
                    if (item.GetType() == typeof(int))
                    {
                        DT.Columns.RemoveAt(Convert.ToInt32(item));
                    }
                    else if (item.GetType() == typeof(string))
                    {
                        DT.Columns.Remove(item.ToString());
                    }
                }
            }

            return DT;
        }

        /// <summary>
        /// (終止字串，指定起終) 擷取指定範圍的資料。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始位置</param>
        /// <param name="EndKey">終止關鍵字</param>
        /// <param name="EndKeyColumnLocation">終止關鍵字所在欄位</param>
        /// <param name="ColumnToRemove">保留欄位</param>
        /// <returns></returns>
        public static DataTable Specified<T>(DataTable OrgDT, int StartStack, string EndKey, int[] EndKeyColumnLocation, List<T> ColumnToRemove, string TableName, string AdditionalCommand = null)
        {
            return Specified(OrgDT, StartStack, 0, EndKey, EndKeyColumnLocation, ColumnToRemove, TableName, AdditionalCommand);
        }

        /// <summary>
        /// (終止字串，指定起終) 擷取指定範圍的資料。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始位置</param>
        /// <param name="EndKey">終止關鍵字param>
        /// <param name="EndKeyColumnLocation">終止關鍵字所在欄位</param>
        /// <param name="ColumnToRemove">保留欄位</param>
        /// <returns></returns>
        public static DataTable Specified<T>(DataTable OrgDT, int StartStack, string EndKey, int EndKeyColumnLocation, List<T> ColumnToRemove, string TableName, string AdditionalCommand = null)
        {
            int[] Array = { EndKeyColumnLocation };
            return Specified(OrgDT, StartStack, 0, EndKey, Array, ColumnToRemove, TableName, AdditionalCommand);
        }

        /// <summary>
        /// (終止位置，指定起終) 擷取指定範圍的資料。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始位置</param>
        /// <param name="EndStack">終止位置</param>
        /// <param name="ColumnToRemove">保留欄位</param>
        /// <returns></returns>
        public static DataTable Specified<T>(DataTable OrgDT, int StartStack, int EndStack, List<T> ColumnToRemove, string TableName, string AdditionalCommand = null)
        {
            return Specified(OrgDT, StartStack, EndStack, null, null, ColumnToRemove, TableName, AdditionalCommand);
        }

        /// <summary>
        /// (無終點，指定起點) 擷取指定範圍的資料。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始位置</param>
        /// <param name="ColumnToRemove">保留欄位</param>
        /// <returns></returns>
        public static DataTable Specified<T>(DataTable OrgDT, int StartStack, List<T> ColumnToRemove, string TableName, string AdditionalCommand = null)
        {
            return Specified(OrgDT, StartStack, OrgDT.Rows.Count, null, null, ColumnToRemove, TableName, AdditionalCommand);
        }
        #endregion

        #region EndStack
        /// <summary>
        /// 獲取指定資料區塊的最終堆棧。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始堆棧</param>
        /// <param name="EndKey">終止關鍵字</param>
        /// <param name="SpecifyColumn">指定搜尋終止關鍵字的欄位號碼</param>
        /// <returns>終止欄位的號碼</returns>
        public static int EndStack(DataTable OrgDT, int StartStack, string EndKey, int SpecifyColumn)
        {
            int[] Array = { SpecifyColumn };
            return EndStack(OrgDT, StartStack, EndKey, Array);
        }

        /// <summary>
        /// 獲取指定資料區塊的最終堆棧。
        /// </summary>
        /// <param name="OrgDT">原始資料表</param>
        /// <param name="StartStack">起始堆棧</param>
        /// <param name="EndKey">終止關鍵字</param>
        /// <param name="SpecifyColumn">指定搜尋終止關鍵字的欄位號碼</param>
        /// <returns>終止欄位的號碼</returns>
        public static int EndStack(DataTable OrgDT, int StartStack, string EndKey, int[] SpecifyColumn)
        {
            FindEndStack FES = new FindEndStack();
            
            for (int i = 0; i < SpecifyColumn.Length; i++)
            {
                FES.Condition += "C" + SpecifyColumn[i];
                FES.Condition += " LIKE '*" + EscapeLikeValue(EndKey) + "*'";
                if (i < SpecifyColumn.Length - 1)
                {
                    FES.Condition += " OR ";
                }
            }
            
            FES.DataRows = OrgDT.Select(FES.Condition);
            FES.StackList = new List<int>();
            for (int i = 0; i < FES.DataRows.Length; i++)
            {
                FES.StackList.Add(Convert.ToInt32(FES.DataRows[i][Const.NUM_COLUMN]));
            }

            FES.min = 99999;
            FES.Stack = FES.StackList.ToArray();

            for (int i = 0; i < FES.Stack.Length; i++)
            {
                if (FES.Stack[i] - StartStack > 0 && FES.Stack[i] - StartStack < FES.min)
                {
                    FES.min = FES.Stack[i] - StartStack;
                }
            }

            return FES.min;
        }
        #endregion
        
        public static void Resort<T>(ref DataTable OrgDT, List<T> SortedColumnSequence)
        {
            if (SortedColumnSequence.GetType() == typeof(List<int>))
            {
                for (int i = 0; i < SortedColumnSequence.Count; i++)
                {
                    OrgDT.Columns["C" + SortedColumnSequence[i].ToString()].SetOrdinal(i + 1);
                }
            } else if (SortedColumnSequence.GetType() == typeof(List<string>))
            {
                for (int i = 0; i < SortedColumnSequence.Count; i++)
                {
                    string ColName = SortedColumnSequence[i].ToString();
                    if (ColName.Substring(0, 1) != "C")
                    {
                        OrgDT.Columns[ColName].SetOrdinal(i + 1);
                    } else
                    {
                        OrgDT.Columns["C" + ColName].SetOrdinal(i + 1);
                    }
                }
            }
        }
        
        /// <summary>
        /// 將csv檔案讀取到指定的Datatable中。
        /// </summary>
        /// <param name="DT">目的資料表。</param>
        /// <param name="CSVPath">csv檔案路徑。</param>
        /// <param name="Delimeter">csv分隔子</param>
        public static void LoadCSV(ref DataTable DT, string Path, string Delimiter = ",")
        {
            try
            {
                Computer My = new Computer();

                int count = 0;

                TextFieldParser CSV = My.FileSystem.OpenTextFieldParser(Path);
                CSV.SetDelimiters(Delimiter);

                while (!CSV.EndOfData)
                {
                    count++;
                    List<string> DataList = new List<string>();
                    try
                    {
                        DataList.Add(Convert.ToString(count));
                        DataList.AddRange(CSV.ReadFields());
                        for (int i = DataList.Count; i < DT.Columns.Count; i++)
                        {
                            DataList.Add("");
                        }
                        string[] Data = DataList.ToArray();

                        DT.Rows.Add(Data);

                        Application.DoEvents();
                    }
                    catch (MalformedLineException)
                    {
                        DataList.AddRange(new string[DT.Columns.Count - DataList.Count]);
                        string[] Data = DataList.ToArray();
                        DT.Rows.Add(Data);
                    }
                    catch (Exception e)
                    {
                        SystemAPI.Error(RError.E_0x00000001_1 + Path + RError.E_0x00000001_2 + DT.TableName + RError.E_0x00000001_3 + Delimiter, e);
                        throw;
                    }
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000002, e);
                throw;
            }
        }

        /// <summary>
        /// 將csv檔案讀取到指定的List<string>中。
        /// </summary>
        public static void LoadCSV(ref List<string> Arr, string Path)
        {
            try
            {
                Computer My = new Computer();
                StreamReader CSV = My.FileSystem.OpenTextFileReader(Path);

                while (!CSV.EndOfStream)
                {
                    Arr.Add(CSV.ReadLine());
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000003, e);
                throw;
            }
        }

        public static string EscapeLikeValue(string valueWithoutWildcards)
        {
            StringBuilder sb = new StringBuilder();
            if (Extent.isEmptyString(valueWithoutWildcards))
            {
                return valueWithoutWildcards;
            }
            for (int i = 0; i < valueWithoutWildcards.Length; i++)
            {
                char c = valueWithoutWildcards[i];
                if (c == '*' || c == '%' || c == '[' || c == ']')
                    sb.Append("[").Append(c).Append("]");
                else if (c == '\'')
                    sb.Append("''");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public static DataTable Merge(DataTable DTLeft, DataTable DTRight)
        {
            try
            {
                DataTable DT = new DataTable();
                DataTableCounts DTC = new DataTableCounts();
                if (DTLeft.Rows.Count > DTRight.Rows.Count)
                {
                    DTC.RowC = DTLeft.Rows.Count;
                }
                else
                {
                    DTC.RowC = DTRight.Rows.Count;
                }

                DTC.ColumnC += DTLeft.Columns.Count;
                DTC.ColumnC += DTRight.Columns.Count;

                for (int i = 0; i < DTC.ColumnC; i++)
                {
                    if (i == 0)
                    {
                        DT.Columns.Add(Const.NUM_COLUMN);
                    }
                    else
                    {
                        DT.Columns.Add(i.ToString());
                    }
                }

                for (int i = 1; i <= DTC.RowC; i++)
                {
                    List<object> DR = new List<object>();

                    DR.Add(i.ToString());
                    if (i < DTLeft.Rows.Count)
                    {
                        DR.AddRange(DTLeft.Rows[i].ItemArray.ToList());
                        DR.RemoveAt(1);
                    }
                    if (i < DTRight.Rows.Count)
                    {
                        DR.AddRange(DTRight.Rows[i].ItemArray);
                        if (DR.Count > DTRight.Rows[i].ItemArray.Length + 1)
                        {
                            DR.RemoveAt(DTLeft.Rows[i].ItemArray.Length);
                        }
                    }
                    DT.Rows.Add(DR.ToArray());
                }

                return DT;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000004, e);
                throw;
            }
        }

        public static DataTable MergeWithKey(DataTable DTMain, DataTable DTSub, int KeyColMain, int KeyColSub)
        {
            try
            {
                DataTable DT = new DataTable();
                int ColCount = 0;
                if (DTMain.Rows.Count < DTSub.Rows.Count)
                {
                    SystemAPI.Warning(RWarning.W_0xC0000001);
                    return null;
                }

                ColCount += DTMain.Columns.Count;
                ColCount += DTSub.Columns.Count;

                for (int i = 0; i < ColCount; i++)
                {
                    if (i == 0)
                    {
                        DT.Columns.Add(Const.NUM_COLUMN);
                    }
                    else
                    {
                        DT.Columns.Add("C" + i.ToString());
                    }
                }

                for (int i = 1; i < DTMain.Rows.Count; i++)
                {
                    List<object> DR = new List<object>();

                    DR.Add(i.ToString());
                    DR.AddRange(DTMain.Rows[i].ItemArray.ToList());
                    DR.RemoveAt(1);
                    string X = DR[KeyColMain].ToString();
                    DataRow[] DTRightRow = Search(DR[KeyColMain].ToString(), DTSub, 0, KeyColSub);
                    if (DTRightRow != null)
                    {
                        DR.AddRange(DTRightRow[0].ItemArray.ToList());
                        DR.RemoveAt(DTMain.Rows[i].ItemArray.Length);
                    }

                    DT.Rows.Add(DR.ToArray());
                }
                return DT;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000005, e);
                throw;
            }
        }

        public static DataTable Separate(DataTable DT, int RemoveColBegin, int RemoveColEnd)
        {
            try
            {
                List<int> ColRemove = new List<int>();
                for (int i = RemoveColBegin; i < RemoveColEnd; i++)
                {
                    ColRemove.Add(i);
                }
                return Specified(DT, 0, ColRemove, "");
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000006, e);
                throw;
            }
        }

        public static void WriteCSV(DataTable DT, string Path)
        {
            try
            {
                WriteCSV(DT, Path, ",");
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000007, e);
                throw;
            }
        }

        public static void WriteCSV(DataTable DT, string Path, string Delimeter)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataRow row in DT.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(Delimeter, fields));
                }

                File.WriteAllText(Path, sb.ToString());
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00000008, e);
                throw;
            }
        }
    }
}
