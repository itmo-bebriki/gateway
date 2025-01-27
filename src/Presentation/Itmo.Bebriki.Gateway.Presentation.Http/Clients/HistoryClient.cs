using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Responses;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Clients;

public class HistoryClient
{
    private readonly Analytics.Contracts.HistoryAnalyticsService.HistoryAnalyticsServiceClient _client;

    public HistoryClient(Analytics.Contracts.HistoryAnalyticsService.HistoryAnalyticsServiceClient client)
    {
        _client = client;
    }

    public async Task<GetHistoryResponse> GetHistoryAsync(
        GetHistoryRequest request,
        CancellationToken cancellationToken)
    {
        Analytics.Contracts.GetHistoryResponse response = await _client.GetHistoryAsync(
            GetHistoryRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return GetHistoryResponseMapper.ToInternal(response);
    }
}
