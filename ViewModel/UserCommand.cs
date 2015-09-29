using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class UserCommand:ICommand
    {
        private Action<Object> action;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(Object parameter)
        {
            if (parameter != null) action(parameter);
            else action("Hello World");
        }
        public UserCommand(Action<Object> action)
        {
            this.action = action;                      
        }
    }
}
