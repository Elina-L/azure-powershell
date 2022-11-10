// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The provisioning state</summary>
    public partial struct WorkloadNetworkPublicIPProvisioningState :
        System.IEquatable<WorkloadNetworkPublicIPProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState Building = @"Building";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="WorkloadNetworkPublicIPProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WorkloadNetworkPublicIPProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkPublicIPProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WorkloadNetworkPublicIPProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WorkloadNetworkPublicIPProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type WorkloadNetworkPublicIPProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WorkloadNetworkPublicIPProvisioningState && Equals((WorkloadNetworkPublicIPProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum WorkloadNetworkPublicIPProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WorkloadNetworkPublicIPProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="WorkloadNetworkPublicIPProvisioningState"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WorkloadNetworkPublicIPProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WorkloadNetworkPublicIPProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkPublicIPProvisioningState" />.</param>

        public static implicit operator WorkloadNetworkPublicIPProvisioningState(string value)
        {
            return new WorkloadNetworkPublicIPProvisioningState(value);
        }

        /// <summary>Implicit operator to convert WorkloadNetworkPublicIPProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WorkloadNetworkPublicIPProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WorkloadNetworkPublicIPProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WorkloadNetworkPublicIPProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPublicIPProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}