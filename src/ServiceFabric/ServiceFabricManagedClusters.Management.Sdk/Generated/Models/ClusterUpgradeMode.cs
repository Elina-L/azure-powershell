// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{

    /// <summary>
    /// Defines values for ClusterUpgradeMode.
    /// </summary>


    public static class ClusterUpgradeMode
    {
        /// <summary>
        /// The cluster will be automatically upgraded to the latest Service Fabric
        /// runtime version, **clusterUpgradeCadence** will determine when the upgrade
        /// starts after the new version becomes available.
        /// </summary>
        public const string Automatic = "Automatic";
        /// <summary>
        /// The cluster will not be automatically upgraded to the latest Service Fabric
        /// runtime version. The cluster is upgraded by setting the
        /// **clusterCodeVersion** property in the cluster resource.
        /// </summary>
        public const string Manual = "Manual";
    }
}