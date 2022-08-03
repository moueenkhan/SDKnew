
# Filters 3

## Structure

`Filters3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Description` | `string` | Optional | - |
| `Enabled` | [`Models.EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | - |
| `ResourceGroups` | `List<string>` | Optional | one or more unique resource groups |
| `EventCategory` | [`List<Models.EventCategoryEnum>`](../../doc/models/event-category-enum.md) | Optional | one or more unique event categories<br>**Constraints**: *Unique Items Required* |
| `Severity` | [`List<Models.SeverityEnum>`](../../doc/models/severity-enum.md) | Optional | 1=Critical 2=High 3=Medium 4=Low 5=Info<br>**Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

## Example (as JSON)

```json
{
  "name": null,
  "description": null,
  "enabled": null,
  "resourceGroups": null,
  "eventCategory": null,
  "severity": null
}
```

