// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Virtual machine resource properties</summary>
    public partial class VirtualMachineProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClaimedByUserId" /> property.</summary>
        private string _claimedByUserId;

        /// <summary>The lab user ID (not the PUID!) of who claimed the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string ClaimedByUserId { get => this._claimedByUserId; }

        /// <summary>Backing field for <see cref="ConnectionProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfile _connectionProfile;

        /// <summary>Profile for information about connecting to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfile ConnectionProfile { get => (this._connectionProfile = this._connectionProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineConnectionProfile()); }

        /// <summary>The username used to log on to the virtual machine as admin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfileAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).AdminUsername; }

        /// <summary>The username used to log on to the virtual machine as non-admin, if one exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfileNonAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).NonAdminUsername; }

        /// <summary>The private IP address of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfilePrivateIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).PrivateIPAddress; }

        /// <summary>
        /// Port and host name separated by semicolon for connecting via RDP protocol to the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfileRdpAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).RdpAuthority; }

        /// <summary>URL for connecting via RDP protocol to the virtual machine in browser.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfileRdpInBrowserUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).RdpInBrowserUrl; }

        /// <summary>
        /// Port and host name separated by semicolon for connecting via SSH protocol to the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfileSshAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).SshAuthority; }

        /// <summary>URL for connecting via SSH protocol to the virtual machine in browser.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string ConnectionProfileSshInBrowserUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).SshInBrowserUrl; }

        /// <summary>Internal Acessors for ClaimedByUserId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ClaimedByUserId { get => this._claimedByUserId; set { {_claimedByUserId = value;} } }

        /// <summary>Internal Acessors for ConnectionProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfile { get => (this._connectionProfile = this._connectionProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.VirtualMachineConnectionProfile()); set { {_connectionProfile = value;} } }

        /// <summary>Internal Acessors for ConnectionProfileAdminUsername</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfileAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).AdminUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).AdminUsername = value ?? null; }

        /// <summary>Internal Acessors for ConnectionProfileNonAdminUsername</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfileNonAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).NonAdminUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).NonAdminUsername = value ?? null; }

        /// <summary>Internal Acessors for ConnectionProfilePrivateIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfilePrivateIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).PrivateIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).PrivateIPAddress = value ?? null; }

        /// <summary>Internal Acessors for ConnectionProfileRdpAuthority</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfileRdpAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).RdpAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).RdpAuthority = value ?? null; }

        /// <summary>Internal Acessors for ConnectionProfileRdpInBrowserUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfileRdpInBrowserUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).RdpInBrowserUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).RdpInBrowserUrl = value ?? null; }

        /// <summary>Internal Acessors for ConnectionProfileSshAuthority</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfileSshAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).SshAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).SshAuthority = value ?? null; }

        /// <summary>Internal Acessors for ConnectionProfileSshInBrowserUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ConnectionProfileSshInBrowserUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).SshInBrowserUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfileInternal)ConnectionProfile).SshInBrowserUrl = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for VMType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachinePropertiesInternal.VMType { get => this._vMType; set { {_vMType = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Current provisioning state of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The current state of the virtual machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string State { get => this._state; }

        /// <summary>Backing field for <see cref="VMType" /> property.</summary>
        private string _vMType;

        /// <summary>The type of this VM resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string VMType { get => this._vMType; }

        /// <summary>Creates an new <see cref="VirtualMachineProperties" /> instance.</summary>
        public VirtualMachineProperties()
        {

        }
    }
    /// Virtual machine resource properties
    public partial interface IVirtualMachineProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>The lab user ID (not the PUID!) of who claimed the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The lab user ID (not the PUID!) of who claimed the virtual machine.",
        SerializedName = @"claimedByUserId",
        PossibleTypes = new [] { typeof(string) })]
        string ClaimedByUserId { get;  }
        /// <summary>The username used to log on to the virtual machine as admin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The username used to log on to the virtual machine as admin.",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfileAdminUsername { get;  }
        /// <summary>The username used to log on to the virtual machine as non-admin, if one exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The username used to log on to the virtual machine as non-admin, if one exists.",
        SerializedName = @"nonAdminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfileNonAdminUsername { get;  }
        /// <summary>The private IP address of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The private IP address of the virtual machine.",
        SerializedName = @"privateIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfilePrivateIPAddress { get;  }
        /// <summary>
        /// Port and host name separated by semicolon for connecting via RDP protocol to the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Port and host name separated by semicolon for connecting via RDP protocol to the virtual machine.",
        SerializedName = @"rdpAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfileRdpAuthority { get;  }
        /// <summary>URL for connecting via RDP protocol to the virtual machine in browser.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL for connecting via RDP protocol to the virtual machine in browser.",
        SerializedName = @"rdpInBrowserUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfileRdpInBrowserUrl { get;  }
        /// <summary>
        /// Port and host name separated by semicolon for connecting via SSH protocol to the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Port and host name separated by semicolon for connecting via SSH protocol to the virtual machine.",
        SerializedName = @"sshAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfileSshAuthority { get;  }
        /// <summary>URL for connecting via SSH protocol to the virtual machine in browser.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL for connecting via SSH protocol to the virtual machine in browser.",
        SerializedName = @"sshInBrowserUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionProfileSshInBrowserUrl { get;  }
        /// <summary>Current provisioning state of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Current provisioning state of the virtual machine.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Failed", "Locked")]
        string ProvisioningState { get;  }
        /// <summary>The current state of the virtual machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The current state of the virtual machine",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Stopped", "Starting", "Running", "Stopping", "ResettingPassword", "Reimaging", "Redeploying")]
        string State { get;  }
        /// <summary>The type of this VM resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of this VM resource",
        SerializedName = @"vmType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("User", "Template")]
        string VMType { get;  }

    }
    /// Virtual machine resource properties
    internal partial interface IVirtualMachinePropertiesInternal

    {
        /// <summary>The lab user ID (not the PUID!) of who claimed the virtual machine.</summary>
        string ClaimedByUserId { get; set; }
        /// <summary>Profile for information about connecting to the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachineConnectionProfile ConnectionProfile { get; set; }
        /// <summary>The username used to log on to the virtual machine as admin.</summary>
        string ConnectionProfileAdminUsername { get; set; }
        /// <summary>The username used to log on to the virtual machine as non-admin, if one exists.</summary>
        string ConnectionProfileNonAdminUsername { get; set; }
        /// <summary>The private IP address of the virtual machine.</summary>
        string ConnectionProfilePrivateIPAddress { get; set; }
        /// <summary>
        /// Port and host name separated by semicolon for connecting via RDP protocol to the virtual machine.
        /// </summary>
        string ConnectionProfileRdpAuthority { get; set; }
        /// <summary>URL for connecting via RDP protocol to the virtual machine in browser.</summary>
        string ConnectionProfileRdpInBrowserUrl { get; set; }
        /// <summary>
        /// Port and host name separated by semicolon for connecting via SSH protocol to the virtual machine.
        /// </summary>
        string ConnectionProfileSshAuthority { get; set; }
        /// <summary>URL for connecting via SSH protocol to the virtual machine in browser.</summary>
        string ConnectionProfileSshInBrowserUrl { get; set; }
        /// <summary>Current provisioning state of the virtual machine.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Failed", "Locked")]
        string ProvisioningState { get; set; }
        /// <summary>The current state of the virtual machine</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Stopped", "Starting", "Running", "Stopping", "ResettingPassword", "Reimaging", "Redeploying")]
        string State { get; set; }
        /// <summary>The type of this VM resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("User", "Template")]
        string VMType { get; set; }

    }
}