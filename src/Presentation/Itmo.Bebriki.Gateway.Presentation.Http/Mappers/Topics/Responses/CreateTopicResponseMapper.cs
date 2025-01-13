using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Responses;

internal static class CreateTopicResponseMapper
{
    internal static CreateTopicResponse ToInternal(Itmo.Bebriki.Topics.Contracts.CreateTopicResponse response)
    {
        return new CreateTopicResponse(TopicId: response.TopicId);
    }
}
