
# Docker V2 Registry 2

## Structure

`DockerV2Registry2`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials32`](../../doc/models/credentials-32.md) | Optional | - |
| `RegistryDomain` | `string` | Optional | - |
| `RegistryNotifications` | `bool?` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "credentials": null,
  "registryDomain": null,
  "registryNotifications": null,
  "limitByTag": null,
  "limitByLabel": null,
  "registryType": "V2_REGISTRY"
}
```

