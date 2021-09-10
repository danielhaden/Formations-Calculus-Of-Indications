using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Formations.Engine.Core
{
    /// <summary>
    /// A base abstract class that contains Property Changed events
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged

    {
        /// <summary>
        /// The event that is fired when a child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Function to fire a <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="name">The name of the changed property</param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Runs an asynchronous function depending on the state of a boolean property
        /// </summary>
        /// <param name="updatingFlag">A boolean property that marks whether the function is already running</param>
        /// <param name="action">The asynchronous function to be executed (if updatingFlag is false)</param>
        /// <returns></returns>
        protected async Task RunCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // If the function is already running, exit this task
            if (updatingFlag.GetPropertyValue<bool>()) return;

            // Otherwise, try to run the function passed as a parameter
            try
            {
                await action();
            }
            finally
            {
                // Set the flag property back to false regardless of whether the try block executed w/o exception
                updatingFlag.SetPropertyValue(false);
            }
        }
    }
}