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

    /// <summary>
    /// Query for fetching history of the task.
    /// </summary>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Fetched history of the task.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
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
