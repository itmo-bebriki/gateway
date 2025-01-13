using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Responses;

internal static class QueryTopicResponseMapper
{
    internal static QueryTopicResponse ToInternal(Itmo.Bebriki.Topics.Contracts.QueryTopicResponse response)
    {
        return new QueryTopicResponse(
            Cursor: response.Cursor,
            Topics: response.Topics.Select(TopicDtoMapper.ToInternal).ToArray());
    }
}
