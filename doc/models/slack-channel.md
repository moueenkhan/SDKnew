
# Slack Channel

## Structure

`SlackChannel`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"SlackChannel"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data11`](../../doc/models/data-11.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "SlackChannel",
  "enabled": null,
  "data": null
}
```

