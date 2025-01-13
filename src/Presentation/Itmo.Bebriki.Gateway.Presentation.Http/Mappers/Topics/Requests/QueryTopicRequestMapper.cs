using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Requests;

internal static class QueryTopicRequestMapper
{
    internal static Itmo.Bebriki.Topics.Contracts.QueryTopicRequest FromInternal(QueryTopicRequest request)
    {
        return new Bebriki.Topics.Contracts.QueryTopicRequest
        {
            TopicIds = { request.TopicIds },
            FromUpdatedAt = request.FromUpdatedAt?.ToTimestamp(),
            ToUpdatedAt = request.ToUpdatedAt?.ToTimestamp(),
            Cursor = request.Cursor,
            PageSize = request.PageSize,
        };
    }
}
