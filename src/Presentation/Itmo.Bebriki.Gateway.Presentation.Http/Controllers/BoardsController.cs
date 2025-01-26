using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/boards")]
public class BoardsController : ControllerBase
{
    private readonly BoardClient _client;

    public BoardsController(BoardClient client)
    {
        _client = client;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<QueryBoardResponse>> QueryBoards(
        [FromQuery] QueryBoardRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.QueryBoardAsync(request, cancellationToken));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CreateBoardResponse>> CreateBoard(
        [FromQuery] CreateBoardRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.CreateBoardAsync(request, cancellationToken));
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UpdateBoard(
        [FromRoute] long id,
        [FromQuery] UpdateBoardRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateBoardAsync(id, request, cancellationToken);

        return Ok();
    }

    [HttpPost("{id}/topics")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> AddBoardTopics(
        [FromRoute] long id,
        [FromQuery] SetBoardTopicsRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddBoardTopicsAsync(id, request, cancellationToken);

        return Ok();
    }

    [HttpDelete("{id}/topics")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RemoveBoardTopics(
        [FromRoute] long id,
        [FromQuery] SetBoardTopicsRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveBoardTopicsAsync(id, request, cancellationToken);

        return Ok();
    }
}
