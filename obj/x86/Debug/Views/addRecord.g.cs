﻿#pragma checksum "..\..\..\..\Views\addRecord.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68FAAC7F591E8D48957D7D613F1CF2711177618F8928B6C33F3038CE3ED5208D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SchoolProject;
using SchoolProject.Helpers;
using SchoolProject.ViewModel;
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


namespace SchoolProject {
    
    
    /// <summary>
    /// addRecord
    /// </summary>
    public partial class addRecord : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\..\Views\addRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtFirstName;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\addRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtLastName;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\addRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPDate;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\Views\addRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RBMale;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Views\addRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RBFemale;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Views\addRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/SchoolProject;component/views/addrecord.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\addRecord.xaml"
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
            this.TxtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DPDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.RBMale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.RBFemale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

