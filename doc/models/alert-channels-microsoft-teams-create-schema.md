
# Alert Channels Microsoft Teams Create Schema

## Structure

`AlertChannelsMicrosoftTeamsCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data7`](../../doc/models/data-7.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "teamsUrl": "teamsUrl6"
  },
  "type": "MicrosoftTeams"
}
```

