using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.Models.Servis;
using MashComputerShop.MashShop.Models.User;
using MashComputerShop.MashShop.ViewModels;
using MashComputerShop.MashShop.Views.UserControlTemplates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class HomePage : Page
    {
        public ShoppingCartVM ShoppingCartVM { get; set; }
       

        public HomePage()
        {
            this.InitializeComponent();
            isShoppingCartOpen = false;
            
        }

        // pri otvaranju stranice prvo se prikazuje frame sa listom svih proizvoda
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {    
            ShoppingCartVM = e.Parameter as ShoppingCartVM;
            DataContext = ShoppingCartVM;
            productsView.Navigate(typeof(ProductsTileView), new Tuple<ShoppingCartVM, string>(ShoppingCartVM, ""));
        }


        // Privremena kolekcija proizvoda koristena za svrhe pretrage
        private string[] products = new string[] { "Intel i7", "Intel i5", "AMD Sempron", "AMD Athlon", "Intel Xeon Phi", "AMD A8 SuperCore", "Snapdragon 860A", "Intel Pentium vPro" };

        // Event u kojem vrsimo pretrazivanje proizvoda u svrhu AutoSuggesta za search
        private void productQueryBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (String.IsNullOrEmpty(sender.Text.ToString())) return;

            var filteredResults = products.Where(p => p.ToLower().StartsWith(productQueryBox.Text.ToLower())).ToArray();
            productQueryBox.ItemsSource = filteredResults;
        }

        // Obrada zahtjeva za pretragu u autosuggest box-u
        private void productQueryBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            productsView.Navigate(typeof(ProductsTileView), args.QueryText);
        }


        /**
         * Prikazivanje sadržaja ShoppingCart-a te zatvaranje istog frame-a
        **/
        bool isShoppingCartOpen;
             
        private void showShoppingCart_Click(object sender, RoutedEventArgs e)
        {
            // Proslijediti parametar takav da se prikažu oni proizvodi koje korisnik ima u korpi?
            if(isShoppingCartOpen)
            {
                if (productsView.CanGoBack) productsView.GoBack();
                showSoppingCart.Content = "Pregledaj korpu";
            }
            else
            {
                productsView.Navigate(typeof(ShoppingCartView), ShoppingCartVM);
                showSoppingCart.Content = "Zatvori korpu";
            }

            isShoppingCartOpen = !isShoppingCartOpen;
        } // end of "showShoppingCart_Click" eventHandler

        private async void proceedToCheckoutBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ShoppingCartVM.UserVM.IUser is RegisteredUser)
                Frame.Navigate(typeof(Checkout), ShoppingCartVM);
            else
            {
                var dialog = new MessageDialog("Da biste pristupili kupovini proizvoda potreban je korisnički račun.", "Potreban je korisnički račun");

                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Log In") { Id = 0 });
                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Nazad") { Id = 1 });

                var result = await dialog.ShowAsync();

                if((int)result.Id == 0)
                {
                    ShoppingCartVM.UserVM.SetTargetPageFrame(Frame);
                    ShoppingCartVM.UserVM.OpenUserProfile.Execute(null);
                }
            }
        }
    } 
}
