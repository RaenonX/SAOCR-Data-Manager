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
using SAOCR_Data_Manager.Resources.Controls;

namespace SAOCR_Data_Manager.Controls.Initialize_Properties
{
    public partial class BasicInfo : UserControl
    {
        CharaData CDT;
        Downloader DL;

        public BasicInfo()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();
                InitializeControlAttribute();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00013001, e);
                throw;
            }
        }

        private void InitializeUIText()
        {
            try
            {
                CharaIDText.Text = RBasicInfo.Layout_CharaID;
                ENText.Text = RBasicInfo.Layout_ENName;
                CVText.Text = RBasicInfo.Layout_CV;
                ElementText.Text = RBasicInfo.Layout_Element;
                WeaponText.Text = RBasicInfo.Layout_Weapon;
                SexText.Text = RBasicInfo.Layout_Sex;
                ReleaseDateText.Text = RBasicInfo.Layout_ReleaseDate;
                GetMethodText.Text = RBasicInfo.Layout_GetMethod;
                FolkNameText.Text = RBasicInfo.Layout_Folkname;
                IntroText.Text = RBasicInfo.Layout_Intro;
                SceneText.Text = RBasicInfo.Layout_Scene;
                PictureTips.Text = RBasicInfo.Layout_ClickToSeePicture;
                RarityText.Text = RBasicInfo.Layout_Rarity;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00013002, e);
                throw;
            }
        }

        private void InitializeEventHandler()
        {
            try
            {
                Element.TextChanged += ElementText_TextChanged;
                Sex.TextChanged += SexText_TextChanged;
                Scene.TextChanged += SceneText_TextChanged;
                GetMethodText.Click += ExtraInfo_Click;
                ReleaseDateText.Click += ExtraInfo_Click;
                FolkNameText.Click += ExtraInfo_Click;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00013003, e);
                throw;
            }
        }

        private void InitializeControlAttribute()
        {
            try
            {
                FolkName.Marquee();
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x00013004, e);
                throw;
            }
        }
    }
}
