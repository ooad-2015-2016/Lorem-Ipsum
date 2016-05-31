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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MashComputerShop.MashShop.Views.UserControlTemplates
{
    public sealed partial class ShopCart : UserControl
    {
        public ShoppingCartVM ShoppingCartVM { get; set; }

        public ShopCart()
        {
            this.InitializeComponent();
            setProductCount(0);
            setTotalPrice(0);
        }

        public event RoutedEventHandler showShoppingCartClicked
        {
            add { showSoppingCart.Click += value; }
            remove { showSoppingCart.Click -= value; }
        }

        public void setProductCount(int num)
        {            
            // Ovdje treba odrediti i postaviti broj proizvoda koji se nalaze u korpi?
            productCount.Text = "Ukupno " + num.ToString() + " proizvoda u korpi.";
        }

        public void setTotalPrice(double price)
        {
            // Ovdje treba odrediti i postaviti ukupnu cijenu proizvoda koji se nalaze u korpi?
            totalPrice.Text = "Ukupna cijena: " + price.ToString();
        }
    }
}
