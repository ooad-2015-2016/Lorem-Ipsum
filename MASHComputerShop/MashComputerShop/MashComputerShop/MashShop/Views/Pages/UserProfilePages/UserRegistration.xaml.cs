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

namespace MashComputerShop.MashShop.Views.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserRegistration : Page
    {
        // ViewModel
        public UserVM UserVM { get; set; }
        public RegisteredUser UserNew { get; set; }

        public UserRegistration()
        {
            this.InitializeComponent();
            UserNew = new RegisteredUser() { FirstName = "", LastName = "" };
            DataContext = UserNew;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Inicijalizacija ViewModela
            UserVM = e.Parameter as UserVM;
        }

        private void doneBtt_Click(object sender, RoutedEventArgs e)
        {
            if (UserVM.GenerateAccount.CanExecute(new Tuple<RegisteredUser, string>(UserNew, ConfirmPwTB.Password)))
            UserVM.GenerateAccount.Execute(UserNew);
        }
    }
}
