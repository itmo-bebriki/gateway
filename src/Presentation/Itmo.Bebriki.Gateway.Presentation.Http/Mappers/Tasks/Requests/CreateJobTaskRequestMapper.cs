using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Requests;

internal static class CreateJobTaskRequestMapper
{
    internal static Itmo.Bebriki.Tasks.Contracts.CreateJobTaskRequest FromInternal(CreateJobTaskRequest request)
    {
        return new Bebriki.Tasks.Contracts.CreateJobTaskRequest
        {
            AssigneeId = request.AssignedId,
            DeadLine = request.Deadline?.ToTimestamp(),
            DependOnTaskIds = { request.DependsOnTaskIds },
            Description = request.Description,
            Priority = JobTaskPriorityMapper.FromInternal(request.Priority),
            Title = request.Title,
        };
    }
}
