namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Dtos;

public record TopicDto(
    long Id,
    string Name,
    string Description,
    long[] TaskIds,
    DateTimeOffset UpdatedAt);
