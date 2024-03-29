﻿#pragma checksum "..\..\..\SettingsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2D1690D923B79F1AFE81EE0E354D979CD1E73EE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GPR5100_LevelEditor;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GPR5100_LevelEditor {
    
    
    /// <summary>
    /// SettingsWindow
    /// </summary>
    public partial class SettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_CloseWindow;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_SelectTilesheet;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_SliceTileWidth;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Btn_SyncDimensions;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_SliceTileHeight;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GPR5100_LevelEditor;component/settingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SettingsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\SettingsWindow.xaml"
            ((GPR5100_LevelEditor.SettingsWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\SettingsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_CloseWindow = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\SettingsWindow.xaml"
            this.Btn_CloseWindow.Click += new System.Windows.RoutedEventHandler(this.Btn_CloseWindow_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_SelectTilesheet = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\SettingsWindow.xaml"
            this.Btn_SelectTilesheet.Click += new System.Windows.RoutedEventHandler(this.OnClick_SelectTilesheet);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Txt_SliceTileWidth = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\SettingsWindow.xaml"
            this.Txt_SliceTileWidth.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txt_SliceTileWidth_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_SyncDimensions = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 58 "..\..\..\SettingsWindow.xaml"
            this.Btn_SyncDimensions.Click += new System.Windows.RoutedEventHandler(this.Btn_SyncDimensions_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Txt_SliceTileHeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 69 "..\..\..\SettingsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClick_SliceTilesheet);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

