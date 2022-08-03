
# Datadog

## Structure

`Datadog`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"Datadog"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data3`](../../doc/models/data-3.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "Datadog",
  "enabled": null,
  "data": {
    "datadogType": "Logs Detail",
    "datadogSite": "com",
    "apiKey": null
  }
}
```

