using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;

internal static class JobTaskStateMapper
{
    internal static JobTaskState ToInternal(Itmo.Bebriki.Enums.JobTaskState state)
    {
        return state switch
        {
            Itmo.Bebriki.Enums.JobTaskState.Unspecified => JobTaskState.None,
            Itmo.Bebriki.Enums.JobTaskState.PendingApproval => JobTaskState.PendingApproval,
            Itmo.Bebriki.Enums.JobTaskState.Approved => JobTaskState.Approved,
            Itmo.Bebriki.Enums.JobTaskState.Rejected => JobTaskState.Rejected,
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null),
        };
    }

    internal static Itmo.Bebriki.Enums.JobTaskState FromInternal(JobTaskState state)
    {
        return state switch
        {
            JobTaskState.None => Itmo.Bebriki.Enums.JobTaskState.Unspecified,
            JobTaskState.PendingApproval => Itmo.Bebriki.Enums.JobTaskState.PendingApproval,
            JobTaskState.Approved => Itmo.Bebriki.Enums.JobTaskState.Approved,
            JobTaskState.Rejected => Itmo.Bebriki.Enums.JobTaskState.Rejected,
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null),
        };
    }
}