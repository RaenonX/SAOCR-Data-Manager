﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOCR_Data_Manager.Resources.Controls;
using SAOCR_Data_Manager.Resources.Message;
using SAOCR_Data_Manager.Forms;
using Microsoft.VisualBasic.Devices;

namespace SAOCR_Data_Manager.Controls.Initialize_Properties
{
    public partial class BasicInfo : UserControl
    {
        string CharaName;

        private void Picture_Click(object sender, EventArgs e)
        {
            try
            {
                PictureB PB = new PictureB();
                PB.PictureBox.Image = Picture.Image;
                PB.Title.Text = CharaID.Text + " - " + CharaName;
                PB.Show();
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00013006, ex);
                throw;
            }
        }

        private void SceneText_TextChanged(object sender, EventArgs e)
        {
            Label LB = (Label)sender;

            EScene Scene = EnumTranslator.SceneT(LB.Text);

            switch (Scene)
            {
                case EScene.SAO:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.LightBlue);
                    break;
                case EScene.ALO:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Green);
                    break;
                case EScene.GGO:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Purple);
                    break;
                case EScene.ALL:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Orange);
                    break;
                default:
                    SystemAPI.Warning(RWarning.W_0xC0013001);
                    LB.ForeColor = Color.FromArgb((int)EBackColorAlpha.White);
                    break;
            }
        }

        private void SexText_TextChanged(object sender, EventArgs e)
        {
            Label LB = (Label)sender;

            ESex Sex = EnumTranslator.SexT(LB.Text);

            switch (Sex)
            {
                case ESex.Male:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.LightBlue);
                    break;
                case ESex.Female:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                    break;
                default:
                    SystemAPI.Warning(RWarning.W_0xC0013002);
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.White);
                    break;
            }
        }

        private void ElementText_TextChanged(object sender, EventArgs e)
        {
            Label LB = (Label)sender;

            EElement Element = EnumTranslator.ElementT(LB.Text);

            switch (Element)
            {
                case EElement.Fire:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Red);
                    break;
                case EElement.Water:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.LightBlue);
                    break;
                case EElement.Wind:
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.Green);
                    break;
                default:
                    SystemAPI.Warning(RWarning.W_0xC0013003);
                    LB.BackColor = Color.FromArgb((int)EBackColorAlpha.White);
                    break;
            }
        }

        private void ExtraInfo_Click(object sender, EventArgs e)
        {
            try
            {
                new DataRegister(EDataRegCategory.CharaInfo, Const.Path.CHARA_DIM, CDT.Info.Extra.GetArray()).ShowDialog();
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x00013007, ex);
                throw;
            }
        }

        private void Picture_Download_Succeed(string PicLocation)
        {
            Picture.ImageLocation = PicLocation;
            Picture.Click += Picture_Click;
        }

        private void Picture_Download_Failed(object sender, EventArgs e)
        {
            Computer My = new Computer();
            Downloader DL = (Downloader)sender;

            My.FileSystem.DeleteFile(DL.GetFileLocation(DataSource.Local));
            Picture.Image = Properties.Resources.Error;
            Picture.Click -= Picture_Click;
        }

        private void Picture_Download_Begin(object sender, EventArgs e)
        {
            Picture.Image = Properties.Resources.Loading;
            Picture.Click -= Picture_Click;
        }
    }
}
