
# Data 2

## Structure

`Data2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](../../doc/models/group-issues-by-enum.md) | Optional | **Default**: `GroupIssuesByEnum.Events` |
| `EventBusArn` | `string` | Required | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:events:([a-zA-Z0-9]{1}[a-zA-Z0-9-]+[a-zA-Z0-9]{1}):([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)?$` |

## Example (as JSON)

```json
{
  "issueGrouping": null,
  "eventBusArn": "eventBusArn2"
}
```

