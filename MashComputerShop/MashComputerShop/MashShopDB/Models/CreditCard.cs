using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MashComputerShop.MashDB.Models
{
    [Table("CreditCards")]
    class CreditCard
    {
        [Key]
        public string CardNumber { get; set; }

        public DateTime ExpDate { get; set; }
        public string CardType { get; set; }
        public int PIN { get; set; }
    }
}
