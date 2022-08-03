
# Resource Groups CONTAINER Create Schema

## Structure

`ResourceGroupsCONTAINERCreateSchema`

## Inherits From

[`ResourceGroupsCreateSchema`](../../doc/models/resource-groups-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props12`](../../doc/models/props-12.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": "resourceName6",
  "enabled": null,
  "props": {
    "description": null,
    "containerLabels": [
      {
        "A.+": null
      },
      {
        "A.+": null
      },
      {
        "A.+": null
      }
    ],
    "containerTags": [
      "containerTags9",
      "containerTags8",
      "containerTags7"
    ]
  },
  "resourceType": "CONTAINER"
}
```

