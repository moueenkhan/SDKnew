
# Azure Al Seq

## Structure

`AzureAlSeq`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required, Constant | **Default**: `"AzureAlSeq"` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data66`](../../doc/models/data-66.md) | Required | - |

## Example (as JSON)

```json
{
  "name": null,
  "type": "AzureAlSeq",
  "enabled": null,
  "data": null
}
```

