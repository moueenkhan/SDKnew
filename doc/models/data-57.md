
# Data 57

## Structure

`Data57`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `UserName` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Password` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `InstanceUrl` | `string` | Optional | **Constraints**: *Pattern*: `^https://[A-Za-z0-9]+[.]{1}service-now[.]{1}com/?$` |
| `CustomTemplateFile` | `Stream` | Optional | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "userName": null,
  "password": null,
  "instanceUrl": null,
  "customTemplateFile": null
}
```

