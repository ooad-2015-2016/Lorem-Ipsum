using MashComputerShop.MashShop.ViewModels;
using MashComputerShop.MashShop.Views.Pages;
using MashComputerShop.MashShop.Views.Pages.UserProfilePages;
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
    /// Na ovoj stranici držimo sve podatke vezane za ViewModel. ShoppingCartVM se proteže kroz cijelu aplikaciju
    /// te pruža osnovni kontejner za podatke i logiku sistema.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ShoppingCartVM ShoppingCartVM { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Inicijalizacija ViewModela
            ShoppingCartVM = new ShoppingCartVM();
            ShoppingCartVM.UserVM.NavigationService.SetTargetFrame(mainContentFrame);
            UserTab.ShoppingCartVM = this.ShoppingCartVM;
            DataContext = ShoppingCartVM;

            // pri prvom otvaranju postavlja se home page kao kontekst
            viewSelector.IsSelected = true;
            mainContentFrame.Navigate(typeof(HomePage), ShoppingCartVM);
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
            if (viewSelector.IsSelected) {
                mainContentFrame.Navigate(typeof(HomePage), ShoppingCartVM);
                changeTopbarTitle(viewSelectorLabel.Text);
            }
            else if (creatConfigSelector.IsSelected) {
                mainContentFrame.Navigate(typeof(CreateConfiguration), ShoppingCartVM);
                changeTopbarTitle(creatConfigSelectorLabel.Text);
            }
            else if (userProfileSelector.IsSelected) {
                ShoppingCartVM.UserVM.SetTargetPageFrame(mainContentFrame);
                ShoppingCartVM.UserVM.OpenUserProfile.Execute(null);
                
                //mainContentFrame.Navigate(typeof(UserProfile));
                changeTopbarTitle(userProfileSelectorLabel.Text);
            }
            //else if (searchSelector.IsSelected) { 
            //    mainContentFrame.Navigate(typeof(ShopWindowView));
            //    changeTopbarTitle(searchSelectorLabel.Text);
            //}
        }


        // Event u kojem obrađujemo naredbe za navigaciju po stranicama
        private void navigationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            changeMainPageContext();
        }
        
        private void UserTab_userProfileBtnClicked(object sender, RoutedEventArgs e)
        {
            userProfileSelector.IsSelected = true;
            //mainContentFrame.Navigate(typeof(UserProfile), ShoppingCartVM.UserVM);
            ShoppingCartVM.UserVM.OpenUserProfile.Execute(null);
            changeTopbarTitle(userProfileSelectorLabel.Text);
        }

    }
}
