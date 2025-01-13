using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Responses;

internal static class CreateBoardResponseMapper
{
    internal static CreateBoardResponse ToInternal(Itmo.Bebriki.Boards.Contracts.CreateBoardResponse request)
    {
        return new CreateBoardResponse(BoardId: request.BoardId);
    }
}
