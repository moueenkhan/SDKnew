
# Data 63

## Structure

`Data63`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AwsAccountId` | `string` | Optional | - |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials`](../../doc/models/cross-account-credentials.md) | Required | - |
| `QueueUrl` | `string` | Required | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |
| `AccountMappingFile` | `Stream` | Optional | - |
| `AccountMapping` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "awsAccountId": null,
  "crossAccountCredentials": {
    "externalId": "externalId0",
    "roleArn": "roleArn6"
  },
  "queueUrl": "queueUrl4",
  "accountMappingFile": null,
  "accountMapping": null
}
```

