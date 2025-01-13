using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Dtos;
using System.Collections.Immutable;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Dtos;

internal static class JobTaskDtoMapper
{
    internal static JobTaskDto ToInternal(Itmo.Bebriki.Tasks.Contracts.JobTaskDto dto)
    {
        return new JobTaskDto
        {
            Id = dto.JobTaskId,
            Title = dto.Title,
            Description = dto.Description,
            AssigneeId = dto.AssigneeId,
            State = JobTaskStateMapper.ToInternal(dto.State),
            Priority = JobTaskPriorityMapper.ToInternal(dto.Priority),
            DependOnJobTaskIds = dto.DependOnTaskIds.ToImmutableHashSet(),
            DeadLine = dto.DeadLine.ToDateTimeOffset(),
            IsAgreed = dto.IsAgreed,
            UpdatedAt = dto.UpdatedAt.ToDateTimeOffset(),
        };
    }
}
