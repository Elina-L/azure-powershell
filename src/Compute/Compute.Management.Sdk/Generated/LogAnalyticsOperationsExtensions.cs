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
    /// Extension methods for LogAnalyticsOperations.
    /// </summary>
    public static partial class LogAnalyticsOperationsExtensions
    {
            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            public static LogAnalyticsOperationResult ExportRequestRateByInterval(this ILogAnalyticsOperations operations, string location, RequestRateByIntervalInput parameters)
            {
                return operations.ExportRequestRateByIntervalAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> ExportRequestRateByIntervalAsync(this ILogAnalyticsOperations operations, string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportRequestRateByIntervalWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// The request body
            /// </param>
            public static LogAnalyticsOperationResult ExportThrottledRequests(this ILogAnalyticsOperations operations, string location, ThrottledRequestsInput parameters)
            {
                return operations.ExportThrottledRequestsAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// The request body
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> ExportThrottledRequestsAsync(this ILogAnalyticsOperations operations, string location, ThrottledRequestsInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportThrottledRequestsWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            public static LogAnalyticsOperationResult BeginExportRequestRateByInterval(this ILogAnalyticsOperations operations, string location, RequestRateByIntervalInput parameters)
            {
                return operations.BeginExportRequestRateByIntervalAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> BeginExportRequestRateByIntervalAsync(this ILogAnalyticsOperations operations, string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginExportRequestRateByIntervalWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// The request body
            /// </param>
            public static LogAnalyticsOperationResult BeginExportThrottledRequests(this ILogAnalyticsOperations operations, string location, ThrottledRequestsInput parameters)
            {
                return operations.BeginExportThrottledRequestsAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of Azure region.
            /// </param>
            /// <param name='parameters'>
            /// The request body
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> BeginExportThrottledRequestsAsync(this ILogAnalyticsOperations operations, string location, ThrottledRequestsInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginExportThrottledRequestsWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
