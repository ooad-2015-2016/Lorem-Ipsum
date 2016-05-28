using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Decimal Price { get { return Quantity*24m + 120m; } }
    }
}
