﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAOCR_Data_Manager.Resources.Controls {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RCharaSearcher {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RCharaSearcher() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SAOCR_Data_Manager.Resources.Controls.RCharaSearcher", typeof(RCharaSearcher).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 代碼表 的當地語系化字串。
        /// </summary>
        internal static string Layout_CodeTable {
            get {
                return ResourceManager.GetString("Layout_CodeTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 關鍵字 的當地語系化字串。
        /// </summary>
        internal static string Layout_Keyword {
            get {
                return ResourceManager.GetString("Layout_Keyword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 星級 的當地語系化字串。
        /// </summary>
        internal static string Layout_Rarity {
            get {
                return ResourceManager.GetString("Layout_Rarity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 搜尋 的當地語系化字串。
        /// </summary>
        internal static string Layout_Search {
            get {
                return ResourceManager.GetString("Layout_Search", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 角色搜尋 的當地語系化字串。
        /// </summary>
        internal static string Layout_SearchChara {
            get {
                return ResourceManager.GetString("Layout_SearchChara", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 角色系 的當地語系化字串。
        /// </summary>
        internal static string Layout_Series {
            get {
                return ResourceManager.GetString("Layout_Series", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 尋找角色。關鍵字:  的當地語系化字串。
        /// </summary>
        internal static string Log_FindChara1 {
            get {
                return ResourceManager.GetString("Log_FindChara1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 ，星級:  的當地語系化字串。
        /// </summary>
        internal static string Log_FindChara2 {
            get {
                return ResourceManager.GetString("Log_FindChara2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 ，角色系代碼:  的當地語系化字串。
        /// </summary>
        internal static string Log_FindChara3 {
            get {
                return ResourceManager.GetString("Log_FindChara3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 已回傳角色系代碼。代碼:  的當地語系化字串。
        /// </summary>
        internal static string Log_FindSeriesCode {
            get {
                return ResourceManager.GetString("Log_FindSeriesCode", resourceCulture);
            }
        }
    }
}
