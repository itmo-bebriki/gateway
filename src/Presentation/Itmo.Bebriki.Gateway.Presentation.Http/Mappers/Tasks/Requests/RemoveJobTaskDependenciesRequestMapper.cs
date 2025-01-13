using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Requests;

internal static class RemoveJobTaskDependenciesRequestMapper
{
    internal static Itmo.Bebriki.Tasks.Contracts.SetJobTaskDependenciesRequest FromInternal(
        long id,
        SetJobTaskDependenciesRequest request)
    {
        return new Bebriki.Tasks.Contracts.SetJobTaskDependenciesRequest
        {
            JobTaskId = id,
            DependOnTaskIds = { request.DependsOnTaskIds },
        };
    }
}
