<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="9bd628bc-5acc-4605-9de5-0e4fe062d2f9" namespace="EditorsTeamTV.Sites.Configuration" xmlSchemaNamespace="urn:EditorsTeamTV.Sites.Configuration" assemblyName="EditorsTeamTV.Sites.Configuration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
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
    <configurationSection name="SitesConfigurationSection" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="sitesConfigurationSection">
      <elementProperties>
        <elementProperty name="kanbanize" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="kanbanize" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/Kanbanize" />
          </type>
        </elementProperty>
        <elementProperty name="simpleSite" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="simpleSite" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/SimpleSite" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="Website">
      <attributeProperties>
        <attributeProperty name="Id" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="id" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Uri" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="uri" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Local" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="local" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/Boolean" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="Kanbanize" xmlItemName="website" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/Website" />
      </itemType>
    </configurationElementCollection>
    <configurationElementCollection name="SimpleSite" xmlItemName="website" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/9bd628bc-5acc-4605-9de5-0e4fe062d2f9/Website" />
      </itemType>
    </configurationElementCollection>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>