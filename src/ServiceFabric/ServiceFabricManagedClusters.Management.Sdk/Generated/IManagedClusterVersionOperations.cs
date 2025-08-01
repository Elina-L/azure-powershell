// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ManagedClusterVersionOperations operations.
    /// </summary>
    public partial interface IManagedClusterVersionOperations
    {
        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by
        /// environment.
        /// </summary>
        /// <remarks>
        /// Gets all available code versions for Service Fabric cluster resources by
        /// environment.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from cluster
        /// location.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IList<ManagedClusterCodeVersionResult>>> ListByEnvironmentWithHttpMessagesAsync(string location, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by
        /// environment.
        /// </summary>
        /// <remarks>
        /// Gets information about an available Service Fabric cluster code version by
        /// environment.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from cluster
        /// location.
        /// </param>
        /// <param name='clusterVersion'>
        /// The cluster code version.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagedClusterCodeVersionResult>> GetByEnvironmentWithHttpMessagesAsync(string location, string clusterVersion, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by
        /// location.
        /// </summary>
        /// <remarks>
        /// Gets all available code versions for Service Fabric cluster resources by
        /// location.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from cluster
        /// location.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IList<ManagedClusterCodeVersionResult>>> ListWithHttpMessagesAsync(string location, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets information about an available Service Fabric managed cluster code
        /// version.
        /// </summary>
        /// <remarks>
        /// Gets information about an available Service Fabric managed cluster code
        /// version.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from cluster
        /// location.
        /// </param>
        /// <param name='clusterVersion'>
        /// The cluster code version.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagedClusterCodeVersionResult>> GetWithHttpMessagesAsync(string location, string clusterVersion, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}