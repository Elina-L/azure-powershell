// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.PowerShell;

    /// <summary>Description of topic resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(SbTopicTypeConverter))]
    public partial class SbTopic
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SbTopic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SbTopic(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SbTopic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SbTopic(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SbTopic" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SbTopic" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SbTopic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SbTopic(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SbTopicPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CountDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetail = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IMessageCountDetails) content.GetValueForProperty("CountDetail",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetail, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.MessageCountDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SizeInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SizeInByte = (long?) content.GetValueForProperty("SizeInByte",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SizeInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).UpdatedAt = (global::System.DateTime?) content.GetValueForProperty("UpdatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).UpdatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AccessedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AccessedAt = (global::System.DateTime?) content.GetValueForProperty("AccessedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AccessedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SubscriptionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SubscriptionCount = (int?) content.GetValueForProperty("SubscriptionCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SubscriptionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultMessageTimeToLive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DefaultMessageTimeToLive = (global::System.TimeSpan?) content.GetValueForProperty("DefaultMessageTimeToLive",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DefaultMessageTimeToLive, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("MaxSizeInMegabytes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxSizeInMegabytes = (int?) content.GetValueForProperty("MaxSizeInMegabytes",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxSizeInMegabytes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaxMessageSizeInKilobytes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxMessageSizeInKilobytes = (long?) content.GetValueForProperty("MaxMessageSizeInKilobytes",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxMessageSizeInKilobytes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RequiresDuplicateDetection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).RequiresDuplicateDetection = (bool?) content.GetValueForProperty("RequiresDuplicateDetection",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).RequiresDuplicateDetection, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DuplicateDetectionHistoryTimeWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DuplicateDetectionHistoryTimeWindow = (global::System.TimeSpan?) content.GetValueForProperty("DuplicateDetectionHistoryTimeWindow",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DuplicateDetectionHistoryTimeWindow, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("EnableBatchedOperations"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableBatchedOperations = (bool?) content.GetValueForProperty("EnableBatchedOperations",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableBatchedOperations, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("SupportOrdering"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SupportOrdering = (bool?) content.GetValueForProperty("SupportOrdering",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SupportOrdering, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoDeleteOnIdle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AutoDeleteOnIdle = (global::System.TimeSpan?) content.GetValueForProperty("AutoDeleteOnIdle",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AutoDeleteOnIdle, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("EnablePartitioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnablePartitioning = (bool?) content.GetValueForProperty("EnablePartitioning",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnablePartitioning, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableExpress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableExpress = (bool?) content.GetValueForProperty("EnableExpress",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableExpress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CountDetailActiveMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailActiveMessageCount = (long?) content.GetValueForProperty("CountDetailActiveMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailActiveMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailDeadLetterMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailDeadLetterMessageCount = (long?) content.GetValueForProperty("CountDetailDeadLetterMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailDeadLetterMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailScheduledMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailScheduledMessageCount = (long?) content.GetValueForProperty("CountDetailScheduledMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailScheduledMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailTransferMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferMessageCount = (long?) content.GetValueForProperty("CountDetailTransferMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailTransferDeadLetterMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferDeadLetterMessageCount = (long?) content.GetValueForProperty("CountDetailTransferDeadLetterMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferDeadLetterMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SbTopic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SbTopic(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SbTopicPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CountDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetail = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IMessageCountDetails) content.GetValueForProperty("CountDetail",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetail, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.MessageCountDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SizeInByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SizeInByte = (long?) content.GetValueForProperty("SizeInByte",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SizeInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).UpdatedAt = (global::System.DateTime?) content.GetValueForProperty("UpdatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).UpdatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AccessedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AccessedAt = (global::System.DateTime?) content.GetValueForProperty("AccessedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AccessedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SubscriptionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SubscriptionCount = (int?) content.GetValueForProperty("SubscriptionCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SubscriptionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultMessageTimeToLive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DefaultMessageTimeToLive = (global::System.TimeSpan?) content.GetValueForProperty("DefaultMessageTimeToLive",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DefaultMessageTimeToLive, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("MaxSizeInMegabytes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxSizeInMegabytes = (int?) content.GetValueForProperty("MaxSizeInMegabytes",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxSizeInMegabytes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaxMessageSizeInKilobytes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxMessageSizeInKilobytes = (long?) content.GetValueForProperty("MaxMessageSizeInKilobytes",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).MaxMessageSizeInKilobytes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RequiresDuplicateDetection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).RequiresDuplicateDetection = (bool?) content.GetValueForProperty("RequiresDuplicateDetection",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).RequiresDuplicateDetection, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DuplicateDetectionHistoryTimeWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DuplicateDetectionHistoryTimeWindow = (global::System.TimeSpan?) content.GetValueForProperty("DuplicateDetectionHistoryTimeWindow",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).DuplicateDetectionHistoryTimeWindow, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("EnableBatchedOperations"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableBatchedOperations = (bool?) content.GetValueForProperty("EnableBatchedOperations",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableBatchedOperations, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("SupportOrdering"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SupportOrdering = (bool?) content.GetValueForProperty("SupportOrdering",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SupportOrdering, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoDeleteOnIdle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AutoDeleteOnIdle = (global::System.TimeSpan?) content.GetValueForProperty("AutoDeleteOnIdle",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).AutoDeleteOnIdle, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("EnablePartitioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnablePartitioning = (bool?) content.GetValueForProperty("EnablePartitioning",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnablePartitioning, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableExpress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableExpress = (bool?) content.GetValueForProperty("EnableExpress",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).EnableExpress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CountDetailActiveMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailActiveMessageCount = (long?) content.GetValueForProperty("CountDetailActiveMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailActiveMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailDeadLetterMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailDeadLetterMessageCount = (long?) content.GetValueForProperty("CountDetailDeadLetterMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailDeadLetterMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailScheduledMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailScheduledMessageCount = (long?) content.GetValueForProperty("CountDetailScheduledMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailScheduledMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailTransferMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferMessageCount = (long?) content.GetValueForProperty("CountDetailTransferMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CountDetailTransferDeadLetterMessageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferDeadLetterMessageCount = (long?) content.GetValueForProperty("CountDetailTransferDeadLetterMessageCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopicInternal)this).CountDetailTransferDeadLetterMessageCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Description of topic resource.
    [System.ComponentModel.TypeConverter(typeof(SbTopicTypeConverter))]
    public partial interface ISbTopic

    {

    }
}