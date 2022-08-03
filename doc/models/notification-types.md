
# Notification Types

## Structure

`NotificationTypes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | [`Models.ReportScheduleEnum?`](../../doc/models/report-schedule-enum.md) | Optional | **Default**: `ReportScheduleEnum.Enum_1200 GMT` |
| `AwsCisS3` | `bool?` | Optional | - |
| `Pci` | `bool?` | Optional | - |
| `Soc` | `bool?` | Optional | - |
| `Hipaa` | `bool?` | Optional | - |
| `Nist80053Rev4` | `bool?` | Optional | - |
| `Nist800171Rev2` | `bool?` | Optional | - |
| `Iso2700` | `bool?` | Optional | - |
| `AzureCis` | `bool?` | Optional | - |
| `AzurePci` | `bool?` | Optional | - |
| `AzureSoc` | `bool?` | Optional | - |
| `GcpCis` | `bool?` | Optional | - |
| `GcpPci` | `bool?` | Optional | - |
| `GcpSoc` | `bool?` | Optional | - |
| `AgentEvents` | `bool?` | Optional | - |
| `AwsCloudtrailEvents` | `bool?` | Optional | - |
| `AwsComplianceEvents` | `bool?` | Optional | - |
| `AzureComplianceEvents` | `bool?` | Optional | - |
| `GcpComplianceEvents` | `bool?` | Optional | - |
| `AzureActivityLogEvents` | `bool?` | Optional | - |
| `GcpAuditTrailEvents` | `bool?` | Optional | - |
| `NoEvents` | `bool?` | Optional | - |
| `TrendReport` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "time": null,
  "awsCisS3": null,
  "pci": null,
  "soc": null,
  "hipaa": null,
  "nist800-53Rev4": null,
  "nist800-171Rev2": null,
  "iso2700": null,
  "azureCis": null,
  "azurePci": null,
  "azureSoc": null,
  "gcpCis": null,
  "gcpPci": null,
  "gcpSoc": null,
  "agentEvents": null,
  "awsCloudtrailEvents": null,
  "awsComplianceEvents": null,
  "azureComplianceEvents": null,
  "gcpComplianceEvents": null,
  "azureActivityLogEvents": null,
  "gcpAuditTrailEvents": null,
  "noEvents": null,
  "trendReport": null
}
```

