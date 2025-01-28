using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;

[SwaggerSchema("Response model for creating a new topic.")]
public sealed record CreateTopicResponse(
    [property: SwaggerSchema("An id of created topic.")]
    [property: SwaggerSchemaExample("5")]
    long TopicId);
