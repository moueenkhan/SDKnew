
# Policies Create Schema

## Structure

`PoliciesCreateSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PolicyType` | `string` | Required | - |
| `QueryId` | `string` | Required | - |
| `Title` | `string` | Required | - |
| `Enabled` | `bool` | Required | - |
| `Description` | `string` | Required | - |
| `Remediation` | `string` | Required | - |
| `Severity` | `string` | Required | - |
| `Limit` | `double?` | Optional | **Constraints**: `>= 1` |
| `AlertEnabled` | `bool` | Required | - |
| `AlertProfile` | `string` | Required | - |
| `ParamInfo` | `object` | Optional | - |
| `EvaluatorId` | `string` | Required | Identifier of the evaluator in which this policy is to be run |

## Example (as JSON)

```json
{
  "policyType": "policyType4",
  "queryId": "queryId6",
  "title": "title4",
  "enabled": false,
  "description": "description0",
  "remediation": "remediation4",
  "severity": "severity0",
  "limit": null,
  "alertEnabled": false,
  "alertProfile": "alertProfile4",
  "paramInfo": null,
  "evaluatorId": "evaluatorId0"
}
```

