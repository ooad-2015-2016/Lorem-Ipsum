using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models.User
{
    public interface IUser
    {
        void OpenUserProfile();
        void LogIn();
        void LogOut();
        void SetProfilePicture();

        // Propeties
        string FirstName { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
