
# Team Members Without Org Access Response Schema

## Structure

`TeamMembersWithoutOrgAccessResponseSchema`

## Inherits From

[`TeamMembersResponseSchema`](../../doc/models/team-members-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props24`](../../doc/models/props-24.md) | Required | - |
| `UserEnabled` | [`Models.UserEnabledEnum`](../../doc/models/user-enabled-enum.md) | Required | - |
| `UserName` | `string` | Required | user email address |
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
  "userEnabled": 1,
  "userName": "userName2",
  "userGuid": null,
  "custGuid": null,
  "schemaOption": "Without_Org-Access"
}
```

