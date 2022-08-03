
# Credentials 3

## Structure

`Credentials3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&’*+/=?`{\|}~^-]+(?:\.[\w!#$%&’*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "clientId": null,
  "privateKeyId": null,
  "clientEmail": null,
  "privateKey": null
}
```

