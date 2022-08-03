
# Google Container Registry GAR2

## Structure

`GoogleContainerRegistryGAR2`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials30`](../../doc/models/credentials-30.md) | Optional | - |
| `RegistryDomain` | [`Models.RegistryDomain2Enum?`](../../doc/models/registry-domain-2-enum.md) | Optional | **Default**: `RegistryDomain2Enum.Enum_uswest1dockerpkgdev` |
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
  "registryType": "GCP_GAR"
}
```

