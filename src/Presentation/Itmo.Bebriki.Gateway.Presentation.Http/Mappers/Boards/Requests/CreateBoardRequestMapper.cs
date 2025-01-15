using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Requests;

internal static class CreateBoardRequestMapper
{
    internal static Itmo.Bebriki.Boards.Contracts.CreateBoardRequest FromInternal(CreateBoardRequest request)
    {
        return new Bebriki.Boards.Contracts.CreateBoardRequest
        {
            Name = request.Name,
            Description = request.Description,
            TopicIds = { request.TopicIds },
        };
    }
}
