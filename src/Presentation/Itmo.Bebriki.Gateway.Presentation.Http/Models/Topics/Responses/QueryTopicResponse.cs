using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;

[SwaggerSchema("Response model for creating a new topic.")]
public sealed record QueryTopicResponse(
    [property: SwaggerSchema("The last id of fetched topic.")]
    [property: SwaggerSchemaExample("5")]
    long? Cursor,

    [property: SwaggerSchema("Topic contents.")]
    [property: SwaggerSchemaExample("5")]
    TopicDto[] Topics);
