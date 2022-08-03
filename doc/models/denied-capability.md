
# Denied Capability

## Structure

`DeniedCapability`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"DIRECT_DEBIT"` |
| `Reasons` | `List<string>` | Optional | - |
| `RequiredActions` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "type": "DIRECT_DEBIT"
}
```

