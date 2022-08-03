
# Team Members With Org Access Update Schema

## Structure

`TeamMembersWithOrgAccessUpdateSchema`

## Inherits From

[`TeamMembersUpdateSchema`](../../doc/models/team-members-update-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props30`](../../doc/models/props-30.md) | Optional | - |
| `OrgAdmin` | `bool?` | Optional | should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored<br>**Default**: `false` |
| `OrgUser` | `bool?` | Optional | should this user be the org user of this org, userRoleAccounts list will be ignored<br>**Default**: `false` |
| `AdminRoleAccounts` | `List<string>` | Optional | list of account names that this user will be admin |
| `UserRoleAccounts` | `List<string>` | Optional | list of account names that this user will be user |
| `UserEnabled` | [`Models.UserEnabledEnum?`](../../doc/models/user-enabled-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "props": null,
  "orgAdmin": null,
  "orgUser": null,
  "adminRoleAccounts": null,
  "userRoleAccounts": null,
  "userEnabled": null,
  "schemaOption": "With_Org-Access"
}
```

