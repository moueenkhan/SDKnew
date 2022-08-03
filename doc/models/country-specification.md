
# Country Specification

## Structure

`CountrySpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `SupportedInstrumentTypes` | `List<string>` | Optional | - |
| `SupportedInstrumentCurrencies` | `List<string>` | Optional | - |
| `SupportedCapabilities` | [`List<Models.CapabilityTypeEnum>`](../../doc/models/capability-type-enum.md) | Optional | - |
| `RequiredFields` | [`Models.RequiredFields`](../../doc/models/required-fields.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "defaultCurrency": null,
  "supportedInstrumentTypes": null,
  "supportedInstrumentCurrencies": null,
  "supportedCapabilities": null,
  "requiredFields": null
}
```

