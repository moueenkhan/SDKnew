
# Risk Status

## Structure

`RiskStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Decision` | [`Models.RiskDecisionEnum?`](../../doc/models/risk-decision-enum.md) | Optional | - |
| `DeclinedReasons` | `List<string>` | Optional | - |
| `RequiredActions` | [`List<Models.RiskRequiredAction>`](../../doc/models/risk-required-action.md) | Optional | - |
| `History` | [`List<Models.RiskStatusHistory>`](../../doc/models/risk-status-history.md) | Optional | - |

## Example (as JSON)

```json
{
  "decision": null,
  "declinedReasons": null,
  "requiredActions": null,
  "history": null
}
```

