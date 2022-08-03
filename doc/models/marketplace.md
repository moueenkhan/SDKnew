
# Marketplace

## Structure

`Marketplace`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Created` | `DateTime?` | Optional | - |
| `Updated` | `DateTime?` | Optional | - |
| `CorrelationRefs` | [`List<Models.CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Parent` | [`Models.Parent`](../../doc/models/parent.md) | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`Models.LegalEntity`](../../doc/models/legal-entity.md) | Optional | **Important !** Depending on the value of the `type` parameter, the `LegalEntity` model is extended with either [`IndividualLegalEntity`](../../doc/models/individual-legal-entity.md) or [`BusinessLegalEntity`](../../doc/models/business-legal-entity.md) |
| `Preferences` | [`Models.MarketplacePreferences`](../../doc/models/marketplace-preferences.md) | Optional | - |
| `Capabilities` | [`Models.Capabilities`](../../doc/models/capabilities.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "created": null,
  "updated": null,
  "correlationRefs": null,
  "metadata": null,
  "parent": null,
  "displayName": null,
  "country": null,
  "timezone": null,
  "defaultCurrency": null,
  "defaultLanguage": null,
  "legalEntity": null,
  "preferences": null,
  "capabilities": null
}
```

