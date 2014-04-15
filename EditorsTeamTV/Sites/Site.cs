using WatiN.Core;

namespace EditorsTeamTV.Sites
{
    /// <summary>
    /// Abstract class for the sites.
    /// </summary>
    public abstract class Site
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Site"/> class.
        /// </summary>
        protected Site()
        {
            Browser = new IE();
        }

        /// <summary>
        /// Gets or sets the browser
        /// </summary>
        public IE Browser { get; set; }

        /// <summary>
        /// Runs the site.
        /// </summary>
        public virtual void Run()
        {
            Browser = new IE(true);
        }

        /// <summary>
        /// Gets the window handle.
        /// </summary>
        /// <returns>The window handle id.</returns>
        public virtual int GetHandle()
        {
            return ((SHDocVw.IWebBrowser2)Browser.InternetExplorer).HWND;
        }

        /// <summary>
        /// Refreshes the browser window.
        /// </summary>
        public virtual void Refresh()
        {
            ((SHDocVw.IWebBrowser2)Browser.InternetExplorer).Refresh();
        }
    }
}
