using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

[SwaggerSchema("Response model for created job task request.")]
public sealed record CreateJobTaskResponse(
    [property: SwaggerSchema("An id of the created job task.")]
    [property: SwaggerSchemaExample("5")]
    long JobTaskId);
