using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MashComputerShop.MashShop.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        ShoppingCartVM shpcrt;
        Product p;
        
        public BlankPage1()
        {
            this.InitializeComponent();
            shpcrt = new ShoppingCartVM();
        }

        private void TstBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if(shpcrt.Proizvodi.Count == 1)
                p = shpcrt.Proizvodi[0];

            byte[] imageBytes = Convert.FromBase64String(p.ProductImage);


            SetImageFromByteArray(imageBytes, tstSlika);
        }


        public async void SetImageFromByteArray(byte[] data, Windows.UI.Xaml.Controls.Image image)
        {
            using (InMemoryRandomAccessStream raStream = new InMemoryRandomAccessStream())
            {
                using (DataWriter writer = new DataWriter(raStream))
                {
                    // Write the bytes to the stream
                    writer.WriteBytes(data);

                    // Store the bytes to the MemoryStream
                    await writer.StoreAsync();

                    // Not necessary, but do it anyway
                    await writer.FlushAsync();

                    // Detach from the Memory stream so we don't close it
                    writer.DetachStream();
                }

                raStream.Seek(0);

                BitmapImage bitMapImage = new BitmapImage();
                bitMapImage.SetSource(raStream);

                image.Source = bitMapImage;
            }
        }

    }
}
