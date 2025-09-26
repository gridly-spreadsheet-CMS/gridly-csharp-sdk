# Com.Gridly.Api.TicketApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](TicketApi.md#create) | **POST** /v1/tickets | Create a new ticket



## Create

> TicketResponse Create (List<System.IO.Stream>  = null, string summary = null, string type = null, string description = null, string priority = null, long? lqaModelCategoryId = null, long? lqaModelSubCategoryId = null, long? lqaModelSeverityId = null, string columnId = null, string recordId = null, string assigneeId = null, string viewId = null)

Create a new ticket

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

            var apiInstance = new TicketApi(Configuration.Default);
            var  = new List<System.IO.Stream>(); // List<System.IO.Stream> |  (optional) 
            var summary = "summary_example";  // string |  (optional) 
            var type = "type_example";  // string |  (optional) 
            var description = "description_example";  // string |  (optional) 
            var priority = "priority_example";  // string |  (optional) 
            var lqaModelCategoryId = 789L;  // long? |  (optional) 
            var lqaModelSubCategoryId = 789L;  // long? |  (optional) 
            var lqaModelSeverityId = 789L;  // long? |  (optional) 
            var columnId = "columnId_example";  // string |  (optional) 
            var recordId = "recordId_example";  // string |  (optional) 
            var assigneeId = "assigneeId_example";  // string |  (optional) 
            var viewId = "viewId_example";  // string |  (optional) 

            try
            {
                // Create a new ticket
                TicketResponse result = apiInstance.Create(, summary, type, description, priority, lqaModelCategoryId, lqaModelSubCategoryId, lqaModelSeverityId, columnId, recordId, assigneeId, viewId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TicketApi.Create: " + e.Message );
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
 **** | [**List&lt;System.IO.Stream&gt;**](System.IO.Stream.md)|  | [optional] 
 **summary** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **priority** | **string**|  | [optional] 
 **lqaModelCategoryId** | **long?**|  | [optional] 
 **lqaModelSubCategoryId** | **long?**|  | [optional] 
 **lqaModelSeverityId** | **long?**|  | [optional] 
 **columnId** | **string**|  | [optional] 
 **recordId** | **string**|  | [optional] 
 **assigneeId** | **string**|  | [optional] 
 **viewId** | **string**|  | [optional] 

### Return type

[**TicketResponse**](TicketResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a new ticket successful ! |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

