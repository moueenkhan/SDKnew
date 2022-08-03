
# Filters 6

## Structure

`Filters6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Description` | `string` | Optional | - |
| `Enabled` | [`Models.EnabledEnum`](../../doc/models/enabled-enum.md) | Required | - |
| `ResourceGroups` | `List<string>` | Optional | one or more unique resource groups |
| `Severity` | [`List<Models.SeverityEnum>`](../../doc/models/severity-enum.md) | Required | 1=Critical 2=High 3=Medium 4=Low 5=Info<br>**Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

## Example (as JSON)

```json
{
  "name": "name0",
  "description": null,
  "enabled": 0,
  "resourceGroups": null,
  "severity": [
    1
  ]
}
```

