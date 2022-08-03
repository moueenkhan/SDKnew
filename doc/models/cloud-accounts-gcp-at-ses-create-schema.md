
# Cloud Accounts Gcp at Ses Create Schema

## Structure

`CloudAccountsGcpAtSesCreateSchema`

## Inherits From

[`CloudAccountsCreateSchema`](../../doc/models/cloud-accounts-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data68`](../../doc/models/data-68.md) | Required | - |

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
      "privateKey": null
    },
    "idType": "ORGANIZATION",
    "id": "id0",
    "subscriptionName": "subscriptionName8"
  },
  "type": "GcpAtSes"
}
```

