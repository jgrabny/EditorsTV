The Example.App.config file shows how to set up an App.config file which is 
used by the ConfigurationService.

Various sections and comments from this file should be copied/extended in your
application so that the end user knows how to override the settings in their
<AppName>Settings.xml file.

MySection.csd is an example ConfigurationSectionDiagram created using 
Configuration Section Designer v1.6.3 available from CodePlex. It produces an
xsd for the custom section in the Example.App.config allowing use of 
intellisense and a C# class that inherits from 
System.Configuration.ConfigurationSection which allows the section to be parsed.
