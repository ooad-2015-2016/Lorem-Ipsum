using MashComputerShop.MashShop.Models.User;
using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MashComputerShop.MashShop.Views.UserControlTemplates
{
    public sealed partial class SignUpForm : UserControl
    {
        public UserVM UserVM { get; set; }
        public RegisteredUser UserNew { get; set; }

        public SignUpForm()
        {
            this.InitializeComponent();
            UserNew = new RegisteredUser();
            DataContext = UserNew;
        }

        private void doneBtt_Click(object sender, RoutedEventArgs e)
        {
            if (UserVM.GenerateAccount.CanExecute(new Tuple<IUser, string>(UserNew, ConfirmPwTB.Text)))
                UserVM.GenerateAccount.Execute(UserNew);
        }
    }
}
