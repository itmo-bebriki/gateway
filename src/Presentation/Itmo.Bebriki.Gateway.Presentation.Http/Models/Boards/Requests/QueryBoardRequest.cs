using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

[SwaggerSchema("Request model for querying boards.")]
public class QueryBoardRequest
{
    [BindProperty(Name = "board_ids")]
    [property: SwaggerSchema("Ids of boards to query.")]
    public long[] BoardIds { get; set; } = [];

    [BindProperty(Name = "from_updated_at")]
    [property: SwaggerSchema("A timestamp of the last board update to query from.", Nullable = true)]
    public DateTimeOffset? FromUpdatedAt { get; set; }

    [BindProperty(Name = "to_updated_at")]
    [property: SwaggerSchema("A timestamp of the last board update to query to.", Nullable = true)]
    public DateTimeOffset? ToUpdatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    [property: SwaggerSchema("An id of the board to query from.", Nullable = true)]
    public long? Cursor { get; set; }

    [Required]
    [BindProperty(Name = "page_size")]
    [property: SwaggerSchema("A page size for paged query.", Nullable = false)]
    [property: SwaggerSchemaExample("10")]
    public int PageSize { get; set; }
}
