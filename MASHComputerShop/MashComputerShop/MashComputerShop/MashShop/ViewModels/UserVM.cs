using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.Models.Servis;
using MashComputerShop.MashShop.Models.User;
using MashComputerShop.MashShop.Views.Pages;
using MashComputerShop.MashShop.Views.Pages.UserProfilePages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace MashComputerShop.MashShop.ViewModels
{
    public class UserVM : INotifyPropertyChanged
    {
        WebService service;

        List<RegisteredUser> regdUsers; // Lista u koju se ubacuju dohvaceni korisnici iz baze 

        // Korisnik 
        private IUser user;
        public IUser IUser { get { return user; } set { user = value; OnNotifyPropertyChanged("IUser"); } }

        private string headerThug;
        public string HeaderTag { get { return headerThug; } set { headerThug = value; OnNotifyPropertyChanged("HeaderTag"); } }

        // Servis za navigaciju
        public NavigationService NavigationService { get; set; }

        // komande koje realizuju funkcionalnosti korištenja korisničkog profila
        public ICommand OpenUserProfile { get; set; }
        public ICommand LogIn { get; set; }
        public ICommand LogOut { get; set; }
        public ICommand CreateAccount { get; set; }
        public ICommand GenerateAccount { get; set; }
        public ICommand SaveProfileDataChanges { get; set; }

        public RegisteredUser noviRacun { get; set; }

        // Konstruktor
        public UserVM()
        {
            service = new WebService();
            regdUsers = new List<RegisteredUser>();
            noviRacun = new RegisteredUser();

            // Ucitavanje korisnika iz baze preko web servisa
            service.getAllUsers(UsersLoaded);

            IUser = new Guest();
            HeaderTag = "Dobrodošli!";
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


        // Callback nakon ucitavanja svih korisnika iz baze
        public void UsersLoaded()
        {
            regdUsers.Clear();
            foreach (var user in service.RegisteredUsers)
                regdUsers.Add(user);
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
            if (regdUsers != null)
            {
                RegisteredUser user = regdUsers.Where(u => u.Username == credentials).FirstOrDefault();

                if (user != null)
                {
                    IUser = user;                    
                    NavigationService.Navigate(typeof(UserProfile), this);
                }
            }
        }

        private bool canLogIn(object obj)
        {
            var credentials = obj as string[];

            if (credentials[0] == "" || credentials[1] == "")
                return false;
            var usr = regdUsers.Where(u => u.Username == credentials[0]).FirstOrDefault();
            return usr.Password == credentials[1];
        }


        // kada korisnik zeli da kreira racun (Sign Up)
        private void createAccount(object obj)
        {
            NavigationService.Navigate(typeof(UserRegistration), this);
        }

        
        private bool canCreateAccout(object obj)
        {
            var credentials = obj as string[];
            return (IUser != null && IUser is Guest);
        }


        // kreiranje novog objekta "User"
        private void generateAccount(object obj)
        {
            RegisteredUser novi = obj as RegisteredUser;
            novi.Id = regdUsers.Count + 1;
            novi.Username = novi.FirstName + novi.LastName;


            // Provjera da li isti user vec postoji u bazi
            if(regdUsers != null)
            {
                bool imaIsti = false;

                foreach(var user in regdUsers)
                {
                    if(user.Username == novi.Username || user.Email == novi.Email)
                    {
                        imaIsti = true;
                        showErrorMessage("Korisnik sa istim username-om ili e-mailom vec postoji!");
                        break;
                    }
                }

                if (!imaIsti)
                {                  
                    service.addNewUser(novi);

                    noviRacun = new RegisteredUser();
                    regdUsers.Add(novi);
                    // postavljamo ovog korisnika za trenutnog korisnika
                    IUser = novi;

                    // Otvorimo korisnicki profil
                    NavigationService.Navigate(typeof(UserProfile), this);
                }
            }         
        }


        private bool canGenerateAccount(object obj)
        {
            var data = obj as Tuple<RegisteredUser, string>;
            RegisteredUser novi = data.Item1;
            novi.Username = novi.FirstName + " " + novi.LastName;
            var email = novi.Email;
            var pass = novi.Password;
            var pass2 = data.Item2 as string;
            var firstName = novi.FirstName;
            var lastName = novi.LastName;

            Regex firstNameRegex = new Regex(@"([A-Z][a-z]*)([\\s\\\'-][A-Z][a-z]*)*",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if(firstName.Length == 0)
            {
                showErrorMessage("Unesite ime");
                return false;
            }
            if (!firstNameRegex.IsMatch(firstName))
            {
                showErrorMessage("Ime smije sadrzavati samo karaktere");
                return false;
            }

            Regex lastNameRegex = new Regex(@"([A-Z][a-z]*)([\\s\\\'-][A-Z][a-z]*)*",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (lastName.Length == 0)
            {
                showErrorMessage("Unesite prezime");
                return false;
            }
            if (!lastNameRegex.IsMatch(lastName))
            {
                showErrorMessage("Prezime smije sadrzavati samo karaktere");
                return false;
            }

            Regex emailRegex = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!emailRegex.IsMatch(email))
            {
                showErrorMessage("Unesite ipravan e-mail");
                return false;
            }

            Regex passwordRegex = new Regex(@"^[a-zA-Z]\w{3,14}$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (!passwordRegex.IsMatch(pass))
            {
                showErrorMessage("Password mora biti duzine 4-15 karaktera i smije sadrzavati samo slova, brojeve i donju crtu");
                return false;
            }

            if(novi.Password != pass2)
            {
                showErrorMessage("Passwordi se ne poklapaju");
                return false;
            }

            return true;
        }


        // kada korisnik zeli da se odjavi sa Sistema
        private void logOut(object obj)
        {
            IUser = null;
            IUser = new Guest();
            HeaderTag = "Log in or Sign up";
            OpenUserProfile.Execute(null);
        }


        // Prilikom izmjena u podacima 
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


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
        #endregion


        public async void showErrorMessage(string message)
        {
            var dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }
    }
}
