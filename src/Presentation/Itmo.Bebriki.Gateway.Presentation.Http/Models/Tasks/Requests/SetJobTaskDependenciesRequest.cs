using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

[SwaggerSchema(Description = "Request model for updating a dependencies of the job task.")]
public class SetJobTaskDependenciesRequest
{
    [Required]
    [MinLength(1)]
    [BindProperty(Name = "depends_on_task_ids")]
    [property: SwaggerSchema("Ids of job task's dependencies.")]
    [property: SwaggerSchemaExample("1,2")]
    public long[] DependsOnTaskIds { get; set; } = [];
}
