
# Container Registries Cont Vuln Cfg Response Schema

## Structure

`ContainerRegistriesContVulnCfgResponseSchema`

## Inherits From

[`ContainerRegistriesResponseSchema`](../../doc/models/container-registries-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "key1": "val1",
    "key2": "val2"
  },
  "isOrg": null,
  "props": null,
  "type": "ContVulnCfg"
}
```

