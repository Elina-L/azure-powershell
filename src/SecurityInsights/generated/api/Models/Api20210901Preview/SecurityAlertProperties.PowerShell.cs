// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>SecurityAlert entity property bag.</summary>
    [System.ComponentModel.TypeConverter(typeof(SecurityAlertPropertiesTypeConverter))]
    public partial class SecurityAlertProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SecurityAlertProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecurityAlertProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SecurityAlertProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecurityAlertProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecurityAlertProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecurityAlertProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SecurityAlertProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecurityAlertProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AlertDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertDisplayName = (string) content.GetValueForProperty("AlertDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("AlertType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertType = (string) content.GetValueForProperty("AlertType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertType, global::System.Convert.ToString);
            }
            if (content.Contains("CompromisedEntity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).CompromisedEntity = (string) content.GetValueForProperty("CompromisedEntity",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).CompromisedEntity, global::System.Convert.ToString);
            }
            if (content.Contains("ConfidenceLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceLevel = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceLevel?) content.GetValueForProperty("ConfidenceLevel",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceLevel, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceLevel.CreateFrom);
            }
            if (content.Contains("ConfidenceReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceReason = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesConfidenceReasonsItem[]) content.GetValueForProperty("ConfidenceReason",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceReason, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesConfidenceReasonsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SecurityAlertPropertiesConfidenceReasonsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("ConfidenceScore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScore = (double?) content.GetValueForProperty("ConfidenceScore",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScore, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ConfidenceScoreStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScoreStatus = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceScoreStatus?) content.GetValueForProperty("ConfidenceScoreStatus",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScoreStatus, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceScoreStatus.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).EndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("EndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).EndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Intent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Intent = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.KillChainIntent?) content.GetValueForProperty("Intent",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Intent, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.KillChainIntent.CreateFrom);
            }
            if (content.Contains("ProviderAlertId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProviderAlertId = (string) content.GetValueForProperty("ProviderAlertId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProviderAlertId, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessingEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProcessingEndTime = (global::System.DateTime?) content.GetValueForProperty("ProcessingEndTime",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProcessingEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProductComponentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductComponentName = (string) content.GetValueForProperty("ProductComponentName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductComponentName, global::System.Convert.ToString);
            }
            if (content.Contains("ProductName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductName = (string) content.GetValueForProperty("ProductName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductName, global::System.Convert.ToString);
            }
            if (content.Contains("ProductVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductVersion = (string) content.GetValueForProperty("ProductVersion",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductVersion, global::System.Convert.ToString);
            }
            if (content.Contains("RemediationStep"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).RemediationStep = (string[]) content.GetValueForProperty("RemediationStep",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).RemediationStep, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Severity = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity?) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Severity, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity.CreateFrom);
            }
            if (content.Contains("StartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).StartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("StartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).StartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertStatus.CreateFrom);
            }
            if (content.Contains("SystemAlertId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).SystemAlertId = (string) content.GetValueForProperty("SystemAlertId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).SystemAlertId, global::System.Convert.ToString);
            }
            if (content.Contains("Tactic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Tactic = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[]) content.GetValueForProperty("Tactic",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Tactic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic.CreateFrom));
            }
            if (content.Contains("TimeGenerated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).TimeGenerated = (global::System.DateTime?) content.GetValueForProperty("TimeGenerated",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).TimeGenerated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("VendorName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).VendorName = (string) content.GetValueForProperty("VendorName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).VendorName, global::System.Convert.ToString);
            }
            if (content.Contains("AlertLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertLink = (string) content.GetValueForProperty("AlertLink",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertLink, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ResourceIdentifier = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny[]) content.GetValueForProperty("ResourceIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ResourceIdentifier, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).AdditionalData = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData) content.GetValueForProperty("AdditionalData",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).AdditionalData, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityCommonPropertiesAdditionalDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SecurityAlertProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecurityAlertProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AlertDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertDisplayName = (string) content.GetValueForProperty("AlertDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("AlertType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertType = (string) content.GetValueForProperty("AlertType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertType, global::System.Convert.ToString);
            }
            if (content.Contains("CompromisedEntity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).CompromisedEntity = (string) content.GetValueForProperty("CompromisedEntity",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).CompromisedEntity, global::System.Convert.ToString);
            }
            if (content.Contains("ConfidenceLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceLevel = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceLevel?) content.GetValueForProperty("ConfidenceLevel",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceLevel, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceLevel.CreateFrom);
            }
            if (content.Contains("ConfidenceReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceReason = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesConfidenceReasonsItem[]) content.GetValueForProperty("ConfidenceReason",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceReason, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesConfidenceReasonsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SecurityAlertPropertiesConfidenceReasonsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("ConfidenceScore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScore = (double?) content.GetValueForProperty("ConfidenceScore",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScore, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ConfidenceScoreStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScoreStatus = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceScoreStatus?) content.GetValueForProperty("ConfidenceScoreStatus",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ConfidenceScoreStatus, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConfidenceScoreStatus.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).EndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("EndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).EndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Intent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Intent = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.KillChainIntent?) content.GetValueForProperty("Intent",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Intent, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.KillChainIntent.CreateFrom);
            }
            if (content.Contains("ProviderAlertId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProviderAlertId = (string) content.GetValueForProperty("ProviderAlertId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProviderAlertId, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessingEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProcessingEndTime = (global::System.DateTime?) content.GetValueForProperty("ProcessingEndTime",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProcessingEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProductComponentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductComponentName = (string) content.GetValueForProperty("ProductComponentName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductComponentName, global::System.Convert.ToString);
            }
            if (content.Contains("ProductName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductName = (string) content.GetValueForProperty("ProductName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductName, global::System.Convert.ToString);
            }
            if (content.Contains("ProductVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductVersion = (string) content.GetValueForProperty("ProductVersion",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ProductVersion, global::System.Convert.ToString);
            }
            if (content.Contains("RemediationStep"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).RemediationStep = (string[]) content.GetValueForProperty("RemediationStep",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).RemediationStep, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Severity = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity?) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Severity, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity.CreateFrom);
            }
            if (content.Contains("StartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).StartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("StartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).StartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertStatus.CreateFrom);
            }
            if (content.Contains("SystemAlertId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).SystemAlertId = (string) content.GetValueForProperty("SystemAlertId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).SystemAlertId, global::System.Convert.ToString);
            }
            if (content.Contains("Tactic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Tactic = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic[]) content.GetValueForProperty("Tactic",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).Tactic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AttackTactic.CreateFrom));
            }
            if (content.Contains("TimeGenerated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).TimeGenerated = (global::System.DateTime?) content.GetValueForProperty("TimeGenerated",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).TimeGenerated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("VendorName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).VendorName = (string) content.GetValueForProperty("VendorName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).VendorName, global::System.Convert.ToString);
            }
            if (content.Contains("AlertLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertLink = (string) content.GetValueForProperty("AlertLink",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).AlertLink, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ResourceIdentifier = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny[]) content.GetValueForProperty("ResourceIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ISecurityAlertPropertiesInternal)this).ResourceIdentifier, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.AnyTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).AdditionalData = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData) content.GetValueForProperty("AdditionalData",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).AdditionalData, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityCommonPropertiesAdditionalDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SecurityAlert entity property bag.
    [System.ComponentModel.TypeConverter(typeof(SecurityAlertPropertiesTypeConverter))]
    public partial interface ISecurityAlertProperties

    {

    }
}