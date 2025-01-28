using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

[SwaggerSchema(Description = "Represents a payload for a dependency update event.")]
public sealed record DependencyPayload(
    long JobTaskId,
    long[] ChangedDependencies) : BasePayload(JobTaskId);
