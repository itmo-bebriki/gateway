using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Responses;

[SwaggerSchema(Description = "Response model for querying agreements.")]
public sealed record QueryAgreementResponse(
    [property: SwaggerSchema("A cursor for paged query results.")]
    [property: SwaggerSchemaExample("-1")]
    long? Cursor,

    [property: SwaggerSchema("A payload for agreement results.")]
    IReadOnlyCollection<AgreementDto> Agreements);
