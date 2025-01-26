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
