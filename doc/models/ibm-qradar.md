
# Ibm Qradar

## Structure

`IbmQradar`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"IbmQradar"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data6`](../../doc/models/data-6.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "IbmQradar",
  "enabled": null,
  "data": {
    "qradarCommType": "HTTPS",
    "qradarHostUrl": null
  }
}
```

