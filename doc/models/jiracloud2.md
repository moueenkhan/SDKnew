
# JIRACLOUD2

## Structure

`JIRACLOUD2`

## Inherits From

[`Data28`](../../doc/models/data-28.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `JiraUrl` | `string` | Optional | **Constraints**: *Pattern*: `[a-zA-Z0-9]\.(atlassian\.net\|jira\.com)$` |
| `ProjectId` | `string` | Optional | - |
| `IssueType` | `string` | Optional | - |
| `Username` | `string` | Optional | - |
| `ApiToken` | `string` | Optional | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "jiraUrl": null,
  "projectId": null,
  "issueType": null,
  "username": null,
  "apiToken": null,
  "customTemplateFile": null,
  "jiraType": "JIRA_CLOUD"
}
```

