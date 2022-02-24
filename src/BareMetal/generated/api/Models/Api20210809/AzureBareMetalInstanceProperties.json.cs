// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Extensions;

    /// <summary>Describes the properties of an AzureBareMetal instance.</summary>
    public partial class AzureBareMetalInstanceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject into a new instance of <see cref="AzureBareMetalInstanceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AzureBareMetalInstanceProperties(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hardwareProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject>("hardwareProfile"), out var __jsonHardwareProfile) ? Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.HardwareProfile.FromJson(__jsonHardwareProfile) : HardwareProfile;}
            {_storageProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject>("storageProfile"), out var __jsonStorageProfile) ? Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.StorageProfile.FromJson(__jsonStorageProfile) : StorageProfile;}
            {_oSProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject>("osProfile"), out var __jsonOSProfile) ? Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.OSProfile.FromJson(__jsonOSProfile) : OSProfile;}
            {_networkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject>("networkProfile"), out var __jsonNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.NetworkProfile.FromJson(__jsonNetworkProfile) : NetworkProfile;}
            {_azureBareMetalInstanceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString>("azureBareMetalInstanceId"), out var __jsonAzureBareMetalInstanceId) ? (string)__jsonAzureBareMetalInstanceId : (string)AzureBareMetalInstanceId;}
            {_powerState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString>("powerState"), out var __jsonPowerState) ? (string)__jsonPowerState : (string)PowerState;}
            {_proximityPlacementGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString>("proximityPlacementGroup"), out var __jsonProximityPlacementGroup) ? (string)__jsonProximityPlacementGroup : (string)ProximityPlacementGroup;}
            {_hwRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString>("hwRevision"), out var __jsonHwRevision) ? (string)__jsonHwRevision : (string)HwRevision;}
            {_partnerNodeId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString>("partnerNodeId"), out var __jsonPartnerNodeId) ? (string)__jsonPartnerNodeId : (string)PartnerNodeId;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstanceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstanceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstanceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject json ? new AzureBareMetalInstanceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AzureBareMetalInstanceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AzureBareMetalInstanceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._hardwareProfile ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) this._hardwareProfile.ToJson(null,serializationMode) : null, "hardwareProfile" ,container.Add );
            AddIf( null != this._storageProfile ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) this._storageProfile.ToJson(null,serializationMode) : null, "storageProfile" ,container.Add );
            AddIf( null != this._oSProfile ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) this._oSProfile.ToJson(null,serializationMode) : null, "osProfile" ,container.Add );
            AddIf( null != this._networkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) this._networkProfile.ToJson(null,serializationMode) : null, "networkProfile" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._azureBareMetalInstanceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString(this._azureBareMetalInstanceId.ToString()) : null, "azureBareMetalInstanceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._powerState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString(this._powerState.ToString()) : null, "powerState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._proximityPlacementGroup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString(this._proximityPlacementGroup.ToString()) : null, "proximityPlacementGroup" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._hwRevision)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString(this._hwRevision.ToString()) : null, "hwRevision" ,container.Add );
            }
            AddIf( null != (((object)this._partnerNodeId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString(this._partnerNodeId.ToString()) : null, "partnerNodeId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}