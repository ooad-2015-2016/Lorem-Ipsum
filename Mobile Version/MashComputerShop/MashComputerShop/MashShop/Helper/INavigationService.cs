using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MashComputerShop.MashShop.Helper
{
    public interface INavigationService
    {
        void SetTargetFrame(Frame targetFrame);
        void SetParentFrame(Frame parentFrame);
        void Navigate(Type sourcePage);
        void Navigate(Type sourcePage, object param);
        void GoBack();
    }
}
