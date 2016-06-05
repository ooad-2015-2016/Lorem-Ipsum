using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseService.MASHShop.Models
{
    public class RegisteredUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // let's pretend that this doesn't exist
        public string Email { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string CreditCard { get; set; }
        public string ProfileImage { get; set; }
    }
}