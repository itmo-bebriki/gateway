using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Responses;

internal class CreateJobTaskResponseMapper
{
    internal static CreateJobTaskResponse ToInternal(Itmo.Bebriki.Tasks.Contracts.CreateJobTaskResponse request)
    {
        return new CreateJobTaskResponse(
            JobTaskId: request.JobTaskId);
    }
}
