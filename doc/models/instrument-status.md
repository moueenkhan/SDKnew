
# Instrument Status

## Structure

`InstrumentStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | [`Models.EntityStateEnum?`](../../doc/models/entity-state-enum.md) | Optional | - |
| `DisabledReasons` | `List<string>` | Optional | - |
| `History` | [`List<Models.EntityStatusHistory>`](../../doc/models/entity-status-history.md) | Optional | - |
| `Validation` | [`Models.ValidationStatus`](../../doc/models/validation-status.md) | Optional | - |
| `Verification` | [`Models.VerificationStatus`](../../doc/models/verification-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "state": null,
  "disabledReasons": null,
  "history": null,
  "validation": null,
  "verification": null
}
```

