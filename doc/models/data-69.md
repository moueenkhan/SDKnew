
# Data 69

## Structure

`Data69`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials`](../../doc/models/credentials.md) | Required | - |
| `IdType` | [`Models.IntegrationLevelEnum`](../../doc/models/integration-level-enum.md) | Required | - |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "privateKeyId": "privateKeyId2",
    "clientEmail": "clientEmail6",
    "privateKey": "privateKey8"
  },
  "idType": "ORGANIZATION",
  "id": "id0"
}
```

