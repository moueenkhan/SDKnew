
# Payment Method Specification

## Structure

`PaymentMethodSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `SupportedCountries` | `List<string>` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `SupportedCurrencies` | `List<string>` | Optional | ISO 4217 currency code. |
| `RequiredFields` | `List<string>` | Optional | - |
| `Details` | [`List<Models.FieldSpecification>`](../../doc/models/field-specification.md) | Optional | Describes payment method specific details, accepted in the payment request. |
| `Actions` | [`List<Models.FieldSpecification>`](../../doc/models/field-specification.md) | Optional | Describes action fields returned in the payment response. |
| `SupportedInstrumentTypes` | `List<string>` | Optional | Describes the supported instrument type that can be used with this payment method. |
| `RequiresInstrument` | `bool?` | Optional | Indicates if this payment method requires one of the supported instrument types to be supplied. |

## Example (as JSON)

```json
{
  "name": null,
  "displayName": null,
  "supportedCountries": null,
  "supportedCurrencies": null,
  "requiredFields": null,
  "details": null,
  "actions": null,
  "supportedInstrumentTypes": null,
  "requiresInstrument": null
}
```

