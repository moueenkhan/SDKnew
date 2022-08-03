
# AWSECRAWS Key ID Access Key 2

## Structure

`AWSECRAWSKeyIDAccessKey2`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials10`](../../doc/models/access-key-credentials-10.md) | Optional | - |
| `AwsAuthType` | [`Models.AuthenticationType1Enum?`](../../doc/models/authentication-type-1-enum.md) | Optional | **Default**: `AuthenticationType1Enum.AWS_ACCESS_KEY` |
| `RegistryDomain` | `string` | Optional | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "accessKeyCredentials": null,
  "awsAuthType": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null,
  "registryType": "AWS_ECR-AWS_ACCESS_KEY"
}
```

