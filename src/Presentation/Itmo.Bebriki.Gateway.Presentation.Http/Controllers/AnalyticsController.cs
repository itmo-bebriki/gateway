using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Analytics.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/analytics")]
public class AnalyticsController : ControllerBase
{
    private readonly AnalyticsClient _client;

    public AnalyticsController(AnalyticsClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an analytics about the task.
    /// </summary>
    /// <param name="id">An id of the task to fetch related analytics.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Analytics about the task.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If the task was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<GetAnalyticsResponse>> QueryAnalytics(
        [FromRoute] long id,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.GetAnalytics(id, cancellationToken));
    }
}
