# SCHEMAS

Get details about the available Lacework schemas.

```csharp
SCHEMASController sCHEMASController = client.SCHEMASController;
```

## Class Name

`SCHEMASController`

## Methods

* [Schema Details](../../doc/controllers/schemas.md#schema-details)
* [Schema Details of Subtype](../../doc/controllers/schemas.md#schema-details-of-subtype)


# Schema Details

Get a list of available Lacework schema types by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/schemas`

Get details about a Lacework schema by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/schemas/{type}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/schemas/AuditLogs`

```csharp
SchemaDetailsAsync(
    string authorization,
    string contentType,
    string type)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | `string` | Template, Required | The schema type, or empty for a list of all schema types |

## Response Type

`Task<object>`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string type = "AuditLogs";

try
{
    object result = await sCHEMASController.SchemaDetailsAsync(authorization, contentType, type);
}
catch (ApiException e){};
```

## Example Response

```
[
  {
    "name": "accountName",
    "type": "string"
  },
  {
    "name": "createdTime",
    "type": "integer"
  },
  {
    "name": "eventDescription",
    "type": "string"
  },
  {
    "name": "eventName",
    "type": "string"
  },
  {
    "name": "userAction",
    "type": "string"
  },
  {
    "name": "userName",
    "type": "string"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 401 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 402 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 403 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 404 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 405 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 406 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 407 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 408 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 409 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 410 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 411 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 412 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 413 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 414 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 415 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 416 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 417 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 418 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 419 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 420 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 421 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 422 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 423 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 424 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 425 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 426 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 427 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 428 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 429 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 430 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 431 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 432 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 433 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 434 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 435 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 436 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 437 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 438 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 439 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 440 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 441 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 442 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 443 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 444 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 445 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 446 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 447 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 448 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 449 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 450 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 451 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 452 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 453 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 454 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 455 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 456 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 457 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 458 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 459 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 460 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 461 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 462 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 463 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 464 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 465 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 466 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 467 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 468 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 469 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 470 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 471 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 472 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 473 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 474 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 475 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 476 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 477 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 478 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 479 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 480 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 481 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 482 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 483 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 484 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 485 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 486 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 487 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 488 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 489 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 490 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 491 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 492 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 493 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 494 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 495 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 496 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 497 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 498 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 499 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 501 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 502 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 503 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 504 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 505 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 506 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 507 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 508 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 509 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 510 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 511 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 512 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 513 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 514 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 515 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 516 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 517 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 518 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 519 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 520 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 521 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 522 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 523 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 524 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 525 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 526 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 527 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 528 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 529 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 530 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 531 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 532 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 533 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 534 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 535 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 536 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 537 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 538 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 539 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 540 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 541 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 542 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 543 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 544 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 545 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 546 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 547 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 548 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 549 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 550 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 551 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 552 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 553 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 554 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 555 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 556 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 557 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 558 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 559 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 560 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 561 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 562 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 563 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 564 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 565 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 566 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 567 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 568 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 569 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 570 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 571 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 572 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 573 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 574 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 575 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 576 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 577 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 578 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 579 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 580 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 581 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 582 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 583 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 584 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 585 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 586 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 587 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 588 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 589 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 590 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 591 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 592 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 593 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 594 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 595 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 596 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 597 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 598 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 599 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |


# Schema Details of Subtype

Get details about a Lacework schema by specifying a schema type and subtype  when invoking the endpoint.

> `GET https://YourLacework.lacework.net/api/v2/schemas/{type}/{subtype}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/schemas/AlertChannels/SlackChannel`

```csharp
SchemaDetailsOfSubtypeAsync(
    string authorization,
    string contentType,
    string type,
    string subtype)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | `string` | Template, Required | the schema type |
| `subtype` | `string` | Template, Required | the subtype |

## Response Type

`Task<object>`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string type = "AlertChannels";
string subtype = "SlackChannel";

try
{
    object result = await sCHEMASController.SchemaDetailsOfSubtypeAsync(authorization, contentType, type, subtype);
}
catch (ApiException e){};
```

## Example Response

```
[
  {
    "required": [
      "type",
      "enabled",
      "name",
      "data"
    ],
    "properties": {
      "name": {
        "type": "string",
        "minLength": 1
      },
      "type": {
        "type": "string",
        "enum": [
          "SlackChannel"
        ]
      },
      "enabled": {
        "type": "number",
        "minimum": 0,
        "maximum": 1
      },
      "data": {
        "properties": {
          "slackUrl": {
            "type": "string",
            "pattern": "^https://hooks.slack.com([/][a-zA-Z0-9#-_]+)+$"
          }
        },
        "required": [
          "slackUrl"
        ],
        "additionalProperties": false,
        "type": "object"
      }
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 401 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 402 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 403 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 404 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 405 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 406 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 407 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 408 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 409 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 410 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 411 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 412 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 413 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 414 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 415 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 416 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 417 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 418 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 419 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 420 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 421 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 422 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 423 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 424 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 425 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 426 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 427 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 428 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 429 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 430 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 431 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 432 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 433 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 434 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 435 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 436 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 437 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 438 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 439 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 440 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 441 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 442 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 443 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 444 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 445 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 446 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 447 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 448 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 449 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 450 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 451 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 452 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 453 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 454 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 455 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 456 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 457 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 458 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 459 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 460 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 461 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 462 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 463 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 464 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 465 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 466 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 467 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 468 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 469 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 470 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 471 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 472 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 473 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 474 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 475 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 476 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 477 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 478 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 479 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 480 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 481 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 482 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 483 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 484 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 485 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 486 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 487 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 488 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 489 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 490 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 491 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 492 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 493 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 494 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 495 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 496 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 497 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 498 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 499 | Client Error | [`ApiV2Schemas400ErrorException`](../../doc/models/api-v2-schemas-400-error-exception.md) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 501 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 502 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 503 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 504 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 505 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 506 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 507 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 508 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 509 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 510 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 511 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 512 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 513 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 514 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 515 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 516 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 517 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 518 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 519 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 520 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 521 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 522 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 523 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 524 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 525 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 526 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 527 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 528 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 529 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 530 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 531 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 532 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 533 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 534 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 535 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 536 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 537 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 538 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 539 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 540 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 541 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 542 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 543 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 544 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 545 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 546 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 547 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 548 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 549 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 550 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 551 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 552 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 553 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 554 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 555 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 556 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 557 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 558 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 559 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 560 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 561 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 562 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 563 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 564 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 565 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 566 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 567 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 568 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 569 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 570 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 571 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 572 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 573 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 574 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 575 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 576 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 577 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 578 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 579 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 580 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 581 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 582 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 583 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 584 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 585 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 586 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 587 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 588 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 589 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 590 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 591 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 592 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 593 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 594 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 595 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 596 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 597 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 598 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |
| 599 | Internal Server Error | [`ResponseInternalErrorException`](../../doc/models/response-internal-error-exception.md) |

