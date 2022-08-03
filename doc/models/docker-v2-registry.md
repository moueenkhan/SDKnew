
# Docker V2 Registry

## Structure

`DockerV2Registry`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials22`](../../doc/models/credentials-22.md) | Required | - |
| `RegistryDomain` | `string` | Required | - |
| `RegistryNotifications` | `bool?` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "credentials": {
    "username": "username4",
    "password": "password0",
    "ssl": null
  },
  "registryDomain": "registryDomain6",
  "registryNotifications": null,
  "limitByTag": null,
  "limitByLabel": null,
  "registryType": "V2_REGISTRY"
}
```

