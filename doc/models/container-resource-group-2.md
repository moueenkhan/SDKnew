
# Container Resource Group 2

## Structure

`ContainerResourceGroup2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required, Constant | **Default**: `"CONTAINER"` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props4`](../../doc/models/props-4.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "CONTAINER",
  "props": null
}
```

