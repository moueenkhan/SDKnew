
# Props 1

## Structure

`Props1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Tenant` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Subscriptions` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

## Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "tenant": "tenant4",
  "subscriptions": [
    "subscriptions9"
  ]
}
```

