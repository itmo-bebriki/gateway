using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/history")]
public class HistoryController : ControllerBase
{
    private readonly HistoryClient _historyClient;

    public HistoryController(HistoryClient historyClient)
    {
        _historyClient = historyClient;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<GetHistoryResponse>> GetHistory(
        [FromQuery] GetHistoryRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _historyClient.GetHistoryAsync(request, cancellationToken));
    }
}
