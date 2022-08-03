
# Access Key Credentials 10

## Structure

`AccessKeyCredentials10`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyId` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

## Example (as JSON)

```json
{
  "accessKeyId": null,
  "secretAccessKey": null
}
```

