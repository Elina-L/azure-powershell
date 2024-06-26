// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cloud endpoint change enumeration status object
    /// </summary>
    public partial class CloudEndpointLastChangeEnumerationStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CloudEndpointLastChangeEnumerationStatus class.
        /// </summary>
        public CloudEndpointLastChangeEnumerationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CloudEndpointLastChangeEnumerationStatus class.
        /// </summary>
        /// <param name="startedTimestamp">Timestamp when change enumeration
        /// started</param>
        /// <param name="completedTimestamp">Timestamp when change enumeration
        /// completed</param>
        /// <param name="namespaceFilesCount">Count of files in the
        /// namespace</param>
        /// <param name="namespaceDirectoriesCount">Count of directories in the
        /// namespace</param>
        /// <param name="namespaceSizeBytes">Namespace size in bytes</param>
        /// <param name="nextRunTimestamp">Timestamp of when change enumeration
        /// is expected to run again</param>
        public CloudEndpointLastChangeEnumerationStatus(System.DateTime? startedTimestamp = default(System.DateTime?), System.DateTime? completedTimestamp = default(System.DateTime?), long? namespaceFilesCount = default(long?), long? namespaceDirectoriesCount = default(long?), long? namespaceSizeBytes = default(long?), System.DateTime? nextRunTimestamp = default(System.DateTime?))
        {
            StartedTimestamp = startedTimestamp;
            CompletedTimestamp = completedTimestamp;
            NamespaceFilesCount = namespaceFilesCount;
            NamespaceDirectoriesCount = namespaceDirectoriesCount;
            NamespaceSizeBytes = namespaceSizeBytes;
            NextRunTimestamp = nextRunTimestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets timestamp when change enumeration started
        /// </summary>
        [JsonProperty(PropertyName = "startedTimestamp")]
        public System.DateTime? StartedTimestamp { get; private set; }

        /// <summary>
        /// Gets timestamp when change enumeration completed
        /// </summary>
        [JsonProperty(PropertyName = "completedTimestamp")]
        public System.DateTime? CompletedTimestamp { get; private set; }

        /// <summary>
        /// Gets count of files in the namespace
        /// </summary>
        [JsonProperty(PropertyName = "namespaceFilesCount")]
        public long? NamespaceFilesCount { get; private set; }

        /// <summary>
        /// Gets count of directories in the namespace
        /// </summary>
        [JsonProperty(PropertyName = "namespaceDirectoriesCount")]
        public long? NamespaceDirectoriesCount { get; private set; }

        /// <summary>
        /// Gets namespace size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "namespaceSizeBytes")]
        public long? NamespaceSizeBytes { get; private set; }

        /// <summary>
        /// Gets timestamp of when change enumeration is expected to run again
        /// </summary>
        [JsonProperty(PropertyName = "nextRunTimestamp")]
        public System.DateTime? NextRunTimestamp { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NamespaceFilesCount != null)
            {
                if (NamespaceFilesCount < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "NamespaceFilesCount", 0);
                }
            }
            if (NamespaceDirectoriesCount != null)
            {
                if (NamespaceDirectoriesCount < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "NamespaceDirectoriesCount", 0);
                }
            }
            if (NamespaceSizeBytes != null)
            {
                if (NamespaceSizeBytes < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "NamespaceSizeBytes", 0);
                }
            }
        }
    }
}
