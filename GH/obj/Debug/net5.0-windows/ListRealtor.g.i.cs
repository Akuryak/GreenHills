﻿#pragma checksum "..\..\..\ListRealtor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74768BF5498D61263662216F0BBB8578CE1AA53E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GH;
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


namespace GH {
    
    
    /// <summary>
    /// ListRealtor
    /// </summary>
    public partial class ListRealtor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\ListRealtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameuser;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ListRealtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_textbox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ListRealtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ListRealtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addrealtor_button;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ListRealtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deliterealtor_button;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\ListRealtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RealtorsListListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GH;V1.0.0.0;component/listrealtor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ListRealtor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\ListRealtor.xaml"
            ((GH.ListRealtor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nameuser = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.search_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.search_button = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\ListRealtor.xaml"
            this.search_button.Click += new System.Windows.RoutedEventHandler(this.search_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addrealtor_button = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ListRealtor.xaml"
            this.addrealtor_button.Click += new System.Windows.RoutedEventHandler(this.addrealtor_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deliterealtor_button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\ListRealtor.xaml"
            this.deliterealtor_button.Click += new System.Windows.RoutedEventHandler(this.deliterealtor_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RealtorsListListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

