using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;

[SwaggerSchema(Description = "Response model for querying boards.")]
public sealed record QueryBoardResponse(
    [property: SwaggerSchema("An id of the last queried board.")]
    [property: SwaggerSchemaExample("1")]
    long? Cursor,

    [property: SwaggerSchema("Contents of fetched boards.")]
    BoardDto[] Boards);
