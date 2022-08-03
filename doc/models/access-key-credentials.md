
# Access Key Credentials

## Structure

`AccessKeyCredentials`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | **Constraints**: *Pattern*: `^\d{12}$` |
| `AccessKeyId` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

## Example (as JSON)

```json
{
  "accountId": "accountId0",
  "accessKeyId": "accessKeyId4",
  "secretAccessKey": "secretAccessKey0"
}
```

