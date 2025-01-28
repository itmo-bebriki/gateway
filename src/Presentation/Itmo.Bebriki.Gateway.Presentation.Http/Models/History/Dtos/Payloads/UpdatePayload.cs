using Swashbuckle.AspNetCore.Annotations;
using JobTaskPriority = Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums.JobTaskPriority;
using JobTaskState = Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums.JobTaskState;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

[SwaggerSchema(Description = "Represents a payload for an update event.")]
public sealed record UpdatePayload(
    long JobTaskId,
    string? Title,
    string? Description,
    long? AssigneeId,
    JobTaskState State,
    JobTaskPriority Priority,
    DateTimeOffset? Deadline,
    bool? IsAgreed,
    DateTimeOffset UpdatedAt) : BasePayload(JobTaskId);
