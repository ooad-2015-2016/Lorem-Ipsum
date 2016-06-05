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
using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.ViewModels;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MashComputerShop.MashShop.Views.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateConfiguration : Page
    {
        public CreatorVM CreatorVM { get; set; }

        public CreateConfiguration()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Preuzimanje primljenog taga za filtriranje proizvoda
            CreatorVM =  new CreatorVM(e.Parameter as ShoppingCartVM);
            CreatorVM.ShoppingCartVM.SetTargetPageFrame(contentPage);
            DataContext = CreatorVM;

            contentPage.Navigate(typeof(PriceRangeSelection), 
                new Tuple<CreatorVM, Rectangle>(CreatorVM, selectedTabUnderline));
        }

        /**
         *  Eventi kojima se upravlja navigacijom izmedju koraka kupovine.
        **/
        private void PriceRangeButton_Click(object sender, RoutedEventArgs e)
        {
            if(CreatorVM?.PriceRange?.OptionTitle == "")
            {
                contentPage.Navigate(typeof(PriceRangeSelection),
                new Tuple<CreatorVM, Rectangle>(CreatorVM, selectedTabUnderline));

                selectedTabUnderline.SetValue(Grid.ColumnProperty, 0);
            }
        }

        private void ComponentsButton_Click(object sender, RoutedEventArgs e)
        {
            if(CreatorVM?.PriceRange?.OptionTitle != "")
            {
                contentPage.Navigate(typeof(ComponentSelection),
               new Tuple<CreatorVM, Rectangle>(CreatorVM, selectedTabUnderline));

                selectedTabUnderline.SetValue(Grid.ColumnProperty, 1);
            }
        }

        private void DeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            if (CreatorVM?.PriceRange?.OptionTitle != "")
            {
                contentPage.Navigate(typeof(DeliveryAndPayment),
                new Tuple<CreatorVM, Rectangle>(CreatorVM, selectedTabUnderline));

                selectedTabUnderline.SetValue(Grid.ColumnProperty, 2);
            }
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            if (CreatorVM?.PriceRange?.OptionTitle != "")
            {
                contentPage.Navigate(typeof(Checkout), CreatorVM.ShoppingCartVM);
                selectedTabUnderline.SetValue(Grid.ColumnProperty, 3);
            }
        }


        /**
         * Prikazivanje sadržaja ShoppingCart-a te zatvaranje istog frame-a
        **/
        bool isShoppingCartOpen;

        private void showShoppingCart_Click(object sender, RoutedEventArgs e)
        {
            // Proslijediti parametar takav da se prikažu oni proizvodi koje korisnik ima u korpi?
            if (isShoppingCartOpen)
            {
                if (contentPage.CanGoBack) contentPage.GoBack();
                showSoppingCart.Content = "Pregledaj korpu";
            }
            else
            {
                contentPage.Navigate(typeof(ShoppingCartView), CreatorVM.ShoppingCartVM);
                showSoppingCart.Content = "Zatvori korpu";
            }

            isShoppingCartOpen = !isShoppingCartOpen;
        } // end of "showShoppingCart_Click" eventHandler


    }
}
