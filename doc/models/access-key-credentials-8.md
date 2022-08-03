
# Access Key Credentials 8

## Structure

`AccessKeyCredentials8`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyId` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

## Example (as JSON)

```json
{
  "accessKeyId": "accessKeyId4",
  "secretAccessKey": "secretAccessKey0"
}
```

