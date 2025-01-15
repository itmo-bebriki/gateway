namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Requests;

internal static class SetBoardTopicsRequestMapper
{
    internal static Itmo.Bebriki.Boards.Contracts.SetBoardTopicsRequest FromInternal(
        long id,
        Models.Boards.Requests.SetBoardTopicsRequest request)
    {
        return new Bebriki.Boards.Contracts.SetBoardTopicsRequest
        {
            BoardId = id,
            TopicIds = { request.TopicIds },
        };
    }
}
