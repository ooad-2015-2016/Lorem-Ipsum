using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using MashComputerShop.MashShop.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace MashComputerShop.MashShop.ViewModels
{
    public class CreatorVM
    {
        public ShoppingCartVM ShoppingCartVM { get; set; }

        // Filter za cijenu
        public ConfigurationOption PriceRange { get; set; }

        // servis za navigaciju
        public INavigationService NavigationService { get; set; }

        // dodatne komande koje realizuju dodavanje i prikaz detalja o proizvodu
        public ICommand MoveToComponentSelection { get; set; }
        public ICommand MoveToPriceRange { get; set; }
        public ICommand ComponentSelection { get; set; }
        public ICommand AddComponentToConfiguration { get; set; }


        // Kontruktor
        public CreatorVM(ShoppingCartVM scvm)
        {
            ShoppingCartVM = scvm;
            PriceRange = new ConfigurationOption("","");
            NavigationService = new NavigationService();

            // inicijaliziramo komande
            MoveToPriceRange = new RelayCommand(moveToPriceRange, canMoveToPriceRange);
            MoveToComponentSelection = new RelayCommand(moveToComponentSelection, canMoveToComponentSelection);
            AddComponentToConfiguration = new RelayCommand(addComponentToConfiguration);
        }


        // proxy metoda za postavljanje odredisnos frame-a
        public void SetTargetPageFrame(Frame targetFrame)
        {
            NavigationService.SetTargetFrame(targetFrame);
        }

        // proxy metoda za postavljenja sekundarnog fram-a ( za double step back)
        public void SetParentPageFrame(Frame parentFrame)
        {
            NavigationService.SetParentFrame(parentFrame);
        }


        #region Commands
        // Navigacija na prvi korak 
        private void moveToPriceRange(object obj)
        {
            NavigationService.Navigate(typeof(PriceRangeSelection), this);
        }

        private bool canMoveToPriceRange(object arg)
        {
            return PriceRange.OptionTitle == "";
        }

        // Navigacija na drugi korak 
        private void moveToComponentSelection(object obj)
        {
            NavigationService.Navigate(typeof(ComponentSelection), this);
        }

        private bool canMoveToComponentSelection(object arg)
        {
            return PriceRange.OptionTitle != "";
        }


        // dodavanje nove komponente u konfiguraciju
        private void addComponentToConfiguration(object obj)
        {
            var type = obj as string;
           
            NavigationService.Navigate(typeof(ProductsTileView), 
                new Tuple<ShoppingCartVM, string, bool>(ShoppingCartVM, type, true));
        }

        #endregion Commands


    }
}
