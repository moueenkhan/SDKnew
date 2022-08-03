
# AWSECRAWS Key ID Access Key

## Structure

`AWSECRAWSKeyIDAccessKey`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials8`](../../doc/models/access-key-credentials-8.md) | Required | - |
| `AwsAuthType` | `string` | Required, Constant | **Default**: `"AWS_ACCESS_KEY"` |
| `RegistryDomain` | `string` | Required | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "accessKeyCredentials": null,
  "awsAuthType": "AWS_ACCESS_KEY",
  "registryDomain": null
}
```

