using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseService.MASHShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public string QuantityInStorage { get; set; }
        public string Grade { get; set; }
    }
}