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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CommunityGalleryImageVersionsOperations.
    /// </summary>
    public static partial class CommunityGalleryImageVersionsOperationsExtensions
    {
            /// <summary>
            /// List community gallery image versions inside an image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='publicGalleryName'>
            /// The public name of the community gallery.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the community gallery image definition.
            /// </param>
            public static IPage<CommunityGalleryImageVersion> List(this ICommunityGalleryImageVersionsOperations operations, string location, string publicGalleryName, string galleryImageName)
            {
                return operations.ListAsync(location, publicGalleryName, galleryImageName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List community gallery image versions inside an image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='publicGalleryName'>
            /// The public name of the community gallery.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the community gallery image definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CommunityGalleryImageVersion>> ListAsync(this ICommunityGalleryImageVersionsOperations operations, string location, string publicGalleryName, string galleryImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, publicGalleryName, galleryImageName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a community gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='publicGalleryName'>
            /// The public name of the community gallery.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the community gallery image definition.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the community gallery image version. Needs to follow semantic
            /// version name pattern: The allowed characters are digit and period. Digits
            /// must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            public static CommunityGalleryImageVersion Get(this ICommunityGalleryImageVersionsOperations operations, string location, string publicGalleryName, string galleryImageName, string galleryImageVersionName)
            {
                return operations.GetAsync(location, publicGalleryName, galleryImageName, galleryImageVersionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a community gallery image version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='publicGalleryName'>
            /// The public name of the community gallery.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the community gallery image definition.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the community gallery image version. Needs to follow semantic
            /// version name pattern: The allowed characters are digit and period. Digits
            /// must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CommunityGalleryImageVersion> GetAsync(this ICommunityGalleryImageVersionsOperations operations, string location, string publicGalleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, publicGalleryName, galleryImageName, galleryImageVersionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List community gallery image versions inside an image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CommunityGalleryImageVersion> ListNext(this ICommunityGalleryImageVersionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List community gallery image versions inside an image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CommunityGalleryImageVersion>> ListNextAsync(this ICommunityGalleryImageVersionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
