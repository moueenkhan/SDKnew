
# Cloud Accounts Aws Us Gov Ct Sqs Response Schema

## Structure

`CloudAccountsAwsUsGovCtSqsResponseSchema`

## Inherits From

[`CloudAccountsResponseSchema`](../../doc/models/cloud-accounts-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data65`](../../doc/models/data-65.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

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
    },
    "queueUrl": "queueUrl6"
  },
  "isOrg": null,
  "props": null,
  "type": "AwsUsGovCtSqs"
}
```

