
# Resource Groups CONTAINER Response Schema

## Structure

`ResourceGroupsCONTAINERResponseSchema`

## Inherits From

[`ResourceGroupsResponseSchema`](../../doc/models/resource-groups-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props12`](../../doc/models/props-12.md) | Required | - |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |

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
  "resourceGuid": null,
  "guid": null,
  "isDefault": null,
  "resourceType": "CONTAINER"
}
```

