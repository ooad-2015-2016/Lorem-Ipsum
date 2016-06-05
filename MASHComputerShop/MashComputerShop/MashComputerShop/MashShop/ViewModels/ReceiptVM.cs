using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;


namespace MashComputerShop.MashShop.ViewModels
{
    public class ReceiptVM
    {
        public Receipt Receipt { get; set; }
        public ShoppingCartVM ShoppingCartVM { get; set; }

        // Lista svih proizvoda i kolicine kupljenih
        public ObservableCollection<ShoppingCartItem> ItemsToSell { get; set; }

        // Komanda za obavljanje kupovine
        public ICommand FinalizeShopping { get; set; }

        // Konstruktor, krši MVVM .. neophodno
        public ReceiptVM(ShoppingCartVM cartVM)
        {
            Receipt = new Receipt();
            ShoppingCartVM = cartVM;
            getStringItems(ShoppingCartVM.ShoppingCart.Items);
            ItemsToSell = ShoppingCartVM.ShoppingCart.Items;
            FinalizeShopping = new RelayCommand(finalizeShopping, canFinalizeShopping);
        }

        #region Commands
        public async void finalizeShopping(object obj)
        {
            var dialog = new MessageDialog("Kupovina uspješno obavljena. Hvala na povjerenju.");
            await dialog.ShowAsync();
        }

        public bool canFinalizeShopping(object obj)
        {
            return ItemsToSell != null && ItemsToSell?.Count > 0;
        }
        #endregion

        #region Helper
        private void getStringItems(ObservableCollection<ShoppingCartItem> items)
        {
            Receipt.SoldItems = new List<string>();
            foreach (var it in items)
            {
                Receipt.SoldItems.Add(it.Product.Name + " " + it.Price.ToString() + " " + it.Quantity.ToString());
            }
        }
        #endregion

        #region Credit Card Validation
        #endregion
    }
}

