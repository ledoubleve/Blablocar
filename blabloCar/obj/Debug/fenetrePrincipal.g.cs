﻿#pragma checksum "..\..\fenetrePrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2DA6B95E568658A76BD0A4540802B151"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using blabloCar;


namespace blabloCar {
    
    
    /// <summary>
    /// fenetrePrincipal
    /// </summary>
    public partial class fenetrePrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\fenetrePrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listeTrajet;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\fenetrePrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox VilleDepart;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\fenetrePrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox VilleArrivee;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\fenetrePrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rechercheTrajet;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\fenetrePrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox detailTrajet;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\fenetrePrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock villeDep;
        
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
            System.Uri resourceLocater = new System.Uri("/blabloCar;component/fenetreprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\fenetrePrincipal.xaml"
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
            this.listeTrajet = ((System.Windows.Controls.ListBox)(target));
            
            #line 39 "..\..\fenetrePrincipal.xaml"
            this.listeTrajet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listeTrajet_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VilleDepart = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.VilleArrivee = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.rechercheTrajet = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\fenetrePrincipal.xaml"
            this.rechercheTrajet.Click += new System.Windows.RoutedEventHandler(this.rechercheTrajet_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.detailTrajet = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.villeDep = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

