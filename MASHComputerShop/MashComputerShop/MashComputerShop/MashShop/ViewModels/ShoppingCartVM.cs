using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.Models.Servis;
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
        // Polje koje čuva korisnika 
        public UserVM UserVM { get; set; }

        // Polje koje čuva samu korpu
        public ShoppingCart ShoppingCart { get; set; }

        // Polje za web servis
        WebService service;

        // Polje koje čuva sve proizvode
        public ObservableCollection<ShoppingCartItem> ShopCatalogue { get; set; }
        private List<Product> proizvodi;
        public List<Product> Proizvodi
        {
            get { return proizvodi; }
            set { proizvodi = value; }
        }


        // Polje koje cuva vrijednost po kojoj filtriramo i prikazujemo proizvode
        public string ProductFilter { get; set; }

        /* polje koje nam omogucava da prikazemo filtrirane proizvode
        public ObservableCollection<ShoppingCartItem> FilteredProducts
        {
            get { return filterProductByType(); }
            set { ShopCatalogue = value;  }
        }
        */

        public ObservableCollection<ShoppingCartItem> FilteredProducts { get; set; }

        // Servis za navigaciju
        public INavigationService NavigationService { get; set; }

        // Dodatne komande koje realizuju dodavanje i prikaz detalja o proizvodu
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


            proizvodi = new List<Product>();
            service = new WebService();

            // Ucitavanje liste proizvoda iz baze podataka
            service.getAllProducts(ProductsLoaded);

            var lista = ProductCatalog.getAllProducts();

            foreach (Product p in lista)
                ShopCatalogue.Add(new ShoppingCartItem() { Product = p, Quantity = 1 } );

            NavigationService = new NavigationService();

            ProductFilter = "";

            // Prvi param je akcija, drugi je validaciona rutina
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
            var item = obj as ShoppingCartItem;
            ShoppingCart.Items.Remove(item);
            ShoppingCart.TotalCartPrice -= item.Price;
        }

        private bool canBeRemoved(object arg)
        {
            return true;
        }
        #endregion Commands


        // Callback metoda kada zavrsi dobavljanje proizvoda iz baze
        public void ProductsLoaded()
        {
            Proizvodi.Clear();
            foreach (var p in service.Products)
            {
                Proizvodi.Add(p);
                //ShopCatalogue.Add(new ShoppingCartItem() { Product = p, Quantity = 1 }); 
            }
        }


        // Proxy metoda za postavljanje odredisnos frame-a
        public void SetTargetPageFrame(Frame targetFrame)
        {
            NavigationService.SetTargetFrame(targetFrame);
        }


        // Pomocna metoda koja vrsi filtriranje proizvoda
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
