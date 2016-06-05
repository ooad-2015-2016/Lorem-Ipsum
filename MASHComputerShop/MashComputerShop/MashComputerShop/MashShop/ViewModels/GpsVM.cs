using MashComputerShop.MashShop.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Maps;


namespace MashComputerShop.MashShop.ViewModels
{
    public class GpsVM : INotifyPropertyChanged
    {
        // Trenutna lokacija koja ce se naci sa geolocation
        private Geopoint currentLocation;
        public Geopoint CurrentLocation
        {
            get { return currentLocation; }
            set
            {
                currentLocation = value;
                OnNotifyPropertyChanged("CurrentLocation");
            }
        }

        // Lokacija
        private string location;
        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnNotifyPropertyChanged("Location");
            }
        }

        // Država
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; OnNotifyPropertyChanged("Country"); }
        }

        // Grad
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; OnNotifyPropertyChanged("City"); }
        }

        // Ulica
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnNotifyPropertyChanged("Address");
            }
        }

        //krsenje mvvm za mapu .. neophodno
        MapControl Mapa;
        public GpsVM(MapControl mapa)
        {
            Mapa = mapa;
            GetUserLocationData = new RelayCommand(getLocationData);
        }


        #region Commands
        public ICommand GetUserLocationData { get; set; }

        // Metoda koja određuje trenutnu lokaciju i postavlja vrijednosti u odgovarajuće textboxove
        public async void getLocationData(object obj)
        {
            // Da li se smije uzeti lokacija, trazi se odobrenje od korisnika (takodjer treba i capability)
            var accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus == GeolocationAccessStatus.Allowed)
            {
                // Uzimanje pozicije ako smije
                Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 10 };
                Geoposition pos = await geolocator.GetGeopositionAsync();

                // Uzimamo lokaciju
                CurrentLocation = pos.Coordinate.Point;

                // Uzimamo podatke o drzavi, gradu i adresi
                MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(pos.Coordinate.Point);

                // Koje podatke nađe, ispiše u textboxove
                if (result.Status == MapLocationFinderStatus.Success)
                {
                    Country = result.Locations[0].Address.Country;
                    City = result.Locations[0].Address.Town;
                    Address = result.Locations[0].Address.Street;
                }
            }
            else
            {
                var dialog = new MessageDialog("Niste omogućili da aplikacija koristi vašu lokaciju.");
                await dialog.ShowAsync();
            }

        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
        #endregion

    }
}
