
# New Relic Insights

## Structure

`NewRelicInsights`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"NewRelicInsights"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data8`](../../doc/models/data-8.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "NewRelicInsights",
  "enabled": null,
  "data": null
}
```

