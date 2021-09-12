using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formations.Engine.Core
{
    public class ApplicationViewModel : BaseViewModel
    {

        /// <summary>
        /// Gets or sets the current page of the app. The page set here is the page shown on startup.
        /// The page is changed using the <see cref="GoToPage"/> in this class.
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.MainPage;

        /// <summary>
        /// Sets the current page of the application view.
        /// </summary>
        /// <param name="page">The page to be viewed.</param>
        public void GoToPage(ApplicationPage page)
        {
            // Set the page
            CurrentPage = page;
        }
    }
}
