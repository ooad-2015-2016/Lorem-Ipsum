using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations.Schema;

namespace MashComputerShop.MashShopDB.Models
{
    public class Product
    {
        // Polja klase odgovaraju poljima u tabeli Product u bazi podataka

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; } // Primary key u tabeli Product

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int QuantityInStorage { get; set; } 
        public int Grade { get; set; }  // Ocjena od 1 do 5

        // Konstruktor
        Product(int ProductID, string Name, double Price, string Description, int QuantityInStorage, int Grade) {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.QuantityInStorage = QuantityInStorage;
            this.Grade = Grade;
        }
    }
}
