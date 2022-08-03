
# Alert Channels Email User Update Schema

## Structure

`AlertChannelsEmailUserUpdateSchema`

## Inherits From

[`AlertChannelsUpdateSchema`](../../doc/models/alert-channels-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data40`](../../doc/models/data-40.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null,
  "type": "EmailUser"
}
```

