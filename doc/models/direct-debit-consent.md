
# Direct Debit Consent

## Structure

`DirectDebitConsent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.Type1Enum`](../../doc/models/type-1-enum.md) | Required | - |
| `TimeOfConsent` | `DateTime` | Required | - |
| `Version` | `int` | Required | - |
| `Frequency` | [`Models.FrequencyEnum?`](../../doc/models/frequency-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "TERMS_OF_SERVICE",
  "timeOfConsent": "2016-03-13T12:52:32.123Z",
  "version": 172,
  "frequency": null
}
```

