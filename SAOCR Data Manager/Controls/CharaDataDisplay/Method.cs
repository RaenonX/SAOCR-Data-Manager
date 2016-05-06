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
using SAOCR_Data_Manager.Resources.Forms;
using SAOCR_Data_Manager.Properties;

namespace SAOCR_Data_Manager.Forms
{
    public partial class CharaDataDisplay : UserControl
    {
        public void DisplayCharacterData(CharaData Data, RefreshFavorite RefreshFavorite)
        {
            try
            {
                HTMLMade = false;
                AppConfig AC = new AppConfig();

                if (Data.CreateSucceed)
                {
                    CDT = Data;
                    isFavorite = Extent.isContainFullElement(AC.Chara_Favorite.Cast<string>().ToList(), Data.Data.CharaID);
                    RefreshFavoriteStatus();

                    Favorite.ButtonEnabled = true;

                    BasicInfo.DisplayCharacterBasicInfo(Data);
                    CharacterName.LText = Data.Info.Basic.GetBasicInfo(EBasicInfoCode.JP_NAME);
                    CharacterName.BreezeStop();
                    CharacterName.BreezeBegin();
                    BA.DisplayCharacterBA(Data);
                    Param.DisplayCharacterParameters(Data);
                    LS.DisplayCharacterLeaderSkill(Data);

                    FavoriteSaved += new EventHandler(RefreshFavorite);

                    LoadCompleted?.Invoke(this, EventArgs.Empty);
                } else
                {
                    SystemAPI.Warning(RWarning.W_0xC0019001);
                    return;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00019004, e);
                throw;
            }
        }
    }
}
