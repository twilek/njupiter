﻿using System;
using System.Xml;

namespace nJupiter.Configuration {
	/// <summary>
	/// Represents a configuration Xml with shorcuts to access sections, elements and attributes
	/// </summary>
	public interface IConfig {

		/// <summary>
		/// Gets the unique key for this configuration object. This is in most cases equal to the assembly name which the configuration object belongs to.
		/// </summary>
		/// <value>The config key.</value>
		string ConfigKey { get; }

		/// <summary>
		/// Gets the Xml Element associated with the configuration object.
		/// </summary>
		/// <value>The config XML.</value>
		XmlElement ConfigXml { get; }

		IConfigSource ConfigSource { get; }

		/// <summary>
		/// Occurs when the configuration object is disposed. This happens when it is droped from the cache.
		/// </summary>
		event EventHandler Disposed;
		void Dispose();

		/// <summary>
		/// Gets the value attribute for the element given in the key parameter. If no value attribute exists on the element the content of the element is returned.
		/// </summary>
		/// <param name="key">The name of the element. The parameter can contain XPath syntax.</param>
		/// <returns>The string value for the key.</returns>
		string GetValue(string key);
		T GetValue<T>(string key);

		/// <summary>
		/// Gets the value attribute for the element given in the key parameter. If no value attribute exists on the element the content of the element is returned.
		/// </summary>
		/// <param name="section">The path to the element. The parameter can contain XPath syntax.</param>
		/// <param name="key">The name of the element. The parameter can contain XPath syntax.</param>
		/// <returns>The string value for the key.</returns>
		string GetValue(string section, string key);
		T GetValue<T>(string section, string key);

		/// <summary>
		/// Gets a given attribute for the element given in the key parameter as a string.
		/// </summary>
		/// <param name="key">The name of the element. The parameter can contain XPath syntax.</param>
		/// <param name="attribute">The name of the attribute. The parameter can contain XPath syntax.</param>
		/// <returns>The string value of the attribute.</returns>
		string GetAttribute(string key, string attribute);
		T GetAttribute<T>(string key, string attribute);

		/// <summary>
		/// Gets a given attribute for the element given in the key parameter as a string.
		/// </summary>
		/// <param name="section">The path to the element. The parameter can contain XPath syntax.</param>
		/// <param name="key">The name of the element. The parameter can contain XPath syntax.</param>
		/// <param name="attribute">The name of the attribute. The parameter can contain XPath syntax.</param>
		/// <returns>The string value of the attribute.</returns>
		string GetAttribute(string section, string key, string attribute);
		T GetAttribute<T>(string section, string key, string attribute);
		
		/// <summary>
		/// Gets the <see cref="XmlNode"/> for the given key.
		/// </summary>
		/// <param name="key">The element name. The parameter can contain XPath syntax.</param>
		/// <returns>An <see cref="XmlNode"/> for the given key.</returns>
		XmlNode GetKey(string key);

		/// <summary>
		/// Gets the <see cref="XmlNode"/> for the given key.
		/// </summary>
		/// <param name="section">The path to the element. The parameter can contain XPath syntax.</param>
		/// <param name="key">The element name. The parameter can contain XPath syntax.</param>
		/// <returns>An <see cref="XmlNode"/> for the given key.</returns>
		XmlNode GetKey(string section, string key);

		/// <summary>
		/// Gets an array of value attribues from elements with the same name. If no value attribute exists on the element the content of the element is returned.
		/// </summary>
		/// <param name="section">The path to the elements. The parameter can contain XPath syntax.</param>
		/// <param name="key">The name of the elements. The parameter can contain XPath syntax.</param>
		/// <returns>A string array.</returns>
		string[] GetValueArray(string section, string key);
		T[] GetValueArray<T>(string section, string key);

		/// <summary>
		/// Gets an array of attribues from elements with the same name.
		/// </summary>
		/// <param name="section">The path to the elements. The parameter can contain XPath syntax.</param>
		/// <param name="key">The name of the elements. The parameter can contain XPath syntax.</param>
		/// <param name="attribute">The name of the attributes. The parameter can contain XPath syntax.</param>
		/// <returns>A string array.</returns>
		string[] GetAttributeArray(string section, string key, string attribute);
		T[] GetAttributeArray<T>(string section, string key, string attribute);

		/// <summary>
		/// Gets a new config object based on a subelement to the current config Xml.
		/// </summary>
		/// <param name="section">The XPath to the section.</param>
		/// <returns>A <see cref="Config"/> object.</returns>
		IConfig GetConfigSection(string section);

		/// <summary>
		/// Determines whether the current configuration contains a specified key.
		/// </summary>
		/// <param name="section">The path to the element. The parameter can contain XPath syntax.</param>
		/// <param name="key">The element name. The parameter can contain XPath syntax.</param>
		/// <returns>
		/// 	<c>true</c> if the current configuration contains the specified key; otherwise, <c>false</c>.
		/// </returns>
		bool ContainsKey(string section, string key);

		/// <summary>
		/// Determines whether the current configuration contains a specified key.
		/// </summary>
		/// <param name="key">The element name. The parameter can contain XPath syntax.</param>
		/// <returns>
		/// 	<c>true</c> if the current configuration contains the specified key; otherwise, <c>false</c>.
		/// </returns>
		bool ContainsKey(string key);

		/// <summary>
		/// Determines whether the current configuration contains a specified attribute.
		/// </summary>
		/// <param name="section">The path to the element. The parameter can contain XPath syntax.</param>
		/// <param name="key">The element name. The parameter can contain XPath syntax.</param>
		/// <param name="attribute">The attribute name. The parameter can contain XPath syntax.</param>
		/// <returns>
		/// 	<c>true</c> if the current configuration contains the specified attribute; otherwise, <c>false</c>.
		/// </returns>
		bool ContainsAttribute(string section, string key, string attribute);

		/// <summary>
		/// Determines whether the current configuration contains a specified attribute.
		/// </summary>
		/// <param name="key">The element name. The parameter can contain XPath syntax.</param>
		/// <param name="attribute">The attribute name. The parameter can contain XPath syntax.</param>
		/// <returns>
		/// 	<c>true</c> if the current configuration contains the specified attribute; otherwise, <c>false</c>.
		/// </returns>
		bool ContainsAttribute(string key, string attribute);

		/// <summary>
		/// Returns the configuration section handler by using the specified section and location paths.
		/// </summary>
		/// <param name="section">The path of the section to be returned.</param>
		/// <param name="configurationSectionHandlerType">The type of the <see cref="System.Configuration.IConfigurationSectionHandler" />.</param>
		/// <returns>The ConfigurationSection object.</returns>
		object GetConfigurationSectionHandler(string section, Type configurationSectionHandlerType);
	}
}