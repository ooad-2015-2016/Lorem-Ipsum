<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MashComputerShop.MashDB.Models
{
    public class CreditCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string CardNumber { get; set; }

        public DateTime ExpDate { get; set; }
        public string CardType { get; set; }
        public int PIN { get; set; }

        public CreditCard() { }
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
    class CreditCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        [Key]
        public string CardNumber { get; set; }

        public DateTime ExpDate { get; set; }
        public string CardType { get; set; }
        public int PIN { get; set; }
    }
}
>>>>>>> origin/master
