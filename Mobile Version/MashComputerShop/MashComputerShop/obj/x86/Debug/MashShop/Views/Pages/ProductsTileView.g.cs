﻿#pragma checksum "C:\Users\medina.i\Desktop\ETF\4. semestar materijali\OOAD\MobileApp\MashComputerShop\MashComputerShop\MashShop\Views\Pages\ProductsTileView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0B8204F216A5A7F17C0FF758E73C14B0"
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
    partial class ProductsTileView : 
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
                    this.productTileViewVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.MobileState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.DesktopState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.centralColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 5:
                {
                    this.productContainer = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 65 "..\..\..\..\..\MashShop\Views\Pages\ProductsTileView.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.productContainer).ItemClick += this.productContainer_ItemClick;
                    #line default
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

