﻿#pragma checksum "..\..\..\Pages\RegistrationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0FE9906789F3C83FB7FD87A75D567267027031568FC466385315E23542BB3DE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PotionBook.Pages;
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


namespace PotionBook.Pages {
    
    
    /// <summary>
    /// RegistrationPage
    /// </summary>
    public partial class RegistrationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSurname;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPatronymic;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtLogin;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TxtPass;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPassRep;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/PotionBook;component/pages/registrationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RegistrationPage.xaml"
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
            this.TxtSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.TxtPassRep = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\RegistrationPage.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

