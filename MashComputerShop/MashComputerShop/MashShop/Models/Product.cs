using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MashComputerShop.MashShop.Models
{
    public class Product
    {
        // Polja klase odgovaraju poljima u tabeli Product u bazi podataka

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int ProductID { get; set; } // Primary key u tabeli Product

        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int QuantityInStorage { get; set; }
        public int Grade { get; set; }  // Ocjena od 1 do 5

        // Konstruktor
        public Product(int ProductID, string Name, string Price, string Description, int QuantityInStorage, int Grade)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.QuantityInStorage = QuantityInStorage;
            this.Grade = Grade;
        }
    }
    
    public class ProductCatalog
    {
        // Lista svih proizvoda
        public static List<Product> ProductsAndComponents { get; set; }
        
        // Metoda kojom dobavljamo sve proizvode iz baze TRENUTNO HARDCODE!!!
        public static List<Product> getAllProductsAndComponents()
        {
            return new List<Product>()
            {
                new Product(1, "Intel Pentium vPro", "320m", "ms-appx:///Assets/ShopProducts/Processors/intelpentiumcpu.jpg", 1, 1),
                new Product(2, "Intel i5", "450m", "ms-appx:///Assets/ShopProducts/Processors/inteli5cpu.jpg", 1, 1),
                new Product(3, "AMB A8", "230m", "ms-appx:///Assets/ShopProducts/Processors/amdaseriescpu.png", 1, 1),
                new Product(4, "Intel i7", "550m", "ms-appx:///Assets/ShopProducts/Processors/inteli7cpu.jpg", 1, 1),
                new Product(5, "AMD Athlon", "370m", "ms-appx:///Assets/ShopProducts/Processors/amdathloncpu.jpg", 1, 1),
                new Product(6, "AMD Semprom", "450m", "ms-appx:///Assets/ShopProducts/Processors/amdsemproncpu.jpg", 1, 1),
                new Product(7, "Intel i5", "230m", "ms-appx:///Assets/ShopProducts/Processors/inteli5cpu.jpg", 1, 1),
                new Product(8, "Intel i7", "550m", "ms-appx:///Assets/ShopProducts/Processors/inteli7cpu.jpg", 1, 1)
            };
        }

    }
}
