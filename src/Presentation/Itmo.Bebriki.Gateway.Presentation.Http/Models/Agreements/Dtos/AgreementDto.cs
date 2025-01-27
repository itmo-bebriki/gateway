using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Dtos;

public sealed record AgreementDto(
    long AgreementId,
    long JobTaskId,
    JobTaskState State,
    long? AssigneeId,
    DateTimeOffset? Deadline,
    DateTimeOffset CreatedAt);