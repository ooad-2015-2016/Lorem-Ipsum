using MashComputerShop.MashShop.Models.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public class ShoppingCart : INotifyPropertyChanged
    {
        public IUser Customer { get; set; }
        public ObservableCollection<ShoppingCartItem> Items { get; set; }

        private Decimal price;
        public Decimal TotalCartPrice
        {
            get { return price; }     
            set { price = value; OnNotifyPropertyChanged("TotalCartPrice"); }      
        }


        // Constructor
        public ShoppingCart()
        {
            Items = new ObservableCollection<ShoppingCartItem>();
            TotalCartPrice = 0m;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

    }
}
