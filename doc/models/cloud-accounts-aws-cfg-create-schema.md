
# Cloud Accounts Aws Cfg Create Schema

## Structure

`CloudAccountsAwsCfgCreateSchema`

## Inherits From

[`CloudAccountsCreateSchema`](../../doc/models/cloud-accounts-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data62`](../../doc/models/data-62.md) | Required | - |

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
  "type": "AwsCfg"
}
```

