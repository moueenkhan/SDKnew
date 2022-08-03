
# Splunk Hec

## Structure

`SplunkHec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"SplunkHec"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data12`](../../doc/models/data-12.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "SplunkHec",
  "enabled": null,
  "data": null
}
```

