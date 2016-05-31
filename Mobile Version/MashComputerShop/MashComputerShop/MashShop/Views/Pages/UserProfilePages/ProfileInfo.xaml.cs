using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MashComputerShop.MashShop.Views.Pages.UserProfilePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfileInfo : Page
    {
        public CameraVM CameraVM { get; set; }
        public UserVM UserVM { get; set; }

        public ProfileInfo()
        {
            this.InitializeComponent();

            // Proslijedjivanje parametra je krsenje MVVM ali nuzno posto Binding ne radi za ovu kontrolu
            CameraVM = new CameraVM(ImagePreview);
            this.DataContext = CameraVM;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UserVM = e.Parameter as UserVM;
        }

    }
}
