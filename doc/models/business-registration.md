
# Business Registration

## Structure

`BusinessRegistration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FormationDate` | `DateTime?` | Optional | Date of the company was created. |
| `FormationCountry` | `string` | Optional | The country where the business was created.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `3` |
| `FormationState` | `string` | Optional | The state or province where the business was created |

## Example (as JSON)

```json
{
  "formationDate": null,
  "formationCountry": null,
  "formationState": null
}
```

