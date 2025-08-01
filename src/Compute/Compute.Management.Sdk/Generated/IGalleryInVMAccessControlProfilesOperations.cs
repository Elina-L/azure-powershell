// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GalleryInVMAccessControlProfilesOperations operations.
    /// </summary>
    public partial interface IGalleryInVMAccessControlProfilesOperations
    {
        /// <summary>
        /// List gallery inVMAccessControlProfiles in a gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<GalleryInVMAccessControlProfile>>> ListByGalleryWithHttpMessagesAsync(string resourceGroupName, string galleryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves information about a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GalleryInVMAccessControlProfile>> GetWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
        /// </param>
        /// <param name='galleryInVMAccessControlProfile'>
        /// Parameters supplied to the create or update gallery
        /// inVMAccessControlProfile operation.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GalleryInVMAccessControlProfile,GalleryInVMAccessControlProfilesCreateOrUpdateHeaders>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, GalleryInVMAccessControlProfile galleryInVMAccessControlProfile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
        /// </param>
        /// <param name='galleryInVMAccessControlProfile'>
        /// Parameters supplied to the update gallery inVMAccessControlProfile
        /// operation.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GalleryInVMAccessControlProfile,GalleryInVMAccessControlProfilesUpdateHeaders>> UpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, GalleryInVMAccessControlProfileUpdate galleryInVMAccessControlProfile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<GalleryInVMAccessControlProfilesDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
        /// </param>
        /// <param name='galleryInVMAccessControlProfile'>
        /// Parameters supplied to the create or update gallery
        /// inVMAccessControlProfile operation.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GalleryInVMAccessControlProfile,GalleryInVMAccessControlProfilesCreateOrUpdateHeaders>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, GalleryInVMAccessControlProfile galleryInVMAccessControlProfile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
        /// </param>
        /// <param name='galleryInVMAccessControlProfile'>
        /// Parameters supplied to the update gallery inVMAccessControlProfile
        /// operation.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GalleryInVMAccessControlProfile,GalleryInVMAccessControlProfilesUpdateHeaders>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, GalleryInVMAccessControlProfileUpdate galleryInVMAccessControlProfile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a gallery inVMAccessControlProfile.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='inVMAccessControlProfileName'>
        /// The name of the gallery inVMAccessControlProfile to be retrieved.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<GalleryInVMAccessControlProfilesDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string galleryName, string inVMAccessControlProfileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List gallery inVMAccessControlProfiles in a gallery.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<GalleryInVMAccessControlProfile>>> ListByGalleryNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
