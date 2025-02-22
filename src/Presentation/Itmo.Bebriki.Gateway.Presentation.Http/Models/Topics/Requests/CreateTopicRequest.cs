using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

public class CreateTopicRequest
{
    [Required]
    [BindProperty(Name = "name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "description")]
    public string Description { get; set; } = string.Empty;

    [BindProperty(Name = "task_ids")]
    public long[] TaskIds { get; set; } = [];
}
