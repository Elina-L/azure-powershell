// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Compute</summary>
    public partial class ComputeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> _attribute;

        /// <summary>Additional attributes for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get => this._attribute; set => this._attribute = value; }

        /// <summary>Backing field for <see cref="CpuCore" /> property.</summary>
        private int? _cpuCore;

        /// <summary>Number of allocated CPU cores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public int? CpuCore { get => this._cpuCore; set => this._cpuCore = value; }

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private string _createdAt;

        /// <summary>Timestamp indicating when the entity was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="EntityId" /> property.</summary>
        private string _entityId;

        /// <summary>Unique identifier for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string EntityId { get => this._entityId; }

        /// <summary>Backing field for <see cref="EntityName" /> property.</summary>
        private string _entityName;

        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string EntityName { get => this._entityName; set => this._entityName = value; }

        /// <summary>Backing field for <see cref="Memory" /> property.</summary>
        private int? _memory;

        /// <summary>Memory allocated in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public int? Memory { get => this._memory; set => this._memory = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for EntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal.EntityId { get => this._entityId; set { {_entityId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>Region where the compute instance is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Current status of the compute instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ComputeProperties" /> instance.</summary>
        public ComputeProperties()
        {

        }
    }
    /// Properties specific to Compute
    public partial interface IComputeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
        /// <summary>Additional attributes for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional attributes for the entity",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get; set; }
        /// <summary>Number of allocated CPU cores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of allocated CPU cores",
        SerializedName = @"cpuCores",
        PossibleTypes = new [] { typeof(int) })]
        int? CpuCore { get; set; }
        /// <summary>Timestamp indicating when the entity was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Timestamp indicating when the entity was created",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedAt { get;  }
        /// <summary>Unique identifier for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique identifier for the entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        string EntityId { get;  }
        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the resource",
        SerializedName = @"entityName",
        PossibleTypes = new [] { typeof(string) })]
        string EntityName { get; set; }
        /// <summary>Memory allocated in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Memory allocated in GB",
        SerializedName = @"memory",
        PossibleTypes = new [] { typeof(int) })]
        int? Memory { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Region where the compute instance is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Region where the compute instance is located",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }
        /// <summary>Current status of the compute instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current status of the compute instance",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Properties specific to Compute
    internal partial interface IComputePropertiesInternal

    {
        /// <summary>Additional attributes for the entity</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get; set; }
        /// <summary>Number of allocated CPU cores</summary>
        int? CpuCore { get; set; }
        /// <summary>Timestamp indicating when the entity was created</summary>
        string CreatedAt { get; set; }
        /// <summary>Unique identifier for the entity</summary>
        string EntityId { get; set; }
        /// <summary>Name of the resource</summary>
        string EntityName { get; set; }
        /// <summary>Memory allocated in GB</summary>
        int? Memory { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Region where the compute instance is located</summary>
        string Region { get; set; }
        /// <summary>Current status of the compute instance</summary>
        string Status { get; set; }

    }
}