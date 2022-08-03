
# Azure Cfg

## Structure

`AzureCfg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"AzureCfg"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data67`](../../doc/models/data-67.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "AzureCfg",
  "enabled": null,
  "data": null
}
```

