﻿#pragma checksum "C:\Users\medina.i\Desktop\ETF\4. semestar materijali\OOAD\MobileApp\MashComputerShop\MashComputerShop\MashShop\Views\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DDC9C33E6E0F3F8996B0A8B78A864584"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MashComputerShop.MashShop.Views.Pages
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.pageGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.homePageVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.MobileState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.DesktopState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.topRow = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 6:
                {
                    this.bottomRow = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 7:
                {
                    this.productsView = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 8:
                {
                    this.FooterDrawer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 9:
                {
                    this.totalPrice = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.firstPriceTag = (global::Windows.UI.Xaml.Documents.Run)(target);
                }
                break;
            case 11:
                {
                    this.productCount = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.showSoppingCart = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 147 "..\..\..\..\..\MashShop\Views\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.showSoppingCart).Click += this.showShoppingCart_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.firstCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 14:
                {
                    this.pivotCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 15:
                {
                    this.lastCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 16:
                {
                    this.productQueryBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 83 "..\..\..\..\..\MashShop\Views\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.productQueryBox).QuerySubmitted += this.productQueryBox_QuerySubmitted;
                    #line 84 "..\..\..\..\..\MashShop\Views\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.productQueryBox).TextChanged += this.productQueryBox_TextChanged;
                    #line default
                }
                break;
            case 17:
                {
                    this.viewFilters = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 18:
                {
                    this.sortFilters = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
