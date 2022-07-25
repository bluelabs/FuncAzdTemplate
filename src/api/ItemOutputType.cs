using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace SimpleTodo.Api;

public class ItemOutputType
{
    [CosmosDBOutput(databaseName: "%AZURE_COSMOS_DATABASE_NAME%", collectionName: "%ItemsCollectionName%", ConnectionStringSetting = "AZURE_COSMOS_ENDPOINT")]
    public TodoItem? UpdatedTodoItem { get; set; }
    public HttpResponseData? HttpResponse { get; set; }

}