
# Alert Channels Gcp Pubsub Create Schema

## Structure

`AlertChannelsGcpPubsubCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data5`](../../doc/models/data-5.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "issueGrouping": null,
    "credentials": {
      "clientId": "clientId8",
      "privateKeyId": "privateKeyId0",
      "clientEmail": "clientEmail4",
      "privateKey": "privateKey6"
    },
    "projectId": "projectId0",
    "topicId": "topicId8"
  },
  "type": "GcpPubsub"
}
```

