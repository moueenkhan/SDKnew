
# Data 3

## Structure

`Data3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatadogType` | [`Models.DatadogServiceEnum`](../../doc/models/datadog-service-enum.md) | Required | **Default**: `DatadogServiceEnum.Enum_Logs Detail` |
| `DatadogSite` | [`Models.DatadogSiteEnum`](../../doc/models/datadog-site-enum.md) | Required | **Default**: `DatadogSiteEnum.com` |
| `ApiKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "datadogType": "Logs Detail",
  "datadogSite": "com",
  "apiKey": null
}
```

