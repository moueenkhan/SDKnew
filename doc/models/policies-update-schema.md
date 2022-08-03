
# Policies Update Schema

## Structure

`PoliciesUpdateSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PolicyType` | `string` | Optional | - |
| `QueryId` | `string` | Optional | - |
| `Title` | `string` | Optional | - |
| `Enabled` | `bool?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Remediation` | `string` | Optional | - |
| `Severity` | `string` | Optional | - |
| `Limit` | `double?` | Optional | **Constraints**: `>= 1` |
| `AlertEnabled` | `bool?` | Optional | - |
| `AlertProfile` | `string` | Optional | - |
| `ParamInfo` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "policyType": null,
  "queryId": null,
  "title": null,
  "enabled": null,
  "description": null,
  "remediation": null,
  "severity": null,
  "limit": null,
  "alertEnabled": null,
  "alertProfile": null,
  "paramInfo": null
}
```

