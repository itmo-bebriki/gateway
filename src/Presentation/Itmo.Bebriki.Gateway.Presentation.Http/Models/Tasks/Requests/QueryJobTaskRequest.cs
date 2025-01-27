using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

public class QueryJobTaskRequest
{
    [BindProperty(Name = "job_task_ids")]
    public long[] JobTaskIds { get; set; } = [];

    [BindProperty(Name = "assignee_ids")]
    public long[] AssigneeIds { get; set; } = [];

    [BindProperty(Name = "states")]
    public JobTaskState[] States { get; set; } = [];

    [BindProperty(Name = "priorities")]
    public JobTaskPriority[] Priorities { get; set; } = [];

    [BindProperty(Name = "depends_on_task_ids")]
    public long[] DependsOnTaskIds { get; set; } = [];

    [BindProperty(Name = "from_deadline")]
    public DateTimeOffset? FromDeadline { get; set; }

    [BindProperty(Name = "to_deadline")]
    public DateTimeOffset? ToDeadline { get; set; }

    [BindProperty(Name = "from_updated_at")]
    public DateTimeOffset? FromUpdatedAt { get; set; }

    [BindProperty(Name = "to_updated_at")]
    public DateTimeOffset? ToUpdatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    public long? Cursor { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "page_size")]
    public int PageSize { get; set; }
}
