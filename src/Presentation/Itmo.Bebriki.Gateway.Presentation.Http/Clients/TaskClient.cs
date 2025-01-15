using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Tasks.Responses;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Clients;

public class TaskClient
{
    private readonly Tasks.Contracts.JobTaskService.JobTaskServiceClient _client;

    public TaskClient(Tasks.Contracts.JobTaskService.JobTaskServiceClient client)
    {
        _client = client;
    }

    public async Task<QueryJobTaskResponse> QueryJobTasksAsync(
        QueryJobTaskRequest request,
        CancellationToken cancellationToken)
    {
        Tasks.Contracts.QueryJobTaskResponse response = await _client.QueryJobTasksAsync(
            QueryJobTaskRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return QueryJobTaskResponseMapper.ToInternal(response);
    }

    public async Task<CreateJobTaskResponse> CreateJobTaskAsync(
        CreateJobTaskRequest request,
        CancellationToken cancellationToken)
    {
        Tasks.Contracts.CreateJobTaskResponse response = await _client.CreateJobTaskAsync(
            CreateJobTaskRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return CreateJobTaskResponseMapper.ToInternal(response);
    }

    public async Task UpdateJobTaskAsync(
        long id,
        UpdateJobTaskRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateJobTaskAsync(
            UpdateJobTaskRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }

    public async Task AddJobTaskDependenciesAsync(
        long id,
        SetJobTaskDependenciesRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddJobTaskDependenciesAsync(
            AddJobTaskDependenciesRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }

    public async Task RemoveJobTaskDependenciesAsync(
        long id,
        SetJobTaskDependenciesRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveJobTaskDependenciesAsync(
            RemoveJobTaskDependenciesRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }
}
