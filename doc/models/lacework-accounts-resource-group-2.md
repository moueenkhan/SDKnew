
# Lacework Accounts Resource Group 2

## Structure

`LaceworkAccountsResourceGroup2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required, Constant | **Default**: `"LW_ACCOUNT"` |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `Props` | [`Models.Props5`](../../doc/models/props-5.md) | Required | - |

## Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "LW_ACCOUNT",
  "props": null
}
```

