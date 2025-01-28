using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Responses;

[SwaggerSchema("Response model for fetched history events.")]
public sealed record GetHistoryResponse(
    [property: SwaggerSchema("An id of the last fetched event.")]
    [property: SwaggerSchemaExample("10")]
    long Cursor,

    [property: SwaggerSchema("Fetched payloads with event content.")]
    PayloadDto[] Payloads);
