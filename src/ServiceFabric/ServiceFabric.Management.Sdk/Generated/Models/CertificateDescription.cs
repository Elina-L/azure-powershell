// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the certificate details.
    /// </summary>
    public partial class CertificateDescription
    {
        /// <summary>
        /// Initializes a new instance of the CertificateDescription class.
        /// </summary>
        public CertificateDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateDescription class.
        /// </summary>

        /// <param name="thumbprint">Thumbprint of the primary certificate.
        /// </param>

        /// <param name="thumbprintSecondary">Thumbprint of the secondary certificate.
        /// </param>

        /// <param name="x509StoreName">The local certificate store location.
        /// Possible values include: &#39;AddressBook&#39;, &#39;AuthRoot&#39;, &#39;CertificateAuthority&#39;,
        /// &#39;Disallowed&#39;, &#39;My&#39;, &#39;Root&#39;, &#39;TrustedPeople&#39;, &#39;TrustedPublisher&#39;</param>
        public CertificateDescription(string thumbprint, string thumbprintSecondary = default(string), string x509StoreName = default(string))

        {
            this.Thumbprint = thumbprint;
            this.ThumbprintSecondary = thumbprintSecondary;
            this.X509StoreName = x509StoreName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets thumbprint of the primary certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint {get; set; }

        /// <summary>
        /// Gets or sets thumbprint of the secondary certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "thumbprintSecondary")]
        public string ThumbprintSecondary {get; set; }

        /// <summary>
        /// Gets or sets the local certificate store location. Possible values include: &#39;AddressBook&#39;, &#39;AuthRoot&#39;, &#39;CertificateAuthority&#39;, &#39;Disallowed&#39;, &#39;My&#39;, &#39;Root&#39;, &#39;TrustedPeople&#39;, &#39;TrustedPublisher&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "x509StoreName")]
        public string X509StoreName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Thumbprint == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Thumbprint");
            }



        }
    }
}