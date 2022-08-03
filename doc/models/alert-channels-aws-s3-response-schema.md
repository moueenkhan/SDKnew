
# Alert Channels Aws S3 Response Schema

## Structure

`AlertChannelsAwsS3ResponseSchema`

## Inherits From

[`AlertChannelsResponseSchema`](../../doc/models/alert-channels-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data`](../../doc/models/data.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

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
  "isOrg": null,
  "props": null,
  "type": "AwsS3"
}
```

