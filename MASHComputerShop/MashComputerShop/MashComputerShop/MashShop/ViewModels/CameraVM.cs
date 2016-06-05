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

        // CaptureElement previewControl;
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
        
        
        public CameraVM(CaptureElement previewControl)
        {
            Camera = new CameraHelper(previewControl);
            Camera.InitializeCameraAsync();
            Uslikaj = new RelayCommand(uslikaj, (object parametar) => true);
        }


        // Komanda koja inicira slikanje
        public async void uslikaj(object parametar)
        {
            await Camera.TakePhotoAsync(SlikanjeGotovo);
        }


        public void SlikanjeGotovo(SoftwareBitmapSource photo)
        {
            Slika = photo;
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
