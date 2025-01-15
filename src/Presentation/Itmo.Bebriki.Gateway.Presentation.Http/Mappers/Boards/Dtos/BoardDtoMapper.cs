using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Dtos;

internal static class BoardDtoMapper
{
    internal static Itmo.Bebriki.Boards.Contracts.BoardDto FromInternal(BoardDto dto)
    {
        return new Bebriki.Boards.Contracts.BoardDto
        {
            BoardId = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            TopicIds = { dto.TopicIds },
            UpdatedAt = dto.UpdatedAt.ToTimestamp(),
        };
    }

    internal static BoardDto ToInternal(Itmo.Bebriki.Boards.Contracts.BoardDto dto)
    {
        return new BoardDto(
            Id: dto.BoardId,
            Name: dto.Name,
            Description: dto.Description,
            TopicIds: dto.TopicIds.ToArray(),
            UpdatedAt: dto.UpdatedAt.ToDateTimeOffset());
    }
}
