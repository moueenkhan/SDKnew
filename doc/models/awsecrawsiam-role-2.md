
# AWSECRAWSIAM Role 2

## Structure

`AWSECRAWSIAMRole2`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials4`](../../doc/models/cross-account-credentials-4.md) | Optional | - |
| `AwsAuthType` | [`Models.AuthenticationTypeEnum?`](../../doc/models/authentication-type-enum.md) | Optional | **Default**: `AuthenticationTypeEnum.AWS_IAM` |
| `RegistryDomain` | `string` | Optional | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "crossAccountCredentials": null,
  "awsAuthType": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null,
  "registryType": "AWS_ECR"
}
```

