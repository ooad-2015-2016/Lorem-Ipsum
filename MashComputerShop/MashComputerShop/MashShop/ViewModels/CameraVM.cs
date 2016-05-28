using MashComputerShop.MashShop.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace MashComputerShop.MashShop.ViewModels
{
    public class CameraVM : INotifyPropertyChanged
    {
        // Kamera uredjaj
        public CameraHelper Camera { get; set; }
        public ICommand Uslikaj { get; set; }
        //public ICommand NewUser { get; set; }


        //Negdje privremeno mora biti slika koja ce se prikazati kad se uslika
        private SoftwareBitmapSource slika;
        public SoftwareBitmapSource Slika
        {
            get { return slika; }
            set
            {
                slika = value;
                OnNotifyPropertyChanged("Slika");
            }
        }

        //kontrola krsenje mvvm
        CaptureElement previewControl;

        public CameraVM(CaptureElement previewControl)
        {
            Camera = new CameraHelper(previewControl);
            Camera.InitializeCameraAsync();
            Uslikaj = new RelayCommand(uslikaj, (object parametar) => true);
        }

        //komanda koja inicira slikanje
        public async void uslikaj(object parametar)
        {
            await Camera.TakePhotoAsync(SlikanjeGotovo);
        }


        public void SlikanjeGotovo(SoftwareBitmapSource photo)
        {
            Slika = photo;
        }

        //proeprty changed observer
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            //? je skracena verzija ako nije null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
