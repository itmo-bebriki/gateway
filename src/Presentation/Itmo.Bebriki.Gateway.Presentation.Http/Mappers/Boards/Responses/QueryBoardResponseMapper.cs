using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Responses;

internal static class QueryBoardResponseMapper
{
    internal static QueryBoardResponse ToInternal(Itmo.Bebriki.Boards.Contracts.QueryBoardResponse response)
    {
        return new QueryBoardResponse(
            Cursor: response.Cursor, Boards: response.Boards.Select(BoardDtoMapper.ToInternal).ToArray());
    }
}
