
# JIRASERVER2

## Structure

`JIRASERVER2`

## Inherits From

[`Data28`](../../doc/models/data-28.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `JiraUrl` | `string` | Optional | **Constraints**: *Pattern*: `[A-Za-z0-9\/\-&?_.=:]+` |
| `ProjectId` | `string` | Optional | - |
| `IssueType` | `string` | Optional | - |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "jiraUrl": null,
  "projectId": null,
  "issueType": null,
  "username": null,
  "password": null,
  "customTemplateFile": null,
  "jiraType": "JIRA_SERVER"
}
```

