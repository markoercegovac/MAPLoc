﻿#pragma checksum "..\..\EditTip2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1085B582B1F75FAE6F7381D24CEC53BE6EB22860"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// EditTip2
    /// </summary>
    public partial class EditTip2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\EditTip2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imeLokTxt;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\EditTip2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTxt;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\EditTip2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image slikaLokala;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\EditTip2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDodaj;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\EditTip2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox opisLokTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/edittip2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditTip2.xaml"
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
            
            #line 14 "..\..\EditTip2.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imeLokTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.idTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.slikaLokala = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.buttonDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\EditTip2.xaml"
            this.buttonDodaj.Click += new System.Windows.RoutedEventHandler(this.dodajSliku);
            
            #line default
            #line hidden
            return;
            case 6:
            this.opisLokTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 70 "..\..\EditTip2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.slika1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 73 "..\..\EditTip2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.slika2);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 76 "..\..\EditTip2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.slika3);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 79 "..\..\EditTip2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.slika4);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 82 "..\..\EditTip2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.slika5);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 86 "..\..\EditTip2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.izmena);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

