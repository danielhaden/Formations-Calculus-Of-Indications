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

        public short GridViewWidth { get; set; } = 300;

        public short GridViewHeight { get; set; } = 300;



    }
}
