
# S3 Cross Account Credentials 3

## Structure

`S3CrossAccountCredentials3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |
| `BucketArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:s3:([a-zA-Z0-9-_]+)?:([0-9]{12})?:([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

## Example (as JSON)

```json
{
  "externalId": null,
  "roleArn": null,
  "bucketArn": null
}
```

