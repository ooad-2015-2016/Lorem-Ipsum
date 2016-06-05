using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class UserLogin : Page
    {
        public UserVM UserVM { get; set; }

        public UserLogin()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Inicijalizacija ViewModela
            UserVM = e.Parameter as UserVM;
            DataContext = UserVM;
        }

        // existing use login
        private async void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UserVM.LogIn.CanExecute(new string[] { usernameInput.Text, passwordInput.Password }))
            {
                UserVM.LogIn.Execute(usernameInput.Text);
            }
            else
            {
                var dialog = new MessageDialog("Pogrešni pristupni podaci!");
                await dialog.ShowAsync();
            }
        }

        // sign up( generate new account )
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserVM.CreateAccount.CanExecute(null))
                UserVM.CreateAccount.Execute(null);
        }

    }
}
