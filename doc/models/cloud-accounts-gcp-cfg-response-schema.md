
# Cloud Accounts Gcp Cfg Response Schema

## Structure

`CloudAccountsGcpCfgResponseSchema`

## Inherits From

[`CloudAccountsResponseSchema`](../../doc/models/cloud-accounts-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data69`](../../doc/models/data-69.md) | Required | - |
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
      "privateKey": "privateKey6"
    },
    "idType": "ORGANIZATION",
    "id": "id0"
  },
  "isOrg": null,
  "props": null,
  "type": "GcpCfg"
}
```

