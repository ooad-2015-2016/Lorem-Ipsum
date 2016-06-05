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
    public sealed partial class UserProfileTab : UserControl
    {
        public UserVM UserVM { get; set; }

        public UserProfileTab()
        {
            this.InitializeComponent();
            UserVM = new UserVM();
            DataContext = UserVM;
        }

        // Event socket za klik na dugme "User Profile"
        public event RoutedEventHandler userProfileBtnClicked
        {
            add { userProfile.Click += value; }
            remove { userProfile.Click -= value; }
        }


        // otvara user profile
        private void userProfile_Click(object sender, RoutedEventArgs e)
        {
            if (UserVM.OpenUserProfile.CanExecute(null))
                UserVM.OpenUserProfile.Execute(null);
        }
        
        // odjava s racuna
        private void logoutFly_Click(object sender, RoutedEventArgs e)
        {
            UserVM.LogOut.Execute(null);
        }
    }
}
