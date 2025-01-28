using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

[SwaggerSchema(Description = "Request model for creating new job task.")]
public class CreateJobTaskRequest
{
    [Required]
    [BindProperty(Name = "title")]
    [property: SwaggerSchema("A title for the job task.")]
    [property: SwaggerSchemaExample("Update swagger doc")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "description")]
    [property: SwaggerSchema("A description for the job task.")]
    [property: SwaggerSchemaExample("Put some examples for queries.")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "assignee_id")]
    [property: SwaggerSchema("An assignee ID for the job task.")]
    [property: SwaggerSchemaExample("1")]
    public long AssignedId { get; set; }

    [Required]
    [BindProperty(Name = "priority")]
    [property: SwaggerSchema("An initial priority for the job task.")]
    [property: SwaggerSchemaExample("High")]
    public JobTaskPriority Priority { get; set; }

    [BindProperty(Name = "depends_on_task_ids")]
    [property: SwaggerSchema("Job task dependencies.")]
    [property: SwaggerSchemaExample("1,2")]
    public long[] DependsOnTaskIds { get; set; } = [];

    [Required]
    [BindProperty(Name = "deadline")]
    [property: SwaggerSchema("A deadline for the job task.", Nullable = true)]
    [property: SwaggerSchemaExample("2020-06-01T00:00:00")]
    public DateTimeOffset? Deadline { get; set; }
}
