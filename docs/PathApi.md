# Com.Gridly.Api.PathApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](PathApi.md#create) | **POST** /v1/views/{viewId}/paths | create
[**Delete**](PathApi.md#delete) | **DELETE** /v1/views/{viewId}/paths | delete
[**List**](PathApi.md#list) | **GET** /v1/views/{viewId}/paths/tree | list
[**Move**](PathApi.md#move) | **POST** /v1/views/{viewId}/paths/move | move
[**Update**](PathApi.md#update) | **PUT** /v1/views/{viewId}/paths/{path} | update



## Create

> PathList Create (string viewId, CreatePath createPath)

create

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

            var apiInstance = new PathApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var createPath = new CreatePath(); // CreatePath | 

            try
            {
                // create
                PathList result = apiInstance.Create(viewId, createPath);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PathApi.Create: " + e.Message );
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
 **createPath** | [**CreatePath**](CreatePath.md)|  | 

### Return type

[**PathList**](PathList.md)

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

> void Delete (string viewId, DeletePath deletePath)

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

            var apiInstance = new PathApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var deletePath = new DeletePath(); // DeletePath | 

            try
            {
                // delete
                apiInstance.Delete(viewId, deletePath);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PathApi.Delete: " + e.Message );
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
 **deletePath** | [**DeletePath**](DeletePath.md)|  | 

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
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## List

> List&lt;PathNode&gt; List (string viewId, string rootPath = null)

list

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

            var apiInstance = new PathApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var rootPath = "rootPath_example";  // string | rootPath (optional) 

            try
            {
                // list
                List<PathNode> result = apiInstance.List(viewId, rootPath);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PathApi.List: " + e.Message );
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
 **rootPath** | **string**| rootPath | [optional] 

### Return type

[**List&lt;PathNode&gt;**](PathNode.md)

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


## Move

> PathList Move (string viewId, MovePath movePath)

move

move

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class MoveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PathApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var movePath = new MovePath(); // MovePath | 

            try
            {
                // move
                PathList result = apiInstance.Move(viewId, movePath);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PathApi.Move: " + e.Message );
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
 **movePath** | [**MovePath**](MovePath.md)|  | 

### Return type

[**PathList**](PathList.md)

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


## Update

> PathSingle Update (string viewId, string path, UpdatePath updatePath)

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

            var apiInstance = new PathApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var path = "path_example";  // string | path
            var updatePath = new UpdatePath(); // UpdatePath | 

            try
            {
                // update
                PathSingle result = apiInstance.Update(viewId, path, updatePath);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PathApi.Update: " + e.Message );
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
 **path** | **string**| path | 
 **updatePath** | [**UpdatePath**](UpdatePath.md)|  | 

### Return type

[**PathSingle**](PathSingle.md)

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

