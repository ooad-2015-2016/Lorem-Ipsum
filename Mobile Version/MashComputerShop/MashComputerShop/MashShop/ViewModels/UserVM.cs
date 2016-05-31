using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.Models.User;
using MashComputerShop.MashShop.Views.Pages;
using MashComputerShop.MashShop.Views.Pages.UserProfilePages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace MashComputerShop.MashShop.ViewModels
{
    public class UserVM
    {
        // TEMPORARY LIST REMOVE LATER !!!
        private List<RegisteredUser> allUsers;

        // Korisnik 
        public IUser IUser { get; set; }

        // Servis za navigaciju
        public NavigationService NavigationService { get; set; }

        // komande koje realizuju funkcionalnosti korištenja korisničkog profila
        public ICommand OpenUserProfile { get; set; }
        public ICommand LogIn { get; set; }
        public ICommand LogOut { get; set; }
        public ICommand CreateAccount { get; set; }
        public ICommand GenerateAccount { get; set; }
        public ICommand SaveProfileDataChanges { get; set; }

        // Konstruktor
        public UserVM()
        {
            allUsers = new List<RegisteredUser>()
            {
                new RegisteredUser() { FirstName = "Windows", LastName = "App", Username = "OOAD", Password = "OOAD" }
            };

            IUser = new Guest();
            NavigationService = new NavigationService();

            OpenUserProfile = new RelayCommand(openUserProfile, canOpenUserProfile);
            CreateAccount = new RelayCommand(createAccount, canCreateAccout);
            GenerateAccount = new RelayCommand(generateAccount, canGenerateAccount);
            LogIn = new RelayCommand(logIn, canLogIn);
            LogOut = new RelayCommand(logOut);
            SaveProfileDataChanges = new RelayCommand(saveProfileDataChanges, canSaveProfileDataChanges);
        }

        // proxy metoda za postavljanje odredisnos frame-a
        public void SetTargetPageFrame(Frame targetFrame)
        {
            NavigationService.SetTargetFrame(targetFrame);
        }


        #region Commands
        // Otvaranje korisnickog profila
        private void openUserProfile(object obj)
        {
            if (IUser is RegisteredUser)
                NavigationService.Navigate(typeof(UserProfile), this);
            else
                NavigationService.Navigate(typeof(UserLogin), this);
        }

        private bool canOpenUserProfile(object obj)
        {
            //NavigationService.Navigate(typeof(UserLogin), this);
            return IUser != null;
        }


        // Prijava na sistem (LogIn)
        private void logIn(object obj)
        {
            var credentials = obj as string;
            // ulogujemo korisnika
            IUser = allUsers.Where(u => u.Username == credentials).FirstOrDefault();
            NavigationService.Navigate(typeof(UserProfile), this);
        }

        private bool canLogIn(object obj)
        {
            var credentials = obj as string[];
            if (credentials[0] == "" || credentials[1] == "") return false;
            var usr = allUsers.Where(u => u.Username == credentials[0]).FirstOrDefault();
            return usr.Password == credentials[1];
        }


        // kada korisnik zeli da kreira racun (Sign Up)
        private void createAccount(object obj)
        {
            NavigationService.Navigate(typeof(UserRegistration), this);
        }

        private bool canCreateAccout(object obj)
        {
            return (IUser != null && IUser is Guest);
        }


        // kreiranje novog objekta "User"
        private void generateAccount(object obj)
        {
            RegisteredUser novi = obj as RegisteredUser;
            novi.Username = novi.FirstName + " " + novi.LastName;
            allUsers.Add(novi);

            // postavljamo ovog korisnika za trenutnog korisnika
            IUser = novi;

            // Otvorimo korisnicki profil
            NavigationService.Navigate(typeof(UserProfile), this);
        }

        private bool canGenerateAccount(object obj)
        {
            var data = obj as Tuple<RegisteredUser, string>;
            RegisteredUser novi = data.Item1;
            novi.Username = novi.FirstName + " " + novi.LastName;
            var pass = data.Item2 as string;

            return (!allUsers.Exists(u => u.Username == novi.Username) && novi.Password == pass && pass != "");
        }


        // kada korisnik zeli da se odjavi sa Sistema
        private void logOut(object obj)
        {
            IUser = null;
            IUser = new Guest();
            OpenUserProfile.Execute(null);
        }


        // prilikom izmjena u podacima 
        private void saveProfileDataChanges(object obj)
        {
            IUser = obj as RegisteredUser;
        }

        private bool canSaveProfileDataChanges(object obj)
        {
            var userNew = obj as RegisteredUser;
            var userOld = IUser as RegisteredUser;
            if (userNew != userOld) return true;
            return false;
        }
        #endregion

    }
}
