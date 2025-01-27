using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;

internal static class JobTaskPriorityMapper
{
    internal static JobTaskPriority ToInternal(Bebriki.Enums.JobTaskPriority priority)
    {
        return priority switch
        {
            Bebriki.Enums.JobTaskPriority.Unspecified => JobTaskPriority.None,
            Bebriki.Enums.JobTaskPriority.Low => JobTaskPriority.Low,
            Bebriki.Enums.JobTaskPriority.Medium => JobTaskPriority.Medium,
            Bebriki.Enums.JobTaskPriority.High => JobTaskPriority.High,
            Bebriki.Enums.JobTaskPriority.Critical => JobTaskPriority.Critical,
            _ => throw new ArgumentOutOfRangeException(nameof(priority), priority, null),
        };
    }

    internal static Bebriki.Enums.JobTaskPriority FromInternal(JobTaskPriority priority)
    {
        return priority switch
        {
            JobTaskPriority.None => Bebriki.Enums.JobTaskPriority.Unspecified,
            JobTaskPriority.Low => Bebriki.Enums.JobTaskPriority.Low,
            JobTaskPriority.Medium => Bebriki.Enums.JobTaskPriority.Medium,
            JobTaskPriority.High => Bebriki.Enums.JobTaskPriority.High,
            JobTaskPriority.Critical => Bebriki.Enums.JobTaskPriority.Critical,
            _ => throw new ArgumentOutOfRangeException(nameof(priority), priority, null),
        };
    }
}