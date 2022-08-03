
# Resource Groups MACHINE Create Schema

## Structure

`ResourceGroupsMACHINECreateSchema`

## Inherits From

[`ResourceGroupsCreateSchema`](../../doc/models/resource-groups-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props16`](../../doc/models/props-16.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": "resourceName6",
  "enabled": null,
  "props": {
    "description": null,
    "machineTags": [
      {
        "A.+": null
      },
      {
        "A.+": null
      }
    ]
  },
  "resourceType": "MACHINE"
}
```

