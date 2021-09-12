namespace Formations.Engine.Core
{
    using Ninject;

    /// <summary>
    /// Class that implements the inversion-of-control design pattern for our application. This takes application startup c ontrol
    /// away fromt he URI and does startup itself.
    /// </summary>
    public static class IoC
    {

        /// <summary>
        /// The kernel for our IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// Gets a service from the IoC. This will be different view models located in Formations.Core
        /// </summary>
        /// <typeparam name="T">The type of the service</typeparam>
        /// <returns>The singleton object (i.e. a view model) stored in the kernel</returns>
        public static T GetService<T>()
        {
            return Kernel.Get<T>();
        }

        /// <summary>
        /// Sets up the IoC container and binds all singleton objects required by the application to the kernel.
        /// NB: This should be called on application startup (in the code behind App.xaml)
        /// </summary>
        public static void Setup()
        {
            BindViewModels();   
        }

        /// <summary>
        /// Creates singleton objects for each view model required by the application and binds them to the kernel.
        /// </summary>
        private static void BindViewModels()
        {
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }


    }
}
