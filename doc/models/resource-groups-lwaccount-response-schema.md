
# Resource Groups LWACCOUNT Response Schema

## Structure

`ResourceGroupsLWACCOUNTResponseSchema`

## Inherits From

[`ResourceGroupsResponseSchema`](../../doc/models/resource-groups-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props17`](../../doc/models/props-17.md) | Required | - |
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
    "lwAccounts": [
      "lwAccounts6",
      "lwAccounts7",
      "lwAccounts8"
    ]
  },
  "resourceGuid": null,
  "guid": null,
  "isDefault": null,
  "resourceType": "LW_ACCOUNT"
}
```

