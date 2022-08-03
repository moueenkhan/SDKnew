
# Instrument Specification

## Structure

`InstrumentSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `SupportedCountries` | `List<string>` | Optional | ISO 3166-1 alpha-2 or alpha-3 country codes. |
| `SupportedCurrencies` | `List<string>` | Optional | - |
| `RequiredFields` | `List<string>` | Optional | - |
| `Details` | [`List<Models.FieldSpecification>`](../../doc/models/field-specification.md) | Optional | - |
| `Fingerprints` | [`List<Models.FingerprintSpecification>`](../../doc/models/fingerprint-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "displayName": null,
  "supportedCountries": null,
  "supportedCurrencies": null,
  "requiredFields": null,
  "details": null,
  "fingerprints": null
}
```

