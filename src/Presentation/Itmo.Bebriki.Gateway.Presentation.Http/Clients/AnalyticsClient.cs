using Itmo.Bebriki.Analytics.Grpc.Contracts;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Analytics.Responses;
using GetAnalyticsResponse = Itmo.Bebriki.Gateway.Presentation.Http.Models.Analytics.Responses.GetAnalyticsResponse;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Clients;

public class AnalyticsClient
{
    private readonly TaskAnalyticsService.TaskAnalyticsServiceClient _client;

    public AnalyticsClient(TaskAnalyticsService.TaskAnalyticsServiceClient client)
    {
        _client = client;
    }

    public async Task<GetAnalyticsResponse> GetAnalytics(
        long id,
        CancellationToken cancellationToken)
    {
        Analytics.Grpc.Contracts.GetAnalyticsResponse response = await _client.GetAnalyticsAsync(
            new GetAnalyticsRequest
            {
                TaskId = id,
            },
            cancellationToken: cancellationToken);

        return GetAnalyticsResponseMapper.ToInternal(response);
    }
}
