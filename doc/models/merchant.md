
# Merchant

## Structure

`Merchant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Created` | `DateTime?` | Optional | - |
| `Updated` | `DateTime?` | Optional | - |
| `CorrelationRefs` | [`List<Models.CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Type` | [`Models.MerchantTypeEnum?`](../../doc/models/merchant-type-enum.md) | Optional | - |
| `Parent` | [`Models.Parent`](../../doc/models/parent.md) | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`Models.LegalEntity`](../../doc/models/legal-entity.md) | Optional | **Important !** Depending on the value of the `type` parameter, the `LegalEntity` model is extended with either [`IndividualLegalEntity`](../../doc/models/individual-legal-entity.md) or [`BusinessLegalEntity`](../../doc/models/business-legal-entity.md) |
| `VolumeProjection` | [`Models.MerchantVolumeProjection`](../../doc/models/merchant-volume-projection.md) | Optional | - |
| `Consents` | [`List<Models.Consent>`](../../doc/models/consent.md) | Optional | - |
| `Capabilities` | [`Models.Capabilities`](../../doc/models/capabilities.md) | Optional | - |
| `Preferences` | [`Models.MerchantPreferences`](../../doc/models/merchant-preferences.md) | Optional | - |
| `Status` | [`Models.EntityStatus`](../../doc/models/entity-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "created": null,
  "updated": null,
  "correlationRefs": null,
  "metadata": null,
  "type": null,
  "parent": null,
  "displayName": null,
  "country": null,
  "timezone": null,
  "defaultCurrency": null,
  "defaultLanguage": null,
  "legalEntity": null,
  "volumeProjection": null,
  "consents": null,
  "capabilities": null,
  "preferences": null,
  "status": null
}
```

