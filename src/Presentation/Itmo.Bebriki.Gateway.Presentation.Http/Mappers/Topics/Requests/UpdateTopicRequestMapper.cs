using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Requests;

internal static class UpdateTopicRequestMapper
{
    internal static Itmo.Bebriki.Topics.Contracts.UpdateTopicRequest FromInternal(
        long id,
        UpdateTopicRequest request)
    {
        return new Bebriki.Topics.Contracts.UpdateTopicRequest
        {
            TopicId = id,
            Name = request.Name,
            Description = request.Description,
        };
    }
}
