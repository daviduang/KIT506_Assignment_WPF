﻿#pragma checksum "..\..\..\Researcher_Report.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FA6EB60B909F0F5C68D0D84E8AD11196AD527683"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KIT506_Assignment_WPF;
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


namespace KIT506_Assignment_WPF {
    
    
    /// <summary>
    /// Researcher_Report
    /// </summary>
    public partial class Researcher_Report : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem StarPerformance;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid StarPerformanceGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem MeetingMinimun;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MeetingMinimunGrid;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem BlowExpectation;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BlowExpectationGrid;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Poor;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Researcher_Report.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PoorGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KIT506_Assignment_WPF;V1.0.0.0;component/researcher_report.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Researcher_Report.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\Researcher_Report.xaml"
            ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StarPerformance = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.StarPerformanceGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.MeetingMinimun = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.MeetingMinimunGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BlowExpectation = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.BlowExpectationGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.Poor = ((System.Windows.Controls.TabItem)(target));
            return;
            case 9:
            this.PoorGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 83 "..\..\..\Researcher_Report.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.copyEmails);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

