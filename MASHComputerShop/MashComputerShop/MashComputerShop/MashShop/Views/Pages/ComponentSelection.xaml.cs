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
    public sealed partial class ComponentSelection : Page
    {
        private List<ConfigurationOption> SelectorOptions;
        public CreatorVM CreatorVM { get; set; }

        public ComponentSelection()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;

            SelectorOptions = OptionsCatalog.getComponentOptions();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var tup = e.Parameter as Tuple<CreatorVM, Rectangle>;
            CreatorVM = tup.Item1;
            DataContext = CreatorVM;
        }

        private void componentSelectorContainer_ItemClick_1(object sender, ItemClickEventArgs e)
        { 
            CreatorVM.SetTargetPageFrame(Frame);

            var item = e.ClickedItem as ConfigurationOption;
            SelectorOptions.Remove(item);
            CreatorVM.AddComponentToConfiguration.Execute(item.OptionTitle);
        }

    }
}
