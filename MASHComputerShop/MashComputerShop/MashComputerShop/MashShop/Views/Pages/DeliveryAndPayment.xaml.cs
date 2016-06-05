using MashComputerShop.MashShop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MashComputerShop.MashShop.Views.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeliveryAndPayment : Page
    {
        public DeliveryAndPayment()
        {
            this.InitializeComponent();
            mapa.Style = MapStyle.Aerial3DWithRoads;
            mapa.ZoomLevel = 20;
            this.DataContext = new GpsVM(mapa);
        }

        private void paymentMethod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // odabran PayPal
                if (paymentMethod.SelectedIndex == 0)
                {
                    payPalTab.Visibility = Visibility.Visible;
                    creditCardTab.Visibility = Visibility.Collapsed;
                }
                else if (paymentMethod.SelectedIndex == 1)
                {
                    payPalTab.Visibility = Visibility.Collapsed;
                    creditCardTab.Visibility = Visibility.Visible;

                    // fokusiramo na tekstbox u koji se treba da učita kod kreditne kartice
                    creditCardCode.Focus(FocusState.Programmatic);
                }
                else
                {
                    payPalTab.Visibility = Visibility.Collapsed;
                    creditCardTab.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception err)
            {
                var dialog = new MessageDialog("Došlo je do greške.");
                dialog.ShowAsync();
            }
        }

        // u ovom eventu potrebno je prvoesti neku vrstu validacije koda dobivenog provlacenjem kreditne kartice kroz citac 
        private void validateCreditCardButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
