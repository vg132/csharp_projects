﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VGSoftware.CodePad.Controls.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TextEditor_HighlightSelectedLine {
            get {
                return ((bool)(this["TextEditor_HighlightSelectedLine"]));
            }
            set {
                this["TextEditor_HighlightSelectedLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TextEditor_ShowTabs {
            get {
                return ((bool)(this["TextEditor_ShowTabs"]));
            }
            set {
                this["TextEditor_ShowTabs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TextEditor_ShowSpaces {
            get {
                return ((bool)(this["TextEditor_ShowSpaces"]));
            }
            set {
                this["TextEditor_ShowSpaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TextEditor_ShowEndOfLine {
            get {
                return ((bool)(this["TextEditor_ShowEndOfLine"]));
            }
            set {
                this["TextEditor_ShowEndOfLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TextEditor_ShowLineNumbers {
            get {
                return ((bool)(this["TextEditor_ShowLineNumbers"]));
            }
            set {
                this["TextEditor_ShowLineNumbers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int TextEditor_TabSize {
            get {
                return ((int)(this["TextEditor_TabSize"]));
            }
            set {
                this["TextEditor_TabSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TextEditor_KeepTabs {
            get {
                return ((bool)(this["TextEditor_KeepTabs"]));
            }
            set {
                this["TextEditor_KeepTabs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Auto")]
        public global::ICSharpCode.TextEditor.Document.IndentStyle TextEditor_IndentStyle {
            get {
                return ((global::ICSharpCode.TextEditor.Document.IndentStyle)(this["TextEditor_IndentStyle"]));
            }
            set {
                this["TextEditor_IndentStyle"] = value;
            }
        }
    }
}
