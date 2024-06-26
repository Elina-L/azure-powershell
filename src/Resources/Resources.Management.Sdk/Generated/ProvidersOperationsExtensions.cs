// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Resources
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ProvidersOperations
    /// </summary>
    public static partial class ProvidersOperationsExtensions
    {
        /// <summary>
        /// Unregisters a subscription from a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider to unregister.
        /// </param>
        public static Provider Unregister(this IProvidersOperations operations, string resourceProviderNamespace)
        {
                return ((IProvidersOperations)operations).UnregisterAsync(resourceProviderNamespace).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Unregisters a subscription from a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider to unregister.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Provider> UnregisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UnregisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Registers a management group with a resource provider. Use this operation
        /// to register a resource provider with resource types that can be deployed at
        /// the management group scope. It does not recursively register subscriptions
        /// within the management group. Instead, you must register subscriptions
        /// individually.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider to register.
        /// </param>
        /// <param name='groupId'>
        /// The management group ID.
        /// </param>
        public static void RegisterAtManagementGroupScope(this IProvidersOperations operations, string resourceProviderNamespace, string groupId)
        {
                ((IProvidersOperations)operations).RegisterAtManagementGroupScopeAsync(resourceProviderNamespace, groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Registers a management group with a resource provider. Use this operation
        /// to register a resource provider with resource types that can be deployed at
        /// the management group scope. It does not recursively register subscriptions
        /// within the management group. Instead, you must register subscriptions
        /// individually.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider to register.
        /// </param>
        /// <param name='groupId'>
        /// The management group ID.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task RegisterAtManagementGroupScopeAsync(this IProvidersOperations operations, string resourceProviderNamespace, string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.RegisterAtManagementGroupScopeWithHttpMessagesAsync(resourceProviderNamespace, groupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Get the provider permissions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        public static ProviderPermissionListResult ProviderPermissions(this IProvidersOperations operations, string resourceProviderNamespace)
        {
                return ((IProvidersOperations)operations).ProviderPermissionsAsync(resourceProviderNamespace).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the provider permissions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ProviderPermissionListResult> ProviderPermissionsAsync(this IProvidersOperations operations, string resourceProviderNamespace, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ProviderPermissionsWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Registers a subscription with a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider to register.
        /// </param>
        public static Provider Register(this IProvidersOperations operations, string resourceProviderNamespace, ProviderRegistrationRequest properties = default(ProviderRegistrationRequest))
        {
                return ((IProvidersOperations)operations).RegisterAsync(resourceProviderNamespace, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Registers a subscription with a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider to register.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Provider> RegisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, ProviderRegistrationRequest properties = default(ProviderRegistrationRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, properties, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all resource providers for a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The properties to include in the results. For example, use
        /// &amp;$expand=metadata in the query string to retrieve resource provider
        /// metadata. To include property aliases in response, use
        /// $expand=resourceTypes/aliases.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Provider> List(this IProvidersOperations operations, string expand = default(string))
        {
                return ((IProvidersOperations)operations).ListAsync(expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all resource providers for a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The properties to include in the results. For example, use
        /// &amp;$expand=metadata in the query string to retrieve resource provider
        /// metadata. To include property aliases in response, use
        /// $expand=resourceTypes/aliases.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Provider>> ListAsync(this IProvidersOperations operations, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all resource providers for the tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The properties to include in the results. For example, use
        /// &amp;$expand=metadata in the query string to retrieve resource provider
        /// metadata. To include property aliases in response, use
        /// $expand=resourceTypes/aliases.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Provider> ListAtTenantScope(this IProvidersOperations operations, string expand = default(string))
        {
                return ((IProvidersOperations)operations).ListAtTenantScopeAsync(expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all resource providers for the tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The properties to include in the results. For example, use
        /// &amp;$expand=metadata in the query string to retrieve resource provider
        /// metadata. To include property aliases in response, use
        /// $expand=resourceTypes/aliases.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Provider>> ListAtTenantScopeAsync(this IProvidersOperations operations, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListAtTenantScopeWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the specified resource provider.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The $expand query parameter. For example, to include property aliases in
        /// response, use $expand=resourceTypes/aliases.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        public static Provider Get(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string))
        {
                return ((IProvidersOperations)operations).GetAsync(resourceProviderNamespace, expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The $expand query parameter. For example, to include property aliases in
        /// response, use $expand=resourceTypes/aliases.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Provider> GetAsync(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the specified resource provider at the tenant level.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The $expand query parameter. For example, to include property aliases in
        /// response, use $expand=resourceTypes/aliases.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        public static Provider GetAtTenantScope(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string))
        {
                return ((IProvidersOperations)operations).GetAtTenantScopeAsync(resourceProviderNamespace, expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified resource provider at the tenant level.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='expand'>
        /// The $expand query parameter. For example, to include property aliases in
        /// response, use $expand=resourceTypes/aliases.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Provider> GetAtTenantScopeAsync(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetAtTenantScopeWithHttpMessagesAsync(resourceProviderNamespace, expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all resource providers for a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Provider> ListNext(this IProvidersOperations operations, string nextPageLink)
        {
                return ((IProvidersOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all resource providers for a subscription.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Provider>> ListNextAsync(this IProvidersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all resource providers for the tenant.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Provider> ListAtTenantScopeNext(this IProvidersOperations operations, string nextPageLink)
        {
                return ((IProvidersOperations)operations).ListAtTenantScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all resource providers for the tenant.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Provider>> ListAtTenantScopeNextAsync(this IProvidersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListAtTenantScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
