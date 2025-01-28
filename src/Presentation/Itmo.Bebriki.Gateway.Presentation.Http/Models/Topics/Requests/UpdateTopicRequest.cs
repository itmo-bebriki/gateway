using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

[SwaggerSchema(Description = "Request model for updating topics.")]
public class UpdateTopicRequest
{
    [BindProperty(Name = "name")]
    [property: SwaggerSchema("A new name for the topic.")]
    public string? Name { get; set; }

    [BindProperty(Name = "description")]
    [property: SwaggerSchema("A new description for the topic.")]
    public string? Description { get; set; }
}
