using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

public class QueryBoardRequest
{
    [MinLength(1)]
    [BindProperty(Name = "board_ids")]
    public long[] BoardIds { get; set; } = [];

    [BindProperty(Name = "from_updated_at")]
    public DateTimeOffset? FromUpdatedAt { get; set; }

    [BindProperty(Name = "to_updated_at")]
    public DateTimeOffset? ToUpdatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    public long? Cursor { get; set; }

    [Required]
    [BindProperty(Name = "page_size")]
    public int PageSize { get; set; }
}
