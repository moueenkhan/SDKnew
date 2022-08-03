
# Property Rate Details

## Structure

`PropertyRateDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Min` | [`Models.Money`](../../doc/models/money.md) | Optional | - |
| `Max` | [`Models.Money`](../../doc/models/money.md) | Optional | - |
| `CleaningFee` | [`Models.Money`](../../doc/models/money.md) | Optional | - |
| `SameDayChargeAllowed` | `bool?` | Optional | - |
| `AutoPricing` | `bool?` | Optional | - |
| `RentingFrequency` | [`Models.RentingFrequencyEnum?`](../../doc/models/renting-frequency-enum.md) | Optional | - |
| `PaymentTerms` | [`Models.PaymentTermsEnum?`](../../doc/models/payment-terms-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "min": null,
  "max": null,
  "cleaningFee": null,
  "sameDayChargeAllowed": null,
  "autoPricing": null,
  "rentingFrequency": null,
  "paymentTerms": null
}
```

