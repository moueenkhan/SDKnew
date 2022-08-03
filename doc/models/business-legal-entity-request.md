
# Business Legal Entity Request

## Structure

`BusinessLegalEntityRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.LegalEntityTypeEnum`](../../doc/models/legal-entity-type-enum.md) | Required | the second description of type parameter |
| `Address` | [`Models.Address`](../../doc/models/address.md) | Optional | - |
| `Phone` | [`Models.Phone`](../../doc/models/phone.md) | Optional | - |
| `Email` | `string` | Optional | The email address.<br>**Constraints**: *Maximum Length*: `512` |
| `Website` | `string` | Optional | **Constraints**: *Maximum Length*: `2048` |
| `SocialNetworks` | [`List<Models.SocialNetwork>`](../../doc/models/social-network.md) | Optional | - |
| `DigitalCurrencyAddresses` | `List<string>` | Optional | - |
| `Additional` | `Dictionary<string, string>` | Optional | - |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |
| `BusinessType` | [`Models.BusinessTypeEnum?`](../../doc/models/business-type-enum.md) | Optional | - |
| `Dba` | `List<string>` | Optional | Doing Business As |
| `PrimaryContact` | [`Models.IndividualLegalEntityRequest`](../../doc/models/individual-legal-entity-request.md) | Optional | - |
| `PrincipalOwner` | [`Models.LegalEntityRequest`](../../doc/models/legal-entity-request.md) | Optional | **Important !** Depending on the value of the `type` parameter, the `LegalEntityRequest` model is extended with either [`IndividualLegalEntityRequest`](../../doc/models/individual-legal-entity-request.md) or [`BusinessLegalEntityRequest`](../../doc/models/business-legal-entity-request.md) |
| `AdditionalOwners` | [`List<Models.LegalEntityRequest>`](../../doc/models/legal-entity-request.md) | Optional | An array of any owners with at least 25% ownership of the company, excluding the principal owner responsible for the account. |
| `IdentityDocuments` | [`List<Models.IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |
| `Registration` | [`Models.BusinessRegistration`](../../doc/models/business-registration.md) | Optional | - |

## Example (as JSON)

```json
{
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

