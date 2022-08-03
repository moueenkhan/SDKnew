# Alert Rules

Lacework combines [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194) and  [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733) to provide a flexible method for  routing alerts.  For [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194), you define information  about where to send alerts, such as to Jira, Slack, or email.  For [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733), you define information  about which alert types to send, such as critical and high severity compliance alerts.

```csharp
AlertRulesController alertRulesController = client.AlertRulesController;
```

## Class Name

`AlertRulesController`

## Methods

* [Create Alert Rules](../../doc/controllers/alert-rules.md#create-alert-rules)
* [List All Alert Rules](../../doc/controllers/alert-rules.md#list-all-alert-rules)
* [Search Alert Rules](../../doc/controllers/alert-rules.md#search-alert-rules)
* [Alert Rule Details](../../doc/controllers/alert-rules.md#alert-rule-details)
* [Update Alert Rules](../../doc/controllers/alert-rules.md#update-alert-rules)
* [Delete Alert Rules](../../doc/controllers/alert-rules.md#delete-alert-rules)


# Create Alert Rules

Create an alert rules by specifying parameters in the request `body` when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertRules`

```csharp
CreateAlertRulesAsync(
    string authorization,
    Models.AlertRulesCreateSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.AlertRulesCreateSchema`](../../doc/models/alert-rules-create-schema.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAlertRules>`](../../doc/models/response-alert-rules.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new AlertRulesCreateSchema();
body.Filters = new Filters();
body.Filters.Name = "name4";
body.Filters.Enabled = EnabledEnum.Enum0;
body.Filters.Severity = new List<SeverityEnum>();
body.Filters.Severity.Add(SeverityEnum.Enum5);
body.Filters.Severity.Add(SeverityEnum.Enum1);
body.Filters.Severity.Add(SeverityEnum.Enum2);
body.IntgGuidList = new List<string>();
body.IntgGuidList.Add("intgGuidList1");
body.IntgGuidList.Add("intgGuidList2");

try
{
    ResponseAlertRules result = await alertRulesController.CreateAlertRulesAsync(authorization, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "mcGuid": "QA42F6C8_97...",
    "filters": {
      "name": "Default Rule",
      "description": "",
      "createdOrUpdatedBy": "user@lacework.net",
      "createdOrUpdatedTime": "2020-02-18T16:52:57.726Z",
      "enabled": 1,
      "resourcegroups": [
        "QA402035_43..."
      ],
      "severity": [
        1,
        2,
        3
      ],
      "eventcategory": [
        "App",
        "Compliance",
        "Cloud",
        "Aws",
        "AzureActivityLog",
        "GcpAuditTrail",
        "User",
        "Machine",
        "File"
      ]
    },
    "intgGuidList": [
      "QA402035_66..."
    ],
    "type": "Event"
  }
}
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


# List All Alert Rules

List all the alert rules in your Lacework instance,  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertRules`

```csharp
ListAllAlertRulesAsync(
    string authorization,
    string contentType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

## Response Type

[`Task<Models.ResponseAlertRulesList>`](../../doc/models/response-alert-rules-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAlertRulesList result = await alertRulesController.ListAllAlertRulesAsync(authorization, contentType);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "mcGuid": "QA42F6C8_97...",
      "filters": {
        "name": "Default Rule",
        "description": "",
        "createdOrUpdatedBy": "user@lacework.net",
        "createdOrUpdatedTime": "2020-02-18T16:52:57.726Z",
        "enabled": 1,
        "resourcegroups": [
          "QA402035_43.."
        ],
        "severity": [
          1,
          2,
          3
        ],
        "eventcategory": [
          "App",
          "Compliance",
          "Cloud",
          "Aws",
          "AzureActivityLog",
          "GcpAuditTrail",
          "User",
          "Machine",
          "File"
        ]
      },
      "intgGuidList": [
        "QA402035_66..."
      ],
      "type": "Event"
    },
    {
      "mcGuid": "QA42F6C8_83...",
      "filters": {
        "name": "test",
        "description": "",
        "createdOrUpdatedBy": "user@lacework.net",
        "createdOrUpdatedTime": "2020-01-15T07:07:21.989Z",
        "enabled": 1,
        "resourcegroups": [
          "QA402035_EB...",
          "QA402035_BA..."
        ],
        "severity": [
          1,
          2,
          3
        ],
        "eventcategory": [
          "User",
          "Cloud",
          "Aws",
          "AzureActivityLog",
          "GcpAuditTrail"
        ]
      },
      "intgGuidList": [
        "QA402035_01...",
        "QA402035_A6..."
      ],
      "type": "Event"
    }
  ]
}
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


# Search Alert Rules

Search alert rules by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertRules/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

Here are some example `body` payloads:

* `{ "filters": [ { "field": "mcGuid", "expression": "rlike", "value": "123ABC" } ] }`

* `{ "filters": [ { "field": "mcGuid", "expression": "between", "values": [ "ABC_123", "DEC_456" ] } ] }`

* `{ "filters": [ { "field": "intgGuidList", "expression": "eq", "value": "ABC_123" } ] }`

* `{ "filters": [ { "field": "intgGuidList", "expression": "in", "values": [ "ABC_123", "DEF_456" ] } ] }`

* `{ "filters": [ { "field": "filters.name", "expression": "ilike", "value": "slack" } ] }`

* `{ "filters": [ { "field": "filters.resourceGroups", "expression": "eq", "value": "ABC_123" } ] }`

* `{ "filters": [ { "field": "filters.severity", "expression": "eq", "value": "5" } ] }`

* `{ "filters": [ { "field": "filters.eventCategory", "expression": "eq", "value": "App" } ] }`

* `{ "filters": [ { "field": "reportNotificationTypes.agentEvents", "expression": "eq", "value": "false" } ] }`

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array.

```csharp
SearchAlertRulesAsync(
    string authorization,
    Models.GETDATAREQUESTBODYFILTERS body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](../../doc/models/getdatarequestbodyfilters.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAlertRulesList>`](../../doc/models/response-alert-rules-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseAlertRulesList result = await alertRulesController.SearchAlertRulesAsync(authorization, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "mcGuid": "QA42F6C8_97...",
      "filters": {
        "name": "Default Rule",
        "description": "",
        "createdOrUpdatedBy": "user@lacework.net",
        "createdOrUpdatedTime": "2020-02-18T16:52:57.726Z",
        "enabled": 1,
        "resourcegroups": [
          "QA402035_43.."
        ],
        "severity": [
          1,
          2,
          3
        ],
        "eventcategory": [
          "App",
          "Compliance",
          "Cloud",
          "Aws",
          "AzureActivityLog",
          "GcpAuditTrail",
          "User",
          "Machine",
          "File"
        ]
      },
      "intgGuidList": [
        "QA402035_66..."
      ],
      "type": "Event"
    },
    {
      "mcGuid": "QA42F6C8_83...",
      "filters": {
        "name": "test",
        "description": "",
        "createdOrUpdatedBy": "user@lacework.net",
        "createdOrUpdatedTime": "2020-01-15T07:07:21.989Z",
        "enabled": 1,
        "resourcegroups": [
          "QA402035_EB...",
          "QA402035_BA..."
        ],
        "severity": [
          1,
          2,
          3
        ],
        "eventcategory": [
          "User",
          "Cloud",
          "Aws",
          "AzureActivityLog",
          "GcpAuditTrail"
        ]
      },
      "intgGuidList": [
        "QA402035_01...",
        "QA402035_A6..."
      ],
      "type": "Event"
    }
  ]
}
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


# Alert Rule Details

Get details about a Alert Rule  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`

Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the `GET /api/v2/AlertRules` endpoint is invoked.

```csharp
AlertRuleDetailsAsync(
    string authorization,
    string contentType,
    string mcGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Alert Rule mcGuid |

## Response Type

[`Task<Models.ResponseAlertRules>`](../../doc/models/response-alert-rules.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string mcGuid = "mcGuid4";

try
{
    ResponseAlertRules result = await alertRulesController.AlertRuleDetailsAsync(authorization, contentType, mcGuid);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "mcGuid": "QA42F6C8_97...",
    "filters": {
      "name": "Default Rule",
      "description": "",
      "createdOrUpdatedBy": "user@lacework.net",
      "createdOrUpdatedTime": "2020-02-18T16:52:57.726Z",
      "enabled": 1,
      "resourcegroups": [
        "QA402035_43..."
      ],
      "severity": [
        1,
        2,
        3
      ],
      "eventcategory": [
        "App",
        "Compliance",
        "Cloud",
        "Aws",
        "AzureActivityLog",
        "GcpAuditTrail",
        "User",
        "Machine",
        "File"
      ]
    },
    "intgGuidList": [
      "QA402035_66..."
    ],
    "type": "Event"
  }
}
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


# Update Alert Rules

Update an alert rules by specifying parameters in the request body when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`

Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the `GET /api/v2/AlertRules` endpoint is invoked.  In the request body, only specify the parameter(s) that you want to update.

```csharp
UpdateAlertRulesAsync(
    string authorization,
    string mcGuid,
    Models.AlertRulesUpdateSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `mcGuid` | `string` | Template, Required | Alert Rules mcGuid |
| `body` | [`Models.AlertRulesUpdateSchema`](../../doc/models/alert-rules-update-schema.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAlertRules>`](../../doc/models/response-alert-rules.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string mcGuid = "mcGuid4";
var body = new AlertRulesUpdateSchema();

try
{
    ResponseAlertRules result = await alertRulesController.UpdateAlertRulesAsync(authorization, mcGuid, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "mcGuid": "QA42F6C8_97...",
    "filters": {
      "name": "Default Rule",
      "description": "",
      "createdOrUpdatedBy": "user@lacework.net",
      "createdOrUpdatedTime": "2020-02-18T16:52:57.726Z",
      "enabled": 1,
      "resourcegroups": [
        "QA402035_43..."
      ],
      "severity": [
        1,
        2,
        3
      ],
      "eventcategory": [
        "App",
        "Compliance",
        "Cloud",
        "Aws",
        "AzureActivityLog",
        "GcpAuditTrail",
        "User",
        "Machine",
        "File"
      ]
    },
    "intgGuidList": [
      "QA402035_66..."
    ],
    "type": "Event"
  }
}
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


# Delete Alert Rules

Delete an Alert Rule by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/AlertRule/{mcGuid}`

Replace `{mcGuid}` with the `mcGuid` value returned for a Alert Rule in the response when the `GET /api/v2/AlertRules` endpoint is invoked.

```csharp
DeleteAlertRulesAsync(
    string authorization,
    string contentType,
    string mcGuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Alert Rules mcGuid |

## Response Type

`Task`

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string mcGuid = "mcGuid4";

try
{
    await alertRulesController.DeleteAlertRulesAsync(authorization, contentType, mcGuid);
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

