
# Cross Account Credentials

## Structure

`CrossAccountCredentials`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Required | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

## Example (as JSON)

```json
{
  "externalId": "externalId4",
  "roleArn": "roleArn0"
}
```

