
# Alert Rules

## Structure

`AlertRules`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters`](../../doc/models/filters.md) | Required | - |
| `IntgGuidList` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Type` | `string` | Required, Constant | **Default**: `"Event"` |
| `McGuid` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "type": "Event"
}
```

