﻿#pragma checksum "C:\Users\medina.i\Desktop\ETF\4. semestar materijali\OOAD\MobileApp\MashComputerShop\MashComputerShop\MashShop\Views\Pages\PriceRangeSelection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C0F609AC525A0A46004F0CC5A17166EA"
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
    partial class PriceRangeSelection : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class PriceRangeSelection_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPriceRangeSelection_Bindings
        {
            private global::MashComputerShop.MashShop.Views.Pages.PriceRangeSelection dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj10;

            public PriceRangeSelection_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IPriceRangeSelection_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // PriceRangeSelection_obj1_Bindings

            public void SetDataRoot(global::MashComputerShop.MashShop.Views.Pages.PriceRangeSelection newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MashComputerShop.MashShop.Views.Pages.PriceRangeSelection obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SelectorOptions(obj.SelectorOptions, phase);
                    }
                }
            }
            private void Update_SelectorOptions(global::System.Collections.Generic.List<global::MashComputerShop.MashShop.Models.ConfigurationOption> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.priceRangeVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
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
                    this.centralRow = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 7:
                {
                    this.bottomRow = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 8:
                {
                    this.firstCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 9:
                {
                    this.lastCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 10:
                {
                    this.optionSelectorContainer = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 11:
                {
                    this.footerNote = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.subtitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    PriceRangeSelection_obj1_Bindings bindings = new PriceRangeSelection_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

