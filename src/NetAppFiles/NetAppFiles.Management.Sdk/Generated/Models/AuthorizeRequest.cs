// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Authorize request
    /// </summary>
    public partial class AuthorizeRequest
    {
        /// <summary>
        /// Initializes a new instance of the AuthorizeRequest class.
        /// </summary>
        public AuthorizeRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizeRequest class.
        /// </summary>

        /// <param name="remoteVolumeResourceId">Resource id of the remote volume
        /// </param>
        public AuthorizeRequest(string remoteVolumeResourceId = default(string))

        {
            this.RemoteVolumeResourceId = remoteVolumeResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource id of the remote volume
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "remoteVolumeResourceId")]
        public string RemoteVolumeResourceId {get; set; }
    }
}