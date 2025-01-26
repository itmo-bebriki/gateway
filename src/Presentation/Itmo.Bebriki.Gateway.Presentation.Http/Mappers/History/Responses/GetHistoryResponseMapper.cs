using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Dtos.Payloads;
using GetHistoryResponse = Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Responses.GetHistoryResponse;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Responses;

internal static class GetHistoryResponseMapper
{
    internal static GetHistoryResponse ToInternal(Bebriki.Analytics.Grpc.Contracts.GetHistoryResponse response)
    {
        return new GetHistoryResponse(
            Cursor: response.Cursor,
            Payloads: response.Payloads.Select(PayloadMapper.ToInternal).ToArray());
    }
}
