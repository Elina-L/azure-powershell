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
    /// The parameters supplied to the update module operation.
    /// </summary>
    public partial class PythonPackageUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the PythonPackageUpdateParameters
        /// class.
        /// </summary>
        public PythonPackageUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PythonPackageUpdateParameters
        /// class.
        /// </summary>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public PythonPackageUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
