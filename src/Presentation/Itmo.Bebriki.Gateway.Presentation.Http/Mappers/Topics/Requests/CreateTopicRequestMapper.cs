using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Requests;

internal static class CreateTopicRequestMapper
{
    internal static Itmo.Bebriki.Topics.Contracts.CreateTopicRequest FromInternal(CreateTopicRequest request)
    {
        return new Bebriki.Topics.Contracts.CreateTopicRequest
        {
            Name = request.Name,
            Description = request.Description,
            TaskIds = { request.TaskIds },
        };
    }
}
