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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MashComputerShop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // pri prvom otvaranju postavlja se home page kao kontekst
            mainContentFrame.Navigate(typeof(HomePage));
        }

        // Events for sideBarNavigation
        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            SideBar.IsPaneOpen = !SideBar.IsPaneOpen;
        }

        internal void changeTopbarTitle(string title)
        {
            TopbarTitle.Text = title;
        }


        // Metoda za navigaciju i izmjenu konteksta glavne stranice 
        private void changeMainPageContext()
        {
            if (viewSelector.IsSelected) { mainContentFrame.Navigate(typeof(HomePage)); changeTopbarTitle(viewSelectorLabel.Text);  }
            else if (creatConfigSelector.IsSelected) { mainContentFrame.Navigate(typeof(CreateConfiguration)); changeTopbarTitle(creatConfigSelectorLabel.Text); }
            else if (userProfileSelector.IsSelected) { mainContentFrame.Navigate(typeof(UserProfilePage)); changeTopbarTitle(userProfileSelectorLabel.Text); }
            else if(searchSelector.IsSelected) { mainContentFrame.Navigate(typeof(HomePage)); changeTopbarTitle(searchSelectorLabel.Text); }
        }

        // Event u kojem obrađujemo naredbe za navigaciju po stranicama
        private void navigationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            changeMainPageContext();
        }

    }
}
