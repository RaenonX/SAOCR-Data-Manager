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
using Microsoft.VisualBasic.Devices;

namespace SAOCR_Data_Manager.Forms
{
    public partial class CharaDataDisplay : UserControl
    {
        public delegate void RefreshFavorite(object sender, EventArgs e);
        public event EventHandler FavoriteAdded, FavoriteRemoved, LoadCompleted, FavoriteSaved;
        public bool isFavorite, HTMLMade;
        string ToWrite = "";
        CharaData CDT;
        Computer My = new Computer();

        public CharaDataDisplay()
        {
            try
            {
                InitializeComponent();
                InitializeEventHandler();
                InitializeUIText();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00019001, e);
                throw;
            }
        }

        private void InitializeEventHandler()
        {
            try
            {
                Border.Paint += SystemAPI.DrawBorderWhite;
                Panel.MouseEnter += Panel_MouseEnter;
                Favorite.ButtonClick += Favorite_ButtonClick;
                SizeChanged += CharaDataDisplay_SizeChanged;
                CharacterName.LabelClick += CharacterName_Click;
                CharacterName.LabelDoubleClick += HTML_Generate;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00019002, e);
                throw;
            }
        }
       
        private void InitializeUIText()
        {
            try
            {
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00019003, e);
                throw;
            }
        }
    }
}
