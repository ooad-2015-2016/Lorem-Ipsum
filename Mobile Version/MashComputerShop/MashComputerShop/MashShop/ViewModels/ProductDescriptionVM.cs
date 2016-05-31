using MashComputerShop.MashShop.Helper;
using MashComputerShop.MashShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MashComputerShop.MashShop.ViewModels
{
    public class ProductDescriptionVM
    {
        // cuvamo glavni VM jer se u njemu nalaze svi podaci
        public ShoppingCartVM Parent { get; set; }
        public ShoppingCartItem ShoppingCartItem { get; set; }
        public ICommand AddToCart { get; set; }

        // privatno polje kojim određujemo odakle je pozvan VM
        private bool isConfigWizard;

        #region Constructors

        public ProductDescriptionVM(ShoppingCartVM parent, ShoppingCartItem item, bool config = false)
        {
            this.Parent = parent;
            AddToCart = new RelayCommand(addItemToCart, canBeAdded);

            isConfigWizard = config;

            // odabrana stavka sa default proizovodom
            ShoppingCartItem = item;
        }

        #endregion Constructors

        #region Commands

        // Metode za validaciju i dodavanje stavke u korpu
        private bool canBeAdded(object arg)
        {
            return true;
        }

        private void addItemToCart(object obj)
        {
            Parent.ShoppingCart.Items.Add(ShoppingCartItem);

            if (isConfigWizard)
            {
                // ako je pozvano prilikom pravljenja konfiguracije potrebno je automatski se vratiti
                // na stranicu za izbor komponenti
                Parent.FilteredProducts.Clear();
                Parent.NavigationService.GoBack();
                Parent.NavigationService.GoBack();
            }
            
        }

        #endregion Commands


    }
}
