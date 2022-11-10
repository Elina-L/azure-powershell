// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Process entity property bag.</summary>
    public partial class ProcessEntityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties __entityCommonProperties = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityCommonProperties();

        /// <summary>Backing field for <see cref="AccountEntityId" /> property.</summary>
        private string _accountEntityId;

        /// <summary>The account entity id running the processes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string AccountEntityId { get => this._accountEntityId; }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData; }

        /// <summary>Backing field for <see cref="CommandLine" /> property.</summary>
        private string _commandLine;

        /// <summary>The command line used to create the process</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string CommandLine { get => this._commandLine; }

        /// <summary>Backing field for <see cref="CreationTimeUtc" /> property.</summary>
        private global::System.DateTime? _creationTimeUtc;

        /// <summary>The time when the process started to run</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? CreationTimeUtc { get => this._creationTimeUtc; }

        /// <summary>Backing field for <see cref="ElevationToken" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ElevationToken? _elevationToken;

        /// <summary>The elevation token associated with the process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ElevationToken? ElevationToken { get => this._elevationToken; set => this._elevationToken = value; }

        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is
        /// optional and might be system generated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName; }

        /// <summary>Backing field for <see cref="HostEntityId" /> property.</summary>
        private string _hostEntityId;

        /// <summary>The host entity id on which the process was running</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string HostEntityId { get => this._hostEntityId; }

        /// <summary>Backing field for <see cref="HostLogonSessionEntityId" /> property.</summary>
        private string _hostLogonSessionEntityId;

        /// <summary>The session entity id in which the process was running</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string HostLogonSessionEntityId { get => this._hostLogonSessionEntityId; }

        /// <summary>Backing field for <see cref="ImageFileEntityId" /> property.</summary>
        private string _imageFileEntityId;

        /// <summary>Image file entity id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ImageFileEntityId { get => this._imageFileEntityId; }

        /// <summary>Internal Acessors for AdditionalData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal.AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName = value; }

        /// <summary>Internal Acessors for AccountEntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.AccountEntityId { get => this._accountEntityId; set { {_accountEntityId = value;} } }

        /// <summary>Internal Acessors for CommandLine</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.CommandLine { get => this._commandLine; set { {_commandLine = value;} } }

        /// <summary>Internal Acessors for CreationTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.CreationTimeUtc { get => this._creationTimeUtc; set { {_creationTimeUtc = value;} } }

        /// <summary>Internal Acessors for HostEntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.HostEntityId { get => this._hostEntityId; set { {_hostEntityId = value;} } }

        /// <summary>Internal Acessors for HostLogonSessionEntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.HostLogonSessionEntityId { get => this._hostLogonSessionEntityId; set { {_hostLogonSessionEntityId = value;} } }

        /// <summary>Internal Acessors for ImageFileEntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.ImageFileEntityId { get => this._imageFileEntityId; set { {_imageFileEntityId = value;} } }

        /// <summary>Internal Acessors for ParentProcessEntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.ParentProcessEntityId { get => this._parentProcessEntityId; set { {_parentProcessEntityId = value;} } }

        /// <summary>Internal Acessors for ProcessId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IProcessEntityPropertiesInternal.ProcessId { get => this._processId; set { {_processId = value;} } }

        /// <summary>Backing field for <see cref="ParentProcessEntityId" /> property.</summary>
        private string _parentProcessEntityId;

        /// <summary>The parent process entity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ParentProcessEntityId { get => this._parentProcessEntityId; }

        /// <summary>Backing field for <see cref="ProcessId" /> property.</summary>
        private string _processId;

        /// <summary>The process ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ProcessId { get => this._processId; }

        /// <summary>Creates an new <see cref="ProcessEntityProperties" /> instance.</summary>
        public ProcessEntityProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entityCommonProperties), __entityCommonProperties);
            await eventListener.AssertObjectIsValid(nameof(__entityCommonProperties), __entityCommonProperties);
        }
    }
    /// Process entity property bag.
    public partial interface IProcessEntityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties
    {
        /// <summary>The account entity id running the processes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The account entity id running the processes.",
        SerializedName = @"accountEntityId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountEntityId { get;  }
        /// <summary>The command line used to create the process</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The command line used to create the process",
        SerializedName = @"commandLine",
        PossibleTypes = new [] { typeof(string) })]
        string CommandLine { get;  }
        /// <summary>The time when the process started to run</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time when the process started to run",
        SerializedName = @"creationTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationTimeUtc { get;  }
        /// <summary>The elevation token associated with the process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The elevation token associated with the process.",
        SerializedName = @"elevationToken",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ElevationToken) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ElevationToken? ElevationToken { get; set; }
        /// <summary>The host entity id on which the process was running</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The host entity id on which the process was running",
        SerializedName = @"hostEntityId",
        PossibleTypes = new [] { typeof(string) })]
        string HostEntityId { get;  }
        /// <summary>The session entity id in which the process was running</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The session entity id in which the process was running",
        SerializedName = @"hostLogonSessionEntityId",
        PossibleTypes = new [] { typeof(string) })]
        string HostLogonSessionEntityId { get;  }
        /// <summary>Image file entity id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Image file entity id",
        SerializedName = @"imageFileEntityId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageFileEntityId { get;  }
        /// <summary>The parent process entity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The parent process entity id.",
        SerializedName = @"parentProcessEntityId",
        PossibleTypes = new [] { typeof(string) })]
        string ParentProcessEntityId { get;  }
        /// <summary>The process ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process ID",
        SerializedName = @"processId",
        PossibleTypes = new [] { typeof(string) })]
        string ProcessId { get;  }

    }
    /// Process entity property bag.
    internal partial interface IProcessEntityPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal
    {
        /// <summary>The account entity id running the processes.</summary>
        string AccountEntityId { get; set; }
        /// <summary>The command line used to create the process</summary>
        string CommandLine { get; set; }
        /// <summary>The time when the process started to run</summary>
        global::System.DateTime? CreationTimeUtc { get; set; }
        /// <summary>The elevation token associated with the process.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ElevationToken? ElevationToken { get; set; }
        /// <summary>The host entity id on which the process was running</summary>
        string HostEntityId { get; set; }
        /// <summary>The session entity id in which the process was running</summary>
        string HostLogonSessionEntityId { get; set; }
        /// <summary>Image file entity id</summary>
        string ImageFileEntityId { get; set; }
        /// <summary>The parent process entity id.</summary>
        string ParentProcessEntityId { get; set; }
        /// <summary>The process ID</summary>
        string ProcessId { get; set; }

    }
}