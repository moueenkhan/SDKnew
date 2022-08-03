
# User Profile Response Schema

## Structure

`UserProfileResponseSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Required | - |
| `OrgAccount` | `bool` | Required | - |
| `Url` | `string` | Optional | - |
| `OrgAdmin` | `bool?` | Optional | - |
| `OrgUser` | `bool?` | Optional | - |
| `Accounts` | [`List<Models.Account>`](../../doc/models/account.md) | Required | list of accounts this user has access to<br>**Constraints**: *Minimum Items*: `1` |

## Example (as JSON)

```json
{
  "username": "username0",
  "orgAccount": false,
  "url": null,
  "orgAdmin": null,
  "orgUser": null,
  "accounts": [
    {
      "admin": null,
      "accountName": null,
      "custGuid": null,
      "userGuid": null,
      "userEnabled": null
    },
    {
      "admin": null,
      "accountName": null,
      "custGuid": null,
      "userGuid": null,
      "userEnabled": null
    }
  ]
}
```

