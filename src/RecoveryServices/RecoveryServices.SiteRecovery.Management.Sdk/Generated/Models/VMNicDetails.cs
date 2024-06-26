// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Hyper V VM network details.
    /// </summary>
    public partial class VMNicDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMNicDetails class.
        /// </summary>
        public VMNicDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMNicDetails class.
        /// </summary>

        /// <param name="nicId">The nic Id.
        /// </param>

        /// <param name="replicaNicId">The replica nic Id.
        /// </param>

        /// <param name="sourceNicArmId">The source nic ARM Id.
        /// </param>

        /// <param name="vmNetworkName">VM network name.
        /// </param>

        /// <param name="recoveryVMNetworkId">Recovery VM network Id.
        /// </param>

        /// <param name="ipConfigs">The IP configurations of the NIC.
        /// </param>

        /// <param name="selectionType">Selection type for failover.
        /// </param>

        /// <param name="recoveryNetworkSecurityGroupId">The id of the NSG associated with the NIC.
        /// </param>

        /// <param name="enableAcceleratedNetworkingOnRecovery">A value indicating whether the NIC has accelerated networking enabled.
        /// </param>

        /// <param name="tfoVMNetworkId">The network to be used by NIC during test failover.
        /// </param>

        /// <param name="tfoNetworkSecurityGroupId">The NSG to be used by NIC during test failover.
        /// </param>

        /// <param name="enableAcceleratedNetworkingOnTfo">Whether the TFO NIC has accelerated networking enabled.
        /// </param>

        /// <param name="recoveryNicName">The name of the NIC to be used when creating target NICs.
        /// </param>

        /// <param name="recoveryNicResourceGroupName">The resource group of the NIC to be used when creating target NICs.
        /// </param>

        /// <param name="reuseExistingNic">A value indicating whether an existing NIC is allowed to be reused during
        /// failover subject to availability.
        /// </param>

        /// <param name="tfoRecoveryNicName">The name of the NIC to be used when creating target NICs in TFO.
        /// </param>

        /// <param name="tfoRecoveryNicResourceGroupName">The resource group of the NIC to be used when creating target NICs in TFO.
        /// </param>

        /// <param name="tfoReuseExistingNic">A value indicating whether an existing NIC is allowed to be reused during
        /// test failover subject to availability.
        /// </param>

        /// <param name="targetNicName">Target NIC name.
        /// </param>
        public VMNicDetails(string nicId = default(string), string replicaNicId = default(string), string sourceNicArmId = default(string), string vmNetworkName = default(string), string recoveryVMNetworkId = default(string), System.Collections.Generic.IList<IPConfigDetails> ipConfigs = default(System.Collections.Generic.IList<IPConfigDetails>), string selectionType = default(string), string recoveryNetworkSecurityGroupId = default(string), bool? enableAcceleratedNetworkingOnRecovery = default(bool?), string tfoVMNetworkId = default(string), string tfoNetworkSecurityGroupId = default(string), bool? enableAcceleratedNetworkingOnTfo = default(bool?), string recoveryNicName = default(string), string recoveryNicResourceGroupName = default(string), bool? reuseExistingNic = default(bool?), string tfoRecoveryNicName = default(string), string tfoRecoveryNicResourceGroupName = default(string), bool? tfoReuseExistingNic = default(bool?), string targetNicName = default(string))

        {
            this.NicId = nicId;
            this.ReplicaNicId = replicaNicId;
            this.SourceNicArmId = sourceNicArmId;
            this.VMNetworkName = vmNetworkName;
            this.RecoveryVMNetworkId = recoveryVMNetworkId;
            this.IPConfigs = ipConfigs;
            this.SelectionType = selectionType;
            this.RecoveryNetworkSecurityGroupId = recoveryNetworkSecurityGroupId;
            this.EnableAcceleratedNetworkingOnRecovery = enableAcceleratedNetworkingOnRecovery;
            this.TfoVMNetworkId = tfoVMNetworkId;
            this.TfoNetworkSecurityGroupId = tfoNetworkSecurityGroupId;
            this.EnableAcceleratedNetworkingOnTfo = enableAcceleratedNetworkingOnTfo;
            this.RecoveryNicName = recoveryNicName;
            this.RecoveryNicResourceGroupName = recoveryNicResourceGroupName;
            this.ReuseExistingNic = reuseExistingNic;
            this.TfoRecoveryNicName = tfoRecoveryNicName;
            this.TfoRecoveryNicResourceGroupName = tfoRecoveryNicResourceGroupName;
            this.TfoReuseExistingNic = tfoReuseExistingNic;
            this.TargetNicName = targetNicName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the nic Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nicId")]
        public string NicId {get; set; }

        /// <summary>
        /// Gets or sets the replica nic Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "replicaNicId")]
        public string ReplicaNicId {get; set; }

        /// <summary>
        /// Gets or sets the source nic ARM Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceNicArmId")]
        public string SourceNicArmId {get; set; }

        /// <summary>
        /// Gets or sets vM network name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vMNetworkName")]
        public string VMNetworkName {get; set; }

        /// <summary>
        /// Gets or sets recovery VM network Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryVMNetworkId")]
        public string RecoveryVMNetworkId {get; set; }

        /// <summary>
        /// Gets or sets the IP configurations of the NIC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipConfigs")]
        public System.Collections.Generic.IList<IPConfigDetails> IPConfigs {get; set; }

        /// <summary>
        /// Gets or sets selection type for failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionType")]
        public string SelectionType {get; set; }

        /// <summary>
        /// Gets or sets the id of the NSG associated with the NIC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryNetworkSecurityGroupId")]
        public string RecoveryNetworkSecurityGroupId {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the NIC has accelerated networking
        /// enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableAcceleratedNetworkingOnRecovery")]
        public bool? EnableAcceleratedNetworkingOnRecovery {get; set; }

        /// <summary>
        /// Gets or sets the network to be used by NIC during test failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoVMNetworkId")]
        public string TfoVMNetworkId {get; set; }

        /// <summary>
        /// Gets or sets the NSG to be used by NIC during test failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoNetworkSecurityGroupId")]
        public string TfoNetworkSecurityGroupId {get; set; }

        /// <summary>
        /// Gets or sets whether the TFO NIC has accelerated networking enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableAcceleratedNetworkingOnTfo")]
        public bool? EnableAcceleratedNetworkingOnTfo {get; set; }

        /// <summary>
        /// Gets or sets the name of the NIC to be used when creating target NICs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryNicName")]
        public string RecoveryNicName {get; set; }

        /// <summary>
        /// Gets or sets the resource group of the NIC to be used when creating target
        /// NICs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryNicResourceGroupName")]
        public string RecoveryNicResourceGroupName {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an existing NIC is allowed to be
        /// reused during failover subject to availability.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reuseExistingNic")]
        public bool? ReuseExistingNic {get; set; }

        /// <summary>
        /// Gets or sets the name of the NIC to be used when creating target NICs in
        /// TFO.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoRecoveryNicName")]
        public string TfoRecoveryNicName {get; set; }

        /// <summary>
        /// Gets or sets the resource group of the NIC to be used when creating target
        /// NICs in TFO.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoRecoveryNicResourceGroupName")]
        public string TfoRecoveryNicResourceGroupName {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an existing NIC is allowed to be
        /// reused during test failover subject to availability.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoReuseExistingNic")]
        public bool? TfoReuseExistingNic {get; set; }

        /// <summary>
        /// Gets or sets target NIC name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetNicName")]
        public string TargetNicName {get; set; }
    }
}