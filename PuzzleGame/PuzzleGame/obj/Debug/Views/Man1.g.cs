﻿#pragma checksum "..\..\..\Views\Man1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1AB8860F6DD27EFF0164D795766A8CC23DD713901B3D75A9A80EFAE47D302803"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PuzzleGame.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using XamlAnimatedGif;


namespace PuzzleGame.Views {
    
    
    /// <summary>
    /// Man1
    /// </summary>
    public partial class Man1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gau1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hoa;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gau;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gau2;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid report;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\Man1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border boderstart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PuzzleGame;component/views/man1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Man1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Views\Man1.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gau1 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.hoa = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.gau = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.gau2 = ((System.Windows.Controls.Image)(target));
            
            #line 59 "..\..\..\Views\Man1.xaml"
            this.gau2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Feast_MouseDown);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\Views\Man1.xaml"
            this.gau2.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Feast_MouseUp);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\Views\Man1.xaml"
            this.gau2.MouseMove += new System.Windows.Input.MouseEventHandler(this.Feast_MouseMove);
            
            #line default
            #line hidden
            return;
            case 6:
            this.report = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.boderstart = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            
            #line 90 "..\..\..\Views\Man1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

