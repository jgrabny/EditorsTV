<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="096b0121-8084-47fe-acf7-1af2a6088561" namespace="EditorsTeamTV.Scheduling.Configuration" xmlSchemaNamespace="urn:EditorsTeamTV.Scheduling.Configuration" assemblyName="EditorsTeamTV.Scheduling.Configuration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="QuartzConfigurationSection" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="quartzConfigurationSection">
      <elementProperties>
        <elementProperty name="quartzPluginSettings" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="quartzPluginSettings" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/096b0121-8084-47fe-acf7-1af2a6088561/QuartzPluginSettings" />
          </type>
        </elementProperty>
        <elementProperty name="quartzThreadPoolSettings" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="quartzThreadPoolSettings" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/096b0121-8084-47fe-acf7-1af2a6088561/QuartzThreadPoolSettings" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElementCollection name="QuartzPluginSettings" xmlItemName="quartzConfigurationItem" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/096b0121-8084-47fe-acf7-1af2a6088561/QuartzConfigurationItem" />
      </itemType>
    </configurationElementCollection>
    <configurationElementCollection name="QuartzThreadPoolSettings" xmlItemName="quartzConfigurationItem" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/096b0121-8084-47fe-acf7-1af2a6088561/QuartzConfigurationItem" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="QuartzConfigurationItem">
      <attributeProperties>
        <attributeProperty name="Key" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="key" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/096b0121-8084-47fe-acf7-1af2a6088561/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Value" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="value" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/096b0121-8084-47fe-acf7-1af2a6088561/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>