﻿#pragma checksum "..\..\..\..\control_items\order_list_items\DemandListSImple.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2AD54ECF44788D8E694CD3797218446FE5CACD7A52EE5EDD913D939659588B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SiteOrder.control_items.order_list_items;
using SiteOrder.converters;
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


namespace SiteOrder.control_items.order_list_items {
    
    
    /// <summary>
    /// DemandListSImple
    /// </summary>
    public partial class DemandListSImple : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\control_items\order_list_items\DemandListSImple.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox demandList;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\control_items\order_list_items\DemandListSImple.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDemandAction;
        
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
            System.Uri resourceLocater = new System.Uri("/SiteOrder;component/control_items/order_list_items/demandlistsimple.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\control_items\order_list_items\DemandListSImple.xaml"
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
            this.demandList = ((System.Windows.Controls.ListBox)(target));
            
            #line 49 "..\..\..\..\control_items\order_list_items\DemandListSImple.xaml"
            this.demandList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.demandList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonDemandAction = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\control_items\order_list_items\DemandListSImple.xaml"
            this.buttonDemandAction.Click += new System.Windows.RoutedEventHandler(this.buttonDemandAction_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

