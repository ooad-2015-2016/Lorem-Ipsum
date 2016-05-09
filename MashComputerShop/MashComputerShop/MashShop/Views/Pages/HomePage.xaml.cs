using MashComputerShop.MashShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class HomePage : Page
    {
        // Noobish way of implementing data binding
        private List<Product> Products;

        public HomePage()
        {
            this.InitializeComponent();
            ShopWindowCollection = new ObservableCollection<Product>();

            // noobs
            Products = ProductCatalog.getAllProductsAndComponents();
        }

        // Kolekcija proizvoda koja predstavlja "izlog prodavnice", dakle sadrži sve proizvode koje trenutno posjedujemo
        public ObservableCollection<Product> ShopWindowCollection { get; set; }

        
        // Privremena kolekcija proizvoda koristena za svrhe pretrage
        private string[] products = new string[] { "Intel i7", "Intel i5", "AMD Sempron", "AMD Athlon", "Intel Xeon Phi", "AMD A8 SuperCore", "Snapdragon 860A", "Intel Pentium vPro" };


        // Event u kojem vrsimo pretrazivanje proizvoda u svrhu AutoSuggesta za search
        private void productQueryBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (String.IsNullOrEmpty(sender.Text.ToString())) return;

            var filteredResults = products.Where(p => p.ToLower().StartsWith(productQueryBox.Text.ToLower())).ToArray();
            productQueryBox.ItemsSource = filteredResults;
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}
