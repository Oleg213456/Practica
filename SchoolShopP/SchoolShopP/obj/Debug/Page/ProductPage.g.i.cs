﻿#pragma checksum "..\..\..\Page\ProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C476955B097373266E83895BC8AC2DB87CBEA396BA8AA5AF1614F02060B3966C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SchoolShopP.Page;
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


namespace SchoolShopP.Page {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearhBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ManufComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderBy;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DescOrderBy;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AmountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewProducts;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Page\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel EmptyPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/SchoolShopP;component/page/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\ProductPage.xaml"
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
            
            #line 7 "..\..\..\Page\ProductPage.xaml"
            ((SchoolShopP.Page.ProductPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearhBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Page\ProductPage.xaml"
            this.SearhBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearhBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ManufComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\Page\ProductPage.xaml"
            this.ManufComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ManufComboBox_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OrderBy = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Page\ProductPage.xaml"
            this.OrderBy.Click += new System.Windows.RoutedEventHandler(this.OrderBy_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DescOrderBy = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Page\ProductPage.xaml"
            this.DescOrderBy.Click += new System.Windows.RoutedEventHandler(this.DescOrderBy_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AmountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ListViewProducts = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\..\Page\ProductPage.xaml"
            this.ListViewProducts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewProducts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Page\ProductPage.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Edit = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Page\ProductPage.xaml"
            this.Edit.Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Page\ProductPage.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.EmptyPanel = ((System.Windows.Controls.StackPanel)(target));
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
            case 8:
            
            #line 50 "..\..\..\Page\ProductPage.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ProductBorder_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

