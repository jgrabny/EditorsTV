using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.IO;

using EditorsTeamTV.Sites;
using EditorsTeamTV.Sites.Configuration;

using Parkeon.Common.Configuration;

using Kanbanize = EditorsTeamTV.Sites.Kanbanize;

namespace EditorsTeamTV
{
    /// <summary>
    /// The sites manager.
    /// </summary>
    public sealed class SitesManager
    {
        /// <summary>
        /// Sites configuration section.
        /// </summary>
        private const string SitesConfigSection = "sitesConfigurationSection";

        /// <summary>
        /// Singleton instance of the SitesManager.
        /// </summary>
        private static readonly SitesManager SitesManagerInstance = new SitesManager();

        /// <summary>
        /// The configuration service.
        /// </summary>
        private readonly IConfigurationService configurationService;

        /// <summary>
        /// Prevents for marking class as 'beforefieldinit'.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1409:RemoveUnnecessaryCode",
            Justification = "Reviewed. Suppression is OK here.")]
        static SitesManager()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitesManager"/> class.
        /// </summary>
        private SitesManager()
        {
            configurationService = new ConfigurationService();

            CurrentHandleIndex = 0;
            Handles = new List<int>();
            Sites = new List<Site>();

            this.InitializeSites();
        }

        /// <summary>
        /// Gets the SitesManager instance.
        /// </summary>
        public static SitesManager Instance
        {
            get
            {
                return SitesManagerInstance;
            }
        }

        /// <summary>
        /// Gets or sets the current handle index.
        /// </summary>
        public int CurrentHandleIndex { get; set; }

        /// <summary>
        /// Gets or sets handles of the sites windows
        /// </summary>
        public IList<int> Handles { get; set; }

        /// <summary>
        /// Gets or sets sites.
        /// </summary>
        public IList<Site> Sites { get; set; }

        /// <summary>
        /// Gets or sets the site change interval.
        /// </summary>
        public int SiteChangeInterval { get; set; }

        /// <summary>
        /// Creates collection of sites and runs them.
        /// </summary>
        private void InitializeSites()
        {
            var sitesConfigSection =
                configurationService.GetSectionValue(SitesConfigSection) as SitesConfigurationSection;
            if (sitesConfigSection == null)
            {
                throw new ConfigurationErrorsException();
            }

            //// Kanbanize sites section

            var kanbanizeLogin = configurationService.GetAppValue("kanbanizeLogin");
            var kanbanizePassword = configurationService.GetAppValue("kanbanizePassword");

            foreach (var property in sitesConfigSection.kanbanize)
            {
                var configitem = property as Website;
                if (configitem == null)
                {
                    continue;
                }

                var kanban = new Kanbanize(kanbanizeLogin, kanbanizePassword, configitem.Uri);
                kanban.Run();
                Handles.Add(kanban.GetHandle());
                Sites.Add(kanban);
            }

            //// Simple sites section

            foreach (var property in sitesConfigSection.simpleSite)
            {
                var configitem = property as Website;
                if (configitem == null)
                {
                    continue;
                }

                string uri = configitem.Local
                                 ? Path.Combine(Directory.GetCurrentDirectory(), configitem.Uri)
                                 : configitem.Uri;

                var simpleSite = new Simple(uri);
                simpleSite.Run();
                Handles.Add(simpleSite.GetHandle());
                Sites.Add(simpleSite);
            }
        }
    }
}