
# Aws Cfg

## Structure

`AwsCfg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"AwsCfg"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data62`](../../doc/models/data-62.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "AwsCfg",
  "enabled": null,
  "data": null
}
```

