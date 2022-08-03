
# Report Rules Update Schema

## Structure

`ReportRulesUpdateSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters9`](../../doc/models/filters-9.md) | Optional | - |
| `IntgGuidList` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `ReportNotificationTypes` | [`Models.ReportNotificationTypes`](../../doc/models/report-notification-types.md) | Optional | - |

## Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "reportNotificationTypes": null
}
```

