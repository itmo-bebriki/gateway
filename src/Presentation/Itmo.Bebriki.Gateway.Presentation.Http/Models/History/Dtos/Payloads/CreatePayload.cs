using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

[SwaggerSchema(Description = "Represents a payload for a creation event.")]
public sealed record CreatePayload(
    long JobTaskId,
    string Title,
    string Description,
    long AssigneeId,
    JobTaskPriority? Priority,
    long[] DependsOnIds,
    DateTimeOffset? Deadline,
    DateTimeOffset CreatedAt) : BasePayload(JobTaskId);
