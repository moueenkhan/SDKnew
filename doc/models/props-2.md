
# Props 2

## Structure

`Props2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Organization` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Projects` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

## Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "organization": "organization6",
  "projects": [
    "projects1",
    "projects2"
  ]
}
```

