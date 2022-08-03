
# Team Members Without Org Access Create Schema

## Structure

`TeamMembersWithoutOrgAccessCreateSchema`

## Inherits From

[`TeamMembersCreateSchema`](../../doc/models/team-members-create-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props24`](../../doc/models/props-24.md) | Required | - |
| `UserEnabled` | [`Models.UserEnabledEnum`](../../doc/models/user-enabled-enum.md) | Required | - |
| `UserName` | `string` | Required | user email address |

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
  "schemaOption": "Without_Org-Access"
}
```

