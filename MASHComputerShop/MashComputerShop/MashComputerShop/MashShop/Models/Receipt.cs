using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MashComputerShop.MashShop.Models
{
    public class Receipt
    {
        public int ReceiptID { get; set; }
        public List<string> SoldItems { get; set; }
        public double TotalPrice { get; set; }

        // Konstruktori
        public Receipt(int id, List<string> items, double price)
        {
            ReceiptID = id;
            SoldItems = items;
            TotalPrice = price;
        }

        public Receipt()
        {
            ReceiptID = 0;
            SoldItems = new List<string>();
            TotalPrice = 0.0d;
        }
    }
}
