﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager
{
    public partial class BaDisplay : UserControl
    {
        public void DisplayCharacterBA(CharaData Data)
        {
            try
            {
                if (Data.Data.CharaID.Length != 8)
                {
                    SystemAPI.Warning(RWarning.W_0xC000E001);
                }
                if (Data.Data.DTs.Source == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC000E002);
                    return;
                }
                if (Extent.isEmptyString(Data.Data.CharaID))
                {
                    SystemAPI.Warning(RWarning.W_0xC000E003);
                    return;
                }
                if (Extent.isEmptyString(Data.Data.TitleP.Start[(int)DataTitle.CharacterParams].ToString()))
                {
                    SystemAPI.Warning(RWarning.W_0xC000E004);
                    return;
                }
                if (Extent.isEmptyString(Data.Data.TitleP.Start[(int)DataTitle.CharacterBATable].ToString()))
                {
                    SystemAPI.Warning(RWarning.W_0xC000E005);
                    return;
                }
                if (!DataAPI.Search(Data.Data.DTs.Source, Data.Data.CharaID, (int)EParamSecCol.ID))
                {
                    SystemAPI.Warning(RWarning.W_0xC000E006);
                    return;
                }

                Label[] BA1s = { Power1, Heal1, Description1.TextLabel, Score1, Series1st1, Series2nd1 };
                Label[] BA2s = { Power2, Heal2, Description2.TextLabel, Score2, Series1st2, Series2nd2 };
                Label[] BA3s = { Power3, Heal3, Description3.TextLabel, Score3, Series1st3, Series2nd3 };
                Label[][] BAs = { BA1s, BA2s, BA3s };
                for (int i = 0; i < Const.Count.BA; i++)
                {
                    string[] BAData = new string[9];
                    switch (i)
                    {
                        case 0:
                            BAData = Data.BA.BA1.GetArray();
                            break;
                        case 1:
                            BAData = Data.BA.BA2.GetArray();
                            break;
                        case 2:
                            BAData = Data.BA.BA3.GetArray();
                            break;
                    }

                    for (int j = 0; j < BA1s.Length; j++)
                    {
                        if ((int)EBADataInfo.PWR + j == (int)EBADataInfo.DesCH)
                        {
                            if (!TextTranslate)
                            {
                                BAs[i][j].Text = BAData[(int)EBADataInfo.DesJP];
                                continue;
                            }
                        }
                        BAs[i][j].Text = BAData[(int)EBADataInfo.PWR + j];
                    }
                }

                Description1.Restart();
                Description2.Restart();
                Description3.Restart();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000E003, e);
                throw;
            }
        }
    }
}