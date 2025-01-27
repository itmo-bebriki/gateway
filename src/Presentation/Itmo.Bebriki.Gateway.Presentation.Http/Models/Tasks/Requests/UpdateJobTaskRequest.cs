using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

public class UpdateJobTaskRequest
{
    [BindProperty(Name = "title")]
    public string? Title { get; set; }

    [BindProperty(Name = "description")]
    public string? Description { get; set; }

    [BindProperty(Name = "assignee_id")]
    public long? AssigneeId { get; set; }

    [BindProperty(Name = "priority")]
    public JobTaskPriority? Priority { get; set; }

    [BindProperty(Name = "deadline")]
    public DateTimeOffset? Deadline { get; set; }
}
