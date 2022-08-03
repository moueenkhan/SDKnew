
# Address

## Structure

`Address`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Line1` | `string` | Optional | Address line 1 (Street address/PO Box/Company name).<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048` |
| `Line2` | `string` | Optional | Address line 2 (Apartment/Suite/Unit/Building).<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048` |
| `Line3` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048` |
| `Line4` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048` |
| `City` | `string` | Optional | City/District/Suburb/Town/Village.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `State` | `string` | Optional | State/County/Province/Region.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `PostalCode` | `string` | Optional | ZIP or postal code<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64` |
| `Country` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |

## Example (as JSON)

```json
{
  "line1": null,
  "line2": null,
  "line3": null,
  "line4": null,
  "city": null,
  "state": null,
  "postalCode": null,
  "country": null
}
```

