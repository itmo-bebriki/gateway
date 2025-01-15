using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Topics.Responses;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Clients;

public class TopicClient
{
    private readonly Topics.Contracts.TopicService.TopicServiceClient _client;

    public TopicClient(Topics.Contracts.TopicService.TopicServiceClient client)
    {
        _client = client;
    }

    public async Task<QueryTopicResponse> QueryTopicAsync(
        QueryTopicRequest request,
        CancellationToken cancellationToken)
    {
        Topics.Contracts.QueryTopicResponse response = await _client.QueryTopicAsync(
            QueryTopicRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return QueryTopicResponseMapper.ToInternal(response);
    }

    public async Task<CreateTopicResponse> CreateTopicAsync(
        CreateTopicRequest request,
        CancellationToken cancellationToken)
    {
        Topics.Contracts.CreateTopicResponse response = await _client.CreateTopicAsync(
            CreateTopicRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return CreateTopicResponseMapper.ToInternal(response);
    }

    public async Task UpdateTopicAsync(
        long id,
        UpdateTopicRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateTopicAsync(
            UpdateTopicRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }

    public async Task AddTopicTasksAsync(
        long id,
        SetTopicTasksRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddTopicTasksAsync(
            SetTopicTasksRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }

    public async Task RemoveTopicTasksAsync(
        long id,
        SetTopicTasksRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveTopicTasksAsync(
            SetTopicTasksRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }
}
