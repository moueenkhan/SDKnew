
# Data 12

## Structure

`Data12`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HecToken` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Channel` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Host` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Port` | `double` | Required | **Constraints**: `>= 0`, `<= 65536` |
| `Ssl` | `bool?` | Optional | - |
| `EventData` | [`Models.EventData`](../../doc/models/event-data.md) | Required | - |

## Example (as JSON)

```json
{
  "hecToken": "hecToken6",
  "channel": null,
  "host": "host8",
  "port": 110.4,
  "ssl": null,
  "eventData": {
    "index": "index6",
    "source": "source4"
  }
}
```

