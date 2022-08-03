
# Risk Status History

## Structure

`RiskStatusHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime?` | Optional | - |
| `Decision` | [`Models.RiskDecisionEnum?`](../../doc/models/risk-decision-enum.md) | Optional | - |
| `DeclinedReasons` | `List<string>` | Optional | - |
| `RequiredActions` | [`List<Models.RiskRequiredAction>`](../../doc/models/risk-required-action.md) | Optional | - |

## Example (as JSON)

```json
{
  "timestamp": null,
  "decision": null,
  "declinedReasons": null,
  "requiredActions": null
}
```

