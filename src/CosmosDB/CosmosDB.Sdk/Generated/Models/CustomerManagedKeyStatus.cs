// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{

    /// <summary>
    /// Defines values for CustomerManagedKeyStatus.
    /// </summary>
    public static class CustomerManagedKeyStatus
    {
        public const string AccesstoyouraccountiscurrentlyrevokedbecausetheAzureCosmosDBserviceisunabletoobtaintheAADauthenticationtokenfortheaccountsdefaultidentityformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideazureActiveDirectoryTokenAcquisitionError4000 = "Access to your account is currently revoked because the Azure Cosmos DB service is unable to obtain the AAD authentication token for the account's default identity; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#azure-active-directory-token-acquisition-error (4000).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausetheAzureCosmosDBaccountskeyvaultkeyURIdoesnotfollowtheexpectedformatformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideimproperSyntaxDetectedOnTheKeyVaultUriProperty4006 = "Access to your account is currently revoked because the Azure Cosmos DB account's key vault key URI does not follow the expected format; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#improper-syntax-detected-on-the-key-vault-uri-property (4006).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausethecurrentdefaultidentitynolongerhaspermissiontotheassociatedKeyVaultkeyformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuidedefaultIdentityIsUnauthorizedToAccessTheAzureKeyVaultKey4002 = "Access to your account is currently revoked because the current default identity no longer has permission to the associated Key Vault key; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#default-identity-is-unauthorized-to-access-the-azure-key-vault-key (4002).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausetheAzureKeyVaultDNSnamespecifiedbytheaccountskeyvaultkeyuripropertycouldnotberesolvedformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideunableToResolveTheKeyVaultsDns4009 = "Access to your account is currently revoked because the Azure Key Vault DNS name specified by the account's keyvaultkeyuri property could not be resolved; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#unable-to-resolve-the-key-vaults-dns (4009).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausethecorrespondentkeyisnotfoundonthespecifiedKeyVaultformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideazureKeyVaultResourceNotFound4003 = "Access to your account is currently revoked because the correspondent key is not found on the specified Key Vault; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#azure-key-vault-resource-not-found (4003).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausetheAzureCosmosDBserviceisunabletowraporunwrapthekeyformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideinternalUnwrappingProcedureError4005 = "Access to your account is currently revoked because the Azure Cosmos DB service is unable to wrap or unwrap the key; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#internal-unwrapping-procedure-error (4005).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausetheAzureCosmosDBaccounthasanundefineddefaultidentityformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideinvalidAzureCosmosDbDefaultIdentity4015 = "Access to your account is currently revoked because the Azure Cosmos DB account has an undefined default identity; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#invalid-azure-cosmos-db-default-identity (4015).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausetheaccessrulesareblockingoutboundrequeststotheAzureKeyVaultserviceformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuide4016 = "Access to your account is currently revoked because the access rules are blocking outbound requests to the Azure Key Vault service; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide (4016).";
        public const string AccesstoyouraccountiscurrentlyrevokedbecausethecorrespondentAzureKeyVaultwasnotfoundformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuideazureKeyVaultResourceNotFound4017 = "Access to your account is currently revoked because the correspondent Azure Key Vault was not found; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide#azure-key-vault-resource-not-found (4017).";
        public const string AccesstoyouraccountiscurrentlyrevokedformoredetailsaboutthiserrorandhowtorestoreaccesstoyouraccountpleasevisithttpsLearnmicrosoftcomEnUsAzureCosmosDbCmkTroubleshootingGuide = "Access to your account is currently revoked; for more details about this error and how to restore access to your account please visit https://learn.microsoft.com/en-us/azure/cosmos-db/cmk-troubleshooting-guide";
        public const string Accesstotheconfiguredcustomermanagedkeyconfirmed = "Access to the configured customer managed key confirmed.";
    }
}
