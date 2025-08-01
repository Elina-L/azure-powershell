// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{

    /// <summary>
    /// Defines values for NotificationChannel.
    /// </summary>


    public static class NotificationChannel
    {
        /// <summary>
        /// For email user receivers. In this case, the parameter receivers should be a
        /// list of email addresses that will receive the notifications.
        /// </summary>
        public const string EmailUser = "EmailUser";
        /// <summary>
        /// For subscription receivers. In this case, the parameter receivers should be
        /// a list of roles of the subscription for the cluster (eg. Owner,
        /// AccountAdmin, etc) that will receive the notifications.
        /// </summary>
        public const string EmailSubscription = "EmailSubscription";
    }
}