using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

public class QueryTopicRequest
{
    [BindProperty(Name = "topic_ids")]
    public long[] TopicIds { get; set; } = [];

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
