using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

public class SetTopicTasksRequest
{
    [MinLength(1)]
    [BindProperty(Name = "task_ids")]
    public long[] TaskIds { get; set; } = [];
}
