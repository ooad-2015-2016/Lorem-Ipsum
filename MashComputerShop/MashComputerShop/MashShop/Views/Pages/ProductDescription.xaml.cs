using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class ProductDescription : Page
    {
        public ProductDescriptionVM ProductDescriptionVM { get; set; }

        public ProductDescription()
        {
            this.InitializeComponent();
            ProductDescriptionVM = null;

            NavigationCacheMode = NavigationCacheMode.Required;
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ProductDescriptionVM = e.Parameter as ProductDescriptionVM;
            DataContext = ProductDescriptionVM;
        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void addToCartButton_Click(object sender, RoutedEventArgs e)
        {
            ProductDescriptionVM.AddToCart.Execute(null);
        }

    }
}
