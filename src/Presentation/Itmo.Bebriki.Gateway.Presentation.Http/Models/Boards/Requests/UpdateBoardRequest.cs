using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

[SwaggerSchema("Request model for updating the board.")]
public class UpdateBoardRequest
{
    [BindProperty(Name = "name")]
    [property: SwaggerSchema("A new board name.", Nullable = true)]
    [property: SwaggerSchemaExample("Some new name")]
    public string? Name { get; set; }

    [BindProperty(Name = "description")]
    [property: SwaggerSchema("A new board description.", Nullable = true)]
    [property: SwaggerSchemaExample("Some new description")]
    public string? Description { get; set; }
}
