using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Requests;

internal static class UpdateBoardRequestMapper
{
    internal static Itmo.Bebriki.Boards.Contracts.UpdateBoardRequest FromInternal(long id, UpdateBoardRequest request)
    {
        return new Bebriki.Boards.Contracts.UpdateBoardRequest
        {
            BoardId = id,
            Name = request.Name,
            Description = request.Description,
        };
    }
}
