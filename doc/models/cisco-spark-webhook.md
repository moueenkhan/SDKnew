
# Cisco Spark Webhook

## Structure

`CiscoSparkWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"CiscoSparkWebhook"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data1`](../../doc/models/data-1.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "CiscoSparkWebhook",
  "enabled": null,
  "data": null
}
```

