# Com.Gridly.Api.HistoryApi

All URIs are relative to *https://api.gridly.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportGrid**](HistoryApi.md#exportgrid) | **POST** /v1/grid-histories/export | Export grid history |

<a id="exportgrid"></a>
# **ExportGrid**
> System.IO.Stream ExportGrid (ExportGridHistory exportGridHistory)

Export grid history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ExportGridExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi(config);
            var exportGridHistory = new ExportGridHistory(); // ExportGridHistory | 

            try
            {
                // Export grid history
                System.IO.Stream result = apiInstance.ExportGrid(exportGridHistory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryApi.ExportGrid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportGridWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export grid history
    ApiResponse<System.IO.Stream> response = apiInstance.ExportGridWithHttpInfo(exportGridHistory);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoryApi.ExportGridWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exportGridHistory** | [**ExportGridHistory**](ExportGridHistory.md) |  |  |

### Return type

**System.IO.Stream**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

