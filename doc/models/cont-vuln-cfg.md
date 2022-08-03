
# Cont Vuln Cfg

## Structure

`ContVulnCfg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"ContVulnCfg"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | `object` | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "ContVulnCfg",
  "enabled": null,
  "data": null
}
```

