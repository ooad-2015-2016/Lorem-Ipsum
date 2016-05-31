using MashComputerShop.MashShop.Models;
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
    public sealed partial class ShoppingCartView : Page
    {
        public ShoppingCartVM ShoppingCartVM { get; set; }

        // Ctor
        public ShoppingCartView()
        {
            this.InitializeComponent();
            ShoppingCartVM = new ShoppingCartVM();
        }

        
        // pri otvranju stranice odnosno prikaza korpe dobavlja se komplet ViewModel
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Preuzimanje primljenog taga za filtriranje proizvoda
            ShoppingCartVM = e.Parameter as ShoppingCartVM;
            DataContext = ShoppingCartVM;

            if (ShoppingCartVM.ShoppingCart.Items.Count > 0)
                cartEmptyIndicator.Visibility = Visibility.Collapsed;
        }


        // kada se klikne na item, taj se item ukloni iz korpe
        private void productContainer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShoppingCartVM.RemoveFromCart.Execute(e.ClickedItem as ShoppingCartItem);

            // ako se kolekcija ispraznila postavljamo odgovarajucu oznaku na page
            if (ShoppingCartVM.ShoppingCart.Items.Count == 0)
                cartEmptyIndicator.Visibility = Visibility.Visible;
        }

    }
}
