
# Resource Groups LWACCOUNT Create Schema

## Structure

`ResourceGroupsLWACCOUNTCreateSchema`

## Inherits From

[`ResourceGroupsCreateSchema`](../../doc/models/resource-groups-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props17`](../../doc/models/props-17.md) | Required | - |

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
  "resourceType": "LW_ACCOUNT"
}
```

