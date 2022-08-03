
# Alert Channels Ibm Qradar Create Schema

## Structure

`AlertChannelsIbmQradarCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data6`](../../doc/models/data-6.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": {
    "qradarCommType": "HTTPS",
    "qradarHostUrl": null
  }
}
```

