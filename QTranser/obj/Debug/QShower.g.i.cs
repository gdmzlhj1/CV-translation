﻿#pragma checksum "..\..\QShower.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D51B0A9AF1D105C12264015AD9988F357D87F6E68727F93675DDBB4A93632A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HotKeyEditor;
using QTranser;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace QTranser {
    
    
    /// <summary>
    /// QShower
    /// </summary>
    public partial class QShower : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 166 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StrIBox;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox HistoryList;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LocationDisabledMessage;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox HistoryListBox;
        
        #line default
        #line hidden
        
        
        #line 345 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyQ;
        
        #line default
        #line hidden
        
        
        #line 346 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyW;
        
        #line default
        #line hidden
        
        
        #line 347 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyB;
        
        #line default
        #line hidden
        
        
        #line 348 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyG;
        
        #line default
        #line hidden
        
        
        #line 362 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Border;
        
        #line default
        #line hidden
        
        
        #line 373 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Pather;
        
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
            System.Uri resourceLocater = new System.Uri("/QTranser;component/qshower.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QShower.xaml"
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
            
            #line 13 "..\..\QShower.xaml"
            ((QTranser.QShower)(target)).Deactivated += new System.EventHandler(this.Window_Deactivated);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 149 "..\..\QShower.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Drop += new System.Windows.DragEventHandler(this.StackPanel_Drop);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 151 "..\..\QShower.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetTop_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StrIBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 177 "..\..\QShower.xaml"
            this.StrIBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.StrIBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HistoryList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.LocationDisabledMessage = ((System.Windows.Controls.TextBlock)(target));
            
            #line 282 "..\..\QShower.xaml"
            this.LocationDisabledMessage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Hyperlink_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.HistoryListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.HotKeyQ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.HotKeyW = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.HotKeyB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.HotKeyG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.Border = ((System.Windows.Controls.Border)(target));
            
            #line 370 "..\..\QShower.xaml"
            this.Border.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Pather_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Pather = ((System.Windows.Shapes.Path)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 144 "..\..\QShower.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.HistoryList_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 145 "..\..\QShower.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.HistoryList_MouseRightButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

