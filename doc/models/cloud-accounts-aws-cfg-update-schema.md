
# Cloud Accounts Aws Cfg Update Schema

## Structure

`CloudAccountsAwsCfgUpdateSchema`

## Inherits From

[`CloudAccountsUpdateSchema`](../../doc/models/cloud-accounts-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data72`](../../doc/models/data-72.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null,
  "type": "AwsCfg"
}
```

