
# Service Now Rest

## Structure

`ServiceNowRest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"ServiceNowRest"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data10`](../../doc/models/data-10.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "ServiceNowRest",
  "enabled": null,
  "data": null
}
```

