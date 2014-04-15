using WatiN.Core;

namespace EditorsTeamTV.Sites
{
    /// <summary>
    /// Manager for Kanbanize.com
    /// </summary>
    public class Kanbanize : Site
    {
        /// <summary>
        /// Kanbanize login site.
        /// </summary>
        private const string LoginSite = "https://kanbanize.com/ctrl_login";

        /// <summary>
        /// Initializes a new instance of the <see cref="Kanbanize"/> class.
        /// </summary>
        public Kanbanize()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Kanbanize"/> class.
        /// </summary>
        /// <param name="userName">
        /// The user name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="board">
        /// The board.
        /// </param>
        public Kanbanize(string userName, string password, string board)
        {
            UserName = userName;
            Password = password;
            BoardAddress = board;
        }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Kanbanize board address.
        /// </summary>
        public string BoardAddress { get; set; }

        /// <summary>
        /// Runs the Kanbanize site.
        /// </summary>
        public override void Run()
        {
            Browser.GoTo(LoginSite);
            Browser.TextField(Find.ByName("login_email")).TypeText(UserName);
            Browser.TextField(Find.ByName("login_password")).TypeText(Password);
            Browser.Button(Find.ByValue("Log In")).Click();
            Browser.GoTo(BoardAddress);
            ((SHDocVw.IWebBrowser2)Browser.InternetExplorer).FullScreen = true;
        }
    }
}
