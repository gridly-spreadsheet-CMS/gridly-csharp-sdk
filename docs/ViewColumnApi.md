# Com.Gridly.Api.ViewColumnApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](ViewColumnApi.md#add) | **POST** /v1/views/{viewId}/columns/{columnId}/add | add
[**BulkCreate**](ViewColumnApi.md#bulkcreate) | **POST** /v1/views/{viewId}/columns/bulk | bulkCreate
[**Create**](ViewColumnApi.md#create) | **POST** /v1/views/{viewId}/columns | create
[**Delete**](ViewColumnApi.md#delete) | **DELETE** /v1/views/{viewId}/columns/{columnId} | delete
[**Get**](ViewColumnApi.md#get) | **GET** /v1/views/{viewId}/columns/{columnId} | get
[**Remove**](ViewColumnApi.md#remove) | **POST** /v1/views/{viewId}/columns/{columnId}/remove | remove
[**Update**](ViewColumnApi.md#update) | **PATCH** /v1/views/{viewId}/columns/{columnId} | update



## Add

> ViewColumn Add (string columnId, string viewId)

add

add

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class AddExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var columnId = "columnId_example";  // string | columnId
            var viewId = "viewId_example";  // string | viewId

            try
            {
                // add
                ViewColumn result = apiInstance.Add(columnId, viewId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.Add: " + e.Message );
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
 **columnId** | **string**| columnId | 
 **viewId** | **string**| viewId | 

### Return type

[**ViewColumn**](ViewColumn.md)

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


## BulkCreate

> List&lt;ViewColumn&gt; BulkCreate (string viewId, List<CreateColumn> createColumn)

bulkCreate

bulkCreate

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class BulkCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var createColumn = new List<CreateColumn>(); // List<CreateColumn> | 

            try
            {
                // bulkCreate
                List<ViewColumn> result = apiInstance.BulkCreate(viewId, createColumn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.BulkCreate: " + e.Message );
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
 **viewId** | **string**| viewId | 
 **createColumn** | [**List&lt;CreateColumn&gt;**](CreateColumn.md)|  | 

### Return type

[**List&lt;ViewColumn&gt;**](ViewColumn.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Create

> ViewColumn Create (string viewId, CreateColumn createColumn)

create

Create a Column

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

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var createColumn = new CreateColumn(); // CreateColumn | 

            try
            {
                // create
                ViewColumn result = apiInstance.Create(viewId, createColumn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.Create: " + e.Message );
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
 **viewId** | **string**| viewId | 
 **createColumn** | [**CreateColumn**](CreateColumn.md)|  | 

### Return type

[**ViewColumn**](ViewColumn.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Delete

> void Delete (string columnId, string viewId)

delete

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

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var columnId = "columnId_example";  // string | columnId
            var viewId = "viewId_example";  // string | viewId

            try
            {
                // delete
                apiInstance.Delete(columnId, viewId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.Delete: " + e.Message );
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
 **columnId** | **string**| columnId | 
 **viewId** | **string**| viewId | 

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


## Get

> ViewColumn Get (string columnId, string viewId)

get

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

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var columnId = "columnId_example";  // string | columnId
            var viewId = "viewId_example";  // string | viewId

            try
            {
                // get
                ViewColumn result = apiInstance.Get(columnId, viewId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.Get: " + e.Message );
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
 **columnId** | **string**| columnId | 
 **viewId** | **string**| viewId | 

### Return type

[**ViewColumn**](ViewColumn.md)

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


## Remove

> void Remove (string columnId, string viewId)

remove

remove

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class RemoveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var columnId = "columnId_example";  // string | columnId
            var viewId = "viewId_example";  // string | viewId

            try
            {
                // remove
                apiInstance.Remove(columnId, viewId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.Remove: " + e.Message );
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
 **columnId** | **string**| columnId | 
 **viewId** | **string**| viewId | 

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


## Update

> ViewColumn Update (string columnId, string viewId, UpdateColumn updateColumn)

update

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

            var apiInstance = new ViewColumnApi(Configuration.Default);
            var columnId = "columnId_example";  // string | columnId
            var viewId = "viewId_example";  // string | viewId
            var updateColumn = new UpdateColumn(); // UpdateColumn | 

            try
            {
                // update
                ViewColumn result = apiInstance.Update(columnId, viewId, updateColumn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewColumnApi.Update: " + e.Message );
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
 **columnId** | **string**| columnId | 
 **viewId** | **string**| viewId | 
 **updateColumn** | [**UpdateColumn**](UpdateColumn.md)|  | 

### Return type

[**ViewColumn**](ViewColumn.md)

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

