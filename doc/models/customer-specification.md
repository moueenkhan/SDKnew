
# Customer Specification

## Structure

`CustomerSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.LegalEntityTypeEnum?`](../../doc/models/legal-entity-type-enum.md) | Optional | the second description of type parameter |
| `Country` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `CommerceType` | `string` | Optional | - |
| `RequiredFields` | `List<string>` | Optional | - |
| `Additional` | [`List<Models.FieldSpecification>`](../../doc/models/field-specification.md) | Optional | - |
| `IdentityDocuments` | [`List<Models.RequiredIdentityDocuments>`](../../doc/models/required-identity-documents.md) | Optional | A list of required identity documents, each entity in the list should be considered as an OR condition. Only a single entry need be satisfied. |

## Example (as JSON)

```json
{
  "type": null,
  "country": null,
  "commerceType": null,
  "requiredFields": null,
  "additional": null,
  "identityDocuments": null
}
```

