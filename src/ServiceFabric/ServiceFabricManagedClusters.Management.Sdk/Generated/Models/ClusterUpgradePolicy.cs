// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the policy used when upgrading the cluster.
    /// </summary>
    public partial class ClusterUpgradePolicy
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpgradePolicy class.
        /// </summary>
        public ClusterUpgradePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterUpgradePolicy class.
        /// </summary>

        /// <param name="forceRestart">If true, then processes are forcefully restarted during upgrade even when
        /// the code version has not changed (the upgrade only changes configuration or
        /// data).
        /// </param>

        /// <param name="healthPolicy">The cluster health policy defines a health policy used to evaluate the
        /// health of the cluster during a cluster upgrade.
        /// </param>

        /// <param name="deltaHealthPolicy">The cluster delta health policy defines a health policy used to evaluate
        /// the health of the cluster during a cluster upgrade.
        /// </param>

        /// <param name="monitoringPolicy">The cluster monitoring policy describes the parameters for monitoring an
        /// upgrade in Monitored mode.
        /// </param>

        /// <param name="upgradeReplicaSetCheckTimeout">The maximum amount of time to block processing of an upgrade domain and
        /// prevent loss of availability when there are unexpected issues.
        /// When this timeout expires, processing of the upgrade domain will proceed
        /// regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can
        /// be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit
        /// integer for seconds)
        /// </param>
        public ClusterUpgradePolicy(bool? forceRestart = default(bool?), ClusterHealthPolicy healthPolicy = default(ClusterHealthPolicy), ClusterUpgradeDeltaHealthPolicy deltaHealthPolicy = default(ClusterUpgradeDeltaHealthPolicy), ClusterMonitoringPolicy monitoringPolicy = default(ClusterMonitoringPolicy), string upgradeReplicaSetCheckTimeout = default(string))

        {
            this.ForceRestart = forceRestart;
            this.HealthPolicy = healthPolicy;
            this.DeltaHealthPolicy = deltaHealthPolicy;
            this.MonitoringPolicy = monitoringPolicy;
            this.UpgradeReplicaSetCheckTimeout = upgradeReplicaSetCheckTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets if true, then processes are forcefully restarted during
        /// upgrade even when the code version has not changed (the upgrade only
        /// changes configuration or data).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "forceRestart")]
        public bool? ForceRestart {get; set; }

        /// <summary>
        /// Gets or sets the cluster health policy defines a health policy used to
        /// evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "healthPolicy")]
        public ClusterHealthPolicy HealthPolicy {get; set; }

        /// <summary>
        /// Gets or sets the cluster delta health policy defines a health policy used
        /// to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deltaHealthPolicy")]
        public ClusterUpgradeDeltaHealthPolicy DeltaHealthPolicy {get; set; }

        /// <summary>
        /// Gets or sets the cluster monitoring policy describes the parameters for
        /// monitoring an upgrade in Monitored mode.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "monitoringPolicy")]
        public ClusterMonitoringPolicy MonitoringPolicy {get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of time to block processing of an upgrade
        /// domain and prevent loss of availability when there are unexpected issues.
        /// When this timeout expires, processing of the upgrade domain will proceed
        /// regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can
        /// be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit
        /// integer for seconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "upgradeReplicaSetCheckTimeout")]
        public string UpgradeReplicaSetCheckTimeout {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.HealthPolicy != null)
            {
                this.HealthPolicy.Validate();
            }
            if (this.DeltaHealthPolicy != null)
            {
                this.DeltaHealthPolicy.Validate();
            }
            if (this.MonitoringPolicy != null)
            {
                this.MonitoringPolicy.Validate();
            }

        }
    }
}