namespace Formations.Engine
{
    using Formations.Engine.Core;
    using System.Windows;

    internal class MainWindowViewModel : BaseViewModel
    {

        #region "Private Members"

        /// <summary>
        /// The <see cref="Window"/> this view model controls
        /// </summary>
        private Window MyWindow;

        #endregion

        #region "Public Properties"

        /// <summary>
        /// The minimum window height that can be set by the user
        /// </summary>
        public int WindowMinimumHeight { get; set; } = 500;

        /// <summary>
        /// The minimum window width that can be set by the user
        /// </summary>
        public int WindowMinimumWidth { get; set; } = 800;


        private int _WindowRadius = 10;
        public int WindowRadius
        {
            get => _WindowRadius;
            set => _WindowRadius = value;
        }


        #endregion

        #region "Constructors"

        public MainWindowViewModel(Window window)
        {
            MyWindow = window;
        }

        #endregion



    }
}
