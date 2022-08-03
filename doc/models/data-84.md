
# Data 84

## Structure

`Data84`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials10`](../../doc/models/credentials-10.md) | Optional | - |
| `TenantId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `QueueUrl` | `string` | Optional | **Constraints**: *Pattern*: `^https://[a-zA-Z0-9-]*.queue.core.windows.net/[a-zA-Z0-9-]*` |

## Example (as JSON)

```json
{
  "credentials": null,
  "tenantId": null,
  "queueUrl": null
}
```

