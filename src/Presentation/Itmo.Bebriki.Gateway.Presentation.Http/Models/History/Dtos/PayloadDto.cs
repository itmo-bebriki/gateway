using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;
using EventType = Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums.EventType;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos;

public record PayloadDto(
    long Id,
    EventType EventType,
    DateTimeOffset Timestamp,
    BasePayload Payload);
