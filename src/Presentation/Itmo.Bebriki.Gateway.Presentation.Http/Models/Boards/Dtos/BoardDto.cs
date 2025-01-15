namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Dtos;

public record BoardDto(
    long Id,
    string Name,
    string Description,
    long[] TopicIds,
    DateTimeOffset UpdatedAt);
