using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Requests;

public class GetHistoryRequest
{
    [BindProperty(Name = "ids")]
    public long[] Ids { get; set; } = [];

    [BindProperty(Name = "event_types")]
    public EventType[] EventTypes { get; set; } = [];

    [BindProperty(Name = "from_timestamp")]
    public DateTimeOffset? FromTimestamp { get; set; } = DateTimeOffset.MinValue;

    [BindProperty(Name = "to_timestamp")]
    public DateTimeOffset? ToTimestamp { get; set; } = DateTimeOffset.MaxValue;

    [BindProperty(Name = "cursor")]
    public long Cursor { get; set; } = -1;

    [Required]
    [BindProperty(Name = "page_size")]
    [Range(1, int.MaxValue)]
    public int PageSize { get; set; } = 1;
}
