if(($null -eq $TestName) -or ($TestName -contains 'Get-AzLabServicesLabPlan'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzLabServicesLabPlan.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

$loadVarsPath = Join-Path $PSScriptRoot '\SetVariables.ps1'
. ($loadVarsPath)
Describe 'Get-AzLabServicesLabPlan' {
    It 'List' {
        Get-AzLabServicesLabPlan | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        Get-AzLabServicesLabPlan -Name $env.LabPlanName -ResourceGroupName $env.ResourceGroupName | Select-Object -Property Name | Should -Be "@{Name=$($env.LabPlanName)}"
    }

    It 'List by Resource Group' {
        Get-AzLabServicesLabPlan -ResourceGroupName $env.ResourceGroupName | Should -Not -BeNullOrEmpty
    }

    It 'Get ResourceId' {        
        Get-AzLabServicesLabPlan -ResourceId "/subscriptions/$($env.SubscriptionId)/resourceGroups/$($env.ResourceGroupName)/providers/Microsoft.LabServices/labPlans/$($env.LabPlanName)" | Should -Not -BeNullOrEmpty
    }
}
