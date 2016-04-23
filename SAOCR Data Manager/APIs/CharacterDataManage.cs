using Microsoft.VisualBasic.Devices;
using SAOCR_Data_Manager.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOCR_Data_Manager
{
    public class CharaAPI
    {
        /// <summary>
        /// 獲取覺醒後的角色的角色ID
        /// </summary>
        /// <param name="OriginalID">原始角色ID。</param>
        /// <returns>覺醒後的角色ID</returns>
        public static string AwakedID(string OriginalID)
        {
            try
            {
                int Rarity = Convert.ToInt32(OriginalID.Substring(6, 1));
                Rarity += 1;
                string RarityString = Convert.ToString(Rarity);

                OriginalID = OriginalID.Remove(6, 1);
                OriginalID = OriginalID.Insert(6, RarityString);

                OriginalID = OriginalID.Remove(7, 1);
                OriginalID = OriginalID.Insert(7, "6");

                return OriginalID;
            }
            catch (Exception)
            {
                return OriginalID;
            }
        }
    }
}
