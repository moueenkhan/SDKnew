
# Api V2 Access Tokens Request

## Structure

`ApiV2AccessTokensRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `KeyId` | `string` | Required | - |
| `ExpiryTime` | `int` | Required | Number of seconds, maximum value: 86400 or 24 hours. |

## Example (as JSON)

```json
{
  "keyId": "YourSecretKey",
  "expiryTime": 3600
}
```

