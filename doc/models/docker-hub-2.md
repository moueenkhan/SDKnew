
# Docker Hub 2

## Structure

`DockerHub2`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials29`](../../doc/models/credentials-29.md) | Optional | - |
| `RegistryDomain` | [`Models.RegistryDomain3Enum?`](../../doc/models/registry-domain-3-enum.md) | Optional | **Default**: `RegistryDomain3Enum.Enum_indexdockerio` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "credentials": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null,
  "registryType": "DOCKERHUB"
}
```

