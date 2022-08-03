
# Lacework Accounts Resource Group

## Structure

`LaceworkAccountsResourceGroup`

## Inherits From

[`ResourceGroupsUpdateSchema`](../../doc/models/resource-groups-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props21`](../../doc/models/props-21.md) | Optional | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null,
  "resourceType": "LW_ACCOUNT"
}
```

