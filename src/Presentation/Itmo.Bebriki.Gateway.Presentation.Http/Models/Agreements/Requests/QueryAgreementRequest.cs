using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

[SwaggerSchema("Request model for querying agreements.")]
public sealed class QueryAgreementRequest
{
    [BindProperty(Name = "agreements_ids")]
    [property: SwaggerSchema("Ids of agreements to queried.")]
    public long[] AgreementIds { get; set; } = [];

    [BindProperty(Name = "job_task_ids")]
    [property: SwaggerSchema("Ids of job tasks to queried.")]
    public long[] JobTaskIds { get; set; } = [];

    [BindProperty(Name = "states")]
    [property: SwaggerSchema("Ids of states of job tasks to queried.")]
    public JobTaskState[] States { get; set; } = [];

    [BindProperty(Name = "assignee_ids")]
    [property: SwaggerSchema("Ids of assignees to queried.")]
    public long[] AssigneeIds { get; set; } = [];

    [BindProperty(Name = "from_deadline")]
    [property: SwaggerSchema("A lower bound date for deadline to query from.", Nullable = true)]
    public DateTimeOffset? FromDeadline { get; set; }

    [BindProperty(Name = "to_deadline")]
    [property: SwaggerSchema("An upper bound date for deadline to query to.", Nullable = true)]
    public DateTimeOffset? ToDeadline { get; set; }

    [BindProperty(Name = "from_created_at")]
    [property: SwaggerSchema("A lower bound date for creation date to query from.", Nullable = true)]
    public DateTimeOffset? FromCreatedAt { get; set; }

    [BindProperty(Name = "to_created_at")]
    [property: SwaggerSchema("An upper bound date for creation date to query to.", Nullable = true)]
    public DateTimeOffset? ToCreatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    [property: SwaggerSchema("A cursor that indicates an id of agreement to query from", Nullable = true)]
    public long? Cursor { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "page_size")]
    [property: SwaggerSchema("A page size for paginated query.")]
    [property: SwaggerSchemaExample("10")]
    public int PageSize { get; set; }
}
