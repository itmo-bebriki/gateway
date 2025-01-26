using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

public class CreateJobTaskRequest
{
    [Required]
    [BindProperty(Name = "title")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "description")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "assignee_id")]
    public long AssignedId { get; set; }

    [Required]
    [BindProperty(Name = "priority")]
    public JobTaskPriority Priority { get; set; }

    [BindProperty(Name = "depends_on_task_ids")]
    public long[] DependsOnTaskIds { get; set; } = [];

    [Required]
    [BindProperty(Name = "deadline")]
    public DateTimeOffset? Deadline { get; set; }
}
