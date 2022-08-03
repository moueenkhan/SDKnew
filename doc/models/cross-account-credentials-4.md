
# Cross Account Credentials 4

## Structure

`CrossAccountCredentials4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

## Example (as JSON)

```json
{
  "externalId": null,
  "roleArn": null
}
```

