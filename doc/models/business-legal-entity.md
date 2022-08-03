
# Business Legal Entity

## Structure

`BusinessLegalEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The Party ID of the Customer, for internal use only. Should not appear in user facing documentation. |
| `Type` | [`Models.LegalEntityTypeEnum`](../../doc/models/legal-entity-type-enum.md) | Required | the second description of type parameter |
| `Address` | [`Models.Address`](../../doc/models/address.md) | Optional | - |
| `Phone` | [`Models.Phone`](../../doc/models/phone.md) | Optional | - |
| `Email` | `string` | Optional | The email address. |
| `Website` | `string` | Optional | The website hostname. |
| `SocialNetworks` | [`List<Models.SocialNetwork>`](../../doc/models/social-network.md) | Optional | - |
| `DigitalCurrencyAddresses` | `List<string>` | Optional | - |
| `Additional` | `Dictionary<string, string>` | Optional | - |
| `Name` | `string` | Optional | The business's legal name. |
| `BusinessType` | [`Models.BusinessTypeEnum?`](../../doc/models/business-type-enum.md) | Optional | - |
| `Dba` | `List<string>` | Optional | Doing Busines As |
| `PrimaryContact` | [`Models.IndividualLegalEntity`](../../doc/models/individual-legal-entity.md) | Optional | - |
| `PrincipalOwner` | [`Models.LegalEntity`](../../doc/models/legal-entity.md) | Optional | **Important !** Depending on the value of the `type` parameter, the `LegalEntity` model is extended with either [`IndividualLegalEntity`](../../doc/models/individual-legal-entity.md) or [`BusinessLegalEntity`](../../doc/models/business-legal-entity.md) |
| `AdditionalOwners` | [`List<Models.LegalEntity>`](../../doc/models/legal-entity.md) | Optional | An array of any owners with at least 25% ownership of the company, excluding the principal owner responsible for the account. |
| `IdentityDocuments` | [`List<Models.IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |
| `Registration` | [`Models.BusinessRegistration`](../../doc/models/business-registration.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "type": "INDIVIDUAL",
  "address": null,
  "phone": null,
  "email": null,
  "website": null,
  "socialNetworks": null,
  "digitalCurrencyAddresses": null,
  "additional": null,
  "name": null,
  "businessType": null,
  "dba": null,
  "primaryContact": null,
  "principalOwner": null,
  "additionalOwners": null,
  "identityDocuments": null,
  "registration": null
}
```

