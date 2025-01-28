using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/agreements")]
public sealed class AgreementController : ControllerBase
{
    private readonly AgreementClient _client;

    public AgreementController(AgreementClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves agreement details by selected filters.
    /// </summary>
    /// <param name="request">The query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <returns>Agreement details if found; otherwise, a 404 response.</returns>
    /// <response code="200">Returns the agreement details.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="500">Server error.</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<QueryAgreementResponse>> QueryAgreements(
        [FromQuery] QueryAgreementRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.QueryAgreementAsync(request, cancellationToken));
    }

    /// <summary>
    /// Approves an agreement.
    /// </summary>
    /// <param name="id">An id of the agreement to be approved.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">The agreement was approved.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If the agreement was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPost("{id}/approve")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> ApproveAgreement(
        [FromRoute] long id,
        CancellationToken cancellationToken)
    {
        var request = new ApproveAgreementRequest { AgreementId = id };

        await _client.ApproveAgreementAsync(request, cancellationToken);

        return Ok();
    }

    /// <summary>
    /// Rejects an agreement.
    /// </summary>
    /// <param name="id">An id of the agreement to be rejected.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">The agreement was rejected.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If the agreement was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPost("{id}/reject")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RejectAgreement(
        [FromRoute] long id,
        CancellationToken cancellationToken)
    {
        var request = new RejectAgreementRequest { AgreementId = id };

        await _client.RejectAgreementAsync(request, cancellationToken);

        return Ok();
    }
}
