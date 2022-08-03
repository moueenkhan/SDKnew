
# Instrument

## Structure

`Instrument`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Created` | `DateTime?` | Optional | - |
| `Updated` | `DateTime?` | Optional | - |
| `CorrelationRefs` | [`List<Models.CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Parent` | [`Models.Parent`](../../doc/models/parent.md) | Optional | - |
| `Type` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Country` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `DisplayName` | `string` | Optional | - |
| `NamesOnAccount` | [`List<Models.NameOnAccount>`](../../doc/models/name-on-account.md) | Optional | - |
| `Address` | [`Models.Address`](../../doc/models/address.md) | Optional | - |
| `Details` | `Dictionary<string, string>` | Optional | - |
| `Fingerprints` | [`List<Models.Fingerprint>`](../../doc/models/fingerprint.md) | Optional | - |
| `Status` | [`Models.InstrumentStatus`](../../doc/models/instrument-status.md) | Optional | - |
| `Capabilities` | [`Models.Capabilities`](../../doc/models/capabilities.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "created": null,
  "updated": null,
  "correlationRefs": null,
  "metadata": null,
  "parent": null,
  "type": null,
  "currency": null,
  "country": null,
  "displayName": null,
  "namesOnAccount": null,
  "address": null,
  "details": null,
  "fingerprints": null,
  "status": null,
  "capabilities": null
}
```

