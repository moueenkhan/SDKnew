
# Cloud Accounts Azure Al Seq Response Schema

## Structure

`CloudAccountsAzureAlSeqResponseSchema`

## Inherits From

[`CloudAccountsResponseSchema`](../../doc/models/cloud-accounts-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data66`](../../doc/models/data-66.md) | Required | - |
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
      "clientSecret": "clientSecret6"
    },
    "tenantId": "tenantId6",
    "queueUrl": "queueUrl6"
  },
  "isOrg": null,
  "props": null,
  "type": "AzureAlSeq"
}
```

