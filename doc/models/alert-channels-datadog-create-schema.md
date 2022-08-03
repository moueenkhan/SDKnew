
# Alert Channels Datadog Create Schema

## Structure

`AlertChannelsDatadogCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data3`](../../doc/models/data-3.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": {
    "datadogType": "Logs Detail",
    "datadogSite": "com",
    "apiKey": null
  }
}
```

