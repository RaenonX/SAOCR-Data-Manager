﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAOCR_Data_Manager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class LSScoring : global::System.Configuration.ApplicationSettingsBase {
        
        private static LSScoring defaultInstance = ((LSScoring)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LSScoring())));
        
        public static LSScoring Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double MPC_STR {
            get {
                return ((double)(this["MPC_STR"]));
            }
            set {
                this["MPC_STR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double MPC_VIT {
            get {
                return ((double)(this["MPC_VIT"]));
            }
            set {
                this["MPC_VIT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.3")]
        public double MPC_INT {
            get {
                return ((double)(this["MPC_INT"]));
            }
            set {
                this["MPC_INT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double MPC_MEN {
            get {
                return ((double)(this["MPC_MEN"]));
            }
            set {
                this["MPC_MEN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.7")]
        public double MPC_HP {
            get {
                return ((double)(this["MPC_HP"]));
            }
            set {
                this["MPC_HP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.3")]
        public double MPC_SS {
            get {
                return ((double)(this["MPC_SS"]));
            }
            set {
                this["MPC_SS"] = value;
            }
        }
    }
}