using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

[SwaggerSchema(Description = "Request model for updating tasks for topics.")]
public class SetTopicTasksRequest
{
    [MinLength(1)]
    [BindProperty(Name = "task_ids")]
    [property: SwaggerSchema("Task IDs to update.")]
    public long[] TaskIds { get; set; } = [];
}
