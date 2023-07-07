using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SchoolProject.ViewModel
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        private Action<object, RoutedEventArgs> checkedBinding;

        public RelayCommand(Action execute, Func<bool> CanExecute = null)
        {
            _execute = execute;
            _canExecute= CanExecute;
        }



        public RelayCommand(Action<object, RoutedEventArgs> checkedBinding)
        {
            this.checkedBinding = checkedBinding;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }
    }
}
