using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public class MashShopProductCatalogue
    {
        public ObservableCollection<Product> Items { get; set; }

        // Constructor
        public MashShopProductCatalogue()
        {
            Items = new ObservableCollection<Product>();

            var allProducts = ProductCatalog.getAllProducts();

            foreach (var p in allProducts)
                Items.Add(p);
        }

    }
}
