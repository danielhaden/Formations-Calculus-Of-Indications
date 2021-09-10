using System;
using System.Windows.Input;


namespace Formations.Engine.Core
{ 
    /// <summary>
    /// A basic command that runs an action"/>
    /// </summary>
    class RelayCommand : ICommand
    {
        #region "Private Members"

        /// <summary>
        /// The action to run when the command is executed.
        /// </summary>
        private Action _action;

        #endregion

        #region "Constructors"

        /// <summary>
        /// RelayCommand constructor
        /// </summary>
        /// <param name="action">The action this command will run</param>
        public RelayCommand(Action action)
        {
            this._action = action;
        }

        #endregion

        #region "ICommand Methods"

        /// <summary>
        /// Returns whether the relay command can execute. A relay command can always execute.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>true always</returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Performs the action associated with the command
        /// </summary>
        /// <param name="parameter">The parameter is ignored. For parameterized commands <see cref="RelayParameterizedCommand"/></param>
        public void Execute(object parameter)
        {
            _action();
        }

        #endregion

        #region "Public Events"

        /// <summary>
        /// The event that is fired when the CanExecuted value of the relay command has changed.
        /// This should never be fired because the command can always be executed.
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion
    }
}
