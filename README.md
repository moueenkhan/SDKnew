
# Getting Started with Lacework API 2.0 Documentation

## Introduction

The Lacework API documentation is available directly from your Lacework Application at the following URI:
`https://YourLacework.lacework.net/api/v2/docs`, where `YourLacework` is your Lacework Application.

No login to the Lacework Console is required. However, there is a link to the Lacework API 2.0 documentation from the
Lacework Console. From the **Help** drop-down, select **API 2.0 Documentation**.

You can run the Lacework APIs using your favorite REST API tools such as curl or Postman. Example curl commands are listed in the API 2.0 documentation provided by the **Help** > **API** 2.0 Documentation menu option in the Lacework Console.

You can also run the Lacework API from the Lacework CLI command. For more information, see the
[CLI Documentation](https://github.com/lacework/go-sdk/wiki/CLI-Documentation).

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (LaceworkAPI20Documentation.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

## Installation

The following section explains how to use the LaceworkAPI20Documentation.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the Tester library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `Tester.Tests` and click `OK`. By doing this, we have added a reference of the `Tester.Tests` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

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

## List of APIs

* [ACCESS TOKENS](doc/controllers/access-tokens.md)
* [SCHEMAS](doc/controllers/schemas.md)
* [Agent Access Tokens](doc/controllers/agent-access-tokens.md)
* [Alert Channels](doc/controllers/alert-channels.md)
* [Alert Rules](doc/controllers/alert-rules.md)
* [Audit Logs](doc/controllers/audit-logs.md)
* [Cloud Accounts](doc/controllers/cloud-accounts.md)
* [Cloud Activities](doc/controllers/cloud-activities.md)
* [Container Registries](doc/controllers/container-registries.md)
* [Contract Info](doc/controllers/contract-info.md)
* [Policies](doc/controllers/policies.md)
* [Queries](doc/controllers/queries.md)
* [Report Rules](doc/controllers/report-rules.md)
* [Resource Groups](doc/controllers/resource-groups.md)
* [Team Members](doc/controllers/team-members.md)
* [User Profile](doc/controllers/user-profile.md)

## Classes Documentation

* [Utility Classes](doc/utility-classes.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)
* [HttpContext](doc/http-context.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](doc/http-client-configuration-builder.md)
* [IAuthManager](doc/i-auth-manager.md)
* [ApiException](doc/api-exception.md)

