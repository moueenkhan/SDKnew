
# Props 9

## Structure

`Props9`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `Tenant` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Subscriptions` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

## Example (as JSON)

```json
{
  "description": null,
  "tenant": "tenant4",
  "subscriptions": [
    "subscriptions9"
  ]
}
```

