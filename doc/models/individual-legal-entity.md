
# Individual Legal Entity

## Structure

`IndividualLegalEntity`

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
| `Name` | [`Models.IndividualName`](../../doc/models/individual-name.md) | Optional | The name of the person. It will consist of first, middle, last, additionalLast, honorificPrefix, and honorificSuffix. |
| `Gender` | [`Models.GenderEnum?`](../../doc/models/gender-enum.md) | Optional | - |
| `DateOfBirth` | `DateTime?` | Optional | - |
| `CountryOfBirth` | `string` | Optional | The country of birth for the person. |
| `Nationality` | `string` | Optional | The nationality of the person. |
| `IdentificationDocuments` | [`List<Models.IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |

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
  "gender": null,
  "dateOfBirth": null,
  "countryOfBirth": null,
  "nationality": null,
  "identificationDocuments": null
}
```

