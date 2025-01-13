using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

public class CreateBoardRequest
{
    [Required]
    [BindProperty(Name = "name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [BindProperty(Name = "description")]
    public string Description { get; set; } = string.Empty;

    [MinLength(1)]
    [BindProperty(Name = "topic_ids")]
    public long[] TopicIds { get; set; } = [];
}
