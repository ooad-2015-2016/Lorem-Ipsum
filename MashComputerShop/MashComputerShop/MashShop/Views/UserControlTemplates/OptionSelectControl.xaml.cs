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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MashComputerShop.MashShop.Views.UserControlTemplates
{
    public sealed partial class OptionSelectControl : UserControl
    {
        public Models.ConfigurationOption ConfigurationOption { get { return this.DataContext as Models.ConfigurationOption; } }

        public OptionSelectControl()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }

        public string getOptionTitle
        {
            get { return ConfigurationOption.OptionTitle; }
        }
    }
}
