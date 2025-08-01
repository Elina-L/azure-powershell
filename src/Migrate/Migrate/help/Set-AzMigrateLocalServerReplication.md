---
external help file:
Module Name: Az.Migrate
online version: https://learn.microsoft.com/powershell/module/az.migrate/set-azmigratelocalserverreplication
schema: 2.0.0
---

# Set-AzMigrateLocalServerReplication

## SYNOPSIS
Updates the target properties for the replicating server.

## SYNTAX

```
Set-AzMigrateLocalServerReplication -TargetObjectID <String>
 [-DynamicMemoryConfig <ProtectedItemDynamicMemoryConfig>] [-IsDynamicMemoryEnabled <String>]
 [-NicToInclude <AzLocalNicInput[]>] [-OsType <String>] [-SubscriptionId <String>] [-TargetVMCPUCore <Int32>]
 [-TargetVMRam <Int64>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The Set-AzMigrateLocalServerReplication cmdlet updates the target properties for the replicating server.

## EXAMPLES

### Example 1: Update dynamic memory configuration
```powershell
$memoryConfig = [PSCustomObject]@{
	MinimumMemoryInMegaByte = 1024
	MaximumMemoryInMegaByte = 34816
	TargetMemoryBufferPercentage = 20
}

Set-AzMigrateLocalServerReplication -TargetObjectID  '/subscriptions/xxx-xxx-xxx/resourceGroups/test-rg/providers/Microsoft.DataReplication/replicationVaults/proj62434replicationvault/protectedItems/503a4f02-916c-d6b0-8d14-222bbd4767e5' -DynamicMemoryConfig $memoryConfig
```

```output
ActivityId                         : ActivityId: 00000000-0000-0000-0000-000000000000
AllowedAction                      : {}
CustomPropertyAffectedObjectDetail : Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.JobModelCustomPropertiesAffectedObjectDetails
DisplayName                        : Create or update protected item
EndTime                            : 1/1/1900 8:54:47 PM
Error                              : {}
Id                                 : /subscriptions/xxx-xxx-xxx/resourceGroups/test-rg/providers/Microsoft.DataReplication/replicationVaults/proj62434replicationvault/jobs/f2d3430a-2977-419f-abd5-11d171e17f5e
Name                               : f2d3430a-2977-419f-abd5-11d171e17f5e
ObjectId                           : /subscriptions/xxx-xxx-xxx/resourceGroups/test-rg/providers/Microsoft.DataReplication/replicationVaults/proj62434replicationvault/protectedItems/0ec082d5-6827-457a-bae2-f986e1b94555     
ObjectInternalId                   : a8b5ee68-102c-5aae-9499-c57a475a8fd4
ObjectInternalName                 : test_vm
ObjectName                         : 0ec082d5-6827-457a-bae2-f986e1b94555
ObjectType                         : ProtectedItem
ReplicationProviderId              : xxx-xxx-xxx
SourceFabricProviderId             : b35da11c-d69e-4220-9a90-d81ed93ad2fc
StartTime                          : 1/1/1900 8:49:27 PM
State                              : Succeeded
SystemDataCreatedAt                : 
SystemDataCreatedBy                : 
SystemDataCreatedByType            : 
SystemDataLastModifiedAt           : 
SystemDataLastModifiedBy           : 
SystemDataLastModifiedByType       : 
TargetFabricProviderId             : 22f00372-a1b7-467f-87ce-d95e17a6e7c7
Task                               : {Creating or updating the protected item, Initializing Protection, Enabling Protection, Starting Replication}
Type                               : Microsoft.DataReplication/replicationVaults/jobs	
```

Update dynamic memory configuration.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DynamicMemoryConfig
Specifies the dynamic memory configuration of RAM.
To construct, see NOTES section for DYNAMICMEMORYCONFIG properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.ProtectedItemDynamicMemoryConfig
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDynamicMemoryEnabled
Specifies if RAM is dynamic or not.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NicToInclude
Specifies the nics on the source server to be included for replication.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.AzLocalNicInput[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OsType
Specifies the OS type of the VM, either WindowsGuest or LinuxGuest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription Id.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetObjectID
Specifies the replicating server for which the properties need to be updated.
The ID should be retrieved using the Get-AzMigrateLocalServerReplication cmdlet.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetVMCPUCore
Specifies the number of CPU cores.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetVMRam
Specifies the target RAM size in MB.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IJobModel

## NOTES

## RELATED LINKS

