// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// CloudServicesNetworkPatchParameters represents the body of the request to patch the cloud services network.
    /// </summary>
    public partial class CloudServicesNetworkPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersInternal
    {

        /// <summary>
        /// The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint[] AdditionalEgressEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchPropertiesInternal)Property).AdditionalEgressEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchPropertiesInternal)Property).AdditionalEgressEndpoint = value ?? null /* arrayOf */; }

        /// <summary>
        /// The indicator of whether the platform default endpoints are allowed for the egress traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints? EnableDefaultEgressEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchPropertiesInternal)Property).EnableDefaultEgressEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchPropertiesInternal)Property).EnableDefaultEgressEndpoint = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints)""); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.CloudServicesNetworkPatchProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchProperties _property;

        /// <summary>The list of the resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.CloudServicesNetworkPatchProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersTags _tag;

        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.CloudServicesNetworkPatchParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="CloudServicesNetworkPatchParameters" /> instance.</summary>
        public CloudServicesNetworkPatchParameters()
        {

        }
    }
    /// CloudServicesNetworkPatchParameters represents the body of the request to patch the cloud services network.
    public partial interface ICloudServicesNetworkPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint.",
        SerializedName = @"additionalEgressEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint[] AdditionalEgressEndpoint { get; set; }
        /// <summary>
        /// The indicator of whether the platform default endpoints are allowed for the egress traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The indicator of whether the platform default endpoints are allowed for the egress traffic.",
        SerializedName = @"enableDefaultEgressEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints? EnableDefaultEgressEndpoint { get; set; }
        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure resource tags that will replace the existing ones.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersTags Tag { get; set; }

    }
    /// CloudServicesNetworkPatchParameters represents the body of the request to patch the cloud services network.
    internal partial interface ICloudServicesNetworkPatchParametersInternal

    {
        /// <summary>
        /// The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IEgressEndpoint[] AdditionalEgressEndpoint { get; set; }
        /// <summary>
        /// The indicator of whether the platform default endpoints are allowed for the egress traffic.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints? EnableDefaultEgressEndpoint { get; set; }
        /// <summary>The list of the resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchProperties Property { get; set; }
        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ICloudServicesNetworkPatchParametersTags Tag { get; set; }

    }
}