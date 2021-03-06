﻿#pragma checksum "..\..\..\UI\EditorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2501E9B4A4C0C7213B1B51F658D941844066F6539330E635E693557567CF038D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ScheduX;
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


namespace ScheduX.UI {
    
    
    /// <summary>
    /// EditorWindow
    /// </summary>
    public partial class EditorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StatusBar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LeftSideBar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LeftSideBarOpenCloseButtonImg;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel LeftSideBarContent;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid WorkingSpace;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu ConfigurateMenu;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu DictionaryButtonList;
        
        #line default
        #line hidden
        
        
        #line 317 "..\..\..\UI\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu LoadButtonList;
        
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
            System.Uri resourceLocater = new System.Uri("/ScheduX;component/ui/editorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\EditorWindow.xaml"
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
            this.StatusBar = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.LeftSideBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 32 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenCloseLeftSideBarButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LeftSideBarOpenCloseButtonImg = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.LeftSideBarContent = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.WorkingSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            
            #line 182 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 182 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMouseLeaveHandler);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ConfigurateMenu = ((System.Windows.Controls.Menu)(target));
            
            #line 209 "..\..\..\UI\EditorWindow.xaml"
            this.ConfigurateMenu.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuMouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 209 "..\..\..\UI\EditorWindow.xaml"
            this.ConfigurateMenu.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuMouseLeaveHandler);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 210 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.PeriodOfStudyItemHandler);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 231 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMouseEnterHandler1);
            
            #line default
            #line hidden
            
            #line 231 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMouseLeaveHandler1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DictionaryButtonList = ((System.Windows.Controls.Menu)(target));
            
            #line 258 "..\..\..\UI\EditorWindow.xaml"
            this.DictionaryButtonList.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuMouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 258 "..\..\..\UI\EditorWindow.xaml"
            this.DictionaryButtonList.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuMouseLeaveHandler);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 290 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMouseEnterHandler2);
            
            #line default
            #line hidden
            
            #line 290 "..\..\..\UI\EditorWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMouseLeaveHandler2);
            
            #line default
            #line hidden
            return;
            case 13:
            this.LoadButtonList = ((System.Windows.Controls.Menu)(target));
            
            #line 317 "..\..\..\UI\EditorWindow.xaml"
            this.LoadButtonList.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuMouseEnterHandler);
            
            #line default
            #line hidden
            
            #line 317 "..\..\..\UI\EditorWindow.xaml"
            this.LoadButtonList.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuMouseLeaveHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

