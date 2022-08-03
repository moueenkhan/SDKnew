
# Data 68

## Structure

`Data68`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials6`](../../doc/models/credentials-6.md) | Required | - |
| `IdType` | [`Models.IntegrationLevelEnum`](../../doc/models/integration-level-enum.md) | Required | - |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `SubscriptionName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "privateKeyId": "privateKeyId2",
    "clientEmail": "clientEmail6",
    "privateKey": null
  },
  "idType": "ORGANIZATION",
  "id": "id0",
  "subscriptionName": "subscriptionName2"
}
```

