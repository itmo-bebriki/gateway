using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

[SwaggerSchema("Response model for querying job tasks.")]
public sealed record QueryJobTaskResponse(
    [property: SwaggerSchema("An id of the last fetched job task.")]
    [property: SwaggerSchemaExample("5")]
    long? Cursor,

    [property: SwaggerSchema("Fetched job tasks.")]
    JobTaskDto[] JobTasks);
