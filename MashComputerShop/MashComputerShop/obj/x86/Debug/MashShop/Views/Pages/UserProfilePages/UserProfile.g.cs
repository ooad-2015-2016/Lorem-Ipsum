﻿#pragma checksum "C:\Users\Almir\Desktop\MashComputerShop\MashComputerShop\MashShop\Views\Pages\UserProfilePages\UserProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA468AFB3581B2548A1802BACB633DCB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MashComputerShop.MashShop.Views.Pages.UserProfilePages
{
    partial class UserProfile : 
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
                    this.navigationBar = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 24 "..\..\..\..\..\..\MashShop\Views\Pages\UserProfilePages\UserProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.navigationBar).SelectionChanged += this.navigationBar_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3:
                {
                    this.licniPodaciSelector = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.profilSelector = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.emailSelector = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
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

