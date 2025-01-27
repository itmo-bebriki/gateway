using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

public sealed class QueryAgreementRequest
{
    [BindProperty(Name = "agreements_ids")]
    public long[] AgreementIds { get; set; } = [];

    [BindProperty(Name = "job_task_ids")]
    public long[] JobTaskIds { get; set; } = [];

    [BindProperty(Name = "states")]
    public JobTaskState[] States { get; set; } = [];

    [BindProperty(Name = "assignee_ids")]
    public long[] AssigneeIds { get; set; } = [];

    [BindProperty(Name = "from_deadline")]
    public DateTimeOffset? FromDeadline { get; set; }

    [BindProperty(Name = "to_deadline")]
    public DateTimeOffset? ToDeadline { get; set; }

    [BindProperty(Name = "from_created_at")]
    public DateTimeOffset? FromCreatedAt { get; set; }

    [BindProperty(Name = "to_created_at")]
    public DateTimeOffset? ToCreatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    public long? Cursor { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "page_size")]
    public int PageSize { get; set; }
}