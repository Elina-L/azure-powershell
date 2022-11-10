// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Update specific properties of the software update configuration.
    /// </summary>
    public partial class UpdateConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the UpdateConfiguration class.
        /// </summary>
        public UpdateConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateConfiguration class.
        /// </summary>
        /// <param name="operatingSystem">operating system of target machines.
        /// Possible values include: 'Windows', 'Linux'</param>
        /// <param name="windows">Windows specific update
        /// configuration.</param>
        /// <param name="linux">Linux specific update configuration.</param>
        /// <param name="duration">Maximum time allowed for the software update
        /// configuration run. Duration needs to be specified using the format
        /// PT[n]H[n]M[n]S as per ISO8601</param>
        /// <param name="azureVirtualMachines">List of azure resource Ids for
        /// azure virtual machines targeted by the software update
        /// configuration.</param>
        /// <param name="nonAzureComputerNames">List of names of non-azure
        /// machines targeted by the software update configuration.</param>
        /// <param name="targets">Group targets for the software update
        /// configuration.</param>
        public UpdateConfiguration(OperatingSystemType operatingSystem, WindowsProperties windows = default(WindowsProperties), LinuxProperties linux = default(LinuxProperties), System.TimeSpan? duration = default(System.TimeSpan?), IList<string> azureVirtualMachines = default(IList<string>), IList<string> nonAzureComputerNames = default(IList<string>), TargetProperties targets = default(TargetProperties))
        {
            OperatingSystem = operatingSystem;
            Windows = windows;
            Linux = linux;
            Duration = duration;
            AzureVirtualMachines = azureVirtualMachines;
            NonAzureComputerNames = nonAzureComputerNames;
            Targets = targets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operating system of target machines. Possible values
        /// include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystem")]
        public OperatingSystemType OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets windows specific update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "windows")]
        public WindowsProperties Windows { get; set; }

        /// <summary>
        /// Gets or sets linux specific update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "linux")]
        public LinuxProperties Linux { get; set; }

        /// <summary>
        /// Gets or sets maximum time allowed for the software update
        /// configuration run. Duration needs to be specified using the format
        /// PT[n]H[n]M[n]S as per ISO8601
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets list of azure resource Ids for azure virtual machines
        /// targeted by the software update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "azureVirtualMachines")]
        public IList<string> AzureVirtualMachines { get; set; }

        /// <summary>
        /// Gets or sets list of names of non-azure machines targeted by the
        /// software update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "nonAzureComputerNames")]
        public IList<string> NonAzureComputerNames { get; set; }

        /// <summary>
        /// Gets or sets group targets for the software update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "targets")]
        public TargetProperties Targets { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
