using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCommandSample
{
    public class ChangeColorCommand : ICommand
    {
        public bool CanExecute(object parameter)
   => (parameter as Person) != null;

        public void Execute(object parameter)
        {
            ((Person)parameter).Firstname = "Changed";
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
