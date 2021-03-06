# Com.Gridly.Api.DatabaseApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](DatabaseApi.md#create) | **POST** /v1/databases | create
[**Delete**](DatabaseApi.md#delete) | **DELETE** /v1/databases/{dbId} | delete
[**Duplicate**](DatabaseApi.md#duplicate) | **POST** /v1/databases/{dbId}/duplicate | duplicate
[**Get**](DatabaseApi.md#get) | **GET** /v1/databases/{dbId} | get
[**List**](DatabaseApi.md#list) | **GET** /v1/databases | list
[**Update**](DatabaseApi.md#update) | **PUT** /v1/databases/{dbId} | update



## Create

> Database Create (long projectId, CreateDatabase body)

create

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

            var apiInstance = new DatabaseApi(Configuration.Default);
            var projectId = 789L;  // long | projectId
            var body = new CreateDatabase(); // CreateDatabase | body

            try
            {
                // create
                Database result = apiInstance.Create(projectId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DatabaseApi.Create: " + e.Message );
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
 **projectId** | **long**| projectId | 
 **body** | [**CreateDatabase**](CreateDatabase.md)| body | 

### Return type

[**Database**](Database.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Delete

> void Delete (string dbId)

delete

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

            var apiInstance = new DatabaseApi(Configuration.Default);
            var dbId = "dbId_example";  // string | dbId

            try
            {
                // delete
                apiInstance.Delete(dbId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DatabaseApi.Delete: " + e.Message );
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
 **dbId** | **string**| dbId | 

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


## Duplicate

> Database Duplicate (string dbId, long projectId, CreateDatabase body)

duplicate

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class DuplicateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatabaseApi(Configuration.Default);
            var dbId = "dbId_example";  // string | dbId
            var projectId = 789L;  // long | projectId
            var body = new CreateDatabase(); // CreateDatabase | body

            try
            {
                // duplicate
                Database result = apiInstance.Duplicate(dbId, projectId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DatabaseApi.Duplicate: " + e.Message );
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
 **dbId** | **string**| dbId | 
 **projectId** | **long**| projectId | 
 **body** | [**CreateDatabase**](CreateDatabase.md)| body | 

### Return type

[**Database**](Database.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Get

> Database Get (string dbId)

get

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

            var apiInstance = new DatabaseApi(Configuration.Default);
            var dbId = "dbId_example";  // string | dbId

            try
            {
                // get
                Database result = apiInstance.Get(dbId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DatabaseApi.Get: " + e.Message );
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
 **dbId** | **string**| dbId | 

### Return type

[**Database**](Database.md)

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


## List

> List&lt;Database&gt; List (List<string> expand = null, string page = null, long? projectId = null, string search = null, string sort = null)

list

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatabaseApi(Configuration.Default);
            var expand = new List<string>(); // List<string> | expand (optional) 
            var page = "\"\"";  // string | page (optional)  (default to "")
            var projectId = 789L;  // long? | projectId (optional) 
            var search = "search_example";  // string | search (optional) 
            var sort = "\"\"";  // string | sort (optional)  (default to "")

            try
            {
                // list
                List<Database> result = apiInstance.List(expand, page, projectId, search, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DatabaseApi.List: " + e.Message );
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
 **expand** | [**List&lt;string&gt;**](string.md)| expand | [optional] 
 **page** | **string**| page | [optional] [default to &quot;&quot;]
 **projectId** | **long?**| projectId | [optional] 
 **search** | **string**| search | [optional] 
 **sort** | **string**| sort | [optional] [default to &quot;&quot;]

### Return type

[**List&lt;Database&gt;**](Database.md)

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


## Update

> Database Update (string dbId, UpdateDatabase body)

update

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

            var apiInstance = new DatabaseApi(Configuration.Default);
            var dbId = "dbId_example";  // string | dbId
            var body = new UpdateDatabase(); // UpdateDatabase | body

            try
            {
                // update
                Database result = apiInstance.Update(dbId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DatabaseApi.Update: " + e.Message );
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
 **dbId** | **string**| dbId | 
 **body** | [**UpdateDatabase**](UpdateDatabase.md)| body | 

### Return type

[**Database**](Database.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

