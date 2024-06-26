// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Hyper V VM network input details.
    /// </summary>
    public partial class VMNicInputDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMNicInputDetails class.
        /// </summary>
        public VMNicInputDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMNicInputDetails class.
        /// </summary>

        /// <param name="nicId">The nic Id.
        /// </param>

        /// <param name="ipConfigs">The IP configurations to be used by NIC during test failover and failover.
        /// </param>

        /// <param name="selectionType">Selection type for failover.
        /// </param>

        /// <param name="recoveryNetworkSecurityGroupId">The id of the NSG associated with the NIC.
        /// </param>

        /// <param name="enableAcceleratedNetworkingOnRecovery">Whether the NIC has accelerated networking enabled.
        /// </param>

        /// <param name="tfoNetworkSecurityGroupId">The NSG to be used by NIC during test failover.
        /// </param>

        /// <param name="enableAcceleratedNetworkingOnTfo">Whether the test NIC has accelerated networking enabled.
        /// </param>

        /// <param name="recoveryNicName">The name of the NIC to be used when creating target NICs.
        /// </param>

        /// <param name="recoveryNicResourceGroupName">The resource group of the NIC to be used when creating target NICs.
        /// </param>

        /// <param name="reuseExistingNic">A value indicating whether an existing NIC is allowed to be reused during
        /// failover subject to availability.
        /// </param>

        /// <param name="tfoNicName">The name of the NIC to be used when creating target NICs in TFO.
        /// </param>

        /// <param name="tfoNicResourceGroupName">The resource group of the NIC to be used when creating target NICs in TFO.
        /// </param>

        /// <param name="tfoReuseExistingNic">A value indicating whether an existing NIC is allowed to be reused during
        /// test failover subject to availability.
        /// </param>

        /// <param name="targetNicName">Target NIC name.
        /// </param>
        public VMNicInputDetails(string nicId = default(string), System.Collections.Generic.IList<IPConfigInputDetails> ipConfigs = default(System.Collections.Generic.IList<IPConfigInputDetails>), string selectionType = default(string), string recoveryNetworkSecurityGroupId = default(string), bool? enableAcceleratedNetworkingOnRecovery = default(bool?), string tfoNetworkSecurityGroupId = default(string), bool? enableAcceleratedNetworkingOnTfo = default(bool?), string recoveryNicName = default(string), string recoveryNicResourceGroupName = default(string), bool? reuseExistingNic = default(bool?), string tfoNicName = default(string), string tfoNicResourceGroupName = default(string), bool? tfoReuseExistingNic = default(bool?), string targetNicName = default(string))

        {
            this.NicId = nicId;
            this.IPConfigs = ipConfigs;
            this.SelectionType = selectionType;
            this.RecoveryNetworkSecurityGroupId = recoveryNetworkSecurityGroupId;
            this.EnableAcceleratedNetworkingOnRecovery = enableAcceleratedNetworkingOnRecovery;
            this.TfoNetworkSecurityGroupId = tfoNetworkSecurityGroupId;
            this.EnableAcceleratedNetworkingOnTfo = enableAcceleratedNetworkingOnTfo;
            this.RecoveryNicName = recoveryNicName;
            this.RecoveryNicResourceGroupName = recoveryNicResourceGroupName;
            this.ReuseExistingNic = reuseExistingNic;
            this.TfoNicName = tfoNicName;
            this.TfoNicResourceGroupName = tfoNicResourceGroupName;
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
        /// Gets or sets the IP configurations to be used by NIC during test failover
        /// and failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipConfigs")]
        public System.Collections.Generic.IList<IPConfigInputDetails> IPConfigs {get; set; }

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
        /// Gets or sets whether the NIC has accelerated networking enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableAcceleratedNetworkingOnRecovery")]
        public bool? EnableAcceleratedNetworkingOnRecovery {get; set; }

        /// <summary>
        /// Gets or sets the NSG to be used by NIC during test failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoNetworkSecurityGroupId")]
        public string TfoNetworkSecurityGroupId {get; set; }

        /// <summary>
        /// Gets or sets whether the test NIC has accelerated networking enabled.
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
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoNicName")]
        public string TfoNicName {get; set; }

        /// <summary>
        /// Gets or sets the resource group of the NIC to be used when creating target
        /// NICs in TFO.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tfoNicResourceGroupName")]
        public string TfoNicResourceGroupName {get; set; }

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