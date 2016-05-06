using System;
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
                BADataImported = false;
                CDT = Data;

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
                MarqueeableLabel[] BADes = { Description1, Description2, Description3 };
                Label[][] BAs = { BA1s, BA2s, BA3s };
                for (int i = 0; i < Const.Count.BA; i++)
                {
                    string[] BAData = new string[9];
                    EDisplayStatus EDS = EDisplayStatus.Chinese;
                    switch (i)
                    {
                        case 0:
                            BAData = Data.BA.BA1.GetArray();
                            EDS = Data.BA.BA1.GetDisplayStatus();
                            break;
                        case 1:
                            BAData = Data.BA.BA2.GetArray();
                            EDS = Data.BA.BA2.GetDisplayStatus();
                            break;
                        case 2:
                            BAData = Data.BA.BA3.GetArray();
                            EDS = Data.BA.BA3.GetDisplayStatus();
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
                            } else
                            {
                                BAs[i][j].Text = BAData[(int)EBADataInfo.DesCH];
                                if (EDS == EDisplayStatus.ForceJP)
                                {
                                    BADes[i].BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                                } else
                                {
                                    BADes[i].BackColor = Color.FromArgb((int)EBackColorAlpha.Grey70);
                                }
                                continue;
                            }
                        }
                        BAs[i][j].Text = BAData[(int)EBADataInfo.PWR + j];
                    }
                }

                Description1.Restart();
                Description2.Restart();
                Description3.Restart();

                BADataImported = true;
            }
            catch (Exception e)
            {
                BADataImported = false;
                SystemAPI.Error(RError.E_0x0000E003, e);
                throw;
            }
        }

        /// <returns>系列1色碼、系列1、敘述、分數、系列2色碼、系列2、威力、治癒量</returns>
        public string[] OutputForHTML()
        {
            string[] L =
            {
                SFColorTrans.BASeriesTextT(EnumTranslator.BASeriesTextT(Series1st1.Text)),
                Series1st1.Text,
                Description1.MarqueeText,
                Score1.Text,
                SFColorTrans.BASeriesTextT(EnumTranslator.BASeriesTextT(Series2nd1.Text)),
                Series2nd1.Text,
                Power1.Text,
                Heal1.Text,
                SFColorTrans.BASeriesTextT(EnumTranslator.BASeriesTextT(Series1st2.Text)),
                Series1st2.Text,
                Description2.MarqueeText,
                Score2.Text,
                SFColorTrans.BASeriesTextT(EnumTranslator.BASeriesTextT(Series2nd2.Text)),
                Series2nd2.Text,
                Power2.Text,
                Heal2.Text,
                SFColorTrans.BASeriesTextT(EnumTranslator.BASeriesTextT(Series1st3.Text)),
                Series1st3.Text,
                Description3.MarqueeText,
                Score3.Text,
                SFColorTrans.BASeriesTextT(EnumTranslator.BASeriesTextT(Series2nd3.Text)),
                Series2nd3.Text,
                Power3.Text,
                Heal3.Text,
            };
            return L;
        }
    }
}
