﻿#pragma checksum "C:\Users\Almir\Desktop\Lorem-Ipsum\MashComputerShop\MashComputerShop\CustomUserControls\SignUpForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FCF85504E524E4321DF227ED8952BECB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MashComputerShop.CustomUserControls
{
    partial class SignUpForm : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    this.backboardPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.doneBtt = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3:
                {
                    this.ConfirmPwTB = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 32 "..\..\..\CustomUserControls\SignUpForm.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.ConfirmPwTB).GotFocus += this.TextBoxBackground_GotFocus;
                    #line default
                }
                break;
            case 4:
                {
                    this.PasswordTB = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 28 "..\..\..\CustomUserControls\SignUpForm.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.PasswordTB).GotFocus += this.TextBoxBackground_GotFocus;
                    #line default
                }
                break;
            case 5:
                {
                    this.EmailTB = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 24 "..\..\..\CustomUserControls\SignUpForm.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.EmailTB).GotFocus += this.TextBoxBackground_GotFocus;
                    #line default
                }
                break;
            case 6:
                {
                    this.SurnameTB = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 20 "..\..\..\CustomUserControls\SignUpForm.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.SurnameTB).GotFocus += this.TextBoxBackground_GotFocus;
                    #line default
                }
                break;
            case 7:
                {
                    this.NameTB = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 16 "..\..\..\CustomUserControls\SignUpForm.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.NameTB).GotFocus += this.TextBoxBackground_GotFocus;
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

