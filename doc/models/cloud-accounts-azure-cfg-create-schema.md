
# Cloud Accounts Azure Cfg Create Schema

## Structure

`CloudAccountsAzureCfgCreateSchema`

## Inherits From

[`CloudAccountsCreateSchema`](../../doc/models/cloud-accounts-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data67`](../../doc/models/data-67.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "credentials": {
      "clientId": "clientId8",
      "clientSecret": "clientSecret6"
    },
    "tenantId": "tenantId6"
  },
  "type": "AzureCfg"
}
```

