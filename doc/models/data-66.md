
# Data 66

## Structure

`Data66`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials4`](../../doc/models/credentials-4.md) | Required | - |
| `TenantId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `QueueUrl` | `string` | Required | **Constraints**: *Pattern*: `^https://[a-zA-Z0-9-]*.queue.core.windows.net/[a-zA-Z0-9-]*` |

## Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "clientSecret": "clientSecret8"
  },
  "tenantId": "tenantId6",
  "queueUrl": "queueUrl4"
}
```

