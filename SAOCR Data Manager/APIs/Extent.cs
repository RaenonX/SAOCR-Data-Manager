using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public class Extent
    {
        /// <summary>
        /// 回傳特定數值於資料陣列中是否為最大值。
        /// </summary>
        /// <param name="ArrayToCompare">資料陣列</param>
        /// <param name="NumberWantToCheckInArray">特定數值</param>
        /// <returns>若為是則回傳true，否則回傳false</returns>
        public static bool isLargest(int[] ArrayToCompare, int Start, int End, int NumberWantToCheckInArray)
        {
            List<int> Array = new List<int>();

            if (Start > End)
            {
                throw new ArgumentException(RError.Error_ArrayWithSectionNotLegal);
            }
            if (ArrayToCompare.Length <= End)
            {
                throw new IndexOutOfRangeException(RError.Error_ArrayOutOfBound);
            }
            for (int i = Start; i <= End; i++)
            {
                Array.Add(ArrayToCompare[i]);
            }

            if (NumberWantToCheckInArray == Array.Max())
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// 將陣列根據大小重新排列，不更動原始陣列。(由大到小)
        /// </summary>
        /// <param name="Array">要重新排列的陣列。</param>
        public static int[] SortArray(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; Array.Length < 15; j++)
                {
                    if (Array[j] < Array[i])
                    {
                        int tmp = Array[j];
                        Array[j] = Array[i];
                        Array[i] = tmp;
                    }
                }
            }

            return Array;
        }

        /// <summary>
        /// 將陣列根據大小重新排列，會直接改變原始陣列的排序。(由大到小)
        /// </summary>
        /// <param name="Array">要重新排列的陣列。</param>
        public static void SortArrayReference(ref int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; Array.Length < 15; j++)
                {
                    if (Array[j] < Array[i])
                    {
                        int tmp = Array[j];
                        Array[j] = Array[i];
                        Array[i] = tmp;
                    }
                }
            }
        }

        public static EEquipType IDtoIdentifyEquipType(string ID)
        {
            return (EEquipType)ID.Length;
        }

        /// <summary>
        /// 測試字串是否為空字串，如果是空則傳回true，否則回傳false。
        /// </summary>
        /// <param name="str">檢測原始字串。</param>
        /// <returns>空字串結果。</returns>
        public static bool isEmptyString(string str)
        {
            if (str == null || str == "" || str == RWarning.W_0xC0000002.Replace("\\n", " ") || str == RWarning.W_0xC0000003.Replace("\\n", " "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isContainFullElement<T>(List<T> array, T itemToCheck)
        {
            if (array != null)
            {
                foreach (T item in array)
                {
                    if (item.Equals(itemToCheck))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void VerifyTextIsNum(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void VerifyLetterDigitOnly(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 文字輸入無效化。
        /// </summary>
        public static void DisableKeyEnter(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static string GetRandomString()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool HaveConnection()
        {
            Network N = new Network();
            return N.IsAvailable;
        }
    }
}
