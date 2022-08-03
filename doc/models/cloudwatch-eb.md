
# Cloudwatch Eb

## Structure

`CloudwatchEb`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"CloudwatchEb"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data2`](../../doc/models/data-2.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "CloudwatchEb",
  "enabled": null,
  "data": null
}
```

