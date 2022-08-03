
# Gcp at Ses

## Structure

`GcpAtSes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"GcpAtSes"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data68`](../../doc/models/data-68.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "GcpAtSes",
  "enabled": null,
  "data": null
}
```

