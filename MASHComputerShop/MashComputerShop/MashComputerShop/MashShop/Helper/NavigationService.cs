using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MashComputerShop.MashShop.Helper
{
    public class NavigationService : INavigationService
    {
        private Frame targetFrame;
        private Frame parentFrame;

        #region Konstruktori

        public NavigationService(Frame targetFrame = null)
        {
            this.targetFrame = new Frame();
            this.targetFrame = targetFrame;
        }

        public NavigationService()
        {
            targetFrame = null;
        }

        #endregion Kontruktori

        // navigation to another page without additional parameters
        public void Navigate(Type sourcePage)
        {
            // ako nije specificiran odredisni frame uzimamo defaultni
            if (targetFrame == null) targetFrame = Window.Current.Content as Frame;
            targetFrame.Navigate(sourcePage);            
        }

        // navigation to another page with additional parameter
        public void Navigate(Type sourcePage, object param)
        {
            // ako nije specificiran odredisni frame uzimamo defaultni
            if (targetFrame == null) targetFrame = Window.Current.Content as Frame;
            targetFrame.Navigate(sourcePage, param);
        }

        // povratak na prethodnu stranicu
        public void GoBack()
        {
            if (targetFrame == null) targetFrame = Window.Current.Content as Frame;

            if (targetFrame.CanGoBack) targetFrame.GoBack();
        }

        // povratak 2 stranice prije
        public void GoBackTwice()
        {
            if (parentFrame.CanGoBack) parentFrame.GoBack();
        }
        
        // postavljanje odredisnog frame-a
        public void SetTargetFrame(Frame targetFrame)
        {
            this.targetFrame = targetFrame;
        }

        // postavljanje odredisnog frame-a
        public void SetParentFrame(Frame parentFrame)
        {
            this.parentFrame = parentFrame;
        }

    }
}
