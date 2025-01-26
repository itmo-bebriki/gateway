using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Analytics.Enums;

internal static class JobTaskPriorityAnalyticsMapper
{
    internal static JobTaskPriority ToInternal(Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskPriority priority)
    {
        return priority switch
        {
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskPriority.Unspecified => JobTaskPriority.None,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskPriority.Low => JobTaskPriority.Low,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskPriority.Medium => JobTaskPriority.Medium,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskPriority.High => JobTaskPriority.High,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskPriority.Critical => JobTaskPriority.Critical,
            _ => throw new ArgumentOutOfRangeException(nameof(priority), priority, null),
        };
    }
}
