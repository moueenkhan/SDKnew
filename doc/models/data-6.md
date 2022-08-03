
# Data 6

## Structure

`Data6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QradarCommType` | [`Models.CommunicationTypeEnum`](../../doc/models/communication-type-enum.md) | Required | **Default**: `CommunicationTypeEnum.HTTPS` |
| `QradarHostUrl` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `.+[a-zA-Z0-9]$` |
| `QradarHostPort` | `double?` | Optional | **Constraints**: `>= 0`, `<= 65535` |

## Example (as JSON)

```json
{
  "qradarCommType": "HTTPS",
  "qradarHostUrl": null
}
```

