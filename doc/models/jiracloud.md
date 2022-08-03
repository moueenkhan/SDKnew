
# JIRACLOUD

## Structure

`JIRACLOUD`

## Inherits From

[`Data28`](../../doc/models/data-28.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `JiraUrl` | `string` | Required | **Constraints**: *Pattern*: `[a-zA-Z0-9]\.(atlassian\.net\|jira\.com)$` |
| `ProjectId` | `string` | Required | - |
| `IssueType` | `string` | Required | - |
| `Username` | `string` | Required | - |
| `ApiToken` | `string` | Required | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "jiraUrl": "jiraUrl4",
  "projectId": "projectId0",
  "issueType": "issueType0",
  "username": "username0",
  "apiToken": "apiToken6",
  "customTemplateFile": null,
  "jiraType": "JIRA_CLOUD"
}
```

