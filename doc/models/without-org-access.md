
# Without Org Access

## Structure

`WithoutOrgAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props24`](../../doc/models/props-24.md) | Required | - |
| `UserName` | `string` | Required | user email address |
| `UserEnabled` | [`Models.UserEnabledEnum`](../../doc/models/user-enabled-enum.md) | Required | - |
| `UserGuid` | `string` | Optional | user guid |
| `CustGuid` | `string` | Optional | customer guid |

## Example (as JSON)

```json
{
  "props": {
    "firstName": "firstName0",
    "lastName": "lastName8",
    "company": "company6",
    "accountAdmin": null
  },
  "userName": "userName2",
  "userEnabled": 1,
  "userGuid": null,
  "custGuid": null
}
```

