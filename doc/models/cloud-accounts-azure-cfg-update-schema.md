
# Cloud Accounts Azure Cfg Update Schema

## Structure

`CloudAccountsAzureCfgUpdateSchema`

## Inherits From

[`CloudAccountsUpdateSchema`](../../doc/models/cloud-accounts-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data87`](../../doc/models/data-87.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null,
  "type": "AzureCfg"
}
```

