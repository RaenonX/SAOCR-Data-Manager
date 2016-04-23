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
using System.Diagnostics;
using SAOCR_Data_Manager.Resources.Message;

namespace SAOCR_Data_Manager
{
    public partial class ParamDisplay : UserControl
    {
        public bool DisplayCharacterParameters(CharaData Data)
        {
            try
            {
                if (Data.Data.CharaID.Length != 8)
                {
                    SystemAPI.Warning(RWarning.W_0xC000A001);
                    return false;
                }
                if (Data.Data.DTs.Source == null)
                {
                    SystemAPI.Warning(RWarning.W_0xC000A002);
                    return false;
                }
                if (Extent.isEmptyString(Data.Data.CharaID))
                {
                    SystemAPI.Warning(RWarning.W_0xC000A003);
                    return false;
                }
                if (Extent.isEmptyString(Data.Data.TitleP.Start[(int)DataTitle.CharacterParams].ToString()))
                {
                    SystemAPI.Warning(RWarning.W_0xC000A004);
                    return false;
                }
                if (!DataAPI.Search(Data.Data.DTs.CharaDict, Data.Data.CharaID, (int)ECharaDictCode.ID))
                {
                    SystemAPI.Warning(RWarning.W_0xC000A005);
                    return false;
                }
                
                if (PAk != EParamAwaked.Unawaked)
                {
                    PAk = EParamAwaked.Unawaked;
                }
                if (PLv != EParamLv.Lv1)
                {
                    PLv = EParamLv.Lv1;
                }

                CDT = Data;
                ReFreshData(Data);

                ChooseCharacterStatus(ST_ULv1, EventArgs.Empty);

                if (Convert.ToInt32(Data.Data.CharaID.Substring(6, 1)) < 3)
                {
                    SetStatusButtonEnabled(EParamAwaked.Unawaked);
                } else
                {
                    SetStatusButtonEnabled(EParamAwaked.Null);
                }

                return true;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A011, e);
                throw;
            }
        }

        public void SetStatusButtonEnabled(EParamAwaked EPA = EParamAwaked.Null)
        {
            try
            {
                switch (EPA)
                {
                    case EParamAwaked.Unawaked:
                        ST_ALv1.ButtonEnabled = false;
                        ST_ALvM.ButtonEnabled = false;
                        ST_ULv1.ButtonEnabled = true;
                        ST_ULvM.ButtonEnabled = true;
                        break;
                    case EParamAwaked.Awaked:
                        ST_ALv1.ButtonEnabled = true;
                        ST_ALvM.ButtonEnabled = true;
                        ST_ULv1.ButtonEnabled = false;
                        ST_ULvM.ButtonEnabled = false;
                        break;
                    case EParamAwaked.Null:
                        ST_ALv1.ButtonEnabled = true;
                        ST_ALvM.ButtonEnabled = true;
                        ST_ULv1.ButtonEnabled = true;
                        ST_ULvM.ButtonEnabled = true;
                        break;
                }
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A012, e);
                throw;
            }
        }
    }
}
