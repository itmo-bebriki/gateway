using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

[SwaggerSchema("Request model for creating a board.")]
public class CreateBoardRequest
{
    [Required]
    [BindProperty(Name = "name")]
    [property: SwaggerSchema("A name for the new board")]
    [property: SwaggerSchemaExample("University related")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "description")]
    [property: SwaggerSchema("A description of the new board")]
    [property: SwaggerSchemaExample("Some university related tasks")]
    public string Description { get; set; } = string.Empty;

    [BindProperty(Name = "topic_ids")]
    [property: SwaggerSchema("Ids of topics for the new board")]
    public long[] TopicIds { get; set; } = [];
}
