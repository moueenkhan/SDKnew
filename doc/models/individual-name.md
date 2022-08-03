
# Individual Name

The name of the person. It will consist of first, middle, last, additionalLast, honorificPrefix, and honorificSuffix.

## Structure

`IndividualName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HonorificPrefix` | `string` | Optional | The persons title.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |
| `First` | `string` | Required | The persons first name.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |
| `Middle` | `string` | Optional | The persons middle name or initial.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |
| `Last` | `string` | Required | The persons last name.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |
| `AdditionalLast` | `string` | Optional | The 2nd last name of the person.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |
| `HonorificSuffix` | `string` | Optional | The persons title.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `512` |

## Example (as JSON)

```json
{
  "honorificPrefix": null,
  "first": "first6",
  "middle": null,
  "last": "last0",
  "additionalLast": null,
  "honorificSuffix": null
}
```

