using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Dtos;

internal static class TopicDtoMapper
{
    internal static Itmo.Bebriki.Topics.Contracts.TopicDto FromInternal(TopicDto dto)
    {
        return new Bebriki.Topics.Contracts.TopicDto
        {
            TopicId = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            TaskIds = { dto.TaskIds },
            UpdatedAt = dto.UpdatedAt.ToTimestamp(),
        };
    }

    internal static TopicDto ToInternal(Itmo.Bebriki.Topics.Contracts.TopicDto dto)
    {
        return new TopicDto(
            Id: dto.TopicId,
            Name: dto.Name,
            Description: dto.Description,
            TaskIds: dto.TaskIds.ToArray(),
            UpdatedAt: dto.UpdatedAt.ToDateTimeOffset());
    }
}
