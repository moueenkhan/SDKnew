
# Machine Resource Group

## Structure

`MachineResourceGroup`

## Inherits From

[`ResourceGroupsUpdateSchema`](../../doc/models/resource-groups-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props23`](../../doc/models/props-23.md) | Optional | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null,
  "resourceType": "MACHINE"
}
```

