using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

[SwaggerSchema(Description = "Request model for creating new topic.")]
public class CreateTopicRequest
{
    [Required]
    [BindProperty(Name = "name")]
    [property: SwaggerSchema("A name for the new topic.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "description")]
    [property: SwaggerSchema("A description for the new topic.")]
    public string Description { get; set; } = string.Empty;

    [BindProperty(Name = "task_ids")]
    [property: SwaggerSchema("Task IDs for new topic.")]
    public long[] TaskIds { get; set; } = [];
}
