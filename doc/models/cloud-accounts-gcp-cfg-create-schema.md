
# Cloud Accounts Gcp Cfg Create Schema

## Structure

`CloudAccountsGcpCfgCreateSchema`

## Inherits From

[`CloudAccountsCreateSchema`](../../doc/models/cloud-accounts-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data69`](../../doc/models/data-69.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "credentials": {
      "clientId": "clientId8",
      "privateKeyId": "privateKeyId0",
      "clientEmail": "clientEmail4",
      "privateKey": "privateKey6"
    },
    "idType": "ORGANIZATION",
    "id": "id0"
  },
  "type": "GcpCfg"
}
```

