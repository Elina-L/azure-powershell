// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.PowerShell;

    /// <summary>Properties related to EventGrid.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventGridTypeConverter))]
    public partial class EventGrid
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.EventGrid"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGrid" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGrid DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventGrid(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.EventGrid"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGrid" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGrid DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventGrid(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.EventGrid"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventGrid(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TopicEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).TopicEndpoint = (string) content.GetValueForProperty("TopicEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).TopicEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("AccessKey1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey1 = (string) content.GetValueForProperty("AccessKey1",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey1, global::System.Convert.ToString);
            }
            if (content.Contains("AccessKey2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey2 = (string) content.GetValueForProperty("AccessKey2",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey2, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).EndpointType = (string) content.GetValueForProperty("EndpointType",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).EndpointType, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).AuthenticationType = (string) content.GetValueForProperty("AuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).AuthenticationType, global::System.Convert.ToString);
            }
            if (content.Contains("DeadLetterSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterSecret = (string) content.GetValueForProperty("DeadLetterSecret",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterSecret, global::System.Convert.ToString);
            }
            if (content.Contains("DeadLetterUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterUri = (string) content.GetValueForProperty("DeadLetterUri",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterUri, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.EventGrid"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventGrid(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TopicEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).TopicEndpoint = (string) content.GetValueForProperty("TopicEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).TopicEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("AccessKey1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey1 = (string) content.GetValueForProperty("AccessKey1",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey1, global::System.Convert.ToString);
            }
            if (content.Contains("AccessKey2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey2 = (string) content.GetValueForProperty("AccessKey2",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGridInternal)this).AccessKey2, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).EndpointType = (string) content.GetValueForProperty("EndpointType",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).EndpointType, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).AuthenticationType = (string) content.GetValueForProperty("AuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).AuthenticationType, global::System.Convert.ToString);
            }
            if (content.Contains("DeadLetterSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterSecret = (string) content.GetValueForProperty("DeadLetterSecret",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterSecret, global::System.Convert.ToString);
            }
            if (content.Contains("DeadLetterUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterUri = (string) content.GetValueForProperty("DeadLetterUri",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourcePropertiesInternal)this).DeadLetterUri, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventGrid" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventGrid" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IEventGrid FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Properties related to EventGrid.
    [System.ComponentModel.TypeConverter(typeof(EventGridTypeConverter))]
    public partial interface IEventGrid

    {

    }
}