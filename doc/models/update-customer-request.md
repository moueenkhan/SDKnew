
# Update Customer Request

## Structure

`UpdateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<Models.CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Required | ISO 3166-1 alpha-2 or alpha-3 country code.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `3` |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`Models.LegalEntityRequest`](../../doc/models/legal-entity-request.md) | Required | **Important !** Depending on the value of the `type` parameter, the `LegalEntityRequest` model is extended with either [`IndividualLegalEntityRequest`](../../doc/models/individual-legal-entity-request.md) or [`BusinessLegalEntityRequest`](../../doc/models/business-legal-entity-request.md) |
| `Options` | [`Models.CustomerOptions`](../../doc/models/customer-options.md) | Optional | - |

## Example (as JSON)

```json
{
  "correlationRefs": null,
  "metadata": null,
  "displayName": null,
  "country": "country4",
  "timezone": null,
  "defaultCurrency": null,
  "defaultLanguage": null,
  "legalEntity": {
    "type": "INDIVIDUAL",
    "address": null,
    "phone": null,
    "email": null,
    "website": null,
    "socialNetworks": null,
    "digitalCurrencyAddresses": null,
    "additional": null
  },
  "options": null
}
```

