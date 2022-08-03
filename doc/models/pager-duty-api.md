
# Pager Duty Api

## Structure

`PagerDutyApi`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"PagerDutyApi"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data9`](../../doc/models/data-9.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "PagerDutyApi",
  "enabled": null,
  "data": null
}
```

