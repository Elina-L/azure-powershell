// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>SpotPlacementScores API response.</summary>
    [System.ComponentModel.TypeConverter(typeof(SpotPlacementScoresResponseTypeConverter))]
    public partial class SpotPlacementScoresResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.SpotPlacementScoresResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SpotPlacementScoresResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.SpotPlacementScoresResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SpotPlacementScoresResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpotPlacementScoresResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SpotPlacementScoresResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.SpotPlacementScoresResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SpotPlacementScoresResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DesiredLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredLocation = (string[]) content.GetValueForProperty("DesiredLocation",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredLocation, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DesiredSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredSize = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IResourceSize[]) content.GetValueForProperty("DesiredSize",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredSize, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IResourceSize>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ResourceSizeTypeConverter.ConvertFrom));
            }
            if (content.Contains("DesiredCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredCount = (int?) content.GetValueForProperty("DesiredCount",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).AvailabilityZone = (bool?) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).AvailabilityZone, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PlacementScore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).PlacementScore = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IPlacementScore[]) content.GetValueForProperty("PlacementScore",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).PlacementScore, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IPlacementScore>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.PlacementScoreTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.SpotPlacementScoresResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SpotPlacementScoresResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DesiredLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredLocation = (string[]) content.GetValueForProperty("DesiredLocation",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredLocation, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DesiredSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredSize = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IResourceSize[]) content.GetValueForProperty("DesiredSize",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredSize, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IResourceSize>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ResourceSizeTypeConverter.ConvertFrom));
            }
            if (content.Contains("DesiredCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredCount = (int?) content.GetValueForProperty("DesiredCount",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).DesiredCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).AvailabilityZone = (bool?) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).AvailabilityZone, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PlacementScore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).PlacementScore = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IPlacementScore[]) content.GetValueForProperty("PlacementScore",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponseInternal)this).PlacementScore, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IPlacementScore>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.PlacementScoreTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SpotPlacementScores API response.
    [System.ComponentModel.TypeConverter(typeof(SpotPlacementScoresResponseTypeConverter))]
    public partial interface ISpotPlacementScoresResponse

    {

    }
}