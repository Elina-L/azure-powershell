// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Fabric agent model.</summary>
    public partial class FabricAgentModel :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModel,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGenerated __resourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ResourceAutoGenerated();

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModelProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.FabricAgentModelProperties()); set => this._property = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="FabricAgentModel" /> instance.</summary>
        public FabricAgentModel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
        }
    }
    /// Fabric agent model.
    public partial interface IFabricAgentModel :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGenerated
    {
        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource-specific properties for this resource.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModelProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModelProperties Property { get; set; }

    }
    /// Fabric agent model.
    internal partial interface IFabricAgentModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal
    {
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricAgentModelProperties Property { get; set; }

    }
}