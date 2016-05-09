using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Properties;
using SAOCR_Data_Manager.APIs;
using SAOCR_Data_Manager.Resources.Controls;

namespace SAOCR_Data_Manager.Forms
{
    public partial class CharaDataDisplay : UserControl
    {
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                ActiveControl = Panel;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00019007, ex);
                throw;
            }
        }

        private void Favorite_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                isFavorite = !isFavorite;
                RefreshFavoriteStatus();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00019006, ex);
                throw;
            }
        }

        private void RefreshFavoriteStatus()
        {
            try
            {
                AppConfig AC = new AppConfig();
                
                if (isFavorite)
                {
                    if (!Extent.isContainFullElement(AC.Chara_Favorite.Cast<string>().ToList(), CDT.Data.CharaID))
                    {
                        AC.Chara_Favorite.Add(CDT.Data.CharaID);
                        StatusLog.Log(RCDDisplay.Log_FavoriteAdded + CDT.Data.CharaID);
                    }
                    AC.Save();
                    Favorite.ButtonBackColor = Color.FromArgb((int)EBackColorBreeze.Yellow);
                    CharacterName.ColorEnd = Color.FromArgb((int)EBackColorBreeze.Red);
                    FavoriteAdded?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    if (Extent.isContainFullElement(AC.Chara_Favorite.Cast<string>().ToList(), CDT.Data.CharaID))
                    {
                        AC.Chara_Favorite.Remove(CDT.Data.CharaID);
                        StatusLog.Log(RCDDisplay.Log_FavoriteDeleted + CDT.Data.CharaID);
                    }
                    AC.Save();
                    Favorite.ButtonBackColor = Color.FromArgb((int)EForeColor.Grey70);
                    CharacterName.ColorEnd = Color.FromArgb((int)EBackColorBreeze.Yellow);
                    FavoriteRemoved?.Invoke(this, EventArgs.Empty);
                }
                CharacterName.BreezeBegin();

                FavoriteSaved?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00019005, e);
                throw;
            }
        }

        private void CharaDataDisplay_SizeChanged(object sender, EventArgs e)
        {
            Border.Size = new Size(Size.Width - 1, Size.Height - 1);
            Panel.Size = new Size(Size.Width - 1, Size.Height - CharacterName.Size.Height - 1);
        }

        private void HTML_Generate(object sender, EventArgs e)
        {
            try
            {
                if (CDT == null)
                {
                    return;
                }
                if (!HTMLMade)
                {
                    ToWrite = "";
                    StatusLog.Log(RCDDisplay.Log_HTMLOutputBegin + CDT.Data.CharaID);

                    List<string> Template = new List<string>(), Data = new List<string>();

                    Data.AddRange(BasicInfo.OutputForHTML());
                    Data.AddRange(BA.OutputForHTML());
                    Data.AddRange(LS.OutputForHTML());

                    MessageDialog MD = new MessageDialog(RCDDisplay.Message_KeyInRecommendTypeCode, RCDDisplay.Message_RecommendTypeTip, MessageBoxButtonStyle.ReturnValue);
                    if (MD.ShowDialog() == DialogResult.OK)
                    {
                        string Return = MD.ReturnValue;
                        EParamType EPT = EParamType.Null;

                        if (!Extent.isEmptyString(Return) && Convert.ToInt32(Return) >= 0 && Convert.ToInt32(Return) <= 3)
                        {
                            EPT = (EParamType)Convert.ToInt32(Return);
                        }
                        
                        Data.Add(SFColorTrans.CharaTypeT(EPT));
                        Data.Add(EnumTranslator.CharaTypeT(EPT));
                    } else
                    {
                        StatusLog.Log(RCDDisplay.Log_HTMLOutputAbort + CDT.Data.CharaID);
                        new MessageDialog(RCDDisplay.Message_HTMLOutputCancelled + CDT.Data.CharaID).ShowDialog();
                        return;
                    }

                    Data.AddRange(Param.OutputForHTML());
                    DataAPI.LoadCSV(ref Template, Const.Path.CHARA_HTML_TEMPLATE);

                    My.FileSystem.WriteAllText(Const.Path.CHARA_HTML_OUTPUT, "", false);
                    for (int i = 0; i < Template.Count; i++)
                    {
                        ToWrite += Template[i];
                        try
                        {
                            ToWrite += Data[i];
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                        }
                    }
                    HTMLMade = true;
                }
                Clipboard.SetText(ToWrite);
                new MessageDialog(RCDDisplay.Message_HTMLOutputComplete1 + CDT.Data.CharaID + RCDDisplay.Message_HTMLOutputComplete2).ShowDialog();
                StatusLog.Log(RCDDisplay.Log_HTMLOutputCompleted + CDT.Data.CharaID);
            }
            catch (Exception ex)
            {
                HTMLMade = false;
                StatusLog.Log(RCDDisplay.Log_HTMLOutputAbort + CDT.Data.CharaID);
                SystemAPI.Error(RError.E_0x00019008, ex);
                throw;
            }
        }

        private void CharacterName_Click(object sender, EventArgs e)
        {
            try
            {
                if (CDT != null)
                {
                    if (!Extent.isEmptyString(CDT.Data.CharaID))
                    {
                        Clipboard.SetText(CharacterName.LText);
                        StatusLog.Log(RCDDisplay.Log_NameCopied + CDT.Data.CharaID);
                    }
                }
            }
            catch (Exception ex)
            {
                StatusLog.Log(RCDDisplay.Log_NameCopyAborted + CDT.Data.CharaID);
                SystemAPI.Error(RError.E_0x00019009, ex);
                throw;
            }
        }
    }
}
