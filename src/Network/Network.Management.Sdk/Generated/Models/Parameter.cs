// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for an Action.
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Initializes a new instance of the Parameter class.
        /// </summary>
        public Parameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Parameter class.
        /// </summary>

        /// <param name="routePrefix">List of route prefixes.
        /// </param>

        /// <param name="community">List of BGP communities.
        /// </param>

        /// <param name="asPath">List of AS paths.
        /// </param>
        public Parameter(System.Collections.Generic.IList<string> routePrefix = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> community = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> asPath = default(System.Collections.Generic.IList<string>))

        {
            this.RoutePrefix = routePrefix;
            this.Community = community;
            this.AsPath = asPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of route prefixes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "routePrefix")]
        public System.Collections.Generic.IList<string> RoutePrefix {get; set; }

        /// <summary>
        /// Gets or sets list of BGP communities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "community")]
        public System.Collections.Generic.IList<string> Community {get; set; }

        /// <summary>
        /// Gets or sets list of AS paths.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "asPath")]
        public System.Collections.Generic.IList<string> AsPath {get; set; }
    }
}