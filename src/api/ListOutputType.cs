using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace SimpleTodo.Api;
public class ListOutputType
{
    [CosmosDBOutput(databaseName: "%AZURE_COSMOS_DATABASE_NAME%", collectionName: "%ListsCollectionName%", ConnectionStringSetting = "AZURE_COSMOS_ENDPOINT")]
    public TodoList? UpdatedTodoList { get; set; }
    public HttpResponseData? HttpResponse { get; set; }
}