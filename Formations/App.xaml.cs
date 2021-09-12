namespace Formations
{
    using System.Windows;
    using Formations.Engine.Core;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Custom startup instantiates IoC (Inversion of ControL) class before anything else.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            // Let the base application do what it needs to
            base.OnStartup(e);

            // Set up IoC object so singleton view models are instantiated and bound to kernel
            IoC.Setup();

        }
    }
}
