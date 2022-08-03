
# Aws Us Gov Ct Sqs

## Structure

`AwsUsGovCtSqs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"AwsUsGovCtSqs"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data65`](../../doc/models/data-65.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "AwsUsGovCtSqs",
  "enabled": null,
  "data": null
}
```

