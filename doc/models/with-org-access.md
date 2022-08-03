
# With Org Access

## Structure

`WithOrgAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props24`](../../doc/models/props-24.md) | Required | - |
| `OrgAdmin` | `bool` | Required | should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored<br>**Default**: `false` |
| `OrgUser` | `bool` | Required | should this user be the org user of this org, userRoleAccounts list will be ignored<br>**Default**: `false` |
| `AdminRoleAccounts` | `List<string>` | Required | list of account names that this user will be admin |
| `UserRoleAccounts` | `List<string>` | Required | list of account names that this user will be user |
| `UserName` | `string` | Required | user email address |
| `UserEnabled` | [`Models.UserEnabledEnum`](../../doc/models/user-enabled-enum.md) | Required | - |
| `UserGuid` | `string` | Optional | user guid |

## Example (as JSON)

```json
{
  "props": null,
  "orgAdmin": false,
  "orgUser": false,
  "adminRoleAccounts": null,
  "userRoleAccounts": null,
  "userName": null,
  "userEnabled": null
}
```

