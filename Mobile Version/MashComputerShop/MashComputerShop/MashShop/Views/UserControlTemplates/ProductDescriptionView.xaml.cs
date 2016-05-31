﻿using MashComputerShop.MashShop.Models;
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
    public sealed partial class ProductDescriptionView : UserControl
    {
        public ShoppingCartItem ShoppingCartItem { get { return this.DataContext as ShoppingCartItem; } }

        public ProductDescriptionView()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }

        // Event socket za klik na dugme "Add To Cart"
        public event RoutedEventHandler AddToCartButtonClicked
        {
            add { addToCartButton.Click += value; }
            remove { addToCartButton.Click -= value; }
        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}