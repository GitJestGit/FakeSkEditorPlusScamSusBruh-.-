﻿#pragma checksum "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E7785ACA77E519231F4642160332FFE2952993B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SkEditorPlus.Windows.Generators {
    
    
    /// <summary>
    /// GuiGenerator
    /// </summary>
    public partial class GuiGenerator : HandyControl.Controls.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SkEditorPlus.Windows.Generators.GuiGenerator generatorWindow;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox nameTextbox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox titleTextbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox rowsTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock howToOpenText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox exampleItemCheckbox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox backgroundCheckbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SkEditorPlus;V1.0.0.0;component/windows/generators/guigenerator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.generatorWindow = ((SkEditorPlus.Windows.Generators.GuiGenerator)(target));
            
            #line 8 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
            this.generatorWindow.KeyUp += new System.Windows.Input.KeyEventHandler(this.OnKey);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nameTextbox = ((HandyControl.Controls.TextBox)(target));
            
            #line 10 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
            this.nameTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FunctionNameChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.titleTextbox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 4:
            this.rowsTextBox = ((HandyControl.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 15 "..\..\..\..\..\Windows\Generators\GuiGenerator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Generate);
            
            #line default
            #line hidden
            return;
            case 6:
            this.howToOpenText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.exampleItemCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.backgroundCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

