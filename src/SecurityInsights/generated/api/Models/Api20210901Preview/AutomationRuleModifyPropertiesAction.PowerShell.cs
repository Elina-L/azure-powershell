// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Describes an automation rule action to modify an object's properties</summary>
    [System.ComponentModel.TypeConverter(typeof(AutomationRuleModifyPropertiesActionTypeConverter))]
    public partial class AutomationRuleModifyPropertiesAction
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleModifyPropertiesAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AutomationRuleModifyPropertiesAction(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ActionConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionConfiguration) content.GetValueForProperty("ActionConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleModifyPropertiesActionConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Order"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).Order = (int) content.GetValueForProperty("Order",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).Order, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).ActionType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).ActionType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType.CreateFrom);
            }
            if (content.Contains("ActionConfigurationOwner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationOwner = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo) content.GetValueForProperty("ActionConfigurationOwner",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationOwner, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentOwnerInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ActionConfigurationClassification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassification = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassification?) content.GetValueForProperty("ActionConfigurationClassification",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassification, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassification.CreateFrom);
            }
            if (content.Contains("ActionConfigurationClassificationComment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationComment = (string) content.GetValueForProperty("ActionConfigurationClassificationComment",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationComment, global::System.Convert.ToString);
            }
            if (content.Contains("ActionConfigurationClassificationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationReason = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassificationReason?) content.GetValueForProperty("ActionConfigurationClassificationReason",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationReason, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassificationReason.CreateFrom);
            }
            if (content.Contains("ActionConfigurationLabel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationLabel = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentLabel[]) content.GetValueForProperty("ActionConfigurationLabel",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationLabel, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentLabel>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentLabelTypeConverter.ConvertFrom));
            }
            if (content.Contains("ActionConfigurationSeverity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationSeverity = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentSeverity?) content.GetValueForProperty("ActionConfigurationSeverity",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationSeverity, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentSeverity.CreateFrom);
            }
            if (content.Contains("ActionConfigurationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationStatus = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentStatus?) content.GetValueForProperty("ActionConfigurationStatus",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationStatus, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentStatus.CreateFrom);
            }
            if (content.Contains("OwnerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType?) content.GetValueForProperty("OwnerType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType.CreateFrom);
            }
            if (content.Contains("OwnerEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerEmail = (string) content.GetValueForProperty("OwnerEmail",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerEmail, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerAssignedTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerAssignedTo = (string) content.GetValueForProperty("OwnerAssignedTo",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerAssignedTo, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerObjectId = (string) content.GetValueForProperty("OwnerObjectId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerUserPrincipalName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerUserPrincipalName = (string) content.GetValueForProperty("OwnerUserPrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerUserPrincipalName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleModifyPropertiesAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AutomationRuleModifyPropertiesAction(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ActionConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionConfiguration) content.GetValueForProperty("ActionConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleModifyPropertiesActionConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Order"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).Order = (int) content.GetValueForProperty("Order",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).Order, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).ActionType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleActionInternal)this).ActionType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AutomationRuleActionType.CreateFrom);
            }
            if (content.Contains("ActionConfigurationOwner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationOwner = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentOwnerInfo) content.GetValueForProperty("ActionConfigurationOwner",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationOwner, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentOwnerInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ActionConfigurationClassification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassification = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassification?) content.GetValueForProperty("ActionConfigurationClassification",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassification, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassification.CreateFrom);
            }
            if (content.Contains("ActionConfigurationClassificationComment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationComment = (string) content.GetValueForProperty("ActionConfigurationClassificationComment",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationComment, global::System.Convert.ToString);
            }
            if (content.Contains("ActionConfigurationClassificationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationReason = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassificationReason?) content.GetValueForProperty("ActionConfigurationClassificationReason",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationClassificationReason, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentClassificationReason.CreateFrom);
            }
            if (content.Contains("ActionConfigurationLabel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationLabel = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentLabel[]) content.GetValueForProperty("ActionConfigurationLabel",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationLabel, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentLabel>(__y, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IncidentLabelTypeConverter.ConvertFrom));
            }
            if (content.Contains("ActionConfigurationSeverity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationSeverity = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentSeverity?) content.GetValueForProperty("ActionConfigurationSeverity",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationSeverity, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentSeverity.CreateFrom);
            }
            if (content.Contains("ActionConfigurationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationStatus = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentStatus?) content.GetValueForProperty("ActionConfigurationStatus",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).ActionConfigurationStatus, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.IncidentStatus.CreateFrom);
            }
            if (content.Contains("OwnerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType?) content.GetValueForProperty("OwnerType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OwnerType.CreateFrom);
            }
            if (content.Contains("OwnerEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerEmail = (string) content.GetValueForProperty("OwnerEmail",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerEmail, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerAssignedTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerAssignedTo = (string) content.GetValueForProperty("OwnerAssignedTo",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerAssignedTo, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerObjectId = (string) content.GetValueForProperty("OwnerObjectId",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("OwnerUserPrincipalName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerUserPrincipalName = (string) content.GetValueForProperty("OwnerUserPrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesActionInternal)this).OwnerUserPrincipalName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleModifyPropertiesAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesAction"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesAction DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AutomationRuleModifyPropertiesAction(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AutomationRuleModifyPropertiesAction"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesAction"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesAction DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AutomationRuleModifyPropertiesAction(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AutomationRuleModifyPropertiesAction" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AutomationRuleModifyPropertiesAction" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRuleModifyPropertiesAction FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes an automation rule action to modify an object's properties
    [System.ComponentModel.TypeConverter(typeof(AutomationRuleModifyPropertiesActionTypeConverter))]
    public partial interface IAutomationRuleModifyPropertiesAction

    {

    }
}