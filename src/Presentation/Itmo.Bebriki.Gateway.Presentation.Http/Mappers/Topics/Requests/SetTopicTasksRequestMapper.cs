using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Requests;

internal static class SetTopicTasksRequestMapper
{
    internal static Itmo.Bebriki.Topics.Contracts.SetTopicTasksRequest FromInternal(
        long id,
        SetTopicTasksRequest request)
    {
        return new Bebriki.Topics.Contracts.SetTopicTasksRequest
        {
            TopicId = id,
            TaskIds = { request.TaskIds },
        };
    }
}
