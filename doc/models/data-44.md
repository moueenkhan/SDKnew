
# Data 44

## Structure

`Data44`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QradarCommType` | [`Models.CommunicationTypeEnum?`](../../doc/models/communication-type-enum.md) | Optional | **Default**: `CommunicationTypeEnum.HTTPS` |
| `QradarHostUrl` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `.+[a-zA-Z0-9]$` |
| `QradarHostPort` | `double?` | Optional | **Constraints**: `>= 0`, `<= 65535` |

## Example (as JSON)

```json
{
  "qradarCommType": null,
  "qradarHostUrl": null,
  "qradarHostPort": null
}
```

