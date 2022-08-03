
# Data 10

## Structure

`Data10`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `UserName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Password` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `InstanceUrl` | `string` | Required | **Constraints**: *Pattern*: `^https://[A-Za-z0-9]+[.]{1}service-now[.]{1}com/?$` |
| `CustomTemplateFile` | `Stream` | Optional | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "userName": "userName2",
  "password": "password4",
  "instanceUrl": "instanceUrl6",
  "customTemplateFile": null
}
```

