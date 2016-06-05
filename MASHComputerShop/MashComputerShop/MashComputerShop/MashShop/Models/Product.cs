using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MashComputerShop.MashShop.Models
{
    [DataContract]
    public class Product : INotifyPropertyChanged
    {
        [DataMember]
        public int Id { get; set; } 
        [DataMember]
        public string ProductType { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public string ProductImage { get; set; }
        public string ImagePath { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string QuantityInStorage { get; set; }
        [DataMember]
        public int Grade { get; set; }  // Ocjena od 1 do 5


        // Konstruktor
        public Product(int Id, string ProductType, string Name, string Price, string ImagePath, string Description, string QuantityInStorage, int Grade)
        {
            this.Id = Id;
            this.ProductType = ProductType;
            this.Name = Name;
            this.Price = Price;
            this.ImagePath = ImagePath;
            this.Description = Description;
            this.QuantityInStorage = QuantityInStorage;
            this.Grade = Grade;
            ProductImage = null;
        }

        public Product() { }


        // Copy ctor
        public Product(Product p)
        {
            this.Id = p.Id;
            this.ProductType = p.ProductType;
            this.Name = p.Name;
            this.Price = p.Price;
            this.ImagePath = p.ImagePath;
            this.Description = p.Description;
            this.QuantityInStorage = p.QuantityInStorage;
            this.Grade = p.Grade;
            ProductImage = p.ProductImage;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
    

    public class ProductCatalog
    {
        // Lista svih proizvoda
        public static List<Product> Products { get; set; }

        // Dummy Product description
        private static string DESCRIPTION = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat.";

        // Metoda za dobavljanje proizvoda, hardkodirano za potrebe testiranja
        public static List<Product> getAllProducts()
        {
            return new List<Product>() 
            {
                new Product(1, "Procesor", "Intel Pentium vPro", "320 BAM", "ms-appx:///Assets/ShopProducts/Processors/intelpentiumcpu.jpg", DESCRIPTION, "1", 1),
                new Product(2, "RAM", "Intel i5", "450 BAM", "ms-appx:///Assets/ShopProducts/Processors/inteli5cpu.jpg", DESCRIPTION, "1", 1),
                new Product(3, "Procesor", "AMB A8", "230 BAM", "ms-appx:///Assets/ShopProducts/Processors/amdaseriescpu.png", DESCRIPTION, "1", 1),
                new Product(4, "Procesor", "Intel i7", "550 BAM", "ms-appx:///Assets/ShopProducts/Processors/inteli7cpu.jpg", DESCRIPTION, "1", 1),
                new Product(5, "Procesor", "AMD Athlon", "370 BAM", "ms-appx:///Assets/ShopProducts/Processors/amdathloncpu.jpg", DESCRIPTION, "1", 1),
                new Product(6, "Procesor", "AMD Semprom", "450 BAM", "ms-appx:///Assets/ShopProducts/Processors/amdsemproncpu.jpg", DESCRIPTION, "1", 1),
                new Product(7, "RAM", "Intel i5", "230 BAM", "ms-appx:///Assets/ShopProducts/Processors/inteli5cpu.jpg", DESCRIPTION, "1", 1),
                new Product(8, "Procesor", "Intel i7", "550m", "ms-appx:///Assets/ShopProducts/Processors/inteli7cpu.jpg", DESCRIPTION, "1", 1)
            };
        }


        // Metoda za dobavljanje proizvoda, hardkodirano za potrebe testiranja
        public static void getAllProductsStat()
        {
            Products = new List<Product>()
            {
                new Product(1, "Procesor", "Intel Pentium vPro", "320 BAM", "ms-appx:///Assets/ShopProducts/Processors/intelpentiumcpu.jpg", DESCRIPTION, "1", 1),
                new Product(2, "RAM", "Intel i5", "450 BAM", "ms-appx:///Assets/ShopProducts/Processors/inteli5cpu.jpg", DESCRIPTION,"1", 1),
                new Product(3, "Procesor", "AMB A8", "230 BAM", "ms-appx:///Assets/ShopProducts/Processors/amdaseriescpu.png", DESCRIPTION, "1", 1),
                new Product(4, "Procesor", "Intel i7", "550 BAM", "ms-appx:///Assets/ShopProducts/Processors/inteli7cpu.jpg", DESCRIPTION, "1", 1),
                new Product(5, "Procesor", "AMD Athlon", "370 BAM", "ms-appx:///Assets/ShopProducts/Processors/amdathloncpu.jpg", DESCRIPTION, "1", 1),
                new Product(6, "Procesor", "AMD Semprom", "450 BAM", "ms-appx:///Assets/ShopProducts/Processors/amdsemproncpu.jpg", DESCRIPTION, "1", 1),
                new Product(7, "RAM", "Intel i5", "230 BAM", "ms-appx:///Assets/ShopProducts/Processors/inteli5cpu.jpg", DESCRIPTION, "1", 1),
                new Product(8, "Procesor", "Intel i7", "550m", "ms-appx:///Assets/ShopProducts/Processors/inteli7cpu.jpg", DESCRIPTION, "1", 1)
            };
        }
    }
}
