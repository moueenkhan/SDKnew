
# Resource Groups AZURE Create Schema

## Structure

`ResourceGroupsAZURECreateSchema`

## Inherits From

[`ResourceGroupsCreateSchema`](../../doc/models/resource-groups-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props9`](../../doc/models/props-9.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": "resourceName6",
  "enabled": null,
  "props": {
    "description": null,
    "tenant": "tenant0",
    "subscriptions": [
      "subscriptions3"
    ]
  },
  "resourceType": "AZURE"
}
```

