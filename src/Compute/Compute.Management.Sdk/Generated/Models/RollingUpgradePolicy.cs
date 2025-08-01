// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration parameters used while performing a rolling upgrade.
    /// </summary>
    public partial class RollingUpgradePolicy
    {
        /// <summary>
        /// Initializes a new instance of the RollingUpgradePolicy class.
        /// </summary>
        public RollingUpgradePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RollingUpgradePolicy class.
        /// </summary>
        /// <param name="maxBatchInstancePercent">The maximum percent of total
        /// virtual machine instances that will be upgraded simultaneously by
        /// the rolling upgrade in one batch. As this is a maximum, unhealthy
        /// instances in previous or future batches can cause the percentage of
        /// instances in a batch to decrease to ensure higher reliability. The
        /// default value for this parameter is 20%.</param>
        /// <param name="maxUnhealthyInstancePercent">The maximum percentage of
        /// the total virtual machine instances in the scale set that can be
        /// simultaneously unhealthy, either as a result of being upgraded, or
        /// by being found in an unhealthy state by the virtual machine health
        /// checks before the rolling upgrade aborts. This constraint will be
        /// checked prior to starting any batch. The default value for this
        /// parameter is 20%.</param>
        /// <param name="maxUnhealthyUpgradedInstancePercent">The maximum
        /// percentage of upgraded virtual machine instances that can be found
        /// to be in an unhealthy state. This check will happen after each
        /// batch is upgraded. If this percentage is ever exceeded, the rolling
        /// update aborts. The default value for this parameter is 20%.</param>
        /// <param name="pauseTimeBetweenBatches">The wait time between
        /// completing the update for all virtual machines in one batch and
        /// starting the next batch. The time duration should be specified in
        /// ISO 8601 format. The default value is 0 seconds (PT0S).</param>
        /// <param name="enableCrossZoneUpgrade">Allow VMSS to ignore AZ
        /// boundaries when constructing upgrade batches. Take into
        /// consideration the Update Domain and maxBatchInstancePercent to
        /// determine the batch size.</param>
        /// <param name="prioritizeUnhealthyInstances">Upgrade all unhealthy
        /// instances in a scale set before any healthy instances.</param>
        /// <param name="rollbackFailedInstancesOnPolicyBreach">Rollback failed
        /// instances to previous model if the Rolling Upgrade policy is
        /// violated.</param>
        /// <param name="maxSurge">Create new virtual machines to upgrade the
        /// scale set, rather than updating the existing virtual machines.
        /// Existing virtual machines will be deleted once the new virtual
        /// machines are created for each batch.</param>
        public RollingUpgradePolicy(int? maxBatchInstancePercent = default(int?), int? maxUnhealthyInstancePercent = default(int?), int? maxUnhealthyUpgradedInstancePercent = default(int?), string pauseTimeBetweenBatches = default(string), bool? enableCrossZoneUpgrade = default(bool?), bool? prioritizeUnhealthyInstances = default(bool?), bool? rollbackFailedInstancesOnPolicyBreach = default(bool?), bool? maxSurge = default(bool?))
        {
            MaxBatchInstancePercent = maxBatchInstancePercent;
            MaxUnhealthyInstancePercent = maxUnhealthyInstancePercent;
            MaxUnhealthyUpgradedInstancePercent = maxUnhealthyUpgradedInstancePercent;
            PauseTimeBetweenBatches = pauseTimeBetweenBatches;
            EnableCrossZoneUpgrade = enableCrossZoneUpgrade;
            PrioritizeUnhealthyInstances = prioritizeUnhealthyInstances;
            RollbackFailedInstancesOnPolicyBreach = rollbackFailedInstancesOnPolicyBreach;
            MaxSurge = maxSurge;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum percent of total virtual machine instances
        /// that will be upgraded simultaneously by the rolling upgrade in one
        /// batch. As this is a maximum, unhealthy instances in previous or
        /// future batches can cause the percentage of instances in a batch to
        /// decrease to ensure higher reliability. The default value for this
        /// parameter is 20%.
        /// </summary>
        [JsonProperty(PropertyName = "maxBatchInstancePercent")]
        public int? MaxBatchInstancePercent { get; set; }

        /// <summary>
        /// Gets or sets the maximum percentage of the total virtual machine
        /// instances in the scale set that can be simultaneously unhealthy,
        /// either as a result of being upgraded, or by being found in an
        /// unhealthy state by the virtual machine health checks before the
        /// rolling upgrade aborts. This constraint will be checked prior to
        /// starting any batch. The default value for this parameter is 20%.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnhealthyInstancePercent")]
        public int? MaxUnhealthyInstancePercent { get; set; }

        /// <summary>
        /// Gets or sets the maximum percentage of upgraded virtual machine
        /// instances that can be found to be in an unhealthy state. This check
        /// will happen after each batch is upgraded. If this percentage is
        /// ever exceeded, the rolling update aborts. The default value for
        /// this parameter is 20%.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnhealthyUpgradedInstancePercent")]
        public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

        /// <summary>
        /// Gets or sets the wait time between completing the update for all
        /// virtual machines in one batch and starting the next batch. The time
        /// duration should be specified in ISO 8601 format. The default value
        /// is 0 seconds (PT0S).
        /// </summary>
        [JsonProperty(PropertyName = "pauseTimeBetweenBatches")]
        public string PauseTimeBetweenBatches { get; set; }

        /// <summary>
        /// Gets or sets allow VMSS to ignore AZ boundaries when constructing
        /// upgrade batches. Take into consideration the Update Domain and
        /// maxBatchInstancePercent to determine the batch size.
        /// </summary>
        [JsonProperty(PropertyName = "enableCrossZoneUpgrade")]
        public bool? EnableCrossZoneUpgrade { get; set; }

        /// <summary>
        /// Gets or sets upgrade all unhealthy instances in a scale set before
        /// any healthy instances.
        /// </summary>
        [JsonProperty(PropertyName = "prioritizeUnhealthyInstances")]
        public bool? PrioritizeUnhealthyInstances { get; set; }

        /// <summary>
        /// Gets or sets rollback failed instances to previous model if the
        /// Rolling Upgrade policy is violated.
        /// </summary>
        [JsonProperty(PropertyName = "rollbackFailedInstancesOnPolicyBreach")]
        public bool? RollbackFailedInstancesOnPolicyBreach { get; set; }

        /// <summary>
        /// Gets or sets create new virtual machines to upgrade the scale set,
        /// rather than updating the existing virtual machines. Existing
        /// virtual machines will be deleted once the new virtual machines are
        /// created for each batch.
        /// </summary>
        [JsonProperty(PropertyName = "maxSurge")]
        public bool? MaxSurge { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxBatchInstancePercent != null)
            {
                if (MaxBatchInstancePercent > 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxBatchInstancePercent", 100);
                }
                if (MaxBatchInstancePercent < 5)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxBatchInstancePercent", 5);
                }
            }
            if (MaxUnhealthyInstancePercent != null)
            {
                if (MaxUnhealthyInstancePercent > 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxUnhealthyInstancePercent", 100);
                }
                if (MaxUnhealthyInstancePercent < 5)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxUnhealthyInstancePercent", 5);
                }
            }
            if (MaxUnhealthyUpgradedInstancePercent != null)
            {
                if (MaxUnhealthyUpgradedInstancePercent > 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxUnhealthyUpgradedInstancePercent", 100);
                }
            }
        }
    }
}
