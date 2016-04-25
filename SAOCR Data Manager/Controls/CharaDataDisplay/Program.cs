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
                    if (!Extent.isContainFullElement(AC.Chara_Favorite.Cast<string>().ToList(), LoadedData.Data.CharaID))
                    {
                        AC.Chara_Favorite.Add(LoadedData.Data.CharaID);
                        StatusLog.Log(RCDDisplay.Log_FavoriteAdded + LoadedData.Data.CharaID);
                    }
                    AC.Save();
                    Favorite.ButtonBackColor = Color.FromArgb((int)EBackColorBreeze.Yellow);
                    CharacterName.ColorEnd = Color.FromArgb((int)EBackColorBreeze.Red);
                    FavoriteAdded?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    if (Extent.isContainFullElement(AC.Chara_Favorite.Cast<string>().ToList(), LoadedData.Data.CharaID))
                    {
                        AC.Chara_Favorite.Remove(LoadedData.Data.CharaID);
                        StatusLog.Log(RCDDisplay.Log_FavoriteDeleted + LoadedData.Data.CharaID);
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
    }
}
