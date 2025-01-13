using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Enums;

internal static class JobTaskStateMapper
{
    internal static JobTaskState ToInternal(Itmo.Bebriki.Tasks.Contracts.JobTaskState state)
    {
        return state switch
        {
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.Unspecified => JobTaskState.None,
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.Backlog => JobTaskState.Backlog,
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.ToDo => JobTaskState.ToDo,
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.InProgress => JobTaskState.InProgress,
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.InReview => JobTaskState.InReview,
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.Done => JobTaskState.Done,
            Itmo.Bebriki.Tasks.Contracts.JobTaskState.Closed => JobTaskState.Closed,
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null),
        };
    }

    internal static Itmo.Bebriki.Tasks.Contracts.JobTaskState FromInternal(JobTaskState state)
    {
        return state switch
        {
            JobTaskState.None => Itmo.Bebriki.Tasks.Contracts.JobTaskState.Unspecified,
            JobTaskState.Backlog => Itmo.Bebriki.Tasks.Contracts.JobTaskState.Backlog,
            JobTaskState.ToDo => Itmo.Bebriki.Tasks.Contracts.JobTaskState.ToDo,
            JobTaskState.InProgress => Itmo.Bebriki.Tasks.Contracts.JobTaskState.InProgress,
            JobTaskState.InReview => Itmo.Bebriki.Tasks.Contracts.JobTaskState.InReview,
            JobTaskState.Done => Itmo.Bebriki.Tasks.Contracts.JobTaskState.Done,
            JobTaskState.Closed => Itmo.Bebriki.Tasks.Contracts.JobTaskState.Closed,
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null),
        };
    }
}
