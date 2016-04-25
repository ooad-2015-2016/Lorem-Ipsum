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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MashComputerShop.CustomUserControls
{
    public sealed partial class SignUpForm : UserControl
    {
        public SignUpForm()
        {
            this.InitializeComponent();
        }

        // Property za postavljanje boje pozadine
        public SolidColorBrush FormColor
        {
            get { return (SolidColorBrush)backboardPanel.Background; }
            set { backboardPanel.Background = value; }
        }

        private void TextBoxBackground_GotFocus(object sender, RoutedEventArgs e)
        {
            NameTB.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(0, 74, 159, 239));
        }

        private void doneBtt_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        // Property za postavljanje boje textboxova
        // To Be implemented Soon

    }
}
