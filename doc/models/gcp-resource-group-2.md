
# GCP Resource Group 2

## Structure

`GCPResourceGroup2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required, Constant | **Default**: `"GCP"` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props2`](../../doc/models/props-2.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "GCP",
  "props": null
}
```

