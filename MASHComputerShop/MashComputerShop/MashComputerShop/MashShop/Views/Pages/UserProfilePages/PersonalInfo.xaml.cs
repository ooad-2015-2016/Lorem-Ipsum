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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MashComputerShop.MashShop.Views.Pages.UserProfile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonalInfo : Page
    {
        public UserVM UserVM { get; set; }
        public RegisteredUser RegisteredUser { get; set; }

        public PersonalInfo()
        {
            this.InitializeComponent();
            RegisteredUser = new RegisteredUser();
            DataContext = RegisteredUser;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UserVM = e.Parameter as UserVM;
            RegisteredUser = UserVM.IUser as RegisteredUser;
            DataContext = RegisteredUser;
        }

        private void saveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserVM.SaveProfileDataChanges.CanExecute(RegisteredUser))
                UserVM.SaveProfileDataChanges.Execute(RegisteredUser);
        }
    }
}
