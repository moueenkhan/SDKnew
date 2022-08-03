
# Resource Groups GCP Response Schema

## Structure

`ResourceGroupsGCPResponseSchema`

## Inherits From

[`ResourceGroupsResponseSchema`](../../doc/models/resource-groups-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props15`](../../doc/models/props-15.md) | Required | - |
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
    "organization": "organization2",
    "projects": [
      "projects7",
      "projects8"
    ]
  },
  "resourceGuid": null,
  "guid": null,
  "isDefault": null,
  "resourceType": "GCP"
}
```

