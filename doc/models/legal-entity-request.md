
# Legal Entity Request

**Important !** Depending on the value of the `type` parameter, the `LegalEntityRequest` model is extended with either [`IndividualLegalEntityRequest`](../../doc/models/individual-legal-entity-request.md) or [`BusinessLegalEntityRequest`](../../doc/models/business-legal-entity-request.md)

## Structure

`LegalEntityRequest`

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
  "additional": null
}
```

