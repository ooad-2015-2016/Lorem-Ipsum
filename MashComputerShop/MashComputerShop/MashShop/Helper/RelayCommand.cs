using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MashComputerShop.MashShop.Helper
{
    public class RelayCommand : ICommand
    {
        // atributi
        private Func<object, bool> _canExecute;
        private Action<object> _execute;

        #region Constructors

        public RelayCommand(Action<object> execMethod)
        {
            this._execute = execMethod;
            this._canExecute = (x) => { return true; };
        }

        public RelayCommand(Action<object> execMethod, Func<object, bool> canExecMethod)
        {
            _execute = execMethod;
            _canExecute = canExecMethod;
        }

        #endregion

        #region ICommand Members

        public event EventHandler CanExecuteChanged;

        bool ICommand.CanExecute(object parameter)
        {
            try { return CanExecute(parameter); }
            catch { return false; }
        }

        void ICommand.Execute(object parameter)
        {
            Execute(parameter);
        }

        #endregion ICommand Members

        #region Public Methods

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if(_execute != null) _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if(CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }

        #endregion Public Methods

        #region Protected Methods

        protected void OnCanExecuteChanged(EventArgs empty)
        {
            var handler = CanExecuteChanged;

            if (handler != null) handler(this, empty);
        }

        #endregion Protected Methods

    }
}
