﻿#pragma checksum "..\..\CreateOptionsDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D5E4AD250483D28E4909887740428453A039ADDB177F5D0CEB8738314DC19B3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PT_lab2;
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


namespace PT_lab2 {
    
    
    /// <summary>
    /// CreateOptionsDialog
    /// </summary>
    public partial class CreateOptionsDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameInputTextBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameInputLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton fileRadioButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton directoryRadioButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ReadOnlyCheckBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ArchiveCheckBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HiddenCheckBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SystemCheckBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CreateOptionsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PT_lab2;component/createoptionsdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateOptionsDialog.xaml"
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
            this.nameInputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nameInputLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.fileRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.directoryRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.ReadOnlyCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.ArchiveCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.HiddenCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.SystemCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\CreateOptionsDialog.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\CreateOptionsDialog.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
