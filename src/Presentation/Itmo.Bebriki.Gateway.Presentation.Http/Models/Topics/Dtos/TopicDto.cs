using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Dtos;

[SwaggerSchema(Description = "A model with topic information.")]
public record TopicDto(
    long Id,
    string Name,
    string Description,
    long[] TaskIds,
    DateTimeOffset UpdatedAt);
