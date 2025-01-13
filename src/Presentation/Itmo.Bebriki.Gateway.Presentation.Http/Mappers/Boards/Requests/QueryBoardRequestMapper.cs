using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Requests;

internal static class QueryBoardRequestMapper
{
    internal static Itmo.Bebriki.Boards.Contracts.QueryBoardRequest FromInternal(QueryBoardRequest request)
    {
        return new Bebriki.Boards.Contracts.QueryBoardRequest
        {
            BoardIds = { request.BoardIds },
            FromUpdatedAt = request.FromUpdatedAt?.ToTimestamp(),
            ToUpdatedAt = request.ToUpdatedAt?.ToTimestamp(),
            Cursor = request.Cursor,
            PageSize = request.PageSize,
        };
    }
}
