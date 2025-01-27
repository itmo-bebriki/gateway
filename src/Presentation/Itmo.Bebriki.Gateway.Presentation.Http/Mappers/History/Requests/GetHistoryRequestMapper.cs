using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Analytics.Contracts;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Requests;

internal static class GetHistoryRequestMapper
{
    internal static GetHistoryRequest FromInternal(Models.History.Requests.GetHistoryRequest request)
    {
        return new GetHistoryRequest
        {
            Ids = { request.Ids.ToArray() },
            EventTypes = { request.EventTypes.Select(EventTypeMapper.FromInternal).ToArray() },
            FromTimestamp = request.FromTimestamp?.ToTimestamp(),
            ToTimestamp = request.ToTimestamp?.ToTimestamp(),
            PageSize = request.PageSize,
        };
    }
}
