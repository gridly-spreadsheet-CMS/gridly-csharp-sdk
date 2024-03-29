# Com.Gridly.Api.BranchApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](BranchApi.md#create) | **POST** /v1/branches | create
[**CreateDiffCheck**](BranchApi.md#creatediffcheck) | **POST** /v1/branches/diffcheck | createDiffCheck
[**Delete**](BranchApi.md#delete) | **DELETE** /v1/branches/{branchId} | delete
[**Get**](BranchApi.md#get) | **GET** /v1/branches/{branchId} | get
[**GetDiffCheck**](BranchApi.md#getdiffcheck) | **GET** /v1/branches/diffcheck/{taskId} | getDiffCheck
[**List**](BranchApi.md#list) | **GET** /v1/branches | list
[**Merge**](BranchApi.md#merge) | **POST** /v1/branches/{branchId}/merge | merge



## Create

> Branch Create (CreateBranch createBranch, string gridId = null, string branchId = null)

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

            var apiInstance = new BranchApi(Configuration.Default);
            var createBranch = new CreateBranch(); // CreateBranch | 
            var gridId = "gridId_example";  // string | gridId (optional) 
            var branchId = "branchId_example";  // string | branchId (optional) 

            try
            {
                // create
                Branch result = apiInstance.Create(createBranch, gridId, branchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.Create: " + e.Message );
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
 **createBranch** | [**CreateBranch**](CreateBranch.md)|  | 
 **gridId** | **string**| gridId | [optional] 
 **branchId** | **string**| branchId | [optional] 

### Return type

[**Branch**](Branch.md)

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


## CreateDiffCheck

> Task CreateDiffCheck (string sourceViewId, string destinationViewId)

createDiffCheck

createDiffCheck

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class CreateDiffCheckExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(Configuration.Default);
            var sourceViewId = "sourceViewId_example";  // string | sourceViewId
            var destinationViewId = "destinationViewId_example";  // string | destinationViewId

            try
            {
                // createDiffCheck
                Task result = apiInstance.CreateDiffCheck(sourceViewId, destinationViewId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.CreateDiffCheck: " + e.Message );
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
 **sourceViewId** | **string**| sourceViewId | 
 **destinationViewId** | **string**| destinationViewId | 

### Return type

[**Task**](Task.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Delete

> void Delete (string branchId)

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

            var apiInstance = new BranchApi(Configuration.Default);
            var branchId = "branchId_example";  // string | branchId

            try
            {
                // delete
                apiInstance.Delete(branchId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.Delete: " + e.Message );
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
 **branchId** | **string**| branchId | 

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

> Branch Get (string branchId)

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

            var apiInstance = new BranchApi(Configuration.Default);
            var branchId = "branchId_example";  // string | branchId

            try
            {
                // get
                Branch result = apiInstance.Get(branchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.Get: " + e.Message );
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
 **branchId** | **string**| branchId | 

### Return type

[**Branch**](Branch.md)

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


## GetDiffCheck

> List&lt;BranchDiffRecord&gt; GetDiffCheck (string taskId, List<string> mergeRecordOptions = null, string query = null, string page = null)

getDiffCheck

getDiffCheck

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class GetDiffCheckExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(Configuration.Default);
            var taskId = "taskId_example";  // string | taskId
            var mergeRecordOptions = new List<string>(); // List<string> | mergeRecordOptions (optional) 
            var query = "\"{}\"";  // string | query (optional)  (default to "{}")
            var page = "\"{}\"";  // string | page (optional)  (default to "{}")

            try
            {
                // getDiffCheck
                List<BranchDiffRecord> result = apiInstance.GetDiffCheck(taskId, mergeRecordOptions, query, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.GetDiffCheck: " + e.Message );
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
 **taskId** | **string**| taskId | 
 **mergeRecordOptions** | [**List&lt;string&gt;**](string.md)| mergeRecordOptions | [optional] 
 **query** | **string**| query | [optional] [default to &quot;{}&quot;]
 **page** | **string**| page | [optional] [default to &quot;{}&quot;]

### Return type

[**List&lt;BranchDiffRecord&gt;**](BranchDiffRecord.md)

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

> List&lt;Branch&gt; List (string gridId)

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

            var apiInstance = new BranchApi(Configuration.Default);
            var gridId = "gridId_example";  // string | gridId

            try
            {
                // list
                List<Branch> result = apiInstance.List(gridId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.List: " + e.Message );
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
 **gridId** | **string**| gridId | 

### Return type

[**List&lt;Branch&gt;**](Branch.md)

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


## Merge

> Task Merge (string branchId, string destinationBranchId, MergeBranchRequest mergeBranchRequest, List<string> mergeRecordOptions = null)

merge

merge

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class MergeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(Configuration.Default);
            var branchId = "branchId_example";  // string | branchId
            var destinationBranchId = "destinationBranchId_example";  // string | destinationBranchId
            var mergeBranchRequest = new MergeBranchRequest(); // MergeBranchRequest | 
            var mergeRecordOptions = new List<string>(); // List<string> | mergeRecordOptions (optional) 

            try
            {
                // merge
                Task result = apiInstance.Merge(branchId, destinationBranchId, mergeBranchRequest, mergeRecordOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.Merge: " + e.Message );
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
 **branchId** | **string**| branchId | 
 **destinationBranchId** | **string**| destinationBranchId | 
 **mergeBranchRequest** | [**MergeBranchRequest**](MergeBranchRequest.md)|  | 
 **mergeRecordOptions** | [**List&lt;string&gt;**](string.md)| mergeRecordOptions | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

