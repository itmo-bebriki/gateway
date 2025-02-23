using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Requests;

internal static class UpdateJobTaskRequestMapper
{
    internal static Itmo.Bebriki.Tasks.Contracts.UpdateJobTaskRequest FromInternal(
        long id,
        UpdateJobTaskRequest request)
    {
        return new Bebriki.Tasks.Contracts.UpdateJobTaskRequest
        {
            JobTaskId = id,
            Title = request.Title,
            Description = request.Description,
            AssigneeId = request.AssigneeId,
            Priority = request.Priority is not null
                ? JobTaskPriorityMapper.FromInternal(request.Priority.Value)
                : Bebriki.Enums.JobTaskPriority.Unspecified,
            DeadLine = request.Deadline?.ToTimestamp(),
        };
    }
}
