﻿#pragma checksum "..\..\..\Server\ServerWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7CF5F7A5294B05AC20BF1C43D9977CC1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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
using iRacingAdmin.Views;


namespace iRacingAdmin.Server {
    
    
    /// <summary>
    /// ServerWindow
    /// </summary>
    public partial class ServerWindow : iRacingAdmin.Views.WindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIpAddress;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ProgressRing ipProgress;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPort;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstUsers;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLog;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid statusPanel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblStatus;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblQueue;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Server\ServerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressQueue;
        
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
            System.Uri resourceLocater = new System.Uri("/iRacingAdmin;component/server/serverwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Server\ServerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.txtIpAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ipProgress = ((MahApps.Metro.Controls.ProgressRing)(target));
            return;
            case 3:
            this.txtPort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Server\ServerWindow.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstUsers = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.txtLog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.statusPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.lblStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.lblQueue = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.progressQueue = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
