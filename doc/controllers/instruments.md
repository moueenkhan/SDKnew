# Instruments

```csharp
InstrumentsController instrumentsController = client.InstrumentsController;
```

## Class Name

`InstrumentsController`

## Methods

* [Get Instruments](../../doc/controllers/instruments.md#get-instruments)
* [Create Instrument](../../doc/controllers/instruments.md#create-instrument)
* [Get Instrument](../../doc/controllers/instruments.md#get-instrument)
* [Update Instrument](../../doc/controllers/instruments.md#update-instrument)
* [Delete Instrument](../../doc/controllers/instruments.md#delete-instrument)
* [Verify Instrument](../../doc/controllers/instruments.md#verify-instrument)


# Get Instruments

Retrieve all Instruments.

```csharp
GetInstrumentsAsync(
    int? offset = 0,
    int? limit = 20,
    string marketplaceId = null,
    string merchantId = null,
    string customerId = null,
    string correlationRefLabel = null,
    string correlationRefValue = null,
    bool? internalUseOnly = false)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |
| `marketplaceId` | `string` | Query, Optional | Filter by `marketplaceId`. |
| `merchantId` | `string` | Query, Optional | Filter by `merchantId`. |
| `customerId` | `string` | Query, Optional | Filter by `customerId`. |
| `correlationRefLabel` | `string` | Query, Optional | Filter by `correlationRef.label`. |
| `correlationRefValue` | `string` | Query, Optional | Filter by `correlationRef.value`. |
| `internalUseOnly` | `bool?` | Query, Optional | Indicates that internal-use-only fields should be returned.<br>**Default**: `false` |

## Response Type

[`Task<Models.InstrumentPage>`](../../doc/models/instrument-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
bool? internalUseOnly = false;

try
{
    InstrumentPage result = await instrumentsController.GetInstrumentsAsync(offset, limit, null, null, null, null, null, internalUseOnly);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Create Instrument

Create an Instrument.

```csharp
CreateInstrumentAsync(
    Models.CreateInstrumentRequest request,
    string xYapStoneIdempotentKey = null,
    bool? internalUseOnly = false)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateInstrumentRequest`](../../doc/models/create-instrument-request.md) | Body, Required | - |
| `xYapStoneIdempotentKey` | `string` | Header, Optional | - |
| `internalUseOnly` | `bool?` | Query, Optional | Indicates that internal-use-only fields should be returned.<br>**Default**: `false` |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
var request = new CreateInstrumentRequest();
request.Type = "type4";
request.Currency = "currency6";
request.Country = "country0";
request.NamesOnAccount = new List<NameOnAccount>();

var requestNamesOnAccount0 = new NameOnAccount();
requestNamesOnAccount0.Type = LegalEntityTypeEnum.INDIVIDUAL;
requestNamesOnAccount0.Name = "name2";
request.NamesOnAccount.Add(requestNamesOnAccount0);

request.Details = new Dictionary<string, string>();
request.Details.Add("key0", "details1");
request.Details.Add("key1", "details2");
bool? internalUseOnly = false;

try
{
    Instrument result = await instrumentsController.CreateInstrumentAsync(request, null, internalUseOnly);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 409 | Conflict | [`ErrorsException`](../../doc/models/errors-exception.md) |
| 422 | Unprocessable Entity | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Get Instrument

Retrieve an Instrument by id.

```csharp
GetInstrumentAsync(
    string id,
    bool? internalUseOnly = false)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `internalUseOnly` | `bool?` | Query, Optional | Indicates that internal-use-only fields should be returned.<br>**Default**: `false` |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
bool? internalUseOnly = false;

try
{
    Instrument result = await instrumentsController.GetInstrumentAsync(id, internalUseOnly);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Update Instrument

Update an Instrument by id.

```csharp
UpdateInstrumentAsync(
    string id,
    Models.UpdateInstrumentRequest request,
    string xYapStoneIdempotentKey = null,
    bool? internalUseOnly = false)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `request` | [`Models.UpdateInstrumentRequest`](../../doc/models/update-instrument-request.md) | Body, Required | - |
| `xYapStoneIdempotentKey` | `string` | Header, Optional | - |
| `internalUseOnly` | `bool?` | Query, Optional | Indicates that internal-use-only fields should be returned.<br>**Default**: `false` |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
var request = new UpdateInstrumentRequest();
request.Type = "type4";
request.Currency = "currency6";
request.Country = "country0";
request.NamesOnAccount = new List<NameOnAccount>();

var requestNamesOnAccount0 = new NameOnAccount();
requestNamesOnAccount0.Type = LegalEntityTypeEnum.INDIVIDUAL;
requestNamesOnAccount0.Name = "name2";
request.NamesOnAccount.Add(requestNamesOnAccount0);

request.Details = new Dictionary<string, string>();
request.Details.Add("key0", "details1");
request.Details.Add("key1", "details2");
bool? internalUseOnly = false;

try
{
    Instrument result = await instrumentsController.UpdateInstrumentAsync(id, request, null, internalUseOnly);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |
| 409 | Conflict | [`ErrorsException`](../../doc/models/errors-exception.md) |
| 422 | Unprocessable Entity | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Delete Instrument

Delete an Instrument by id.

```csharp
DeleteInstrumentAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";

try
{
    Instrument result = await instrumentsController.DeleteInstrumentAsync(id);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Verify Instrument

Request verification of an Instrument by id.

```csharp
VerifyInstrumentAsync(
    string id,
    Models.VerifyInstrumentRequest request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `request` | [`Models.VerifyInstrumentRequest`](../../doc/models/verify-instrument-request.md) | Body, Required | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
var request = new VerifyInstrumentRequest();

try
{
    Instrument result = await instrumentsController.VerifyInstrumentAsync(id, request);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |

