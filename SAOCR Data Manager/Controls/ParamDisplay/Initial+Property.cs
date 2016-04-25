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
using SAOCR_Data_Manager.Resources.Controls;

namespace SAOCR_Data_Manager
{
    public partial class ParamDisplay : UserControl
    {
        int Param1st = 0, Param2nd = 1, Param3rd = 2, Param4th = 3;
        
        Size ControlSize;
        CharaData CDT;

        EParamLv PLv = EParamLv.Null;
        EParamAwaked PAk = EParamAwaked.Null;

        public event EventHandler SortReArrange;

        public ParamDisplay()
        {
            try
            {
                InitializeComponent();
                InitializeUIText();
                InitializeEventHandler();
                SizeChanged += ParamDisplay_SizeChanged;
                ControlSize = Size;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A001, e);
                throw;
            }
        }

        private void ParamDisplay_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                Size = ControlSize;
            }
            catch (Exception ex)
            {
                SystemAPI.Error(RError.E_0x0000A002, ex);
                throw;
            }
        }

        public void InitializeUIText()
        {
            try
            {
                //GroupBoxes
                ST.Text = RParamI.Layout_Level;
                GR.Text = RParamI.Layout_GrowRateText;
                PR_MainBox.Text = RParamI.Layout_ParamMain;
                DS.Text = RParamI.Layout_Distribution;

                //in Level
                ST_ALv1.ButtonText = RParamI.Layout_LevelAwaked + RParamI.Layout_LevelLv1;
                ST_ALvM.ButtonText = RParamI.Layout_LevelAwaked + RParamI.Layout_LevelLvMAX;
                ST_ULv1.ButtonText = RParamI.Layout_LevelUnawaked + RParamI.Layout_LevelLv1;
                ST_ULvM.ButtonText = RParamI.Layout_LevelUnawaked + RParamI.Layout_LevelLvMAX;

                //in Params
                PR_STR.Text = RParamI.Layout_ParamSTR;
                PR_VIT.Text = RParamI.Layout_ParamVIT;
                PR_INT.Text = RParamI.Layout_ParamINT;
                PR_MEN.Text = RParamI.Layout_ParamMEN;
                PR_HP.Text = RParamI.Layout_ParamHP;

                //in Grow Rate
                GR_HPText.Text = RParamI.Layout_GrowRateHP;
                GR_ParamText.Text = RParamI.Layout_GrowRateParams;
                GR_HPx.Text = RParamI.Layout_GrowRateMultiplication;
                GR_Paramx.Text = RParamI.Layout_GrowRateMultiplication;

                //in Distribution
                DS_STRText.Text = RParamI.Layout_ParamSTR;
                DS_VITText.Text = RParamI.Layout_ParamVIT;
                DS_INTText.Text = RParamI.Layout_ParamINT;
                DS_MENText.Text = RParamI.Layout_ParamMEN;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A003, e);
                throw;
            }
        }

        public void InitializeEventHandler()
        {
            try
            {
                ST_ALv1.ButtonClick += ChooseCharacterStatus;
                ST_ALvM.ButtonClick += ChooseCharacterStatus;
                ST_ULv1.ButtonClick += ChooseCharacterStatus;
                ST_ULvM.ButtonClick += ChooseCharacterStatus;

                ST_ALv1.ButtonClick += (sender, e) => ReFreshData(CDT);
                ST_ALvM.ButtonClick += (sender, e) => ReFreshData(CDT);
                ST_ULv1.ButtonClick += (sender, e) => ReFreshData(CDT);
                ST_ULvM.ButtonClick += (sender, e) => ReFreshData(CDT);

                SortReArrange += ReArrange;
            }
            catch (Exception e)
            {
                SystemAPI.Error(RError.E_0x0000A004, e);
                throw;
            }
        }

        /// <summary>
        /// 要顯示在第一行的角色型態。
        /// </summary>
        [Bindable(true), Category("Parameters Distributing Options"),
          Description("參數於參數陣列中的配置方法。此為第1個~第10個參數所配置的種類，同時，也是顯示在第一排的參數。")]
        public EParamType TypeParamAt1st
        {
            get
            {
                try
                {
                    return (EParamType)Param1st;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A005, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    SortReArrange?.Invoke(this, EventArgs.Empty);
                    Param1st = (int)value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A006, e);
                    throw;
                }
              
            }
        }

        /// <summary>
        /// 要顯示在第二行的角色型態。
        /// </summary>
        [Bindable(true), Category("Parameters Distributing Options"),
          Description("參數於參數陣列中的配置方法。此為第11個~第20個參數所配置的種類，同時，也是顯示在第二排的參數。")]
        public EParamType TypeParamAt2nd
        {
            get
            {
                try
                {
                    return (EParamType)Param2nd;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A007, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    SortReArrange?.Invoke(this, EventArgs.Empty);
                    Param2nd = (int)value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A008, e);
                    throw;
                }
            }
        }
        
        /// <summary>
        /// 要顯示在第三行的角色型態。
        /// </summary>
        [Bindable(true), Category("Parameters Distributing Options"),
          Description("參數於參數陣列中的配置方法。此為第21個~第30個參數所配置的種類，同時，也是顯示在第三排的參數。")]
        public EParamType TypeParamAt3rd
        {
            get
            {
                try
                {
                    return (EParamType)Param3rd;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A009, e);
                    throw;
                }
            }

            set
            {
                try
                {
                    SortReArrange?.Invoke(this, EventArgs.Empty);
                    Param3rd = (int)value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A00A, e);
                    throw;
                }
            }
        }

        /// <summary>
        /// 要顯示在第四行的角色型態。
        /// </summary>
        [Bindable(true), Category("Parameters Distributing Options"),
          Description("參數於參數陣列中的配置方法。此為第31個~第40個參數所配置的種類，同時，也是顯示在第四排的參數。")]
        public EParamType TypeParamAt4th
        {
            get
            {
                try
                {
                    return (EParamType)Param4th;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A00B, e);
                    throw;
                }
               
            }

            set
            {
                try
                {
                    SortReArrange?.Invoke(this, EventArgs.Empty);
                    Param4th = (int)value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A00C, e);
                    throw;
                }
               
            }
        }

        /// <summary>
        /// 顯示中的參數所對應的等級。
        /// </summary>
        [Bindable(true), Category("Parameters Displaying Options"),
          Description("顯示中的參數所對應的等級。")]
        public EParamLv Lv
        {
            get
            {
                try
                {
                    return PLv;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A00D, e);
                    throw;
                }
            }
            set
            {
                try
                {
                    PLv = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A00E, e);
                    throw;
                }
            }
        }

        /// <summary>
        /// 顯示中的參數所對應的覺醒狀態。
        /// </summary>
        [Bindable(true), Category("Parameters Displaying Options"),
          Description("顯示中的參數所對應的覺醒狀態。")]
        public EParamAwaked Awaked
        {
            get
            {
                try
                {
                    return PAk;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A00F, e);
                    throw;
                }
            }
            set
            {
                try
                {
                    PAk = value;
                }
                catch (Exception e)
                {
                    SystemAPI.Error(RError.E_0x0000A010, e);
                    throw;
                }
            }
        }
    }
}
