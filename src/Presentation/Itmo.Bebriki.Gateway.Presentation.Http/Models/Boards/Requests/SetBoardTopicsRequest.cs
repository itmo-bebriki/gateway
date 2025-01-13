using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

public class SetBoardTopicsRequest
{
    [MinLength(1)]
    [BindProperty(Name = "topic_ids")]
    public long[] TopicIds { get; set; } = [];
}
