
# Container Registries Cont Vuln Cfg Update Schema

## Structure

`ContainerRegistriesContVulnCfgUpdateSchema`

## Inherits From

[`ContainerRegistriesUpdateSchema`](../../doc/models/container-registries-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null,
  "type": "ContVulnCfg"
}
```

