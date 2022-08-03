
# AWSECRAWSIAM Role

## Structure

`AWSECRAWSIAMRole`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials`](../../doc/models/cross-account-credentials.md) | Required | - |
| `AwsAuthType` | `string` | Required, Constant | **Default**: `"AWS_IAM"` |
| `RegistryDomain` | `string` | Required | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "crossAccountCredentials": null,
  "awsAuthType": "AWS_IAM",
  "registryDomain": null
}
```

