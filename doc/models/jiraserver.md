
# JIRASERVER

## Structure

`JIRASERVER`

## Inherits From

[`Data28`](../../doc/models/data-28.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `JiraUrl` | `string` | Required | **Constraints**: *Pattern*: `[A-Za-z0-9\/\-&?_.=:]+` |
| `ProjectId` | `string` | Required | - |
| `IssueType` | `string` | Required | - |
| `Username` | `string` | Required | - |
| `Password` | `string` | Required | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "jiraUrl": "jiraUrl4",
  "projectId": "projectId0",
  "issueType": "issueType0",
  "username": "username0",
  "password": "password4",
  "customTemplateFile": null,
  "jiraType": "JIRA_SERVER"
}
```

