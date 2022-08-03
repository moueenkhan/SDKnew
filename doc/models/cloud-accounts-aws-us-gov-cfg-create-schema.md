
# Cloud Accounts Aws Us Gov Cfg Create Schema

## Structure

`CloudAccountsAwsUsGovCfgCreateSchema`

## Inherits From

[`CloudAccountsCreateSchema`](../../doc/models/cloud-accounts-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data64`](../../doc/models/data-64.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "accessKeyCredentials": {
      "accountId": "accountId0",
      "accessKeyId": "accessKeyId4",
      "secretAccessKey": "secretAccessKey0"
    }
  },
  "type": "AwsUsGovCfg"
}
```

