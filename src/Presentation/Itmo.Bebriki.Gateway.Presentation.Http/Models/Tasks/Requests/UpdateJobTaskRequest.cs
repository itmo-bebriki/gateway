using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

[SwaggerSchema(Description = "Request model for updating a dependencies of the job task.")]
public class UpdateJobTaskRequest
{
    [BindProperty(Name = "title")]
    [property: SwaggerSchema("A new title for the job task.", Nullable = true)]
    [property: SwaggerSchemaExample("Update deps")]
    public string? Title { get; set; }

    [BindProperty(Name = "description")]
    [property: SwaggerSchema("A new description for the job task.", Nullable = true)]
    [property: SwaggerSchemaExample("Should update etcd client version.")]
    public string? Description { get; set; }

    [BindProperty(Name = "assignee_id")]
    [property: SwaggerSchema("A new assignee id. This is a critical field, so this update should be approved.", Nullable = true)]
    [property: SwaggerSchemaExample("123")]
    public long? AssigneeId { get; set; }

    [BindProperty(Name = "priority")]
    [property: SwaggerSchema("A new priority for the job task.", Nullable = true)]
    [property: SwaggerSchemaExample("Critical")]
    public JobTaskPriority? Priority { get; set; }

    [BindProperty(Name = "deadline")]
    [property: SwaggerSchema("A new deadline of the job task. This is a critical field, so this update should be approved.", Nullable = true)]
    [property: SwaggerSchemaExample("2020-01-01T00:00:00+00:00")]
    public DateTimeOffset? Deadline { get; set; }
}
