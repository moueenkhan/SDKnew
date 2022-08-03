
# Legal Entity

**Important !** Depending on the value of the `type` parameter, the `LegalEntity` model is extended with either [`IndividualLegalEntity`](../../doc/models/individual-legal-entity.md) or [`BusinessLegalEntity`](../../doc/models/business-legal-entity.md)

## Structure

`LegalEntity`

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
  "additional": null
}
```

