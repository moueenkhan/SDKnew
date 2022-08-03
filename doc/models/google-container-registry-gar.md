
# Google Container Registry GAR

## Structure

`GoogleContainerRegistryGAR`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials21`](../../doc/models/credentials-21.md) | Required | - |
| `RegistryDomain` | [`Models.RegistryDomain2Enum`](../../doc/models/registry-domain-2-enum.md) | Required | **Default**: `RegistryDomain2Enum.Enum_uswest1dockerpkgdev` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "credentials": null,
  "registryDomain": "us-west1-docker.pkg.dev"
}
```

