# Team Members

Team members can be granted access to multiple Lacework accounts and have different roles for each account. Team members can also be granted organization-level roles. For more information, see [Team Members](https://support.lacework.com/hc/en-us/articles/360039936974).

```csharp
TeamMembersController teamMembersController = client.TeamMembersController;
```

## Class Name

`TeamMembersController`

## Methods

* [Create Team Members](../../doc/controllers/team-members.md#create-team-members)
* [List All Team Members](../../doc/controllers/team-members.md#list-all-team-members)
* [Search Team Members](../../doc/controllers/team-members.md#search-team-members)
* [Team Member Details](../../doc/controllers/team-members.md#team-member-details)
* [Update Team Member](../../doc/controllers/team-members.md#update-team-member)
* [Delete Team Member](../../doc/controllers/team-members.md#delete-team-member)


# Create Team Members

Create a Team Member in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/TeamMembers`

Here is an example `body` payload:

> `{ "userName": "jane.smith@mycompany.com", "userEnabled": 1, "props": { "firstName": "Jane", "lastName": "Smith", "company": "myCompany", "accountAdmin": true } }`

```csharp
CreateTeamMembersAsync(
    string authorization,
    object body,
    bool? orgAccess = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | `object` | Body, Required | - |
| `orgAccess` | `bool?` | Header, Optional | Org account privileges |

## Response Type

[`Task<Models.ResponseTeamMembers>`](../../doc/models/response-team-members.md)

## Example Usage

```csharp
string authorization = "Authorization8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseTeamMembers result = await teamMembersController.CreateTeamMembersAsync(authorization, body, null);
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


# List All Team Members

Get a list of Team Members in your Lacework instance, by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/TeamMembers`

```csharp
ListAllTeamMembersAsync(
    string authorization,
    string contentType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

## Response Type

[`Task<Models.ResponseTeamMembersList>`](../../doc/models/response-team-members-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseTeamMembersList result = await teamMembersController.ListAllTeamMembersAsync(authorization, contentType);
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


# Search Team Members

Search all the team members in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/TeamMembers/search`

To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

You can filter on the following fields:

* `custGuid`

* `userGuid`

* `userName`

* `userEnabled`

Here is an example `body` payload:

> `{ "filters" : [ { "expression": "eq", "field": "userName", "value": "jane.smith@mycompany.com" } ] }`

```csharp
SearchTeamMembersAsync(
    string authorization,
    Models.GETDATAREQUESTBODYFILTERS body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](../../doc/models/getdatarequestbodyfilters.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseTeamMembersList>`](../../doc/models/response-team-members-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseTeamMembersList result = await teamMembersController.SearchTeamMembersAsync(authorization, body);
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


# Team Member Details

Get details about a Team Member  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`

Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the `GET /api/v2/TeamMembers` endpoint is invoked.

```csharp
TeamMemberDetailsAsync(
    string authorization,
    string contentType,
    string userGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `userGuid` | `string` | Template, Required | Team Member userGuid |

## Response Type

[`Task<Models.ResponseTeamMembers>`](../../doc/models/response-team-members.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string userGuid = "userGuid2";

try
{
    ResponseTeamMembers result = await teamMembersController.TeamMemberDetailsAsync(authorization, contentType, userGuid);
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


# Update Team Member

Optionally update the `userName` and`userEnabled` settings and the `props`  sub-settings of the passed in Team Member.  Update these settings by invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`

Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response, when the `GET /api/v2/TeamMembers` endpoint is invoked.

Here is an example `body` payload:

> `{ "props": {"firstName":"Jane"} }`

```csharp
UpdateTeamMemberAsync(
    string authorization,
    string userGuid,
    object body,
    bool? orgAccess = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `userGuid` | `string` | Template, Required | Team Member userGuid |
| `body` | `object` | Body, Required | - |
| `orgAccess` | `bool?` | Header, Optional | Org account privileges |

## Response Type

[`Task<Models.ResponseUpdateTeamMember>`](../../doc/models/response-update-team-member.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string userGuid = "userGuid2";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseUpdateTeamMember result = await teamMembersController.UpdateTeamMemberAsync(authorization, userGuid, body, null);
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


# Delete Team Member

Delete a Team Member by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`

Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the `GET /api/v2/TeamMembers` endpoint is invoked.

```csharp
DeleteTeamMemberAsync(
    string authorization,
    string contentType,
    string userGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `userGuid` | `string` | Template, Required | Team Member userGuid |

## Response Type

`Task`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string userGuid = "userGuid2";

try
{
    await teamMembersController.DeleteTeamMemberAsync(authorization, contentType, userGuid);
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

