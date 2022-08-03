
# Create Merchant Request

## Structure

`CreateMerchantRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<Models.CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Type` | [`Models.MerchantTypeEnum`](../../doc/models/merchant-type-enum.md) | Required | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`Models.LegalEntityRequest`](../../doc/models/legal-entity-request.md) | Optional | **Important !** Depending on the value of the `type` parameter, the `LegalEntityRequest` model is extended with either [`IndividualLegalEntityRequest`](../../doc/models/individual-legal-entity-request.md) or [`BusinessLegalEntityRequest`](../../doc/models/business-legal-entity-request.md) |
| `Consents` | [`List<Models.Consent>`](../../doc/models/consent.md) | Optional | - |
| `Preferences` | [`Models.MerchantPreferences`](../../doc/models/merchant-preferences.md) | Optional | - |

## Example (as JSON)

```json
{
  "correlationRefs": null,
  "metadata": null,
  "type": "MERCHANT",
  "displayName": null,
  "country": null,
  "timezone": null,
  "defaultCurrency": null,
  "defaultLanguage": null,
  "legalEntity": null,
  "consents": null,
  "preferences": null
}
```

