
# Alert Channels Pager Duty Api Create Schema

## Structure

`AlertChannelsPagerDutyApiCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data9`](../../doc/models/data-9.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "apiIntgKey": "apiIntgKey4"
  },
  "type": "PagerDutyApi"
}
```

