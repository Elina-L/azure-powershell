// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Extensions;

    /// <summary>
    /// Details of a REST API operation, returned from the Resource Provider Operations API
    /// </summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal
    {

        /// <summary>Backing field for <see cref="ActionType" /> property.</summary>
        private string _actionType;

        /// <summary>
        /// Extensible enum. Indicates the action type. "Internal" refers to actions that are for internal only APIs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public string ActionType { get => this._actionType; }

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplay _display;

        /// <summary>Localized display information for this particular operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.OperationDisplay()); set => this._display = value; }

        /// <summary>
        /// The short, localized friendly description of the operation; suitable for tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Description; }

        /// <summary>
        /// The concise, localized friendly name for the operation; suitable for dropdowns. E.g. "Create or Update Virtual Machine",
        /// "Restart Virtual Machine".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Operation; }

        /// <summary>
        /// The localized friendly form of the resource provider name, e.g. "Microsoft Monitoring Insights" or "Microsoft Compute".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Provider; }

        /// <summary>
        /// The localized friendly name of the resource type related to this operation. E.g. "Virtual Machines" or "Job Schedule Collections".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Resource; }

        /// <summary>Backing field for <see cref="IsDataAction" /> property.</summary>
        private bool? _isDataAction;

        /// <summary>
        /// Whether the operation applies to data-plane. This is "true" for data-plane operations and "false" for Azure Resource Manager/control-plane
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public bool? IsDataAction { get => this._isDataAction; }

        /// <summary>Internal Acessors for ActionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.ActionType { get => this._actionType; set { {_actionType = value;} } }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Internal Acessors for DisplayDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Description = value ?? null; }

        /// <summary>Internal Acessors for DisplayOperation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>Internal Acessors for DisplayProvider</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>Internal Acessors for DisplayResource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for IsDataAction</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.IsDataAction { get => this._isDataAction; set { {_isDataAction = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Origin</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationInternal.Origin { get => this._origin; set { {_origin = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the operation, as per Resource-Based Access Control (RBAC). Examples: "Microsoft.Compute/virtualMachines/write",
        /// "Microsoft.Compute/virtualMachines/capture/action"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>
        /// The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is
        /// "user,system"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Details of a REST API operation, returned from the Resource Provider Operations API
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Extensible enum. Indicates the action type. "Internal" refers to actions that are for internal only APIs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Extensible enum. Indicates the action type. ""Internal"" refers to actions that are for internal only APIs.",
        SerializedName = @"actionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PSArgumentCompleterAttribute("Internal")]
        string ActionType { get;  }
        /// <summary>
        /// The short, localized friendly description of the operation; suitable for tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The short, localized friendly description of the operation; suitable for tool tips and detailed views.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get;  }
        /// <summary>
        /// The concise, localized friendly name for the operation; suitable for dropdowns. E.g. "Create or Update Virtual Machine",
        /// "Restart Virtual Machine".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The concise, localized friendly name for the operation; suitable for dropdowns. E.g. ""Create or Update Virtual Machine"", ""Restart Virtual Machine"".",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get;  }
        /// <summary>
        /// The localized friendly form of the resource provider name, e.g. "Microsoft Monitoring Insights" or "Microsoft Compute".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The localized friendly form of the resource provider name, e.g. ""Microsoft Monitoring Insights"" or ""Microsoft Compute"".",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get;  }
        /// <summary>
        /// The localized friendly name of the resource type related to this operation. E.g. "Virtual Machines" or "Job Schedule Collections".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The localized friendly name of the resource type related to this operation. E.g. ""Virtual Machines"" or ""Job Schedule Collections"".",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get;  }
        /// <summary>
        /// Whether the operation applies to data-plane. This is "true" for data-plane operations and "false" for Azure Resource Manager/control-plane
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the operation applies to data-plane. This is ""true"" for data-plane operations and ""false"" for Azure Resource Manager/control-plane operations.",
        SerializedName = @"isDataAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDataAction { get;  }
        /// <summary>
        /// The name of the operation, as per Resource-Based Access Control (RBAC). Examples: "Microsoft.Compute/virtualMachines/write",
        /// "Microsoft.Compute/virtualMachines/capture/action"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the operation, as per Resource-Based Access Control (RBAC). Examples: ""Microsoft.Compute/virtualMachines/write"", ""Microsoft.Compute/virtualMachines/capture/action""",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>
        /// The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is
        /// "user,system"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is ""user,system""",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PSArgumentCompleterAttribute("user", "system", "user,system")]
        string Origin { get;  }

    }
    /// Details of a REST API operation, returned from the Resource Provider Operations API
    internal partial interface IOperationInternal

    {
        /// <summary>
        /// Extensible enum. Indicates the action type. "Internal" refers to actions that are for internal only APIs.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PSArgumentCompleterAttribute("Internal")]
        string ActionType { get; set; }
        /// <summary>Localized display information for this particular operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IOperationDisplay Display { get; set; }
        /// <summary>
        /// The short, localized friendly description of the operation; suitable for tool tips and detailed views.
        /// </summary>
        string DisplayDescription { get; set; }
        /// <summary>
        /// The concise, localized friendly name for the operation; suitable for dropdowns. E.g. "Create or Update Virtual Machine",
        /// "Restart Virtual Machine".
        /// </summary>
        string DisplayOperation { get; set; }
        /// <summary>
        /// The localized friendly form of the resource provider name, e.g. "Microsoft Monitoring Insights" or "Microsoft Compute".
        /// </summary>
        string DisplayProvider { get; set; }
        /// <summary>
        /// The localized friendly name of the resource type related to this operation. E.g. "Virtual Machines" or "Job Schedule Collections".
        /// </summary>
        string DisplayResource { get; set; }
        /// <summary>
        /// Whether the operation applies to data-plane. This is "true" for data-plane operations and "false" for Azure Resource Manager/control-plane
        /// operations.
        /// </summary>
        bool? IsDataAction { get; set; }
        /// <summary>
        /// The name of the operation, as per Resource-Based Access Control (RBAC). Examples: "Microsoft.Compute/virtualMachines/write",
        /// "Microsoft.Compute/virtualMachines/capture/action"
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is
        /// "user,system"
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PSArgumentCompleterAttribute("user", "system", "user,system")]
        string Origin { get; set; }

    }
}