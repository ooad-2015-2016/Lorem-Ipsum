using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models.User
{
    [DataContract]
    public class RegisteredUser : IUser
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; } // let's pretend that this doesn't exist
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string TelephoneNumber { get; set; }
        [DataMember]
        public string CreditCard { get; set; }
        [DataMember]
        public string ProfileImage { get; set; }
       

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
