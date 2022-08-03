
# Machine Resource Group 2

## Structure

`MachineResourceGroup2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required, Constant | **Default**: `"MACHINE"` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props3`](../../doc/models/props-3.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "MACHINE",
  "props": null
}
```

