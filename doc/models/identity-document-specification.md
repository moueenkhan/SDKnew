
# Identity Document Specification

## Structure

`IdentityDocumentSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Types` | [`List<Models.LegalEntityTypeEnum>`](../../doc/models/legal-entity-type-enum.md) | Optional | - |
| `SupportedCountries` | `List<string>` | Optional | - |
| `Details` | [`List<Models.FieldSpecification>`](../../doc/models/field-specification.md) | Optional | - |
| `Fingerprints` | [`List<Models.FingerprintSpecification>`](../../doc/models/fingerprint-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": null,
  "displayName": null,
  "types": null,
  "supportedCountries": null,
  "details": null,
  "fingerprints": null
}
```

