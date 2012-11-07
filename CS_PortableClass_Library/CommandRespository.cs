using System;
using System.Windows.Input;

namespace CS_PortableClass_Library
{
    public class CommandRespository : ICommand
    {
        private Action _handler;

        public CommandRespository(Action handler)
        {
            _handler = handler;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _handler();
        }
    }
}
