using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Responses;

internal static class QueryJobTaskResponseMapper
{
    internal static QueryJobTaskResponse ToInternal(Itmo.Bebriki.Tasks.Contracts.QueryJobTaskResponse response)
    {
        return new QueryJobTaskResponse(
            Cursor: response.Cursor,
            JobTasks: response.JobTasks.Select(JobTaskDtoMapper.ToInternal).ToArray());
    }
}
