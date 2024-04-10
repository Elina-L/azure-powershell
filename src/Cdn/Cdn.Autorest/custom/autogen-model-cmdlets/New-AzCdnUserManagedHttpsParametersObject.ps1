
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for UserManagedHttpsParameters.
.Description
Create an in-memory object for UserManagedHttpsParameters.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.UserManagedHttpsParameters
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-AzCdnUserManagedHttpsParametersObject
#>
function New-AzCdnUserManagedHttpsParametersObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.UserManagedHttpsParameters')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Resource group of the user's Key Vault containing the SSL certificate.")]
        [string]
        $CertificateSourceParameterResourceGroupName,
        [Parameter(Mandatory, HelpMessage="The name of Key Vault Secret (representing the full certificate PFX) in Key Vault.")]
        [string]
        $CertificateSourceParameterSecretName,
        [Parameter(HelpMessage="The version(GUID) of Key Vault Secret in Key Vault.")]
        [string]
        $CertificateSourceParameterSecretVersion,
        [Parameter(Mandatory, HelpMessage="Subscription Id of the user's Key Vault containing the SSL certificate.")]
        [string]
        $CertificateSourceParameterSubscriptionId,
        [Parameter(Mandatory, HelpMessage="The name of the user's Key Vault containing the SSL certificate.")]
        [string]
        $CertificateSourceParameterVaultName,
        [Parameter(Mandatory, HelpMessage="Defines the source of the SSL certificate.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateSource])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateSource]
        $CertificateSource,
        [Parameter(HelpMessage="TLS protocol version that will be used for Https.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MinimumTlsVersion])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MinimumTlsVersion]
        $MinimumTlsVersion,
        [Parameter(Mandatory, HelpMessage="Defines the TLS extension protocol that is used for secure delivery.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType]
        $ProtocolType
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.UserManagedHttpsParameters]::New()

        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterResourceGroupName')) {
            $Object.CertificateSourceParameterResourceGroupName = $CertificateSourceParameterResourceGroupName
        }
        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterSecretName')) {
            $Object.CertificateSourceParameterSecretName = $CertificateSourceParameterSecretName
        }
        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterSecretVersion')) {
            $Object.CertificateSourceParameterSecretVersion = $CertificateSourceParameterSecretVersion
        }
        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterSubscriptionId')) {
            $Object.CertificateSourceParameterSubscriptionId = $CertificateSourceParameterSubscriptionId
        }
        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterVaultName')) {
            $Object.CertificateSourceParameterVaultName = $CertificateSourceParameterVaultName
        }
        if ($PSBoundParameters.ContainsKey('CertificateSource')) {
            $Object.CertificateSource = $CertificateSource
        }
        if ($PSBoundParameters.ContainsKey('MinimumTlsVersion')) {
            $Object.MinimumTlsVersion = $MinimumTlsVersion
        }
        if ($PSBoundParameters.ContainsKey('ProtocolType')) {
            $Object.ProtocolType = $ProtocolType
        }
        return $Object
    }
}

