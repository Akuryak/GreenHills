﻿#pragma checksum "..\..\..\Object(realtor.admin).xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0AAB4E8C284FF1FDA02C7B335A652A229FF4F13"
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
    /// Object_realtor
    /// </summary>
    public partial class Object_realtor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameuser;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_textbox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filter_button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addObject_button;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deliteObject_button;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Object(realtor.admin).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ObjectsListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/GH;V1.0.0.0;component/object(realtor.admin).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Object(realtor.admin).xaml"
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
            
            #line 9 "..\..\..\Object(realtor.admin).xaml"
            ((GH.Object_realtor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
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
            
            #line 25 "..\..\..\Object(realtor.admin).xaml"
            this.search_button.Click += new System.Windows.RoutedEventHandler(this.search_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.filter_button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Object(realtor.admin).xaml"
            this.filter_button.Click += new System.Windows.RoutedEventHandler(this.filter_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addObject_button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Object(realtor.admin).xaml"
            this.addObject_button.Click += new System.Windows.RoutedEventHandler(this.addObject_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deliteObject_button = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Object(realtor.admin).xaml"
            this.deliteObject_button.Click += new System.Windows.RoutedEventHandler(this.deliteObject_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ObjectsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

