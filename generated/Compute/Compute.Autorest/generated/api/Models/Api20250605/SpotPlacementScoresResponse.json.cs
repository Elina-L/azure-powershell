// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>SpotPlacementScores API response.</summary>
    public partial class SpotPlacementScoresResponse
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ISpotPlacementScoresResponse FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json ? new SpotPlacementScoresResponse(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject into a new instance of <see cref="SpotPlacementScoresResponse" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SpotPlacementScoresResponse(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_desiredLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray>("desiredLocations"), out var __jsonDesiredLocations) ? If( __jsonDesiredLocations as Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : DesiredLocation;}
            {_desiredSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray>("desiredSizes"), out var __jsonDesiredSizes) ? If( __jsonDesiredSizes as Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IResourceSize[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IResourceSize) (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.ResourceSize.FromJson(__p) )) ))() : null : DesiredSize;}
            {_desiredCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNumber>("desiredCount"), out var __jsonDesiredCount) ? (int?)__jsonDesiredCount : DesiredCount;}
            {_availabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonBoolean>("availabilityZones"), out var __jsonAvailabilityZones) ? (bool?)__jsonAvailabilityZones : AvailabilityZone;}
            {_placementScore = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray>("placementScores"), out var __jsonPlacementScores) ? If( __jsonPlacementScores as Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IPlacementScore[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.IPlacementScore) (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20250605.PlacementScore.FromJson(__k) )) ))() : null : PlacementScore;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SpotPlacementScoresResponse" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SpotPlacementScoresResponse" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._desiredLocation)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.XNodeArray();
                foreach( var __x in this._desiredLocation )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("desiredLocations",__w);
            }
            if (null != this._desiredSize)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.XNodeArray();
                foreach( var __s in this._desiredSize )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("desiredSizes",__r);
            }
            AddIf( null != this._desiredCount ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNumber((int)this._desiredCount) : null, "desiredCount" ,container.Add );
            AddIf( null != this._availabilityZone ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonBoolean((bool)this._availabilityZone) : null, "availabilityZones" ,container.Add );
            if (null != this._placementScore)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.XNodeArray();
                foreach( var __n in this._placementScore )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("placementScores",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}