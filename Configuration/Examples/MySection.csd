<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel dslVersion="1.0.0.0" Id="a1d141f4-984a-42a4-85c1-23a3419c637b" namespace="MyConfig.MyHandler" xmlSchemaNamespace="MyConfig.MyHandler" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
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
    <configurationSection name="MyCustomSection" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="myCustomSection">
      <elementProperties>
        <elementProperty name="Element1" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="element1" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/MyCustomElement" />
          </type>
        </elementProperty>
        <elementProperty name="ElementCollection1" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="elementCollection1" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/MyElements" />
          </type>
        </elementProperty>
        <elementProperty name="Element2" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="element2" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/MyCustomElementWithValue" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="MyCustomElement">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="MyElements" xmlItemName="myElement" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/MyElement" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="MyElement">
      <attributeProperties>
        <attributeProperty name="Key" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="key" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="MyCustomElementWithValue">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="AValue" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="aValue" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/a1d141f4-984a-42a4-85c1-23a3419c637b/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>