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
    public sealed partial class LargeTileButton : UserControl
    {
        public LargeTileButton()
        {
            this.InitializeComponent();
        }

        // Property za boju pozadine dugmeta
        public SolidColorBrush ButtonColor
        {
            get { return (SolidColorBrush)tileButton.Background; }
            set { tileButton.Background = bttOutline.Background = value; }
        }

        // Property za postavljanje ikone na dugme
        public ImageSource IconSource
        {
            get { return (ImageSource)tileIcon.Source; }
            set { tileIcon.Source = value; }
        }

        // Property za text labele 
        public string Text
        {
            get { return tileLabel.Text; }
            set { tileLabel.Text = value; }
        }
    }
}
