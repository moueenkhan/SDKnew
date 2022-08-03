
# Github Container Registry 2

## Structure

`GithubContainerRegistry2`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials32`](../../doc/models/credentials-32.md) | Optional | - |
| `RegistryDomain` | [`Models.RegistryDomain6Enum?`](../../doc/models/registry-domain-6-enum.md) | Optional | **Default**: `RegistryDomain6Enum.Enum_ghcrio` |
| `RegistryNotifications` | `bool?` | Optional | - |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "credentials": null,
  "registryDomain": null,
  "registryNotifications": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null,
  "registryType": "GHCR"
}
```

