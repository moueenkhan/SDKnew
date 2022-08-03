
# Cloud Accounts Aws Cfg Response Schema

## Structure

`CloudAccountsAwsCfgResponseSchema`

## Inherits From

[`CloudAccountsResponseSchema`](../../doc/models/cloud-accounts-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data62`](../../doc/models/data-62.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "awsAccountId": null,
    "crossAccountCredentials": {
      "externalId": "externalId2",
      "roleArn": "roleArn6"
    }
  },
  "isOrg": null,
  "props": null,
  "type": "AwsCfg"
}
```

