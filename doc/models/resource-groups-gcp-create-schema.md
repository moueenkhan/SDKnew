
# Resource Groups GCP Create Schema

## Structure

`ResourceGroupsGCPCreateSchema`

## Inherits From

[`ResourceGroupsCreateSchema`](../../doc/models/resource-groups-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props15`](../../doc/models/props-15.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": "resourceName6",
  "enabled": null,
  "props": {
    "description": null,
    "organization": "organization2",
    "projects": [
      "projects7",
      "projects8"
    ]
  },
  "resourceType": "GCP"
}
```

