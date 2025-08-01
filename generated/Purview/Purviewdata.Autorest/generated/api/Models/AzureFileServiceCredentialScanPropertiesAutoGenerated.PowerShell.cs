// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(AzureFileServiceCredentialScanPropertiesAutoGeneratedTypeConverter))]
    public partial class AzureFileServiceCredentialScanPropertiesAutoGenerated
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureFileServiceCredentialScanPropertiesAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CollectionReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionReferenceName = (string) content.GetValueForProperty("CollectionReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectedViaReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedViaReferenceName = (string) content.GetValueForProperty("ConnectedViaReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedViaReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CollectionLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("CollectionLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CollectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionType = (string) content.GetValueForProperty("CollectionType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionType, global::System.Convert.ToString);
            }
            if (content.Contains("Collection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Collection = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesCollection) content.GetValueForProperty("Collection",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Collection, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ScanPropertiesCollectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConnectedVia"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedVia = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesConnectedVia) content.GetValueForProperty("ConnectedVia",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedVia, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ScanPropertiesConnectedViaTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScanRulesetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetName = (string) content.GetValueForProperty("ScanRulesetName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetName, global::System.Convert.ToString);
            }
            if (content.Contains("ScanRulesetType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetType = (string) content.GetValueForProperty("ScanRulesetType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetType, global::System.Convert.ToString);
            }
            if (content.Contains("Worker"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Worker = (int?) content.GetValueForProperty("Worker",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Worker, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CredentialReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialReferenceName = (string) content.GetValueForProperty("CredentialReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialType = (string) content.GetValueForProperty("CredentialType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialType, global::System.Convert.ToString);
            }
            if (content.Contains("Credential"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).Credential = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesCredential) content.GetValueForProperty("Credential",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).Credential, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceCredentialScanPropertiesCredentialTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShareName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).ShareName = (string) content.GetValueForProperty("ShareName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).ShareName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureFileServiceCredentialScanPropertiesAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CollectionReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionReferenceName = (string) content.GetValueForProperty("CollectionReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectedViaReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedViaReferenceName = (string) content.GetValueForProperty("ConnectedViaReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedViaReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CollectionLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("CollectionLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CollectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionType = (string) content.GetValueForProperty("CollectionType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CollectionType, global::System.Convert.ToString);
            }
            if (content.Contains("Collection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Collection = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesCollection) content.GetValueForProperty("Collection",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Collection, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ScanPropertiesCollectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConnectedVia"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedVia = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesConnectedVia) content.GetValueForProperty("ConnectedVia",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ConnectedVia, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ScanPropertiesConnectedViaTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScanRulesetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetName = (string) content.GetValueForProperty("ScanRulesetName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetName, global::System.Convert.ToString);
            }
            if (content.Contains("ScanRulesetType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetType = (string) content.GetValueForProperty("ScanRulesetType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).ScanRulesetType, global::System.Convert.ToString);
            }
            if (content.Contains("Worker"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Worker = (int?) content.GetValueForProperty("Worker",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).Worker, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CredentialReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialReferenceName = (string) content.GetValueForProperty("CredentialReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialType = (string) content.GetValueForProperty("CredentialType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).CredentialType, global::System.Convert.ToString);
            }
            if (content.Contains("Credential"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).Credential = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesCredential) content.GetValueForProperty("Credential",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).Credential, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceCredentialScanPropertiesCredentialTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShareName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).ShareName = (string) content.GetValueForProperty("ShareName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesInternal)this).ShareName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureFileServiceCredentialScanPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureFileServiceCredentialScanPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureFileServiceCredentialScanPropertiesAutoGenerated" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureFileServiceCredentialScanPropertiesAutoGenerated" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureFileServiceCredentialScanPropertiesAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    [System.ComponentModel.TypeConverter(typeof(AzureFileServiceCredentialScanPropertiesAutoGeneratedTypeConverter))]
    public partial interface IAzureFileServiceCredentialScanPropertiesAutoGenerated

    {

    }
}