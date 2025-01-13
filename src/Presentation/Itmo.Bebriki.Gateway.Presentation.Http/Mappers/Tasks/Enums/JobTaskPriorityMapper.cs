using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Enums;

internal static class JobTaskPriorityMapper
{
    internal static JobTaskPriority ToInternal(Itmo.Bebriki.Tasks.Contracts.JobTaskPriority priority)
    {
        return priority switch
        {
            Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Unspecified => JobTaskPriority.None,
            Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Low => JobTaskPriority.Low,
            Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Medium => JobTaskPriority.Medium,
            Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.High => JobTaskPriority.High,
            Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Critical => JobTaskPriority.Critical,
            _ => throw new ArgumentOutOfRangeException(nameof(priority), priority, null),
        };
    }

    internal static Itmo.Bebriki.Tasks.Contracts.JobTaskPriority FromInternal(JobTaskPriority priority)
    {
        return priority switch
        {
            JobTaskPriority.None => Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Unspecified,
            JobTaskPriority.Low => Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Low,
            JobTaskPriority.Medium => Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Medium,
            JobTaskPriority.High => Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.High,
            JobTaskPriority.Critical => Itmo.Bebriki.Tasks.Contracts.JobTaskPriority.Critical,
            _ => throw new ArgumentOutOfRangeException(nameof(priority), priority, null),
        };
    }
}
