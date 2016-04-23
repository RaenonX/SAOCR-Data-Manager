﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Forms;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Resources.Controls;

namespace SAOCR_Data_Manager.Controls.Initialize_Properties
{
    public partial class BasicInfo : UserControl
    {
        public void DisplayCharacterBasicInfo(CharaData Data)
        {
            try
            {
                CharaID.Text = Data.Data.CharaID;
                Rarity.Text = Data.Data.CharaID.Substring(6, 1);
                CharaName = Data.Info.Basic.GetBasicInfo(EBasicInfoCode.JP_NAME);

                Control[] BasicInfoL = { EN, CV, Intro };
                for (int i = 1; i <= BasicInfoL.Length; i++)
                {
                    BasicInfoL[i - 1].Text = Data.Info.Basic.GetBasicInfo((EBasicInfoCode)i);
                }

                Label[] BattleInfoL = { Weapon, Element, Scene, Sex };
                for (int i = 0; i < BattleInfoL.Length; i++)
                {
                    BattleInfoL[i].Text = Data.Info.BattleRelated.GetStringArray()[i];
                }

                GetMethod.Text = Data.Info.Extra.GetMethod;
                DateTime DTT = Data.Info.Extra.ReleaseDate;
                if (DTT.Year == 1)
                {
                    ReleaseDate.Text = RBasicInfo.Output_Unknown;
                }
                else
                {
                    ReleaseDate.Text = DTT.ToString("yyyy年MM月dd日 (" + EnumTranslator.WeekDayT(DTT.DayOfWeek) + ")");
                }

                FolkName.MarqueeText = Data.Info.Extra.FolkName;
                FolkName.Restart();

                Picture.ImageLocation = null;
                Picture.ImageLocation = Const.URL.PIC_AREA + Const.URL.CHARA_PIC + "/" + Data.Data.CharaID + ".jpg";
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00013005, e);
                throw;
            }
        }
    }
}