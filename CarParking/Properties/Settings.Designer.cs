﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarParking.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\ProjectModels;Initial Catalog=loginCP;Integrated Security=T" +
            "rue;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string loginCPConnectionString {
            get {
                return ((string)(this["loginCPConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeo" +
            "ut=30;Encrypt=False;TrustServerCertificate=False")]
        public string LoginDBConnectionString {
            get {
                return ((string)(this["LoginDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-7TC6IQE;Initial Catalog=Logincp;Integrated Security=True;Conn" +
            "ect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string LogincpConnectionString1 {
            get {
                return ((string)(this["LogincpConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP;Initial Catalog=paking;Integrated Security=True;Connect Timeou" +
            "t=30;Encrypt=False;TrustServerCertificate=False")]
        public string pakingConnectionString {
            get {
                return ((string)(this["pakingConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-7TC6IQE;Initial Catalog=ParkingCarrrr;Integrated Security=Tru" +
            "e;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string ParkingCarrrrConnectionString {
            get {
                return ((string)(this["ParkingCarrrrConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-7TC6IQE;Initial Catalog=Data121;Integrated Security=True;Conn" +
            "ect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string Data121ConnectionString {
            get {
                return ((string)(this["Data121ConnectionString"]));
            }
        }
    }
}
