﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubtitlesMule.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.bsplayer-subtitles.com/index.php?cmd=search&p=exploresub&q={0}&lang={1" +
            "}")]
        public string SearchURL {
            get {
                return ((string)(this["SearchURL"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HRV")]
        public string DefaultLanguage {
            get {
                return ((string)(this["DefaultLanguage"]));
            }
            set {
                this["DefaultLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.getsubtitle.com/webService/download_subtitle.php?{0}")]
        public string FileDownloadURL {
            get {
                return ((string)(this["FileDownloadURL"]));
            }
            set {
                this["FileDownloadURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("VladimirZD")]
        public string OpenSubtitlesUserName {
            get {
                return ((string)(this["OpenSubtitlesUserName"]));
            }
            set {
                this["OpenSubtitlesUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lignja!@")]
        public string OpenSubtitlesPassword {
            get {
                return ((string)(this["OpenSubtitlesPassword"]));
            }
            set {
                this["OpenSubtitlesPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OSTestUserAgent")]
        public string OpenSubtitlesUserAgent {
            get {
                return ((string)(this["OpenSubtitlesUserAgent"]));
            }
            set {
                this["OpenSubtitlesUserAgent"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://api.opensubtitles.org/xml-rpc")]
        public string OpenSubtitleApiURL {
            get {
                return ((string)(this["OpenSubtitleApiURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".mkv;.mp4")]
        public string FileTypesToScan {
            get {
                return ((string)(this["FileTypesToScan"]));
            }
        }
    }
}
