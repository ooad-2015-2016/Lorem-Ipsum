using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.Models.User;
using MashComputerShop.MashShop.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace MashComputerShop.MashShop.ViewModels
{
    public class ShoppingCartVM
    {
        // polje koje čuva korisnika 
        public UserVM UserVM { get; set; }

        // polje koje čuva samu korpu
        public ShoppingCart ShoppingCart { get; set; }

        // polje koje čuva sve proizvode
        public ObservableCollection<ShoppingCartItem> ShopCatalogue { get; set; }

        // polje koje cuva vrijednost po kojoj filtriramo i prikazujemo proizvode
        public string ProductFilter { get; set; }

        /* polje koje nam omogucava da prikazemo filtrirane proizvode
        public ObservableCollection<ShoppingCartItem> FilteredProducts
        {
            get { return filterProductByType(); }
            set { ShopCatalogue = value;  }
        }
        */

        public ObservableCollection<ShoppingCartItem> FilteredProducts { get; set; }

        // servis za navigaciju
        public INavigationService NavigationService { get; set; }

        // dodatne komande koje realizuju dodavanje i prikaz detalja o proizvodu
        public ICommand ShowProductDetails { get; set; }
        public ICommand RemoveFromCart { get; set; }
        public ICommand GoBack { get; set; }

        // Constructor
        public ShoppingCartVM()
        {
            // Pri prvom kreiranju korisnik je gost
            UserVM = new UserVM();

            ShoppingCart = new ShoppingCart();
            ShopCatalogue = new ObservableCollection<ShoppingCartItem>();

            var lista = ProductCatalog.getAllProducts();
            foreach (Product p in lista)
                ShopCatalogue.Add(new ShoppingCartItem() { Product = p, Quantity = 1 } );

            NavigationService = new NavigationService();

            ProductFilter = "";

            // prvi param je akcija, drugi je validaciona rutina
            ShowProductDetails = new RelayCommand(showDetails, canShowDetails);
            RemoveFromCart = new RelayCommand(removeItemFromCart, canBeRemoved);
        }


        #region Commands
        // akcija za otvaranje detalja o proizvodu
        private void showDetails(object obj)
        {
            NavigationService.Navigate(typeof(ProductDescription), new ProductDescriptionVM(this, obj as ShoppingCartItem));
        }

        // provjera da li se uopste mogu otvoriti detalji o proizvodu
        public bool canShowDetails(object arg)
        {
            return true;
        }

        // Metode za validaciju i uklanjanje stavke iz korpe
        private void removeItemFromCart(object obj)
        {
           ShoppingCart.Items.Remove(obj as ShoppingCartItem);
        }

        private bool canBeRemoved(object arg)
        {
            return true;
        }
        #endregion Commands


        // proxy metoda za postavljanje odredisnos frame-a
        public void SetTargetPageFrame(Frame targetFrame)
        {
            NavigationService.SetTargetFrame(targetFrame);
        }


        // pomocna metoda koja vrsi filtriranje proizvoda
        public ObservableCollection<ShoppingCartItem> filterProductByType()
        {
            if (ProductFilter == "") return ShopCatalogue;

            ObservableCollection<ShoppingCartItem> tmp = new ObservableCollection<ShoppingCartItem>();

            foreach (var p in ShopCatalogue)
                if (p.Product.ProductType == ProductFilter)
                    tmp.Add(p);

            return tmp;
        }

    }
}
