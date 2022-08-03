
# Consent

**Important !** If the value of the `type` parameter is `DIRECT_DEBIT`, the `Consent` model can be extended with [`DirectDebitConsent`](../../doc/models/direct-debit-consent.md)

## Structure

`Consent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.Type1Enum`](../../doc/models/type-1-enum.md) | Required | - |
| `TimeOfConsent` | `DateTime` | Required | - |
| `Version` | `int` | Required | - |

## Example (as JSON)

```json
{
  "type": "TERMS_OF_SERVICE",
  "timeOfConsent": "2016-03-13T12:52:32.123Z",
  "version": 172
}
```

