﻿#pragma checksum "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "037EAB8C8394E6D4D9600FB1CCD8DE4D3609F259B1C86D7C2BEA3B805D8FA3FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SiteOrder.control_items.executor_content_presenters;
using SiteOrder.converters;
using SiteOrder.db_context;
using SiteOrder.overridden_controls;
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


namespace SiteOrder.control_items.executor_content_presenters {
    
    
    /// <summary>
    /// ShowTechnicalTaskContent
    /// </summary>
    public partial class ShowTechnicalTaskContent : SiteOrder.overridden_controls.TabItemContentParent, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDemandAdd;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonTechnicalTaskWork;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock name;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock customer;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRefuseTechnicalTask;
        
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
            System.Uri resourceLocater = new System.Uri("/SiteOrder;component/control_items/executor_content_presenters/showtechnicaltaskc" +
                    "ontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
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
            this.buttonDemandAdd = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
            this.buttonDemandAdd.Click += new System.Windows.RoutedEventHandler(this.buttonDemandAdd_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonTechnicalTaskWork = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
            this.buttonTechnicalTaskWork.Click += new System.Windows.RoutedEventHandler(this.buttonTechnicalTaskWork_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.customer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 121 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
            ((System.Windows.Controls.ListBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRefuseTechnicalTask = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\..\control_items\executor_content_presenters\ShowTechnicalTaskContent.xaml"
            this.buttonRefuseTechnicalTask.Click += new System.Windows.RoutedEventHandler(this.buttonRefuseTechnicalTask_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
