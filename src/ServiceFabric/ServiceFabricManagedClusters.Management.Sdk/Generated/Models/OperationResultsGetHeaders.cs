// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    public partial class OperationResultsGetHeaders
    {
        /// <summary>
        /// Initializes a new instance of the OperationResultsGetHeaders class.
        /// </summary>
        public OperationResultsGetHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationResultsGetHeaders class.
        /// </summary>

        /// <param name="location">
        /// </param>
        public OperationResultsGetHeaders(string location = default(string))

        {
            this.Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }
    }
}