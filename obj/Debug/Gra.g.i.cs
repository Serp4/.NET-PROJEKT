﻿#pragma checksum "..\..\Gra.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0A1541BAF1D8C47447F32CFA21AE8E50"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt_na_zaliczenie;
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


namespace Projekt_na_zaliczenie {
    
    
    /// <summary>
    /// Gra
    /// </summary>
    public partial class Gra : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 95 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pol_na_pol;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button telefon;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pytanie_do_publicznosc;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox win_lista;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pytanie;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button A;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button C;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\Gra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button D;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekt_na_zaliczenie;component/gra.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Gra.xaml"
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
            this.pol_na_pol = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\Gra.xaml"
            this.pol_na_pol.Click += new System.Windows.RoutedEventHandler(this.pol_na_pol_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.telefon = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\Gra.xaml"
            this.telefon.Click += new System.Windows.RoutedEventHandler(this.telefon_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pytanie_do_publicznosc = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\Gra.xaml"
            this.pytanie_do_publicznosc.Click += new System.Windows.RoutedEventHandler(this.pytanie_do_publicznosc_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.win_lista = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.Pytanie = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.A = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\Gra.xaml"
            this.A.Click += new System.Windows.RoutedEventHandler(this.A_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.B = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\Gra.xaml"
            this.B.Click += new System.Windows.RoutedEventHandler(this.B_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.C = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\Gra.xaml"
            this.C.Click += new System.Windows.RoutedEventHandler(this.C_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.D = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\Gra.xaml"
            this.D.Click += new System.Windows.RoutedEventHandler(this.D_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
