
# Data 65

## Structure

`Data65`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials`](../../doc/models/access-key-credentials.md) | Required | - |
| `QueueUrl` | `string` | Required | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |

## Example (as JSON)

```json
{
  "accessKeyCredentials": {
    "accountId": "accountId0",
    "accessKeyId": "accessKeyId6",
    "secretAccessKey": "secretAccessKey0"
  },
  "queueUrl": "queueUrl4"
}
```

