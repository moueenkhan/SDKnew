
# Azure Resource Group 2

## Structure

`AzureResourceGroup2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required, Constant | **Default**: `"AZURE"` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props1`](../../doc/models/props-1.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "AZURE",
  "props": null
}
```

