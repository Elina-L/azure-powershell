// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Entity timeline Item.</summary>
    public partial class EntityTimelineItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItem,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityTimelineItemInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind _kind;

        /// <summary>The entity query kind type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Creates an new <see cref="EntityTimelineItem" /> instance.</summary>
        public EntityTimelineItem()
        {

        }
    }
    /// Entity timeline Item.
    public partial interface IEntityTimelineItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>The entity query kind type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The entity query kind type.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get; set; }

    }
    /// Entity timeline Item.
    internal partial interface IEntityTimelineItemInternal

    {
        /// <summary>The entity query kind type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTimelineKind Kind { get; set; }

    }
}