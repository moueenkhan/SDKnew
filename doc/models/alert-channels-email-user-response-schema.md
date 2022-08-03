
# Alert Channels Email User Response Schema

## Structure

`AlertChannelsEmailUserResponseSchema`

## Inherits From

[`AlertChannelsResponseSchema`](../../doc/models/alert-channels-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data25`](../../doc/models/data-25.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "channelProps": null
  },
  "isOrg": null,
  "props": null,
  "type": "EmailUser"
}
```

