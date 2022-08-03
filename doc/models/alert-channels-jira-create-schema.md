
# Alert Channels Jira Create Schema

## Structure

`AlertChannelsJiraCreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "key1": "val1",
    "key2": "val2"
  },
  "type": "Jira"
}
```

