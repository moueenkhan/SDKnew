
# Microsoft Teams

## Structure

`MicrosoftTeams`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"MicrosoftTeams"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data7`](../../doc/models/data-7.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "MicrosoftTeams",
  "enabled": null,
  "data": null
}
```

