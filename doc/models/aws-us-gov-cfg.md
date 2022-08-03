
# Aws Us Gov Cfg

## Structure

`AwsUsGovCfg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"AwsUsGovCfg"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data64`](../../doc/models/data-64.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "AwsUsGovCfg",
  "enabled": null,
  "data": null
}
```

