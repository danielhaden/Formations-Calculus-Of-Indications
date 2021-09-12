using Formations.Engine.Core;

namespace Formations.Engine
{

    /// <summary>
    /// Uses dependency injection (IoC) for use in binding in XAML files
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Singleton instance of the locator.
        /// </summary>
        public static ViewModelLocator Instance { get; set; } = new ViewModelLocator();

        //public static ApplicationViewModel ApplicationViewModel = 
        //    Public Shared ReadOnly Property ApplicationViewModel As ApplicationViewModel = IoC.GetService(Of ApplicationViewModel)()


    }
}






//End Class
