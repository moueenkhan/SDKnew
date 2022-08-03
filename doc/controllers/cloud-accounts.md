# Cloud Accounts

Cloud Accounts are integrations between Lacework and Cloud providers such as Amazon Web Services, Microsoft Azure, and Google Cloud Platform.

```csharp
CloudAccountsController cloudAccountsController = client.CloudAccountsController;
```

## Class Name

`CloudAccountsController`

## Methods

* [Create Cloud Accounts](../../doc/controllers/cloud-accounts.md#create-cloud-accounts)
* [List All Cloud Accounts](../../doc/controllers/cloud-accounts.md#list-all-cloud-accounts)
* [List Cloud Accounts by Type](../../doc/controllers/cloud-accounts.md#list-cloud-accounts-by-type)
* [Search Cloud Accounts](../../doc/controllers/cloud-accounts.md#search-cloud-accounts)
* [Cloud Accounts Details](../../doc/controllers/cloud-accounts.md#cloud-accounts-details)
* [Update Cloud Accounts](../../doc/controllers/cloud-accounts.md#update-cloud-accounts)
* [Delete Cloud Accounts](../../doc/controllers/cloud-accounts.md#delete-cloud-accounts)


# Create Cloud Accounts

Create a cloud account by specifying parameters in the request  body when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/CloudAccounts`

```csharp
CreateCloudAccountsAsync(
    string authorization,
    object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | `object` | Body, Required | - |

## Response Type

[`Task<Models.ResponseCloudAccounts>`](../../doc/models/response-cloud-accounts.md)

## Example Usage

```csharp
string authorization = "Authorization8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseCloudAccounts result = await cloudAccountsController.CreateCloudAccountsAsync(authorization, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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


# List All Cloud Accounts

Get a list of cloud accounts for the current user by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts`

```csharp
ListAllCloudAccountsAsync(
    string authorization,
    string contentType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

## Response Type

[`Task<Models.ResponseCloudAccountsList>`](../../doc/models/response-cloud-accounts-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseCloudAccountsList result = await cloudAccountsController.ListAllCloudAccountsAsync(authorization, contentType);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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


# List Cloud Accounts by Type

Get a list of cloud accounts of the specified type by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{type}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/AwsCfg`

```csharp
ListCloudAccountsByTypeAsync(
    string authorization,
    string contentType,
    Models.Type26Enum type)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | [`Models.Type26Enum`](../../doc/models/type-26-enum.md) | Template, Required | Cloud Accounts Type |

## Response Type

[`Task<Models.ResponseCloudAccountsList>`](../../doc/models/response-cloud-accounts-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
Type26Enum type = Type26Enum.GcpAtSes;

try
{
    ResponseCloudAccountsList result = await cloudAccountsController.ListCloudAccountsByTypeAsync(authorization, contentType, type);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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


# Search Cloud Accounts

Search cloud accounts by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/CloudAccounts/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`.

```csharp
SearchCloudAccountsAsync(
    string authorization,
    Models.GETDATAREQUESTBODYFILTERS body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](../../doc/models/getdatarequestbodyfilters.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseCloudAccountsList>`](../../doc/models/response-cloud-accounts-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseCloudAccountsList result = await cloudAccountsController.SearchCloudAccountsAsync(authorization, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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


# Cloud Accounts Details

Get the details about a cloud account by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`

```csharp
CloudAccountsDetailsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Cloud Account intgGuid |

## Response Type

[`Task<Models.ResponseCloudAccounts>`](../../doc/models/response-cloud-accounts.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    ResponseCloudAccounts result = await cloudAccountsController.CloudAccountsDetailsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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


# Update Cloud Accounts

Update a cloud account by specifying parameters in the request body when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`

In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`.

```csharp
UpdateCloudAccountsAsync(
    string authorization,
    string intgGuid,
    object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `intgGuid` | `string` | Template, Required | Cloud Account intgGuid |
| `body` | `object` | Body, Required | - |

## Response Type

[`Task<Models.ResponseCloudAccounts>`](../../doc/models/response-cloud-accounts.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string intgGuid = "intgGuid8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseCloudAccounts result = await cloudAccountsController.UpdateCloudAccountsAsync(authorization, intgGuid, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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


# Delete Cloud Accounts

Delete a cloud account by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`

```csharp
DeleteCloudAccountsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Cloud Account intgGuid |

## Response Type

`Task`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await cloudAccountsController.DeleteCloudAccountsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 401 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 402 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 403 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 404 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 405 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 406 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 407 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 408 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 409 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 410 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 411 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 412 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 413 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 414 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 415 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 416 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 417 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 418 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 419 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 420 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 421 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 422 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 423 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 424 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 425 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 426 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 427 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 428 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 429 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 430 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 431 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 432 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 433 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 434 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 435 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 436 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 437 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 438 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 439 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 440 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 441 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 442 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 443 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 444 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 445 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 446 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 447 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 448 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 449 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 450 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 451 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 452 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 453 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 454 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 455 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 456 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 457 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 458 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 459 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 460 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 461 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 462 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 463 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 464 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 465 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 466 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 467 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 468 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 469 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 470 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 471 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 472 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 473 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 474 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 475 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 476 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 477 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 478 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 479 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 480 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 481 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 482 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 483 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 484 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 485 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 486 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 487 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 488 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 489 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 490 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 491 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 492 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 493 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 494 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 495 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 496 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 497 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 498 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
| 499 | Client Error | [`Response4XXException`](../../doc/models/response-4-xx-exception.md) |
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

