
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `DefaultHost` | `string` | *Default*: `"www.example.com"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
LaceworkAPI20Documentation.Standard.LaceworkAPI20DocumentationClient client = new LaceworkAPI20Documentation.Standard.LaceworkAPI20DocumentationClient.Builder()
    .Environment(LaceworkAPI20Documentation.Standard.Environment.Production)
    .DefaultHost("www.example.com")
    .HttpClientConfig(config => config.NumberOfRetries(0))
    .Build();
```

## Lacework API 2.0 DocumentationClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| ACCESSTOKENSController | Gets ACCESSTOKENSController controller. |
| SCHEMASController | Gets SCHEMASController controller. |
| AgentAccessTokensController | Gets AgentAccessTokensController controller. |
| AlertChannelsController | Gets AlertChannelsController controller. |
| AlertRulesController | Gets AlertRulesController controller. |
| AuditLogsController | Gets AuditLogsController controller. |
| CloudAccountsController | Gets CloudAccountsController controller. |
| CloudActivitiesController | Gets CloudActivitiesController controller. |
| ContainerRegistriesController | Gets ContainerRegistriesController controller. |
| ContractInfoController | Gets ContractInfoController controller. |
| PoliciesController | Gets PoliciesController controller. |
| QueriesController | Gets QueriesController controller. |
| ReportRulesController | Gets ReportRulesController controller. |
| ResourceGroupsController | Gets ResourceGroupsController controller. |
| TeamMembersController | Gets TeamMembersController controller. |
| UserProfileController | Gets UserProfileController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | `IHttpClientConfiguration` |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| DefaultHost | DefaultHost value. | `string` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Lacework API 2.0 DocumentationClient using the values provided for the builder. | `Builder` |

## Lacework API 2.0 DocumentationClient Builder Class

Class to build instances of Lacework API 2.0 DocumentationClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |

