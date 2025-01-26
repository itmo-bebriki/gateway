using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

public sealed record CreatePayload(
    long JobTaskId,
    string Title,
    string Description,
    long AssigneeId,
    JobTaskPriority? Priority,
    long[] DependsOnIds,
    DateTimeOffset? Deadline,
    DateTimeOffset CreatedAt) : BasePayload(JobTaskId);
