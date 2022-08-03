
# Resource Groups AWS Response Schema

## Structure

`ResourceGroupsAWSResponseSchema`

## Inherits From

[`ResourceGroupsResponseSchema`](../../doc/models/resource-groups-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props6`](../../doc/models/props-6.md) | Required | - |
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
    "accountIds": [
      "accountIds9",
      "accountIds0"
    ]
  },
  "resourceGuid": null,
  "guid": null,
  "isDefault": null,
  "resourceType": "AWS"
}
```

