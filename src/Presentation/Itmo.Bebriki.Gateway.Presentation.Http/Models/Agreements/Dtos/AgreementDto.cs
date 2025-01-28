using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Dtos;

[SwaggerSchema("A data transfer object for agreements.")]
public sealed record AgreementDto(
    long AgreementId,
    long JobTaskId,
    JobTaskState State,
    long? AssigneeId,
    DateTimeOffset? Deadline,
    DateTimeOffset CreatedAt);
