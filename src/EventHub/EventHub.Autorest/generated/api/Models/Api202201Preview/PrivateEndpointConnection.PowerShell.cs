// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.PowerShell;

    /// <summary>Properties of the PrivateEndpointConnection.</summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointConnectionTypeConverter))]
    public partial class PrivateEndpointConnection
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnection"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateEndpointConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnection"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnection DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateEndpointConnection(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateEndpointConnection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PrivateEndpointConnection" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnection FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateEndpointConnection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointConnectionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpoint) content.GetValueForProperty("PrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpoint, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrivateLinkServiceConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IConnectionState) content.GetValueForProperty("PrivateLinkServiceConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ConnectionStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState.CreateFrom);
            }
            if (content.Contains("PrivateEndpointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpointId = (string) content.GetValueForProperty("PrivateEndpointId",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpointId, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.PrivateLinkConnectionStatus?) content.GetValueForProperty("ConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ConnectionState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.PrivateLinkConnectionStatus.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateEndpointConnection(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointConnectionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpoint) content.GetValueForProperty("PrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpoint, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.PrivateEndpointTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrivateLinkServiceConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IConnectionState) content.GetValueForProperty("PrivateLinkServiceConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ConnectionStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState.CreateFrom);
            }
            if (content.Contains("PrivateEndpointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpointId = (string) content.GetValueForProperty("PrivateEndpointId",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).PrivateEndpointId, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.PrivateLinkConnectionStatus?) content.GetValueForProperty("ConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).ConnectionState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.PrivateLinkConnectionStatus.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IPrivateEndpointConnectionInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the PrivateEndpointConnection.
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointConnectionTypeConverter))]
    public partial interface IPrivateEndpointConnection

    {

    }
}