using System;
using System.Windows.Input;

namespace CommandsAndPropertyChanged
{
    public class Command : ICommand
    {
        private Action<object> action;
        private Func<bool> func;


        public Command(Action<object> action, Func<bool> func = null)
        {
            this.action = action;
            this.func = func;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {          
            return func?.Invoke() ?? true;
        }

        public void Execute(object parameter)
        {
            action.Invoke(parameter);
        }

        public void CanExecuteChange()
        {
            CanExecuteChanged.Invoke(this,EventArgs.Empty);
        }
    }
}
