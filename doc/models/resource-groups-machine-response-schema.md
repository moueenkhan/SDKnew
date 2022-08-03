
# Resource Groups MACHINE Response Schema

## Structure

`ResourceGroupsMACHINEResponseSchema`

## Inherits From

[`ResourceGroupsResponseSchema`](../../doc/models/resource-groups-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props16`](../../doc/models/props-16.md) | Required | - |
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
    "machineTags": [
      {
        "A.+": null
      },
      {
        "A.+": null
      }
    ]
  },
  "resourceGuid": null,
  "guid": null,
  "isDefault": null,
  "resourceType": "MACHINE"
}
```

