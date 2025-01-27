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