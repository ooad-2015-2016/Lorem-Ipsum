<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MashComputerShop.MashDB.Models
{
    public class Receipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ReceiptID { get; set; }

        public int CardID { get; set; }
        public int CustomerID { get; set; }
        public double TotalPrice { get; set; }

        public Receipt() { }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MashComputerShop.MashDB.Models
{
    class Receipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ReceiptID { get; set; }

        public int CardID { get; set; }
        public int CustomerID { get; set; }
        public double TotalPrice { get; set; }
    }
}
>>>>>>> origin/master
