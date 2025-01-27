using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Dtos;

public sealed record JobTaskDto
{
    internal JobTaskDto() { }

    public long Id { get; init; }

    public string Title { get; init; } = string.Empty;

    public string Description { get; init; } = string.Empty;

    public long AssigneeId { get; init; }

    public JobTaskState State { get; init; }

    public JobTaskPriority Priority { get; init; }

    public IReadOnlySet<long> DependOnJobTaskIds { get; init; } = new HashSet<long>();

    public DateTimeOffset DeadLine { get; init; }

    public DateTimeOffset UpdatedAt { get; init; }
}
