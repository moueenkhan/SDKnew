
# Credentials

## Structure

`Credentials`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&’*+/=?`{\|}~^-]+(?:\.[\w!#$%&’*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "clientId": "clientId6",
  "privateKeyId": "privateKeyId6",
  "clientEmail": "clientEmail0",
  "privateKey": "privateKey2"
}
```

