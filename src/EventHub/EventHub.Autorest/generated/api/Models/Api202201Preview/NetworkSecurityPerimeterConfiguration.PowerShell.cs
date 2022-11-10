// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.PowerShell;

    /// <summary>Network Security Perimeter related configurations of a given namespace</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkSecurityPerimeterConfigurationTypeConverter))]
    public partial class NetworkSecurityPerimeterConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NetworkSecurityPerimeterConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NetworkSecurityPerimeterConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NetworkSecurityPerimeterConfiguration" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="NetworkSecurityPerimeterConfiguration" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NetworkSecurityPerimeterConfiguration(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkSecurityPerimeter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeter = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeter) content.GetValueForProperty("NetworkSecurityPerimeter",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeter, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceAssociation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociation = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociation) content.GetValueForProperty("ResourceAssociation",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociation, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfigurationPropertiesResourceAssociationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Profile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Profile = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationPropertiesProfile) content.GetValueForProperty("Profile",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Profile, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfigurationPropertiesProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NetworkSecurityPerimeterConfigurationProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NetworkSecurityPerimeterConfigurationProvisioningState.CreateFrom);
            }
            if (content.Contains("ProvisioningIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningIssue = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IProvisioningIssue[]) content.GetValueForProperty("ProvisioningIssue",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IProvisioningIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ProvisioningIssueTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityPerimeterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterId = (string) content.GetValueForProperty("NetworkSecurityPerimeterId",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterId, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkSecurityPerimeterLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterLocation = (string) content.GetValueForProperty("NetworkSecurityPerimeterLocation",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceAssociationAccessMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationAccessMode = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ResourceAssociationAccessMode?) content.GetValueForProperty("ResourceAssociationAccessMode",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationAccessMode, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ResourceAssociationAccessMode.CreateFrom);
            }
            if (content.Contains("NetworkSecurityPerimeterGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterGuid = (string) content.GetValueForProperty("NetworkSecurityPerimeterGuid",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceAssociationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationName = (string) content.GetValueForProperty("ResourceAssociationName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationName, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileAccessRulesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRulesVersion = (string) content.GetValueForProperty("ProfileAccessRulesVersion",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRulesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileAccessRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRule = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INspAccessRule[]) content.GetValueForProperty("ProfileAccessRule",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INspAccessRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NspAccessRuleTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NetworkSecurityPerimeterConfiguration(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkSecurityPerimeter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeter = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeter) content.GetValueForProperty("NetworkSecurityPerimeter",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeter, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceAssociation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociation = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociation) content.GetValueForProperty("ResourceAssociation",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociation, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfigurationPropertiesResourceAssociationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Profile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Profile = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationPropertiesProfile) content.GetValueForProperty("Profile",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).Profile, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NetworkSecurityPerimeterConfigurationPropertiesProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NetworkSecurityPerimeterConfigurationProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.NetworkSecurityPerimeterConfigurationProvisioningState.CreateFrom);
            }
            if (content.Contains("ProvisioningIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningIssue = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IProvisioningIssue[]) content.GetValueForProperty("ProvisioningIssue",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProvisioningIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IProvisioningIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ProvisioningIssueTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityPerimeterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterId = (string) content.GetValueForProperty("NetworkSecurityPerimeterId",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterId, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkSecurityPerimeterLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterLocation = (string) content.GetValueForProperty("NetworkSecurityPerimeterLocation",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceAssociationAccessMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationAccessMode = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ResourceAssociationAccessMode?) content.GetValueForProperty("ResourceAssociationAccessMode",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationAccessMode, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ResourceAssociationAccessMode.CreateFrom);
            }
            if (content.Contains("NetworkSecurityPerimeterGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterGuid = (string) content.GetValueForProperty("NetworkSecurityPerimeterGuid",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).NetworkSecurityPerimeterGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceAssociationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationName = (string) content.GetValueForProperty("ResourceAssociationName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ResourceAssociationName, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileAccessRulesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRulesVersion = (string) content.GetValueForProperty("ProfileAccessRulesVersion",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRulesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ProfileAccessRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRule = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INspAccessRule[]) content.GetValueForProperty("ProfileAccessRule",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INetworkSecurityPerimeterConfigurationInternal)this).ProfileAccessRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.INspAccessRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.NspAccessRuleTypeConverter.ConvertFrom));
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
    /// Network Security Perimeter related configurations of a given namespace
    [System.ComponentModel.TypeConverter(typeof(NetworkSecurityPerimeterConfigurationTypeConverter))]
    public partial interface INetworkSecurityPerimeterConfiguration

    {

    }
}