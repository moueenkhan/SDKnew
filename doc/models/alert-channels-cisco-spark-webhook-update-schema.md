
# Alert Channels Cisco Spark Webhook Update Schema

## Structure

`AlertChannelsCiscoSparkWebhookUpdateSchema`

## Inherits From

[`AlertChannelsUpdateSchema`](../../doc/models/alert-channels-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data20`](../../doc/models/data-20.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null,
  "type": "CiscoSparkWebhook"
}
```

