using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Raetselraten
{

    //https://www.c-sharpcorner.com/article/explaing-icommand-in-mvvm-wpf/
    public class MyCommand: ICommand
    {
        Action<object> _execteMethod;
        Func<object, bool> _canexecuteMethod;

        public MyCommand(Action<object> execteMethod, Func<object, bool> canexecuteMethod)
        {
            _execteMethod = execteMethod;
            _canexecuteMethod = canexecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            var canExecute = _canexecuteMethod(parameter);
            return canExecute;
        }
      
    public void Execute(object parameter)
        {
            _execteMethod(parameter);
        }

        public event EventHandler CanExecuteChanged
{
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
