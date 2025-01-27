using Itmo.Bebriki.Analytics;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Dtos.Payloads;

internal static class PayloadMapper
{
    internal static PayloadDto ToInternal(Payload payload)
    {
        return new PayloadDto(
            Id: payload.Id,
            EventType: EventTypeMapper.ToInternal(payload.EventType),
            Timestamp: payload.Timestamp.ToDateTimeOffset(),
            Payload: PayloadTypeMapper.ToInternal(payload));
    }
}
