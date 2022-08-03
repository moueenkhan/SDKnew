
# Alert Channels Slack Channel Create Schema

## Structure

`AlertChannelsSlackChannelCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data11`](../../doc/models/data-11.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "slackUrl": "slackUrl0"
  },
  "type": "SlackChannel"
}
```

