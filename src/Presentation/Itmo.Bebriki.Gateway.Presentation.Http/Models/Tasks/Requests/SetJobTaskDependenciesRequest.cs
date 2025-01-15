using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;

public class SetJobTaskDependenciesRequest
{
    [Required]
    [MinLength(1)]
    [BindProperty(Name = "depends_on_task_ids")]
    public long[] DependsOnTaskIds { get; set; } = [];
}
