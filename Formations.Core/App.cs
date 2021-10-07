using MvvmCross.Platform.IoC;

namespace Formations.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Set the starting page
            RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
        }
    }
}
