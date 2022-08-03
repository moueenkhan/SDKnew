
# Alert Channels Cloudwatch Eb Create Schema

## Structure

`AlertChannelsCloudwatchEbCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data2`](../../doc/models/data-2.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "issueGrouping": null,
    "eventBusArn": "eventBusArn2"
  },
  "type": "CloudwatchEb"
}
```

