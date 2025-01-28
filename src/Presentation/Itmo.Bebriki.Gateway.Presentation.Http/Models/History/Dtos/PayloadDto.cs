using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;
using Swashbuckle.AspNetCore.Annotations;
using EventType = Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums.EventType;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos;

[SwaggerSchema(Description = "Represents a model for the full payload.")]
public record PayloadDto(
    long Id,
    EventType EventType,
    DateTimeOffset Timestamp,
    BasePayload Payload);
