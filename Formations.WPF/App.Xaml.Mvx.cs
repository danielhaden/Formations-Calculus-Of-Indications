using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Wpf.Views.Presenters;
using System;
using System.Windows;

namespace Formations.WPF
{
    public partial class App : Application
    {
        private bool _setupComplete;

        /// <summary>
        /// Performs required setup on startup
        /// </summary>
        private void Setup()
        {
            LoadMvxAssemblyResources();

            var presenter = new MvxSimpleWpfViewPresenter(MainWindow);

            var setup = new Setup(Dispatcher, presenter);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            _setupComplete = true;
        }

        protected override void OnActivated(EventArgs e)
        {
            if (!_setupComplete)
            {
                Setup();
            }

            base.OnActivated(e);
        }

        private void LoadMvxAssemblyResources()
        {
            for (var i = 0; ; i++)
            {
                var key = "MvxAssemblyImport" + i;
                var data = TryFindResource(key);
                if (data == null)
                {
                    return;
                }
            }
        }
    }
}