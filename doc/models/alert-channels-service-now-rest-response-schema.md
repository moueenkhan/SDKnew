
# Alert Channels Service Now Rest Response Schema

## Structure

`AlertChannelsServiceNowRestResponseSchema`

## Inherits From

[`AlertChannelsResponseSchema`](../../doc/models/alert-channels-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data10`](../../doc/models/data-10.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "issueGrouping": null,
    "userName": "userName2",
    "password": "password4",
    "instanceUrl": "instanceUrl4",
    "customTemplateFile": null
  },
  "isOrg": null,
  "props": null,
  "type": "ServiceNowRest"
}
```

