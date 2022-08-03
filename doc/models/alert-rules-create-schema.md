
# Alert Rules Create Schema

## Structure

`AlertRulesCreateSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters`](../../doc/models/filters.md) | Required | - |
| `IntgGuidList` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Type` | `string` | Required, Constant | **Default**: `"Event"` |

## Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "type": "Event"
}
```

