using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;

[SwaggerSchema(Description = "Response model for creating a new board.")]
public sealed record CreateBoardResponse(
    [property: SwaggerSchema("An id of created board.")]
    [property: SwaggerSchemaExample("1")]
    long BoardId);
