﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeAutomationSimulator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HostName=tt-homeautomation-iothub.azure-devices.net;DeviceId=hub-weyer-1;SharedAc" +
            "cessKey=Q84IfO+VxR/HYv50MiJ7BE0o/2ul88m120facuaBoks=")]
        public string IotHubConnectionString {
            get {
                return ((string)(this["IotHubConnectionString"]));
            }
            set {
                this["IotHubConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("hub-weyer-1")]
        public string HubDeviceId {
            get {
                return ((string)(this["HubDeviceId"]));
            }
            set {
                this["HubDeviceId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15000")]
        public int MaxTimeToFinish {
            get {
                return ((int)(this["MaxTimeToFinish"]));
            }
            set {
                this["MaxTimeToFinish"] = value;
            }
        }
    }
}
