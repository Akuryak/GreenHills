﻿#pragma checksum "..\..\..\Realtor(cabinet).xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C91B62E2170CD7E47AA7B8D8CE1E45C3909AA9A"
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
    /// Realtor_cabinet_
    /// </summary>
    public partial class Realtor_cabinet_ : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Realtor(cabinet).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cabinet_button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Realtor(cabinet).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button object_button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Realtor(cabinet).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button client_button;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Realtor(cabinet).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button documents_button;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Realtor(cabinet).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button power_button;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Realtor(cabinet).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Realtor;
        
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
            System.Uri resourceLocater = new System.Uri("/GH;V1.0.0.0;component/realtor(cabinet).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Realtor(cabinet).xaml"
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
            
            #line 9 "..\..\..\Realtor(cabinet).xaml"
            ((GH.Realtor_cabinet_)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cabinet_button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Realtor(cabinet).xaml"
            this.cabinet_button.Click += new System.Windows.RoutedEventHandler(this.cabinet_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.object_button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Realtor(cabinet).xaml"
            this.object_button.Click += new System.Windows.RoutedEventHandler(this.object_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.client_button = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Realtor(cabinet).xaml"
            this.client_button.Click += new System.Windows.RoutedEventHandler(this.client_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.documents_button = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Realtor(cabinet).xaml"
            this.documents_button.Click += new System.Windows.RoutedEventHandler(this.documents_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.power_button = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Realtor(cabinet).xaml"
            this.power_button.Click += new System.Windows.RoutedEventHandler(this.power_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Realtor = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

