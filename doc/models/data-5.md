
# Data 5

## Structure

`Data5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `Credentials` | [`Models.Credentials`](../../doc/models/credentials.md) | Required | - |
| `ProjectId` | `string` | Required | - |
| `TopicId` | `string` | Required | - |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "credentials": {
    "clientId": "clientId0",
    "privateKeyId": "privateKeyId2",
    "clientEmail": "clientEmail6",
    "privateKey": "privateKey8"
  },
  "projectId": "projectId0",
  "topicId": "topicId2"
}
```

