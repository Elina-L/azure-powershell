// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Extensions;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    public partial class SystemData
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject json ? new SystemData(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject into a new instance of <see cref="SystemData" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemData(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_createdBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString>("createdBy"), out var __jsonCreatedBy) ? (string)__jsonCreatedBy : (string)_createdBy;}
            {_createdByType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString>("createdByType"), out var __jsonCreatedByType) ? (string)__jsonCreatedByType : (string)_createdByType;}
            {_createdAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString>("createdAt"), out var __jsonCreatedAt) ? global::System.DateTime.TryParse((string)__jsonCreatedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedAtValue) ? __jsonCreatedAtValue : _createdAt : _createdAt;}
            {_lastModifiedBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString>("lastModifiedBy"), out var __jsonLastModifiedBy) ? (string)__jsonLastModifiedBy : (string)_lastModifiedBy;}
            {_lastModifiedByType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString>("lastModifiedByType"), out var __jsonLastModifiedByType) ? (string)__jsonLastModifiedByType : (string)_lastModifiedByType;}
            {_lastModifiedAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString>("lastModifiedAt"), out var __jsonLastModifiedAt) ? global::System.DateTime.TryParse((string)__jsonLastModifiedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedAtValue) ? __jsonLastModifiedAtValue : _lastModifiedAt : _lastModifiedAt;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemData" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemData" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._createdBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString(this._createdBy.ToString()) : null, "createdBy" ,container.Add );
            AddIf( null != (((object)this._createdByType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString(this._createdByType.ToString()) : null, "createdByType" ,container.Add );
            AddIf( null != this._createdAt ? (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString(this._createdAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "createdAt" ,container.Add );
            AddIf( null != (((object)this._lastModifiedBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString(this._lastModifiedBy.ToString()) : null, "lastModifiedBy" ,container.Add );
            AddIf( null != (((object)this._lastModifiedByType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString(this._lastModifiedByType.ToString()) : null, "lastModifiedByType" ,container.Add );
            AddIf( null != this._lastModifiedAt ? (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonString(this._lastModifiedAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedAt" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}