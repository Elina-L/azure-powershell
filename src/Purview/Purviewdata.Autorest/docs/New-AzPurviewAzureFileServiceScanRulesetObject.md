---
external help file:
Module Name: Az.Purview
online version: https://learn.microsoft.com/powershell/module/Az.Purview/new-azpurviewazurefileservicescanrulesetobject
schema: 2.0.0
---

# New-AzPurviewAzureFileServiceScanRulesetObject

## SYNOPSIS
Create an in-memory object for AzureFileServiceScanRuleset.

## SYNTAX

```
New-AzPurviewAzureFileServiceScanRulesetObject [-Description <String>]
 [-ExcludedSystemClassification <String[]>] [-IncludedCustomClassificationRuleName <String[]>]
 [-ScanningRuleCustomFileExtension <ICustomFileExtension[]>] [-ScanningRuleFileExtension <String[]>]
 [-Type <String>] [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for AzureFileServiceScanRuleset.

## EXAMPLES

### Example 1: Create Azure File Service custom scanruleset object
```powershell
New-AzPurviewAzureFileServiceScanRulesetObject -Description 'desc' -ExcludedSystemClassification @('MICROSOFT.FINANCIAL.CREDIT_CARD_NUMBER','MICROSOFT.SECURITY.COMMON_PASSWORDS') -IncludedCustomClassificationRuleName @('ClassificationRule2') -ScanningRuleFileExtension @("CSV","JSON","PSV","SSV","TSV","TXT","XML","PARQUET","AVRO","ORC","Documents","GZ","DOC","DOCM","DOCX","DOT","ODP","ODS","ODT","PDF","POT","PPS","PPSX","PPT","PPTM","PPTX","XLC","XLS","XLSB","XLSM","XLSX","XLT") -Type 'Custom'
```

```output
CreatedAt                            :
Description                          : desc
ExcludedSystemClassification         : {MICROSOFT.FINANCIAL.CREDIT_CARD_NUMBER, MICROSOFT.SECURITY.COMMON_PASSWORDS}
Id                                   :
IncludedCustomClassificationRuleName : {ClassificationRule2}
Kind                                 : AzureFileService
LastModifiedAt                       :
Name                                 :
ScanningRuleCustomFileExtension      :
ScanningRuleFileExtension            : {CSV, JSON, PSV, SSV…}
Status                               :
Type                                 : Custom
Version                              :
```

Create Azure File Service custom scanruleset object

## PARAMETERS

### -Description


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

### -ExcludedSystemClassification


```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludedCustomClassificationRuleName


```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScanningRuleCustomFileExtension


```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ICustomFileExtension[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScanningRuleFileExtension


```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type


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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureFileServiceScanRuleset

## NOTES

## RELATED LINKS

