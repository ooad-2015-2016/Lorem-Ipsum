using MashComputerShop.MashShop.Models;
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
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MashComputerShop.MashShop.Views.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PriceRangeSelection : Page
    {
        private List<ConfigurationOption> SelectorOptions;
        private Rectangle underline;

        // ViewModel
        public CreatorVM CreatorVM { get; set; }

        public PriceRangeSelection()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
            SelectorOptions = OptionsCatalog.getConfigurationOptions();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var args = e.Parameter as Tuple<CreatorVM, Rectangle>;
            CreatorVM = args.Item1;
            underline = args.Item2;

            CreatorVM.PriceRange = SelectorOptions[0];
            DataContext = CreatorVM;
        }

    }
}
