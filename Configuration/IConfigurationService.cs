using System;
using System.Configuration;

namespace Parkeon.Common.Configuration
{
    /// <summary>
    /// Interface for accessing configuration information.
    /// </summary>
    public interface IConfigurationService
    {
        /// <summary>
        /// Gets all the values stored in the connectionStrings.
        /// This will provide a single collection containing the defaults or 
        /// overrides as appropriate.
        /// </summary>
        /// <returns>The collection of all connection strings.</returns>
        ConnectionStringSettingsCollection GetConnectionStrings();

        /// <summary>
        /// Gets the string value stored in the appSettings
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        ///     Configuration key does not exist in appSettings</exception>
        string GetAppValue(string key);

        /// <summary>
        /// Gets the string value stored in the connectionStrings
        /// </summary>
        /// <param name="key">Connection name</param>
        /// <returns>Stored connection string</returns>
        /// <exception cref="ConfigurationErrorsException">
        ///     Configuration key does not exist in connectionStrings</exception>
        string GetConnectionString(string key);
 
        /// <summary>
        /// Gets the structured object value stored in the ConfigurationSection
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        ///     Configuration key does not exist in ConfigurationSection</exception>
        object GetSectionValue(string key);

        /// <summary>
        /// Gets the string value stored in the configuration
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        ///     Configuration key does not exist or value is not a string</exception>
        string GetStringValue(string key);

        /// <summary>
        /// Gets the value stored in the configuration
        /// </summary>
        /// <param name="key">Configuration value name</param>
        /// <returns>Stored configuration value</returns>
        /// <exception cref="ConfigurationErrorsException">
        ///     Configuration key does not exist</exception>
        object GetValue(string key);

        /// <summary>
        /// Checks if the value is stored in appSettings.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName is stored in appSettings; 
        /// 	otherwise, <c>false</c>.
        /// </returns>
        bool HasAppValue(string settingName);

        /// <summary>
        /// Checks if the value is stored in connectionStrings.
        /// </summary>
        /// <param name="connectionName">Connection name</param>
        /// <returns>
        /// 	<c>true</c> if the specified is connectionName stored in 
        /// 	connectionStrings; otherwise, <c>false</c>.
        /// </returns>
        bool HasConnectionString(string connectionName);

        /// <summary>
        /// Checks if the value is stored in a ConfigurationSection.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored as a 
        /// 	ConfigurationSection; otherwise, <c>false</c>.
        /// </returns>
        bool HasSectionValue(string settingName);

        /// <summary>
        /// Checks if the value is stored as a string.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored in configuration
        /// 	as a string; otherwise, <c>false</c>.
        /// </returns>
        bool HasStringValue(string settingName);

        /// <summary>
        /// Checks if the value is stored in configuration.
        /// </summary>
        /// <param name="settingName">Configuration value name</param>
        /// <returns>
        /// 	<c>true</c> if the specified settingName stored in configuration; 
        /// 	otherwise, <c>false</c>.
        /// </returns>
        bool HasValue(string settingName);
    }
}
