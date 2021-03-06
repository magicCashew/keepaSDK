# Org.OpenAPITools - the PowerShell module for the Keepa API

The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.

This PowerShell module is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 
- Build package: org.openapitools.codegen.languages.PowerShellClientCodegen
    For more information, please visit [https://keepa.com/#!api](https://keepa.com/#!api)

<a name="frameworks-supported"></a>
## Frameworks supported
- PowerShell 3.0 or later

<a name="dependencies"></a>
## Dependencies
- C# API client generated by OpenAPI Generator AND should be located in $ScriptDir\csharp\OpenAPIClient as stated in Build.ps1

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Windows] `Build.ps1`

Then import module from the .\src\Org.OpenAPITools folder:
```powershell
using Org.OpenAPITools.Org.OpenAPITools/API;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Org.OpenAPITools/Model;
```

