using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Dtos;

[SwaggerSchema(Description = "A model that contains information about boards.")]
public record BoardDto(
    long Id,
    string Name,
    string Description,
    long[] TopicIds,
    DateTimeOffset UpdatedAt);
