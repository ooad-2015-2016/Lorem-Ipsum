using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public sealed partial class ProductsTileView : Page
    {
        public ShoppingCartVM ShoppingCartVM { get; set; }

        // polje kojim određujemo da li je stranica postavljena pri 
        // kreiranju konfiguracije ili prilikom pregleda svih proizvoda
        private bool isConfigurationWizard;

        public ProductsTileView()
        {
            this.InitializeComponent();
            isConfigurationWizard = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {   

            var tmp = e.Parameter as Tuple<ShoppingCartVM, string>;
            if (tmp == null)
            {
                // ako je poslan dodatni parametar tipa bool
                var args = e.Parameter as Tuple<ShoppingCartVM, string, bool>;

                // Preuzimanje primljenog taga za filtriranje proizvoda
                ShoppingCartVM = args.Item1;
                isConfigurationWizard = args.Item3;

                // ako je potrebno filtrirati proizvode
                ShoppingCartVM.ProductFilter = args.Item2;
            }
            else
            {
                // Preuzimanje primljenog taga za filtriranje proizvoda
                ShoppingCartVM = tmp.Item1;

                // ako je potrebno filtrirati proizvode
                ShoppingCartVM.ProductFilter = tmp.Item2;
            }
            
            ShoppingCartVM?.SetTargetPageFrame(Frame);
            ShoppingCartVM.FilteredProducts = ShoppingCartVM.filterProductByType();
            DataContext = ShoppingCartVM;
        }

        
        private void productContainer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShoppingCartVM.SetTargetPageFrame(Frame);
            Frame.Navigate(typeof(ProductDescription),
                new ProductDescriptionVM(ShoppingCartVM, e.ClickedItem as ShoppingCartItem, isConfigurationWizard));
        }

    }
}
