using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

public class UpdateBoardRequest
{
    [BindProperty(Name = "name")]
    public string? Name { get; set; }

    [BindProperty(Name = "description")]
    public string? Description { get; set; }
}
