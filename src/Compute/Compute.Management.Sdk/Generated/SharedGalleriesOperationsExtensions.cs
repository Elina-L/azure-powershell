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
    /// Extension methods for SharedGalleriesOperations.
    /// </summary>
    public static partial class SharedGalleriesOperationsExtensions
    {
            /// <summary>
            /// List shared galleries by subscription id or tenant id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='sharedTo'>
            /// The query parameter to decide what shared galleries to fetch when doing
            /// listing operations. Possible values include: 'tenant'
            /// </param>
            public static IPage<SharedGallery> List(this ISharedGalleriesOperations operations, string location, string sharedTo = default(string))
            {
                return operations.ListAsync(location, sharedTo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List shared galleries by subscription id or tenant id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='sharedTo'>
            /// The query parameter to decide what shared galleries to fetch when doing
            /// listing operations. Possible values include: 'tenant'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedGallery>> ListAsync(this ISharedGalleriesOperations operations, string location, string sharedTo = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, sharedTo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a shared gallery by subscription id or tenant id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='galleryUniqueName'>
            /// The unique name of the Shared Gallery.
            /// </param>
            public static SharedGallery Get(this ISharedGalleriesOperations operations, string location, string galleryUniqueName)
            {
                return operations.GetAsync(location, galleryUniqueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a shared gallery by subscription id or tenant id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='galleryUniqueName'>
            /// The unique name of the Shared Gallery.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedGallery> GetAsync(this ISharedGalleriesOperations operations, string location, string galleryUniqueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, galleryUniqueName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List shared galleries by subscription id or tenant id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedGallery> ListNext(this ISharedGalleriesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List shared galleries by subscription id or tenant id.
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
            public static async Task<IPage<SharedGallery>> ListNextAsync(this ISharedGalleriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
