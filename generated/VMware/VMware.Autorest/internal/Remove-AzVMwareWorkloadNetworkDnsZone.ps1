
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
Delete a WorkloadNetworkDnsZone
.Description
Delete a WorkloadNetworkDnsZone
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DNSZONEINPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon.
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization
  [CloudLinkName <String>]: Name of the cloud link.
  [ClusterName <String>]: Name of the cluster
  [DatastoreName <String>]: Name of the datastore
  [DhcpId <String>]: The ID of the DHCP configuration
  [DnsServiceId <String>]: ID of the DNS service.
  [DnsZoneId <String>]: ID of the DNS zone.
  [GatewayId <String>]: The ID of the NSX Gateway
  [GlobalReachConnectionName <String>]: Name of the global reach connection
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site
  [HostId <String>]: The host identifier.
  [Id <String>]: Resource identity path
  [Location <String>]: The name of the Azure region.
  [PlacementPolicyName <String>]: Name of the placement policy.
  [PortMirroringId <String>]: ID of the NSX port mirroring profile.
  [PrivateCloudName <String>]: Name of the private cloud
  [ProvisionedNetworkName <String>]: Name of the cloud link.
  [PublicIPId <String>]: ID of the DNS zone.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet.
  [ScriptExecutionName <String>]: Name of the script cmdlet.
  [ScriptPackageName <String>]: Name of the script package.
  [SegmentId <String>]: The ID of the NSX Segment
  [StoragePolicyName <String>]: Name of the storage policy.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
  [VMGroupId <String>]: ID of the VM group.
  [VirtualMachineId <String>]: ID of the virtual machine.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon.
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization
  [CloudLinkName <String>]: Name of the cloud link.
  [ClusterName <String>]: Name of the cluster
  [DatastoreName <String>]: Name of the datastore
  [DhcpId <String>]: The ID of the DHCP configuration
  [DnsServiceId <String>]: ID of the DNS service.
  [DnsZoneId <String>]: ID of the DNS zone.
  [GatewayId <String>]: The ID of the NSX Gateway
  [GlobalReachConnectionName <String>]: Name of the global reach connection
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site
  [HostId <String>]: The host identifier.
  [Id <String>]: Resource identity path
  [Location <String>]: The name of the Azure region.
  [PlacementPolicyName <String>]: Name of the placement policy.
  [PortMirroringId <String>]: ID of the NSX port mirroring profile.
  [PrivateCloudName <String>]: Name of the private cloud
  [ProvisionedNetworkName <String>]: Name of the cloud link.
  [PublicIPId <String>]: ID of the DNS zone.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet.
  [ScriptExecutionName <String>]: Name of the script cmdlet.
  [ScriptPackageName <String>]: Name of the script package.
  [SegmentId <String>]: The ID of the NSX Segment
  [StoragePolicyName <String>]: Name of the storage policy.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
  [VMGroupId <String>]: ID of the VM group.
  [VirtualMachineId <String>]: ID of the virtual machine.
.Link
https://learn.microsoft.com/powershell/module/az.vmware/remove-azvmwareworkloadnetworkdnszone
#>
function Remove-AzVMwareWorkloadNetworkDnsZone {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # ID of the DNS zone.
    ${DnsZoneName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Parameter(ParameterSetName='DeleteViaIdentityDnsZone', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='DeleteViaIdentityDnsZone', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    ${DnsZoneInputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            Delete = 'Az.VMware.private\Remove-AzVMwareWorkloadNetworkDnsZone_Delete';
            DeleteViaIdentity = 'Az.VMware.private\Remove-AzVMwareWorkloadNetworkDnsZone_DeleteViaIdentity';
            DeleteViaIdentityDnsZone = 'Az.VMware.private\Remove-AzVMwareWorkloadNetworkDnsZone_DeleteViaIdentityDnsZone';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
