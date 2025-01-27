using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Requests;

internal static class QueryJobTaskRequestMapper
{
    internal static Itmo.Bebriki.Tasks.Contracts.QueryJobTaskRequest FromInternal(QueryJobTaskRequest request)
    {
        return new Itmo.Bebriki.Tasks.Contracts.QueryJobTaskRequest
        {
            JobTaskIds = { request.JobTaskIds },
            AssigneeIds = { request.AssigneeIds },
            States = { request.States.Select(JobTaskStateMapper.FromInternal).ToArray() },
            Priorities = { request.Priorities.Select(JobTaskPriorityMapper.FromInternal).ToArray() },
            DependsOnTaskIds = { request.DependsOnTaskIds },
            FromDeadline = request.FromDeadline?.ToTimestamp(),
            ToDeadline = request.ToDeadline?.ToTimestamp(),
            FromUpdatedAt = request.FromUpdatedAt?.ToTimestamp(),
            ToUpdatedAt = request.ToUpdatedAt?.ToTimestamp(),
            Cursor = request.Cursor,
            PageSize = request.PageSize,
        };
    }
}
