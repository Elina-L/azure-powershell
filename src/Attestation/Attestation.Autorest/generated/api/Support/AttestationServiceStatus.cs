// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support
{

    /// <summary>Status of attestation service.</summary>
    public partial struct AttestationServiceStatus :
        System.IEquatable<AttestationServiceStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus Error = @"Error";

        public static Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus NotReady = @"NotReady";

        public static Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus Ready = @"Ready";

        /// <summary>the value for an instance of the <see cref="AttestationServiceStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AttestationServiceStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AttestationServiceStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AttestationServiceStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AttestationServiceStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AttestationServiceStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AttestationServiceStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AttestationServiceStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AttestationServiceStatus && Equals((AttestationServiceStatus)obj);
        }

        /// <summary>Returns hashCode for enum AttestationServiceStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AttestationServiceStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AttestationServiceStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AttestationServiceStatus" />.</param>

        public static implicit operator AttestationServiceStatus(string value)
        {
            return new AttestationServiceStatus(value);
        }

        /// <summary>Implicit operator to convert AttestationServiceStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AttestationServiceStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AttestationServiceStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AttestationServiceStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Attestation.Support.AttestationServiceStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}