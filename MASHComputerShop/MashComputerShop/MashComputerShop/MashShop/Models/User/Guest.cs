using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models.User
{
    public class Guest : IUser
    {
        public string FirstName { get { return "Gost"; } set { } }
        public string LastName { get { return "doe"; } set { } }
        public string Username { get { return "jon doe"; } set { } }
        public string Password { get { return ""; } set { } }
        public string Address { get { return "none"; } set { } }

        public void LogIn()
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public void OpenUserProfile()
        {
            throw new NotImplementedException();
        }

        public void SetProfilePicture()
        {
            throw new NotImplementedException();
        }
    }
}
