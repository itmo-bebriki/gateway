namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

public sealed record DependencyPayload(
    long JobTaskId,
    long[] ChangedDependencies) : BasePayload(JobTaskId);
