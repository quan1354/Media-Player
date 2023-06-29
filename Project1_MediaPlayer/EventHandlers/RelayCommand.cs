using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project1_MediaPlayer
{
    /// <summary>
    /// Handles all UI Commands
    /// </summary>
    public class RelayCommand<T> : ICommand, IRelayCommand
    {
        /// <summary>
        /// Can event be executed
        /// </summary>
        private readonly Predicate<T> _canExecute;
        /// <summary>
        /// Execute event 
        /// </summary>
        private readonly Action<T> _execute;
        /// <summary>
        /// Set the execute paramter
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<T> execute) : this(execute, null)
        {
            _execute = execute;
        }
        /// <summary>
        /// Set the evet parameters
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Add or remove events
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        /// <summary>
        /// Indicates if an event can be executed
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return (_canExecute == null) || _canExecute((T)parameter);
        }

        /// <summary>
        /// Execute an event 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }
    }
}
