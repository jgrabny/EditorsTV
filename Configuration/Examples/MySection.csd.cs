//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3625
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyConfig.MyHandler
{
    
    
    /// <summary>
    /// The MyCustomSection Configuration Section.
    /// </summary>
    public partial class MyCustomSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the MyCustomSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string MyCustomSectionSectionName = "myCustomSection";
        
        /// <summary>
        /// Gets the MyCustomSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public static global::MyConfig.MyHandler.MyCustomSection Instance
        {
            get
            {
                return ((global::MyConfig.MyHandler.MyCustomSection)(global::System.Configuration.ConfigurationManager.GetSection(global::MyConfig.MyHandler.MyCustomSection.MyCustomSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::MyConfig.MyHandler.MyCustomSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Element1 Property
        /// <summary>
        /// The XML name of the <see cref="Element1"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string Element1PropertyName = "element1";
        
        /// <summary>
        /// Gets or sets the Element1.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Element1.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomSection.Element1PropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::MyConfig.MyHandler.MyCustomElement Element1
        {
            get
            {
                return ((global::MyConfig.MyHandler.MyCustomElement)(base[global::MyConfig.MyHandler.MyCustomSection.Element1PropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyCustomSection.Element1PropertyName] = value;
            }
        }
        #endregion
        
        #region ElementCollection1 Property
        /// <summary>
        /// The XML name of the <see cref="ElementCollection1"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string ElementCollection1PropertyName = "elementCollection1";
        
        /// <summary>
        /// Gets or sets the ElementCollection1.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The ElementCollection1.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomSection.ElementCollection1PropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::MyConfig.MyHandler.MyElements ElementCollection1
        {
            get
            {
                return ((global::MyConfig.MyHandler.MyElements)(base[global::MyConfig.MyHandler.MyCustomSection.ElementCollection1PropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyCustomSection.ElementCollection1PropertyName] = value;
            }
        }
        #endregion
        
        #region Element2 Property
        /// <summary>
        /// The XML name of the <see cref="Element2"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string Element2PropertyName = "element2";
        
        /// <summary>
        /// Gets or sets the Element2.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Element2.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomSection.Element2PropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::MyConfig.MyHandler.MyCustomElementWithValue Element2
        {
            get
            {
                return ((global::MyConfig.MyHandler.MyCustomElementWithValue)(base[global::MyConfig.MyHandler.MyCustomSection.Element2PropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyCustomSection.Element2PropertyName] = value;
            }
        }
        #endregion
    }
}
namespace MyConfig.MyHandler
{
    
    
    /// <summary>
    /// The MyCustomElement Configuration Element.
    /// </summary>
    public partial class MyCustomElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomElement.NamePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Name
        {
            get
            {
                return ((string)(base[global::MyConfig.MyHandler.MyCustomElement.NamePropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyCustomElement.NamePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace MyConfig.MyHandler
{
    
    
    /// <summary>
    /// A collection of MyElement instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::MyConfig.MyHandler.MyElement), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::MyConfig.MyHandler.MyElements.MyElementPropertyName)]
    public partial class MyElements : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::MyConfig.MyHandler.MyElement"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string MyElementPropertyName = "myElement";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        protected override string ElementName
        {
            get
            {
                return global::MyConfig.MyHandler.MyElements.MyElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::MyConfig.MyHandler.MyElements.MyElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::MyConfig.MyHandler.MyElement)(element)).Key;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::MyConfig.MyHandler.MyElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::MyConfig.MyHandler.MyElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::MyConfig.MyHandler.MyElement();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::MyConfig.MyHandler.MyElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::MyConfig.MyHandler.MyElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public global::MyConfig.MyHandler.MyElement this[int index]
        {
            get
            {
                return ((global::MyConfig.MyHandler.MyElement)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::MyConfig.MyHandler.MyElement"/> with the specified key.
        /// </summary>
        /// <param name="key">The key of the <see cref="global::MyConfig.MyHandler.MyElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public global::MyConfig.MyHandler.MyElement this[object key]
        {
            get
            {
                return ((global::MyConfig.MyHandler.MyElement)(base.BaseGet(key)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::MyConfig.MyHandler.MyElement"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="myElement">The <see cref="global::MyConfig.MyHandler.MyElement"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public void Add(global::MyConfig.MyHandler.MyElement myElement)
        {
            base.BaseAdd(myElement);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::MyConfig.MyHandler.MyElement"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="myElement">The <see cref="global::MyConfig.MyHandler.MyElement"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public void Remove(global::MyConfig.MyHandler.MyElement myElement)
        {
            base.BaseRemove(this.GetElementKey(myElement));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::MyConfig.MyHandler.MyElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::MyConfig.MyHandler.MyElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public global::MyConfig.MyHandler.MyElement GetItemAt(int index)
        {
            return ((global::MyConfig.MyHandler.MyElement)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::MyConfig.MyHandler.MyElement"/> with the specified key.
        /// </summary>
        /// <param name="key">The key of the <see cref="global::MyConfig.MyHandler.MyElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public global::MyConfig.MyHandler.MyElement GetItemByKey(string key)
        {
            return ((global::MyConfig.MyHandler.MyElement)(base.BaseGet(((object)(key)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace MyConfig.MyHandler
{
    
    
    /// <summary>
    /// The MyElement Configuration Element.
    /// </summary>
    public partial class MyElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Key Property
        /// <summary>
        /// The XML name of the <see cref="Key"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string KeyPropertyName = "key";
        
        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Key.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyElement.KeyPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public string Key
        {
            get
            {
                return ((string)(base[global::MyConfig.MyHandler.MyElement.KeyPropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyElement.KeyPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace MyConfig.MyHandler
{
    
    
    /// <summary>
    /// The MyCustomElementWithValue Configuration Element.
    /// </summary>
    public partial class MyCustomElementWithValue : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomElementWithValue.NamePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Name
        {
            get
            {
                return ((string)(base[global::MyConfig.MyHandler.MyCustomElementWithValue.NamePropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyCustomElementWithValue.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region AValue Property
        /// <summary>
        /// The XML name of the <see cref="AValue"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        internal const string AValuePropertyName = "aValue";
        
        /// <summary>
        /// Gets or sets the AValue.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "1.6.3.0")]
        [global::System.ComponentModel.DescriptionAttribute("The AValue.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::MyConfig.MyHandler.MyCustomElementWithValue.AValuePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string AValue
        {
            get
            {
                return ((string)(base[global::MyConfig.MyHandler.MyCustomElementWithValue.AValuePropertyName]));
            }
            set
            {
                base[global::MyConfig.MyHandler.MyCustomElementWithValue.AValuePropertyName] = value;
            }
        }
        #endregion
    }
}
