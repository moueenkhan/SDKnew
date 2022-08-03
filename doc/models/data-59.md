
# Data 59

## Structure

`Data59`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HecToken` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Channel` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Host` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Port` | `double?` | Optional | **Constraints**: `>= 0`, `<= 65536` |
| `Ssl` | `bool?` | Optional | - |
| `EventData` | [`Models.EventData3`](../../doc/models/event-data-3.md) | Optional | - |

## Example (as JSON)

```json
{
  "hecToken": null,
  "channel": null,
  "host": null,
  "port": null,
  "ssl": null,
  "eventData": null
}
```

