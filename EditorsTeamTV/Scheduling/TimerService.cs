using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Reflection;

using EditorsTeamTV.Scheduling.Configuration;

using Helpers;

using Parkeon.Common.Configuration;

using Quartz;
using Quartz.Impl;
using Quartz.Impl.Calendar;

namespace EditorsTeamTV.Scheduling
{
    /// <summary>
    /// The Timer Service. Utilizes the Quartz.Net library.
    /// </summary>
    public class TimerService : IDisposable
    {
        #region Constants

        /// <summary>
        /// Configuration section that contains Quartz.NET config.
        /// </summary>
        private const string QuartzConfigSection = "quartzConfigurationSection";

        /// <summary>
        /// Quartz configuration key that contains files definitions.
        /// </summary>
        private const string QuartzFileConfigKey = "quartz.plugin.xml.fileNames";

        #endregion

        #region Private Members

        /// <summary>
        /// The configuration service.
        /// </summary>
        private readonly IConfigurationService configurationService;

        /// <summary>
        /// The Quartz scheduler.
        /// </summary>
        private IScheduler scheduler;

        /// <summary>
        /// Indicates whether the service is initialized.
        /// </summary>
        private bool initialized;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TimerService"/> class.
        /// </summary>
        public TimerService()
        {
            configurationService = new ConfigurationService();

            this.InitializeTimer();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts the timer.
        /// </summary>
        public void StartTimer()
        {
            if (initialized)
            {
                Utils.WriteConsoleLog("Initializing the timer.");
                scheduler.Start();
            }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public void Dispose()
        {
            scheduler.Shutdown();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes the Timer Service.
        /// </summary>
        private void InitializeTimer()
        {
            initialized = false;

            var properties = this.BuildQuartzPropertiesFromConfiguration();

            ISchedulerFactory sf = new StdSchedulerFactory(properties);

            scheduler = sf.GetScheduler();

            this.CreateCalendar("cal1");

            initialized = true;
        }

        /// <summary>
        /// Creates the simple calendar and adds it to the scheduler.
        /// </summary>
        /// <param name="calName">The calendar name.</param>
        private void CreateCalendar(string calName)
        {
            var dailyCalendar = new DailyCalendar("00:01", "23:59");
            dailyCalendar.InvertTimeRange = true;

            if (!scheduler.GetCalendarNames().Contains(calName))
            {
                scheduler.AddCalendar(calName, dailyCalendar, false, false);
            }
        }

        /// <summary>
        /// Builds the quartz properties from configuration.
        /// </summary>
        /// <returns>Name-value collection of the Quartz configuration items.</returns>
        private NameValueCollection BuildQuartzPropertiesFromConfiguration()
        {
            var quartzConfigSection = configurationService.GetSectionValue(QuartzConfigSection) as QuartzConfigurationSection;
            if (quartzConfigSection == null)
            {
                throw new ConfigurationErrorsException();
            }

            var properties = new NameValueCollection();

            foreach (var property in quartzConfigSection.quartzThreadPoolSettings)
            {
                var configitem = property as QuartzConfigurationItem;
                if (configitem == null)
                {
                    continue;
                }

                properties[configitem.Key] = configitem.Value;
            }

            foreach (var property in quartzConfigSection.quartzPluginSettings)
            {
                var configitem = property as QuartzConfigurationItem;
                if (configitem == null)
                {
                    continue;
                }

                if (configitem.Key.Equals(QuartzFileConfigKey))
                {
                    string finalPath = GetPathToJobsDef(configitem.Value);
                    if (string.IsNullOrEmpty(finalPath))
                    {
                        return null;
                    }

                    properties[configitem.Key] = finalPath;
                    continue;
                }

                properties[configitem.Key] = configitem.Value;
            }

            return properties;
        }

        /// <summary>
        /// Gets the path to file with jobs definitions.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>Path to the file with configured Quartz jobs.</returns>
        private string GetPathToJobsDef(string fileName)
        {
            var quartzConfigPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            if (!File.Exists(quartzConfigPath))
            {
                return fileName;
            }

            return quartzConfigPath;
        }

        #endregion
    }
}
