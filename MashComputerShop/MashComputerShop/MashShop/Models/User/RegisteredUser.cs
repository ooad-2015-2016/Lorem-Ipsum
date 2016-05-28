using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations.Schema;

namespace MashComputerShop.MashShop.Models.User
{
    public class RegisteredUser : IUser
    {
        // Polja klase odgovaraju poljima u tabeli u bazi padataka

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // let's pretend that this doesn't exist
        public string Email { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string CreditCard { get; set; }
        public byte[] ProfileImage { get; set; }

        public string HeaderTag { get { return "Dobrodošli " + FirstName; } set { } }

        // Konstruktor
        public RegisteredUser()
        {
            Id = 0;
            FirstName = "Jon"; LastName = "Doe";
            Username = ""; Password = "";
            Email = ""; TelephoneNumber = "";
            Address = "";
            ProfileImage = null;
        }

        public void OpenUserProfile()
        {
            throw new NotImplementedException();
        }

        public void LogIn()
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public void SetProfilePicture()
        {
            throw new NotImplementedException();
        }
    }
}
