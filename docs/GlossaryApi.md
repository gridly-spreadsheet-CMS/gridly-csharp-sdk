# Com.Gridly.Api.GlossaryApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](GlossaryApi.md#create) | **POST** /v1/glossaries | Create a new glossary
[**Delete**](GlossaryApi.md#delete) | **DELETE** /v1/glossaries/{id} | Delete a glossary
[**ExportFile**](GlossaryApi.md#exportfile) | **GET** /v1/glossaries/{id}/export | Export a glossary
[**Get**](GlossaryApi.md#get) | **GET** /v1/glossaries/{id} | get glossary info
[**GetAll**](GlossaryApi.md#getall) | **GET** /v1/glossaries | List all glossaries
[**ImportFile**](GlossaryApi.md#importfile) | **POST** /v1/glossaries/{id}/import | Import a glossary from file
[**Update**](GlossaryApi.md#update) | **PUT** /v1/glossaries/{id} | Update glossary info



## Create

> Glossary Create (CreateGlossary createGlossary = null)

Create a new glossary

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);
            var createGlossary = new CreateGlossary(); // CreateGlossary |  (optional) 

            try
            {
                // Create a new glossary
                Glossary result = apiInstance.Create(createGlossary);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.Create: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createGlossary** | [**CreateGlossary**](CreateGlossary.md)|  | [optional] 

### Return type

[**Glossary**](Glossary.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a new glossary successful ! |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Delete

> void Delete (long id)

Delete a glossary

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);
            var id = 789L;  // long | 

            try
            {
                // Delete a glossary
                apiInstance.Delete(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.Delete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long**|  | 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportFile

> void ExportFile (long id, List<string> fields = null, GlossaryExportFormat? format = null, List<string> langs = null)

Export a glossary

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ExportFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);
            var id = 789L;  // long | 
            var fields = new List<string>(); // List<string> |  (optional) 
            var format = new GlossaryExportFormat();  // GlossaryExportFormat? |  (optional) 
            var langs = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Export a glossary
                apiInstance.ExportFile(id, fields, format, langs);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.ExportFile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long**|  | 
 **fields** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **format** | **GlossaryExportFormat?**|  | [optional] 
 **langs** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Get

> Glossary Get (long id)

get glossary info

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);
            var id = 789L;  // long | 

            try
            {
                // get glossary info
                Glossary result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.Get: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long**|  | 

### Return type

[**Glossary**](Glossary.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAll

> List&lt;Glossary&gt; GetAll ()

List all glossaries

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class GetAllExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);

            try
            {
                // List all glossaries
                List<Glossary> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.GetAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;Glossary&gt;**](Glossary.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportFile

> void ImportFile (long id, ImportOption? importOption = null, Object file = null)

Import a glossary from file

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ImportFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);
            var id = 789L;  // long | 
            var importOption = new ImportOption();  // ImportOption? |  (optional) 
            var file = new Object(); // Object |  (optional) 

            try
            {
                // Import a glossary from file
                apiInstance.ImportFile(id, importOption, file);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.ImportFile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long**|  | 
 **importOption** | **ImportOption?**|  | [optional] 
 **file** | [**Object**](Object.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Update

> void Update (long id, UpdateGlossary updateGlossary = null)

Update glossary info

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlossaryApi(Configuration.Default);
            var id = 789L;  // long | 
            var updateGlossary = new UpdateGlossary(); // UpdateGlossary |  (optional) 

            try
            {
                // Update glossary info
                apiInstance.Update(id, updateGlossary);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GlossaryApi.Update: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long**|  | 
 **updateGlossary** | [**UpdateGlossary**](UpdateGlossary.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

