using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public abstract class User
    {
        // ID broj korisnika
        public int UserID { get; set; }

        public User(int id)
        {
            UserID = id;
        }
    }
}
