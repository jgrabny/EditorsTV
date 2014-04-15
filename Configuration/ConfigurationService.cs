using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using Parkeon.Common.Configuration.Properties;

namespace Parkeon.Common.Configuration
{
    /// <summary>
    /// Class responsible for providing configuration
    /// </summary>
    public class ConfigurationService : Parkeon.Common.Configuration.IConfigurationService
    {
        #region Private Members


        /// <summary>
        /// Path to the Configuration Settings XML file
        /// </summary>
        private string m_settingsPath;

        /// <summary>
        /// Dictionary containing the configuration strings
        /// </summary>
        private IDictionary<string, string> m_configurationDictionary;

        /// <summary>
        /// The default configuration loaded from the app.config
        /// </summary>
        private System.Configuration.Configuration m_defaultConfig;

        /// <summary>
        /// The override configuration loaded from the supplied file
        /// </summary>
        private System.Configuration.Configuration m_overridenConfig;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationService"/> class.
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path 
        /// containing the override configuration.</param>
        /// <exception cref="ConfigurationErrorsException">configuration file is invalid</exception>
        public ConfigurationService()
            : this(Resources.DefaultSettingsFileName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationService"/> class.
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path 
        /// containing the override configuration.</param>
        /// <exception cref="ConfigurationErrorsException">configuration file is invalid</exception>
        public ConfigurationService(string configurationFilePath)
        {
            Configure(configurationFilePath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationService"/> class.
        /// </summary>
        /// <param name="useAssemblyConfiguration">Indicates the configuration 
        /// from the calling assembly should be used</param>
        /// <exception cref="ConfigurationErrorsException">configuration file is invalid</exception>
        public ConfigurationService(bool useAssemblyConfiguration)
         {
            if (useAssemblyConfiguration == true)
            {
                m_defaultConfig = ConfigurationManager.OpenExeConfiguration(
                    Assembly.GetCallingAssembly().Location);
            }
            Configure(Resources.DefaultSettingsFileName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationService"/> class.
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path 
        /// containing the override configuration.</param>
        /// <param name="useAssemblyConfiguration">Indicates the configuration 
        /// from the calling assembly should be used</param>
        /// <exception cref="ConfigurationErrorsException">configuration file is invalid</exception>
        public ConfigurationService(string configurationFilePath, bool useAssemblyConfiguration)
        {
            if (useAssemblyConfiguration == true)
            {
                m_defaultConfig = ConfigurationManager.OpenExeConfiguration(
                    Assembly.GetCallingAssembly().Location);
            }
            Configure(configurationFilePath);
        }
        #endregion


        #region Private Methods

        /// <summary>
        /// Configures the <see cref="ConfigurationService"/>
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path 
        /// containing the override configuration if required.</param>
        /// <exception cref="ConfigurationErrorsException">configuration file is invalid</exception>
        private void Configure(string configurationFilePath)
        {
            // Gets the default configuration
            if (m_defaultConfig == null)
            {
                GetDefaultConfigurationForApplication();
            }

            // If the path is relative to the Application Current Directory
            // make sure the full base directory is used (required for services)
            if (Path.IsPathRooted(configurationFilePath) == false)
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                m_settingsPath = Path.Combine(appDirectory, configurationFilePath);
            }

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configurationFilePath;

            m_overridenConfig = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            // Check at least one config was found.
            if (!m_defaultConfig.HasFile && !m_overridenConfig.HasFile)
            {
                string message = string.Format(Resources.msg_ConfigurationFileDoesNotExist,
                    configurationFilePath, Assembly.GetEntryAssembly().GetName().Name);
                // Can't log this, as we won't have a logger!
                throw new ApplicationException(message);
            }
        }

        /// <summary>
        /// Gets the Default Configuration for an application, ie: Exe, Windows Service or Website
        /// </summary>
        private void GetDefaultConfigurationForApplication()
        {
            string defaultConfigPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            if (File.Exists(defaultConfigPath))
            {
                ConfigurationFileMap defaultConfigurationFileMap = new ConfigurationFileMap(defaultConfigPath);
                m_defaultConfig = ConfigurationManager.OpenMappedMachineConfiguration(defaultConfigurationFileMap);
            }
            else
            {
                m_defaultConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            }
        }

        /// <summary>
        /// Find the value if stored in configuration.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>object</c> if the specified settingName stored in configuration; 
        /// 	otherwise, <c>null</c>.
        /// </returns>
        private object FindValue(string settingName)
        {
            // Check if the key exists in appSettings
            object setting = FindAppValue(settingName);

            // Check if the key exists as a ConfigurationSection
            if (setting == null)
            {
                setting = FindSectionValue(settingName);
            }

            // Check if the key exists as a ConnectionString
            if (setting == null)
            {
                setting = FindConnectionString(settingName);
            }

            return setting;
        }


        /// <summary>
        /// Find the value if stored in a ConfigurationSection.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>object</c> if the specified settingName stored in configuration; 
        /// 	otherwise, <c>null</c>.
        /// </returns>
        private object FindSectionValue(string settingName)
        {
            // Check if the key exists
            object setting = null;

            if (m_overridenConfig.HasFile)
            {
                ConfigurationSection section = m_overridenConfig.GetSection(settingName);

                if (section != null && section.SectionInformation.GetRawXml() != null)
                {
                    setting = section;
                }
            }

            if (setting == null)
            {
                ConfigurationSection section = m_defaultConfig.GetSection(settingName);

                if (section != null && section.SectionInformation.GetRawXml() != null)
                {
                    setting = section;
                }
            }

            return setting;
        }

        /// <summary>
        /// Find the value if stored in connectionStrings.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>object</c> if the specified settingName stored in 
        /// 	connectionStrings; otherwise, <c>null</c>.
        /// </returns>
        private string FindConnectionString(string settingName)
        {
            // Check if the key exists
            string setting = null;

            if (m_overridenConfig.HasFile)
            {
                var s = m_overridenConfig.ConnectionStrings.ConnectionStrings[settingName];

                if (s != null)
                {
                    setting = s.ConnectionString;
                }
            }

            if (setting == null)
            {
                var s = ConfigurationManager.ConnectionStrings[settingName];

                if (s != null)
                {
                    setting = s.ConnectionString;
                }
            }

            return setting;
        }

        /// <summary>
        /// Find the value if stored in appSettings.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>object</c> if the specified settingName stored in configuration; 
        /// 	otherwise, <c>null</c>.
        /// </returns>
        private string FindAppValue(string settingName)
        {
            // Check if the key exists
            string setting = null;

            if (m_overridenConfig.HasFile)
            {
                var s = m_overridenConfig.AppSettings.Settings[settingName];

                if (s != null)
                {
                    setting = s.Value;
                }
            }

            if (setting == null)
            {
                setting = ConfigurationManager.AppSettings[settingName];
            }

            return setting;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Gets the string value stored in the ConfigurationSection
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        /// Configuration key does not exist in ConfigurationSection</exception>
        public object GetSectionValue(string key)
        {
            object setting = FindSectionValue(key);

            if (setting == null)
            {
                string message = Resources.msg_ConfigurationKeyNotSection;
                message = string.Format(message, key);
                throw new ConfigurationErrorsException(message);
            }
            return setting;
        }

        /// <summary>
        /// Gets all the values stored in the connectionStrings.
        /// This will provide a single collection containing the defaults or 
        /// overrides as appropriate.
        /// </summary>
        /// <returns>The collection of all connection strings.</returns>
        public ConnectionStringSettingsCollection GetConnectionStrings()
        {
            ConnectionStringSettingsCollection allConnections =
                new ConnectionStringSettingsCollection();

            // Put in all the default values
            foreach (ConnectionStringSettings connSetting in 
                ConfigurationManager.ConnectionStrings)
            {
                allConnections.Add(connSetting);
            }

            if (m_overridenConfig.HasFile)
            {
                foreach (ConnectionStringSettings connSetting in
                    m_overridenConfig.ConnectionStrings.ConnectionStrings)
                {
                    // Remove the default if already present
                    if (allConnections[connSetting.Name] != null)
                    {
                        allConnections.Remove(connSetting.Name);
                    }
                    allConnections.Add(connSetting);
                }
            }

            return allConnections;
        }

        /// <summary>
        /// Gets the string value stored in the connectionStrings
        /// </summary>
        /// <param name="key">Connection name</param>
        /// <returns>Stored connection string</returns>
        /// <exception cref="ConfigurationErrorsException">
        /// Configuration key does not exist in connectionStrings</exception>
        public string GetConnectionString(string key)
        {
            string setting = FindConnectionString(key);

            if (setting == null)
            {
                string message = Resources.msg_ConfigurationKeyNotConnectionString;
                message = string.Format(message, key);
                throw new ConfigurationErrorsException(message);
            }
            return setting;
        }


        /// <summary>
        /// Gets the string value stored in the appSettings
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        /// Configuration key does not exist in appSettings</exception>
        public string GetAppValue(string key)
        {
            string setting = FindAppValue(key);

            if (setting == null)
            {
                string message = Resources.msg_ConfigurationKeyNotAppSetting;
                message = string.Format(message, key);
                throw new ConfigurationErrorsException(message);
            }
            return setting;
        }

        /// <summary>
        /// Gets the string value stored in the configuration
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        /// Configuration key does not exist or value is not a string</exception>
        public string GetStringValue(string key)
        {
            string setting = GetValue(key) as string;

            if (setting == null)
            {
                string message = Resources.msg_ConfigurationKeyNotString;
                message = string.Format(message, key);
                throw new ConfigurationErrorsException(message);
            }
            return setting;
        }

        /// <summary>
        /// Gets the value stored in the configuration
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">Configuration key does not exist</exception>
        public object GetValue(string key)
        {
            // Check if the key exists
            object setting = FindValue(key);

            if(setting == null)
            {
                string message = Resources.msg_ConfigurationKeyDoesNotExists;
                message = string.Format(message, key);
                throw new ConfigurationErrorsException(message);
            }
            return setting;
        }

        /// <summary>
        /// Checks if the value is stored in a ConfigurationSection.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored in a 
        /// 	ConfigurationSection; otherwise, <c>false</c>.
        /// </returns>
        public bool HasSectionValue(string settingName)
        {
            return FindSectionValue(settingName) != null;
        }

        /// <summary>
        /// Checks if the value is stored in connectionStrings.
        /// </summary>
        /// <param name="connectionName">Connection name</param>
        /// <returns>
        /// 	<c>true</c> if the specified connectionName stored in 
        /// 	connectionStrings; otherwise, <c>false</c>.
        /// </returns>
        public bool HasConnectionString(string connectionName)
        {
            return FindConnectionString(connectionName) != null;
        }

        /// <summary>
        /// Checks if the value is stored in appSettings.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored in appSettings; 
        /// 	otherwise, <c>false</c>.
        /// </returns>
        public bool HasAppValue(string settingName)
        {
            return FindAppValue(settingName) != null;
        }

        /// <summary>
        /// Checks if the value is stored in as a string.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored in configuration
        /// 	as a string; otherwise, <c>false</c>.
        /// </returns>
        public bool HasStringValue(string settingName)
        {
            return (FindValue(settingName) as string) != null;
        }

        /// <summary>
        /// Checks if the value is stored in configuration.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored in configuration; 
        /// 	otherwise, <c>false</c>.
        /// </returns>
        public bool HasValue(string settingName)
        {
            return FindValue(settingName) != null;
        }
        #endregion
    }
}
