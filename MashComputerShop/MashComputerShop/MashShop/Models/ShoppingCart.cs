using MashComputerShop.MashShop.Models.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public class ShoppingCart
    {
        public ObservableCollection<ShoppingCartItem> Items { get; set; }

        public Decimal TotalCartPrice
        {
            get { Decimal price = 0; foreach (var it in Items) price += it.Price; return price; }
        }

        public IUser Customer { get; set; }

        // Constructor
        public ShoppingCart()
        {
            Items = new ObservableCollection<ShoppingCartItem>();
        }

    }
}
