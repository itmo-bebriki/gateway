using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Analytics.Enums;

internal static class JobTaskStateAnalyticsMapper
{
    internal static JobTaskState ToInternal(Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState state)
    {
        return state switch
        {
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.Unspecified => JobTaskState.None,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.Backlog => JobTaskState.Backlog,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.ToDo => JobTaskState.ToDo,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.InProgress => JobTaskState.InProgress,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.InReview => JobTaskState.InReview,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.Done => JobTaskState.Done,
            Itmo.Bebriki.Analytics.Grpc.Contracts.JobTaskState.Closed => JobTaskState.Closed,
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null),
        };
    }
}
