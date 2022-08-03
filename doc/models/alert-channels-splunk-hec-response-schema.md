
# Alert Channels Splunk Hec Response Schema

## Structure

`AlertChannelsSplunkHecResponseSchema`

## Inherits From

[`AlertChannelsResponseSchema`](../../doc/models/alert-channels-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data12`](../../doc/models/data-12.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "hecToken": "hecToken4",
    "channel": null,
    "host": "host2",
    "port": 210.5,
    "ssl": null,
    "eventData": {
      "index": "index4",
      "source": "source4"
    }
  },
  "isOrg": null,
  "props": null,
  "type": "SplunkHec"
}
```

