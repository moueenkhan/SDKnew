# Agent Access Tokens

To connect to the Lacework instance, Lacework agents require  an [agent access token](https://support.lacework.com/hc/en-us/articles/360005318133).

```csharp
AgentAccessTokensController agentAccessTokensController = client.AgentAccessTokensController;
```

## Class Name

`AgentAccessTokensController`

## Methods

* [Create Agent Access Token](../../doc/controllers/agent-access-tokens.md#create-agent-access-token)
* [List All Agent Access Tokens](../../doc/controllers/agent-access-tokens.md#list-all-agent-access-tokens)
* [Search Agent Access Tokens](../../doc/controllers/agent-access-tokens.md#search-agent-access-tokens)
* [Agent Access Token Details](../../doc/controllers/agent-access-tokens.md#agent-access-token-details)
* [Update Agent Access Token](../../doc/controllers/agent-access-tokens.md#update-agent-access-token)


# Create Agent Access Token

Create a new agent access token that is used by an agent to connect and send data to your Lacework instance, by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens`

Here is an example `body` payload:

> `{ "tokenAlias": "qa", "props": {"description":"QA group"} } }`

By default, if `tokenEnabled` is not set, the agent access token is enabled.

```csharp
CreateAgentAccessTokenAsync(
    string authorization,
    Models.AgentAccessTokensCreateSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.AgentAccessTokensCreateSchema`](../../doc/models/agent-access-tokens-create-schema.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAgentAccessTokens>`](../../doc/models/response-agent-access-tokens.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new AgentAccessTokensCreateSchema();
body.TokenEnabled = "tokenEnabled4";
body.TokenAlias = "tokenAlias2";

try
{
    ResponseAgentAccessTokens result = await agentAccessTokensController.CreateAgentAccessTokenAsync(authorization, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "accessToken": "47d102752b57caa18b...",
    "createdTime": "2020-12-16T16:43:37.915Z",
    "props": "{\"CREATED_TIME\":1598530228648}",
    "tokenAlias": "Ops Agent",
    "tokenEnabled": "1",
    "version": "0.1"
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


# List All Agent Access Tokens

Get a list of agent Access Tokens that are currently enabled in your Lacework instance, by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens`

```csharp
ListAllAgentAccessTokensAsync(
    string authorization,
    string contentType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

## Response Type

[`Task<Models.ResponseAgentAccessTokensList>`](../../doc/models/response-agent-access-tokens-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAgentAccessTokensList result = await agentAccessTokensController.ListAllAgentAccessTokensAsync(authorization, contentType);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "accessToken": "47d102752b57caa18b...",
      "createdTime": "2020-12-16T16:43:37.915Z",
      "props": "{\"CREATED_TIME\":1598530228648}",
      "tokenAlias": "Ops Agent",
      "tokenEnabled": "1",
      "version": "0.1"
    },
    {
      "accessToken": "e2f32885791213cb41...",
      "createdTime": "2020-12-10T18:14:05.754Z",
      "props": "{\"CREATED_TIME\":1607624045577,\"DESCRIPTION\":\"testing agent\"}",
      "tokenAlias": "Dev Agent",
      "tokenEnabled": "1",
      "version": "0.1"
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


# Search Agent Access Tokens

Search all the enabled agent access tokens in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens/search`

To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

You can filter on the following fields:

* `accessToken`

* `createdTime`

* `tokenAlias`

* `tokenEnabled`

* `version`

Here is an example `body` payload:

> `{ "filters" : [ { "expression": "eq", "field": "tokenAlias", "value": "Eng" } ] }`

```csharp
SearchAgentAccessTokensAsync(
    string authorization,
    Models.GETDATAREQUESTBODYFILTERS body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](../../doc/models/getdatarequestbodyfilters.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAgentAccessTokensList>`](../../doc/models/response-agent-access-tokens-list.md)

## Example Usage

```csharp
string authorization = "Authorization8";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseAgentAccessTokensList result = await agentAccessTokensController.SearchAgentAccessTokensAsync(authorization, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "accessToken": "47d102752b57caa18b...",
      "createdTime": "2020-12-16T16:43:37.915Z",
      "props": "{\"CREATED_TIME\":1598530228648}",
      "tokenAlias": "Ops Agent",
      "tokenEnabled": "1",
      "version": "0.1"
    },
    {
      "accessToken": "e2f32885791213cb41...",
      "createdTime": "2020-12-10T18:14:05.754Z",
      "props": "{\"CREATED_TIME\":1607624045577,\"DESCRIPTION\":\"testing agent\"}",
      "tokenAlias": "Dev Agent",
      "tokenEnabled": "1",
      "version": "0.1"
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


# Agent Access Token Details

Get details about an agent access token  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`

You can get the `{id}` by invoking the `GET /api/v2/AgentAccessTokens` endpoint.  Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response.

```csharp
AgentAccessTokenDetailsAsync(
    string authorization,
    string contentType,
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `id` | `string` | Template, Required | Agent Access Token {id} |

## Response Type

[`Task<Models.ResponseAgentAccessTokens>`](../../doc/models/response-agent-access-tokens.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string id = "id0";

try
{
    ResponseAgentAccessTokens result = await agentAccessTokensController.AgentAccessTokenDetailsAsync(authorization, contentType, id);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "accessToken": "47d102752b57caa18b...",
    "createdTime": "2020-12-16T16:43:37.915Z",
    "props": "{\"CREATED_TIME\":1598530228648}",
    "tokenAlias": "Ops Agent",
    "tokenEnabled": "1",
    "version": "0.1"
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


# Update Agent Access Token

Optionally update the `tokenEnabled`, `tokenAlias`, or `description`  settings of the passed in agent access token.  Update these settings by invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`

You can get the agent access token id by calling the `GET /api/v2/AgentAccessTokens` endpoint.

Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response.

Here is an example `body` payload:

> `{ "tokenAlias": "Eng", "tokenEnabled": "1", "props": {"description":"Eng group"} } }`

```csharp
UpdateAgentAccessTokenAsync(
    string authorization,
    string id,
    Models.AgentAccessTokensUpdateSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `id` | `string` | Template, Required | AgentAccessTokens {id} |
| `body` | [`Models.AgentAccessTokensUpdateSchema`](../../doc/models/agent-access-tokens-update-schema.md) | Body, Required | - |

## Response Type

[`Task<Models.ResponseAgentAccessTokens>`](../../doc/models/response-agent-access-tokens.md)

## Example Usage

```csharp
string authorization = "Authorization8";
string id = "id0";
var body = new AgentAccessTokensUpdateSchema();

try
{
    ResponseAgentAccessTokens result = await agentAccessTokensController.UpdateAgentAccessTokenAsync(authorization, id, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "accessToken": "47d102752b57caa18b...",
    "createdTime": "2020-12-16T16:43:37.915Z",
    "props": "{\"CREATED_TIME\":1598530228648}",
    "tokenAlias": "Ops Agent",
    "tokenEnabled": "1",
    "version": "0.1"
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

