using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views.Presenters;
using System.Windows.Threading;

namespace Formations.WPF
{
    public class Setup
        : MvxWpfSetup
    {
        public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
            : base(dispatcher, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Formations.Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
