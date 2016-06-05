using MashComputerShop.MashShop.ViewModels;
using MashComputerShop.MashShop.Views.Pages.UserProfile;
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

namespace MashComputerShop.MashShop.Views.Pages.UserProfilePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserProfile : Page
    {
        public UserVM UserVM { get; set; }

        public UserProfile()
        {
            this.InitializeComponent();
            licniPodaciSelector.IsSelected = true;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UserVM = e.Parameter as UserVM;
            DataContext = UserVM;
            contentFrame.Navigate(typeof(PersonalInfo), UserVM);
        }

        private void navigationBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (licniPodaciSelector.IsSelected) { contentFrame.Navigate(typeof(PersonalInfo), UserVM); }
            else if (profilSelector.IsSelected) { contentFrame.Navigate(typeof(ProfileInfo), UserVM); }
            //else if (emailSelector.IsSelected) { contentFrame.Navigate(typeof(UserProfilePage)); }
        }
    }
}