using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;

public record QueryTopicResponse(long? Cursor, TopicDto[] Topics);
