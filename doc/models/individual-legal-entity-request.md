
# Individual Legal Entity Request

## Structure

`IndividualLegalEntityRequest`

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
| `Name` | [`Models.IndividualName`](../../doc/models/individual-name.md) | Required | The name of the person. It will consist of first, middle, last, additionalLast, honorificPrefix, and honorificSuffix. |
| `Gender` | [`Models.GenderEnum?`](../../doc/models/gender-enum.md) | Optional | - |
| `DateOfBirth` | `DateTime?` | Optional | The date of birth for the person, format should be (yyyy-mm-dd) |
| `CountryOfBirth` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `3` |
| `Nationality` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `3` |
| `IdentificationDocuments` | [`List<Models.IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |

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
  "name": {
    "honorificPrefix": null,
    "first": "first6",
    "middle": null,
    "last": "last0",
    "additionalLast": null,
    "honorificSuffix": null
  },
  "gender": null,
  "dateOfBirth": null,
  "countryOfBirth": null,
  "nationality": null,
  "identificationDocuments": null
}
```

