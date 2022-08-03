
# Access Key Credentials 4

## Structure

`AccessKeyCredentials4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Optional | **Constraints**: *Pattern*: `^\d{12}$` |
| `AccessKeyId` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

## Example (as JSON)

```json
{
  "accountId": null,
  "accessKeyId": null,
  "secretAccessKey": null
}
```

