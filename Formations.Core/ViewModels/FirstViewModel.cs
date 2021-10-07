using MvvmCross.Core.ViewModels;

namespace Formations.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        public short GridViewWidth { get; set; } = 900;

        public short GridViewHeight { get; set; } = 900;

        public short ZoomLevel { get; set; } = 10;


        bool _AreMajorGridlinesDistinguished = true;
        /// <summary>
        /// Indicates whether major/minor gridlines should be distinguished or uniform
        /// </summary>
        public bool AreMajorGridlinesDistinguished {
            get { return _AreMajorGridlinesDistinguished; }
            set { SetProperty(ref _AreMajorGridlinesDistinguished, value); }  
        }


    }
}
