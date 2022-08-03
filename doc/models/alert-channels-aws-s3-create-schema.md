
# Alert Channels Aws S3 Create Schema

## Structure

`AlertChannelsAwsS3CreateSchema`

## Inherits From

[`AlertChannelsCreateSchema`](../../doc/models/alert-channels-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data`](../../doc/models/data.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "s3CrossAccountCredentials": {
      "externalId": "externalId6",
      "roleArn": "roleArn8",
      "bucketArn": "bucketArn2"
    }
  },
  "type": "AwsS3"
}
```

