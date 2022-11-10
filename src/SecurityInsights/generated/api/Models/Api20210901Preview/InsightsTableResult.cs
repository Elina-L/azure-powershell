// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Query results for table insights query.</summary>
    public partial class InsightsTableResult :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResult,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultInternal
    {

        /// <summary>Backing field for <see cref="Column" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem[] _column;

        /// <summary>Columns Metadata of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem[] Column { get => this._column; set => this._column = value; }

        /// <summary>Backing field for <see cref="Row" /> property.</summary>
        private string[][] _row;

        /// <summary>Rows data of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[][] Row { get => this._row; set => this._row = value; }

        /// <summary>Creates an new <see cref="InsightsTableResult" /> instance.</summary>
        public InsightsTableResult()
        {

        }
    }
    /// Query results for table insights query.
    public partial interface IInsightsTableResult :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Columns Metadata of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Columns Metadata of the table",
        SerializedName = @"columns",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem[] Column { get; set; }
        /// <summary>Rows data of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Rows data of the table",
        SerializedName = @"rows",
        PossibleTypes = new [] { typeof(string) })]
        string[][] Row { get; set; }

    }
    /// Query results for table insights query.
    internal partial interface IInsightsTableResultInternal

    {
        /// <summary>Columns Metadata of the table</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IInsightsTableResultColumnsItem[] Column { get; set; }
        /// <summary>Rows data of the table</summary>
        string[][] Row { get; set; }

    }
}