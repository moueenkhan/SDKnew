# Alert Channels

Lacework combines [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194)  with [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733)  or [report rules](https://support.lacework.com/hc/en-us/articles/36004176675)  to provide a flexible method for routing alerts and reports.  <ul>  <li>For [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194), you define where to  send alerts or reports, such as to Jira, Slack, or email.</li>  <li>For [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733), you define information  about which alert types to send, such as critical and high severity compliance alerts.</li>  <li>For [report rules](https://support.lacework.com/hc/en-us/articles/36004176675), you define information about  which reports to send.</li>  </ul>

```csharp
AlertChannelsController alertChannelsController = client.AlertChannelsController;
```

## Class Name

`AlertChannelsController`

## Methods

* [Create Alert Channels](../../doc/controllers/alert-channels.md#create-alert-channels)
* [List All Alert Channels](../../doc/controllers/alert-channels.md#list-all-alert-channels)
* [List Alert Channels by Type](../../doc/controllers/alert-channels.md#list-alert-channels-by-type)
* [Search Alert Channels](../../doc/controllers/alert-channels.md#search-alert-channels)
* [Test Alert Channels](../../doc/controllers/alert-channels.md#test-alert-channels)
* [Alert Channel Details](../../doc/controllers/alert-channels.md#alert-channel-details)
* [Update Alert Channels](../../doc/controllers/alert-channels.md#update-alert-channels)
* [Delete Alert Channels](../../doc/controllers/alert-channels.md#delete-alert-channels)


# Create Alert Channels

Create an alert channel by specifying parameters in the request body  when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertChannels`

```csharp
CreateAlertChannelsAsync(
    string authorization,
    object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | `object` | Body, Required | - |

## Response Type

[`Task<Models.ResponseAlertChannels>`](../../doc/models/response-alert-channels.md)

## Example Usage

```csharp
string authorization = "Authorization8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseAlertChannels result = await alertChannelsController.CreateAlertChannelsAsync(authorization, body);
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


# List All Alert Channels

Get a list of alert channels for the current user by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels`

```csharp
ListAllAlertChannelsAsync(
    string authorization,
    string contentType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

## Response Type

[`Task<Models.ResponseAlertChannelsList>`](../../doc/models/response-alert-channels-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAlertChannelsList result = await alertChannelsController.ListAllAlertChannelsAsync(authorization, contentType);
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


# List Alert Channels by Type

Get a list of alert channels of the specified type by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels/{type}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels/SlackChannel`

```csharp
ListAlertChannelsByTypeAsync(
    string authorization,
    string contentType,
    Models.Type25Enum type)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | [`Models.Type25Enum`](../../doc/models/type-25-enum.md) | Template, Required | Alert Channel Type |

## Response Type

[`Task<Models.ResponseAlertChannelsList>`](../../doc/models/response-alert-channels-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
Type25Enum type = Type25Enum.VictorOps;

try
{
    ResponseAlertChannelsList result = await alertChannelsController.ListAlertChannelsByTypeAsync(authorization, contentType, type);
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


# Search Alert Channels

Search alert channels by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertChannels/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`.

```csharp
SearchAlertChannelsAsync(
    string authorization,
    Models.GETDATAREQUESTBODYFILTERS body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](../../doc/models/getdatarequestbodyfilters.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAlertChannelsList>`](../../doc/models/response-alert-channels-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseAlertChannelsList result = await alertChannelsController.SearchAlertChannelsAsync(authorization, body);
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


# Test Alert Channels

Test the integration of an alert channel by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}/test`

```csharp
TestAlertChannelsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |

## Response Type

`Task`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await alertChannelsController.TestAlertChannelsAsync(authorization, contentType, intgGuid);
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


# Alert Channel Details

Get the details about an alert channel by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}`

```csharp
AlertChannelDetailsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |

## Response Type

[`Task<Models.ResponseAlertChannels>`](../../doc/models/response-alert-channels.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    ResponseAlertChannels result = await alertChannelsController.AlertChannelDetailsAsync(authorization, contentType, intgGuid);
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


# Update Alert Channels

Update an alert channel by specifying parameters in the request body  when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}`

In the request body, only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`.

```csharp
UpdateAlertChannelsAsync(
    string authorization,
    string intgGuid,
    object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |
| `body` | `object` | Body, Required | Only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`. |

## Response Type

[`Task<Models.ResponseAlertChannels>`](../../doc/models/response-alert-channels.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string intgGuid = "intgGuid8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseAlertChannels result = await alertChannelsController.UpdateAlertChannelsAsync(authorization, intgGuid, body);
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


# Delete Alert Channels

Delete an alert channel by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}`

```csharp
DeleteAlertChannelsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |

## Response Type

`Task`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await alertChannelsController.DeleteAlertChannelsAsync(authorization, contentType, intgGuid);
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

