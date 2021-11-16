using System;
using System.Windows.Input;

namespace InternLookup.Core
{
    class RelayCommand : ICommand
    {
        private readonly Action<object> varExecute;
        private readonly Func<object, bool> varCanExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            varExecute = execute;
            varCanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return varCanExecute == null || varCanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            varExecute(parameter);
        }
    }
}