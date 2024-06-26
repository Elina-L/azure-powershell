// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.PowerShell;

    /// <summary>Properties for high level summary of firmware analysis results.</summary>
    [System.ComponentModel.TypeConverter(typeof(FirmwareSummaryTypeConverter))]
    public partial class FirmwareSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.FirmwareSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummary" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FirmwareSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.FirmwareSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummary" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FirmwareSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.FirmwareSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FirmwareSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtractedSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedSize = (long?) content.GetValueForProperty("ExtractedSize",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FileSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).FileSize = (long?) content.GetValueForProperty("FileSize",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).FileSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExtractedFileCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedFileCount = (long?) content.GetValueForProperty("ExtractedFileCount",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedFileCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ComponentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ComponentCount = (long?) content.GetValueForProperty("ComponentCount",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ComponentCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BinaryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).BinaryCount = (long?) content.GetValueForProperty("BinaryCount",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).BinaryCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AnalysisTimeSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).AnalysisTimeSecond = (long?) content.GetValueForProperty("AnalysisTimeSecond",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).AnalysisTimeSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RootFileSystem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).RootFileSystem = (long?) content.GetValueForProperty("RootFileSystem",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).RootFileSystem, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SummaryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.ISummaryResourcePropertiesInternal)this).SummaryType = (string) content.GetValueForProperty("SummaryType",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.ISummaryResourcePropertiesInternal)this).SummaryType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.FirmwareSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FirmwareSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtractedSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedSize = (long?) content.GetValueForProperty("ExtractedSize",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FileSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).FileSize = (long?) content.GetValueForProperty("FileSize",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).FileSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExtractedFileCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedFileCount = (long?) content.GetValueForProperty("ExtractedFileCount",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ExtractedFileCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ComponentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ComponentCount = (long?) content.GetValueForProperty("ComponentCount",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).ComponentCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BinaryCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).BinaryCount = (long?) content.GetValueForProperty("BinaryCount",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).BinaryCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AnalysisTimeSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).AnalysisTimeSecond = (long?) content.GetValueForProperty("AnalysisTimeSecond",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).AnalysisTimeSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RootFileSystem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).RootFileSystem = (long?) content.GetValueForProperty("RootFileSystem",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummaryInternal)this).RootFileSystem, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SummaryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.ISummaryResourcePropertiesInternal)this).SummaryType = (string) content.GetValueForProperty("SummaryType",((Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.ISummaryResourcePropertiesInternal)this).SummaryType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FirmwareSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FirmwareSummary" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IFirmwareSummary FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties for high level summary of firmware analysis results.
    [System.ComponentModel.TypeConverter(typeof(FirmwareSummaryTypeConverter))]
    public partial interface IFirmwareSummary

    {

    }
}