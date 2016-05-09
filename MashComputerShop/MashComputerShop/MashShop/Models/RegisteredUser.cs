using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations.Schema;

namespace MashComputerShop.MashShop.Models
{
    public class RegisteredUser : User
    {
        // Polja klase odgovaraju poljima u tabeli u bazi padataka

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int RegUserID { get { return UserID; } set { UserID = value; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // let's pretend that this doesn't exist
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public byte[] ProfileImage { get; set; }


        // Konstruktor
        public RegisteredUser(int id = 0) : base(id)
        {
            FirstName = "Jon"; LastName = "Doe";
            Username = ""; Password = "";
            Email = ""; TelephoneNumber = "";
            ProfileImage = null;
        }

    }
}
