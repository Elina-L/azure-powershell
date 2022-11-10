// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The health status of the VM.
    /// </summary>
    public partial class VirtualMachineHealthStatus
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineHealthStatus class.
        /// </summary>
        public VirtualMachineHealthStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineHealthStatus class.
        /// </summary>
        /// <param name="status">The health status information for the
        /// VM.</param>
        public VirtualMachineHealthStatus(InstanceViewStatus status = default(InstanceViewStatus))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the health status information for the VM.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InstanceViewStatus Status { get; private set; }

    }
}
