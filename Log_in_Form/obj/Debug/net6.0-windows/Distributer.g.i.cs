﻿#pragma checksum "..\..\..\Distributer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "781286175DEBBE6C3782255DCA2BE7421C83F878"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Log_in_Form;
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


namespace Log_in_Form {
    
    
    /// <summary>
    /// Distributer
    /// </summary>
    public partial class Distributer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas distPanel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCity;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeBtn;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Distributer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridDistrbute;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Log_in_Form;V1.0.0.0;component/distributer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Distributer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.distPanel = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            
            #line 59 "..\..\..\Distributer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Distributer.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Distributer.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.removeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Distributer.xaml"
            this.removeBtn.Click += new System.Windows.RoutedEventHandler(this.removeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.gridDistrbute = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

