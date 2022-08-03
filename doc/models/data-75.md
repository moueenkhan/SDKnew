
# Data 75

## Structure

`Data75`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AwsAccountId` | `string` | Optional | - |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials4`](../../doc/models/cross-account-credentials-4.md) | Optional | - |
| `QueueUrl` | `string` | Optional | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |
| `AccountMappingFile` | `Stream` | Optional | - |
| `AccountMapping` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "awsAccountId": null,
  "crossAccountCredentials": null,
  "queueUrl": null,
  "accountMappingFile": null,
  "accountMapping": null
}
```

