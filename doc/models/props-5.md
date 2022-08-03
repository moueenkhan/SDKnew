
# Props 5

## Structure

`Props5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `LwAccounts` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

## Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "lwAccounts": [
    "lwAccounts2",
    "lwAccounts3",
    "lwAccounts4"
  ]
}
```

