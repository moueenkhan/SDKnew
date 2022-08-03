
# Cloud Accounts Gcp at Ses Response Schema

## Structure

`CloudAccountsGcpAtSesResponseSchema`

## Inherits From

[`CloudAccountsResponseSchema`](../../doc/models/cloud-accounts-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data68`](../../doc/models/data-68.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

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
  "isOrg": null,
  "props": null,
  "type": "GcpAtSes"
}
```

