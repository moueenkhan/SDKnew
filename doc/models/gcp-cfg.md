
# Gcp Cfg

## Structure

`GcpCfg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"GcpCfg"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data69`](../../doc/models/data-69.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "GcpCfg",
  "enabled": null,
  "data": null
}
```

