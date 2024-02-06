
# ----------------------------------------------------------------------------------	
#	
# Copyright Microsoft Corporation	
# Licensed under the Apache License, Version 2.0 (the "License");	
# you may not use this file except in compliance with the License.	
# You may obtain a copy of the License at	
# http://www.apache.org/licenses/LICENSE-2.0	
# Unless required by applicable law or agreed to in writing, software	
# distributed under the License is distributed on an "AS IS" BASIS,	
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.	
# See the License for the specific language governing permissions and	
# limitations under the License.	
# ----------------------------------------------------------------------------------	

<#	
.Synopsis	
Get the Azure Virtual Desktop registration info.	
.Description	
Get the Azure Virtual Desktop registration info.	
#>	
function Get-AzWvdRegistrationInfo {	
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20240116Preview.RegistrationInfo')]	
    [CmdletBinding(PositionalBinding=$false)]	
    param(	
        [Parameter()]	
        [Alias('AzureRMContext', 'AzureCredential')]	
        [ValidateNotNull()]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Azure')]	
        [System.Management.Automation.PSObject]	
        # The credentials, account, tenant, and subscription used for communication with Azure.	
        ${DefaultProfile},	

        [Parameter(DontShow)]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]	
        [System.Management.Automation.SwitchParameter]	
        # Wait for .NET debugger to attach	
        ${Break},	

        [Parameter(DontShow)]	
        [ValidateNotNull()]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SendAsyncStep[]]	
        # SendAsync Pipeline Steps to be appended to the front of the pipeline	
        ${HttpPipelineAppend},	

        [Parameter(DontShow)]	
        [ValidateNotNull()]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SendAsyncStep[]]	
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline	
        ${HttpPipelinePrepend},	

        [Parameter(DontShow)]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]	
        [System.Uri]	
        # The URI for the proxy server to use	
        ${Proxy},	

        [Parameter(DontShow)]	
        [ValidateNotNull()]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]	
        [System.Management.Automation.PSCredential]	
        # Credentials for a proxy server to use for the remote call	
        ${ProxyCredential},	

        [Parameter(DontShow)]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]	
        [System.Management.Automation.SwitchParameter]	
        # Use the default credentials for the proxy	
        ${ProxyUseDefaultCredentials},	

        [Parameter(Mandatory, HelpMessage='Subscription Id')]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]	
        [System.String]	
        ${SubscriptionId},	

        [Parameter(Mandatory, HelpMessage='Resource Group Name')]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]	
        [System.String]	
        ${ResourceGroupName},	

        [Parameter(Mandatory, HelpMessage='Host Pool Name')]	
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]	
        [System.String]	
        ${HostPoolName}	
    )	

    process {	
        $registrationInfo = Az.DesktopVirtualization\Get-AzWvdHostPoolRegistrationToken @PSBoundParameters
        $registrationInfo
    }	
} 