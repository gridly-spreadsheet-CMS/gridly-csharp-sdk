# Com.Gridly.Api.ViewApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](ViewApi.md#create) | **POST** /v1/views | create
[**Export**](ViewApi.md#export) | **GET** /v1/views/{viewId}/export | export
[**Get**](ViewApi.md#get) | **GET** /v1/views/{viewId} | get
[**GetStatistic**](ViewApi.md#getstatistic) | **GET** /v1/views/{viewId}/statistic | getStatistic
[**ImportView**](ViewApi.md#importview) | **POST** /v1/views/{viewId}/import | importView
[**List**](ViewApi.md#list) | **GET** /v1/views | list
[**Merge**](ViewApi.md#merge) | **POST** /v1/views/{viewId}/merge | merge



## Create

> View Create (CreateView createView)

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

            var apiInstance = new ViewApi(Configuration.Default);
            var createView = new CreateView(); // CreateView | 

            try
            {
                // create
                View result = apiInstance.Create(createView);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.Create: " + e.Message );
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
 **createView** | [**CreateView**](CreateView.md)|  | 

### Return type

[**View**](View.md)

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


## Export

> System.IO.Stream Export (string viewId, List<string> columnIds = null, ExportFileHeader? fileHeader = null, string query = null, string sort = null, string type = null)

export

export

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ExportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var columnIds = new List<string>(); // List<string> | columnIds (optional) 
            var fileHeader = (ExportFileHeader) "none";  // ExportFileHeader? | fileHeader (optional) 
            var query = "\"{}\"";  // string | query (optional)  (default to "{}")
            var sort = "\"{}\"";  // string | sort (optional)  (default to "{}")
            var type = "csv";  // string | type (optional)  (default to csv)

            try
            {
                // export
                System.IO.Stream result = apiInstance.Export(viewId, columnIds, fileHeader, query, sort, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.Export: " + e.Message );
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
 **columnIds** | [**List&lt;string&gt;**](string.md)| columnIds | [optional] 
 **fileHeader** | **ExportFileHeader?**| fileHeader | [optional] 
 **query** | **string**| query | [optional] [default to &quot;{}&quot;]
 **sort** | **string**| sort | [optional] [default to &quot;{}&quot;]
 **type** | **string**| type | [optional] [default to csv]

### Return type

**System.IO.Stream**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Get

> View Get (string viewId, List<string> columnIds = null, List<string> include = null, string page = null, string query = null, string sort = null)

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

            var apiInstance = new ViewApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var columnIds = new List<string>(); // List<string> | columnIds (optional) 
            var include = new List<string>(); // List<string> | include (optional) 
            var page = "\"{}\"";  // string | page (optional)  (default to "{}")
            var query = "\"{}\"";  // string | query (optional)  (default to "{}")
            var sort = "\"{}\"";  // string | sort (optional)  (default to "{}")

            try
            {
                // get
                View result = apiInstance.Get(viewId, columnIds, include, page, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.Get: " + e.Message );
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
 **columnIds** | [**List&lt;string&gt;**](string.md)| columnIds | [optional] 
 **include** | [**List&lt;string&gt;**](string.md)| include | [optional] 
 **page** | **string**| page | [optional] [default to &quot;{}&quot;]
 **query** | **string**| query | [optional] [default to &quot;{}&quot;]
 **sort** | **string**| sort | [optional] [default to &quot;{}&quot;]

### Return type

[**View**](View.md)

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


## GetStatistic

> ViewStatistic GetStatistic (string viewId, List<string> columnIds = null)

getStatistic

getStatistic

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class GetStatisticExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var columnIds = new List<string>(); // List<string> | columnIds (optional) 

            try
            {
                // getStatistic
                ViewStatistic result = apiInstance.GetStatistic(viewId, columnIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.GetStatistic: " + e.Message );
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
 **columnIds** | [**List&lt;string&gt;**](string.md)| columnIds | [optional] 

### Return type

[**ViewStatistic**](ViewStatistic.md)

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


## ImportView

> void ImportView (string viewId, System.IO.Stream file, string importRequest = null, string type = null)

importView

importView

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ImportViewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewApi(Configuration.Default);
            var viewId = "viewId_example";  // string | viewId
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The following file types are supported: csv, tsv, xls, xlsx and json
            var importRequest = "\"{}\"";  // string | importRequest (optional)  (default to "{}")
            var type = "csv";  // string | type (optional)  (default to csv)

            try
            {
                // importView
                apiInstance.ImportView(viewId, file, importRequest, type);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.ImportView: " + e.Message );
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
 **file** | **System.IO.Stream**| The following file types are supported: csv, tsv, xls, xlsx and json | 
 **importRequest** | **string**| importRequest | [optional] [default to &quot;{}&quot;]
 **type** | **string**| type | [optional] [default to csv]

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
| **202** | Accepted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## List

> List&lt;View&gt; List (string branchId = null, string gridId = null, string type = null)

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

            var apiInstance = new ViewApi(Configuration.Default);
            var branchId = "branchId_example";  // string | branchId (optional) 
            var gridId = "gridId_example";  // string | gridId (optional) 
            var type = "defaultView";  // string | type (optional) 

            try
            {
                // list
                List<View> result = apiInstance.List(branchId, gridId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.List: " + e.Message );
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
 **branchId** | **string**| branchId | [optional] 
 **gridId** | **string**| gridId | [optional] 
 **type** | **string**| type | [optional] 

### Return type

[**List&lt;View&gt;**](View.md)

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

> Task Merge (string destinationViewId, string viewId, MergeBranchRequest mergeBranchRequest, List<string> mergeRecordOptions = null)

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

            var apiInstance = new ViewApi(Configuration.Default);
            var destinationViewId = "destinationViewId_example";  // string | destinationViewId
            var viewId = "viewId_example";  // string | viewId
            var mergeBranchRequest = new MergeBranchRequest(); // MergeBranchRequest | 
            var mergeRecordOptions = new List<string>(); // List<string> | mergeRecordOptions (optional) 

            try
            {
                // merge
                Task result = apiInstance.Merge(destinationViewId, viewId, mergeBranchRequest, mergeRecordOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ViewApi.Merge: " + e.Message );
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
 **destinationViewId** | **string**| destinationViewId | 
 **viewId** | **string**| viewId | 
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

