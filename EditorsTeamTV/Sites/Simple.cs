using System;

using WatiN.Core;

namespace EditorsTeamTV.Sites
{
    /// <summary>
    /// Manages the simple site.
    /// </summary>
    public class Simple : Site
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Simple"/> class.
        /// </summary>
        /// <param name="siteName">The site name.</param>
        public Simple(string siteName)
        {
            SiteName = siteName;
        }

        /// <summary>
        /// Gets or sets the site name.
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// Runs the site.
        /// </summary>
        public override void Run()
        {
            Browser.GoTo(SiteName);
            ((SHDocVw.IWebBrowser2)Browser.InternetExplorer).FullScreen = true;
        }
    }
}
