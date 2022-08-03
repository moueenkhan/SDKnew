
# Create Instrument Request

## Structure

`CreateInstrumentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<Models.CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Options` | [`Models.InstrumentOptions`](../../doc/models/instrument-options.md) | Optional | - |
| `Parent` | [`Models.Parent`](../../doc/models/parent.md) | Optional | - |
| `Type` | `string` | Required | - |
| `Currency` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `Country` | `string` | Required | ISO 3166-1 alpha-2 or alpha-3 country code.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `3` |
| `DisplayName` | `string` | Optional | - |
| `NamesOnAccount` | [`List<Models.NameOnAccount>`](../../doc/models/name-on-account.md) | Required | **Constraints**: *Minimum Items*: `1` |
| `Address` | [`Models.Address`](../../doc/models/address.md) | Optional | - |
| `Details` | `Dictionary<string, string>` | Required | - |

## Example (as JSON)

```json
{
  "correlationRefs": null,
  "metadata": null,
  "options": null,
  "parent": null,
  "type": "type0",
  "currency": "currency0",
  "country": "country4",
  "displayName": null,
  "namesOnAccount": [
    {
      "type": "INDIVIDUAL",
      "name": "name6"
    },
    {
      "type": "BUSINESS",
      "name": "name7"
    }
  ],
  "address": null,
  "details": {
    "key0": "details5",
    "key1": "details6",
    "key2": "details7"
  }
}
```

