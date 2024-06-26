// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// InMageRcm mobility agent details.
    /// </summary>
    public partial class InMageRcmMobilityAgentDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmMobilityAgentDetails class.
        /// </summary>
        public InMageRcmMobilityAgentDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmMobilityAgentDetails class.
        /// </summary>

        /// <param name="version">The agent version.
        /// </param>

        /// <param name="latestVersion">The latest agent version available.
        /// </param>

        /// <param name="latestAgentReleaseDate">The latest agent version release date.
        /// </param>

        /// <param name="driverVersion">The driver version.
        /// </param>

        /// <param name="latestUpgradableVersionWithoutReboot">The latest upgradeable version available without reboot.
        /// </param>

        /// <param name="agentVersionExpiryDate">The agent version expiry date.
        /// </param>

        /// <param name="driverVersionExpiryDate">The driver version expiry date.
        /// </param>

        /// <param name="lastHeartbeatUtc">The time of the last heartbeat received from the agent.
        /// </param>

        /// <param name="reasonsBlockingUpgrade">The whether update is possible or not.
        /// </param>

        /// <param name="isUpgradeable">A value indicating whether agent is upgradeable or not.
        /// </param>
        public InMageRcmMobilityAgentDetails(string version = default(string), string latestVersion = default(string), string latestAgentReleaseDate = default(string), string driverVersion = default(string), string latestUpgradableVersionWithoutReboot = default(string), System.DateTime? agentVersionExpiryDate = default(System.DateTime?), System.DateTime? driverVersionExpiryDate = default(System.DateTime?), System.DateTime? lastHeartbeatUtc = default(System.DateTime?), System.Collections.Generic.IList<string> reasonsBlockingUpgrade = default(System.Collections.Generic.IList<string>), string isUpgradeable = default(string))

        {
            this.Version = version;
            this.LatestVersion = latestVersion;
            this.LatestAgentReleaseDate = latestAgentReleaseDate;
            this.DriverVersion = driverVersion;
            this.LatestUpgradableVersionWithoutReboot = latestUpgradableVersionWithoutReboot;
            this.AgentVersionExpiryDate = agentVersionExpiryDate;
            this.DriverVersionExpiryDate = driverVersionExpiryDate;
            this.LastHeartbeatUtc = lastHeartbeatUtc;
            this.ReasonsBlockingUpgrade = reasonsBlockingUpgrade;
            this.IsUpgradeable = isUpgradeable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the agent version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version {get; private set; }

        /// <summary>
        /// Gets the latest agent version available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "latestVersion")]
        public string LatestVersion {get; private set; }

        /// <summary>
        /// Gets the latest agent version release date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "latestAgentReleaseDate")]
        public string LatestAgentReleaseDate {get; private set; }

        /// <summary>
        /// Gets the driver version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "driverVersion")]
        public string DriverVersion {get; private set; }

        /// <summary>
        /// Gets the latest upgradeable version available without reboot.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "latestUpgradableVersionWithoutReboot")]
        public string LatestUpgradableVersionWithoutReboot {get; private set; }

        /// <summary>
        /// Gets the agent version expiry date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "agentVersionExpiryDate")]
        public System.DateTime? AgentVersionExpiryDate {get; private set; }

        /// <summary>
        /// Gets the driver version expiry date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "driverVersionExpiryDate")]
        public System.DateTime? DriverVersionExpiryDate {get; private set; }

        /// <summary>
        /// Gets the time of the last heartbeat received from the agent.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastHeartbeatUtc")]
        public System.DateTime? LastHeartbeatUtc {get; private set; }

        /// <summary>
        /// Gets the whether update is possible or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reasonsBlockingUpgrade")]
        public System.Collections.Generic.IList<string> ReasonsBlockingUpgrade {get; private set; }

        /// <summary>
        /// Gets a value indicating whether agent is upgradeable or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isUpgradeable")]
        public string IsUpgradeable {get; private set; }
    }
}