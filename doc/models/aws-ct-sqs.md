
# Aws Ct Sqs

## Structure

`AwsCtSqs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"AwsCtSqs"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data63`](../../doc/models/data-63.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "AwsCtSqs",
  "enabled": null,
  "data": null
}
```

