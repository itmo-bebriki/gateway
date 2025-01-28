using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

[SwaggerSchema(Description = "Request model for querying job tasks.")]
public class QueryJobTaskRequest
{
    [BindProperty(Name = "job_task_ids")]
    [property: SwaggerSchema("Job task ids to query.")]
    public long[] JobTaskIds { get; set; } = [];

    [BindProperty(Name = "assignee_ids")]
    [property: SwaggerSchema("Ids of assignees to query.")]
    public long[] AssigneeIds { get; set; } = [];

    [BindProperty(Name = "states")]
    [property: SwaggerSchema("States of the job tasks to query.")]
    public JobTaskState[] States { get; set; } = [];

    [BindProperty(Name = "priorities")]
    [property: SwaggerSchema("Priorities of the job task to query.")]
    public JobTaskPriority[] Priorities { get; set; } = [];

    [BindProperty(Name = "depends_on_task_ids")]
    [property: SwaggerSchema("Dependencies of the job task to query.")]
    public long[] DependsOnTaskIds { get; set; } = [];

    [BindProperty(Name = "from_deadline")]
    [property: SwaggerSchema("A lower bound timestamp of deadline to query from.", Nullable = true)]
    public DateTimeOffset? FromDeadline { get; set; }

    [BindProperty(Name = "to_deadline")]
    [property: SwaggerSchema("An upper bound timestamp of deadline to query to.", Nullable = true)]
    public DateTimeOffset? ToDeadline { get; set; }

    [BindProperty(Name = "from_updated_at")]
    [property: SwaggerSchema("An upper bound timestamp of last update to query to.", Nullable = true)]
    public DateTimeOffset? FromUpdatedAt { get; set; }

    [BindProperty(Name = "to_updated_at")]
    [property: SwaggerSchema("An upper bound timestamp of last update to query to.", Nullable = true)]
    public DateTimeOffset? ToUpdatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    [property: SwaggerSchema("An ids of the job task to query from.", Nullable = true)]
    public long? Cursor { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "page_size")]
    [property: SwaggerSchema("A page size for paged query.")]
    [property: SwaggerSchemaExample("10")]
    public int PageSize { get; set; }
}
